using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarangaShop {
    class ComboboxItem {

        public string Text { get; set; }
        public object Value { get; set; }

        public ComboboxItem() {

        }

        public ComboboxItem(string ovo, object cu) {
            this.Text = ovo;
            this.Value = cu;
        }

        public override string ToString() {
            return Text;
        }

    }
}
