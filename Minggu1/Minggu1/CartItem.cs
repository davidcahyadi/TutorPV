using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minggu1
{
    class CartItem
    {
        public Novel novel { get; set; }
        public int qty { get; set; }

        public CartItem(Novel novel, int qty)
        {
            this.novel = novel;
            this.qty = qty;
        }

        public override string ToString()
        {
            return $"{novel.Judul} - {this.qty}";
        }
    }
}
