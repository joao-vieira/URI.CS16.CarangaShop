using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarangaShop {
    class Utils {

        public static String CONST_API_VEICULOS = "http://fipeapi.appspot.com/api/1/";
        public static String CONST_API_ENDERECOS= "https://viacep.com.br/ws/";

        public static int ID_FUNCIONARIO_LOGADO;
        public static int NIVEL_ACESSO_ATUAL;



        public static void disableFields(Control con) {
            foreach (Control c in con.Controls) {
                disableFields(c);
            }

            if(con != null && (con is TextBox || con is ComboBox || con is MaskedTextBox || con is DateTimePicker || con is NumericUpDown)) {
                con.Enabled = false;
            }
        }


        public static void enableFields(Control con) {
            foreach (Control c in con.Controls) {
                enableFields(c);
            }

            if (con != null && (con is TextBox || con is ComboBox || con is MaskedTextBox || con is DateTimePicker || con is NumericUpDown)) {
                con.Enabled = true;
            }
        }


        public static void cleanFields(Control con) {
            foreach (Control c in con.Controls) {
                if (c is TextBox) {
                    TextBox textBox = (TextBox)c;
                    textBox.Text = null;
                }

                if (c is ComboBox) {
                    ComboBox comboBox = (ComboBox)c;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (c is CheckBox) {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Checked = false;
                }

                if (c is ListBox) {
                    ListBox listBox = (ListBox)c;
                    listBox.ClearSelected();
                }

                if (c is MaskedTextBox) {
                    MaskedTextBox maskedTextBox = (MaskedTextBox)c;
                    maskedTextBox.Text = null;
                }

                if (c is DateTimePicker) {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Text = null;
                }

                if (c is NumericUpDown) {
                    NumericUpDown numericUpDown = (NumericUpDown)c;
                    numericUpDown.Value = 1;
                    numericUpDown.Text = "1";
                }
            }
        }


        public static void showSimpleMessageBox(String title, String message, String type) {
            switch(type) {
                case "wrong":
                    MessageBox.Show(message, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "success":
                    MessageBox.Show(message, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default: // warning
                    MessageBox.Show(message, title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }


        public static void dg(String msg) {
            Console.WriteLine("#### CarangaShop #### | " + msg);
        }


        public static String makeRequest(WebRequest webRequest) {
            String respJSON = "";
            webRequest.Credentials = CredentialCache.DefaultCredentials;

            try {
                WebResponse response = webRequest.GetResponse();
                String statusRequest = ((HttpWebResponse)response).StatusDescription;
                if (statusRequest.Equals("OK")) {
                    Stream dataStream = response.GetResponseStream();

                    using (StreamReader reader = new StreamReader(dataStream)) {
                        respJSON = reader.ReadToEnd();
                    }
                    return respJSON;
                } else {
                    return null;
                }
            } catch(Exception ex) {
                Utils.dg("########## Exceção na requisição para URL (" + webRequest.ToString() + "): " + ex.Message);
                Utils.dg(ex.StackTrace);
                return null;
            }
        }


        public static bool validaCPF(String sCPF) {
            String valor = sCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11) return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909") return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++) numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++) soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if(resultado == 1 || resultado == 0) {
                if (numeros[9] != 0) return false;
            } else if(numeros[9] != 11 - resultado) {
                return false;
            }

            soma = 0;
            for (int i = 0; i < 10; i++) soma += (11 - i) * numeros[i];

            resultado = soma % 11;
            if(resultado == 1 || resultado == 0) {
                if (numeros[10] != 0) return false;
            } else {
                if (numeros[10] != 11 - resultado) return false;
            }

            return true;
        }


        public static String encrypt(String encryptString) {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  // essa chave de conversão pode ser mudada conforme necessidade
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);

            using (Aes encryptor = Aes.Create()) {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream()) {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)) {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }

            return encryptString;
        }


        public static String decrypt(String cipherText) {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  // essa chave de conversão pode ser mudada conforme necessidade
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes encryptor = Aes.Create()) {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream()) {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)) {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return cipherText;
        }


        public static String formatPrice2DB(String s) {
            String fmt2DecimalDB = s.Split(' ')[1];
            fmt2DecimalDB = fmt2DecimalDB.Replace(".", String.Empty).Replace(',', '.');
            return fmt2DecimalDB;
        }


        public static String formatPrice2User(String s) {
            String fmt2User = "";
            String cents = s.Split('.')[1];
            String absValue = s.Split('.')[0];

            int increment = absValue.Length / 3;
            int index = absValue.Length - 1 + increment;
            String[] sPartial = new String[absValue.Length + increment];

            int cont = 0;
            int i;
            for (i = absValue.Length - 1; i >= 0; i--) {
                sPartial[index] += absValue[i];
                cont++;
                index--;
                if (cont == 3) {
                    cont = 0;
                    sPartial[index] = ".";
                    index--;
                }
            }

            fmt2User += "R$ ";
            for (i = 0; i < absValue.Length + increment; i++) {
                fmt2User += sPartial[i];
            }
            fmt2User += "," + cents;

            return fmt2User;
        }


        public static Boolean sendEmail(int iIdVenda, String sBody) {
            try {
                SmtpClient client = new SmtpClient("smtp.mailtrap.io", 2525) {
                    Credentials = new NetworkCredential("8ebf34650295d6", "544b6e6041a4e7"),
                    EnableSsl = true
                };


                client.Send("equipe@carangashop.com", "cliente@exemplo.com", "Detalhes da Venda #" + iIdVenda, sBody);
                Console.WriteLine("Sent");
                Console.ReadLine();
            } catch(Exception ex) {
                Utils.dg(ex.StackTrace);
            }

            return false;
        }

    }
}
