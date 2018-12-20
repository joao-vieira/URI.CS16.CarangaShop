using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarangaShop {
    class SqlManager {

        public static String CONNECTION_STRING = Properties.Settings.Default.CarangaShopConnectionString;

        public static SqlConnection CONN = new SqlConnection(SqlManager.CONNECTION_STRING);


        public SqlDataReader performQuery(SqlCommand comm) {
            SqlDataReader sqlReader;
            try {
                SqlManager.CONN.Open();
                try {
                    sqlReader = comm.ExecuteReader();
                    return sqlReader;
                } catch (Exception error) {
                    Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao executar o comando SQL no banco!", "wrong");
                    Console.WriteLine(error.StackTrace);
                }
            } catch (Exception error) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao abrir a conexão com o banco de dados!", "wrong");
                Console.WriteLine(error.StackTrace);
            }

            return null;
        }


        public void closeConnection() {
            try {
                SqlManager.CONN.Close();
            } catch (Exception error) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao fechar a conexão com o banco!", "wrong");
                Console.WriteLine(error.StackTrace);
            }
        }


        public void performQueryWithoutReturn(SqlCommand comm) {
            try {
                SqlManager.CONN.Open();
                try {
                    comm.ExecuteNonQuery();
                    SqlManager.CONN.Close();
                } catch (Exception error) {
                    Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao executar o comando SQL!", "wrong");
                    Console.WriteLine(error.StackTrace);
                }
            } catch (Exception error) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao abrir a conexão com o banco!", "wrong");
                Console.WriteLine(error.StackTrace);
            }
        }


        public int performQueryReturnId(SqlCommand comm) {
            try {
                SqlManager.CONN.Open();
                try {
                    int modified = (int) comm.ExecuteScalar();
                    //int ts = (int) comm.ExecuteNonQuery();
                    SqlManager.CONN.Close();
                    return modified;
                } catch (Exception error) {
                    Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao executar o comando SQL!", "wrong");
                    Console.WriteLine(error.StackTrace);
                }
            } catch (Exception error) {
                Utils.showSimpleMessageBox("Ops", "Ocorreu algum erro ao abrir a conexão com o banco!", "wrong");
                Console.WriteLine(error.StackTrace);
            }
            return 0;
        }


         public int performQueryReturnId2(SqlCommand comm) {
            Utils.dg("CU= " + comm.CommandText);
            try {
                SqlManager.CONN.Open();
                try {
                    int modified = (int) comm.ExecuteScalar();
                    SqlManager.CONN.Close();
                    return modified;
                } catch (Exception error) {
                }
            } catch (Exception error) {
            }
            return 0;
        }


    }
}
