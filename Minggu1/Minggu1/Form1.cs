using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minggu1
{
    public partial class Form1 : Form
    {
        List<Novel> novels = new List<Novel>();
        List<CartItem> cartItem = new List<CartItem>();

        public Form1()
        {
            InitializeComponent();
        }

        void loadBuku()
        {
            cbBuku.DataSource = null;
            cbBuku.DataSource = novels;
        }

        void loadCart()
        {
            lbCheckout.DataSource = null;
            lbCheckout.DataSource = cartItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ambil data novel
            string judul = tbJudul.Text;
            int stok = (int)numStock.Value;
            int harga = (int)numericUpDown1.Value;
            List<int> genres = new List<int>();
            if (checkBox1.Checked) genres.Add(1);
            if (checkBox2.Checked) genres.Add(2);
            if (checkBox3.Checked) genres.Add(3);
            bool hardCover = rbHardCover.Checked;

            // Tambah novel ke list
            Novel temp = new Novel(judul, stok, harga, genres, hardCover);
            novels.Add(temp);
            // Load ulang combobox buku
            loadBuku();

            // Kosongkan input
            tbJudul.Text = "";
            numStock.Value = 0;
            numericUpDown1.Value = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            rbHardCover.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tambah novel ke cart
            Novel n = (Novel)cbBuku.SelectedItem;
            int qty = (int)numCheckoutStock.Value;
            CartItem ci = new CartItem(n, qty);
            cartItem.Add(ci);
            loadCart();
        }

        private void lbCheckout_DoubleClick(object sender, EventArgs e)
        {
            int idx = lbCheckout.SelectedIndex;
            if (idx >= 0)
            {
                cartItem.RemoveAt(idx);
                loadCart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Jual novel

            // Untuk tiap novel yang ada di cart, kurangi stok nya
            foreach (CartItem item in cartItem)
            {
                item.novel.stock -= item.qty;
            }
            cartItem = new List<CartItem>();
            loadBuku();
            loadCart();

            // Kosongkan inputan
            cbBuku.SelectedIndex = 0;
            numCheckoutStock.Value = 1;

        }
    }
}
