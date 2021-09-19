
namespace Minggu1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbJudul = new System.Windows.Forms.TextBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbSoftCover = new System.Windows.Forms.RadioButton();
            this.rbHardCover = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCheckoutStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbBuku = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbCheckout = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem Jual Novel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbJudul);
            this.groupBox1.Controls.Add(this.numStock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbSoftCover);
            this.groupBox1.Controls.Add(this.rbHardCover);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(255, 507);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entri Novel";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 342);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 22);
            this.numericUpDown1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga";
            // 
            // tbJudul
            // 
            this.tbJudul.Location = new System.Drawing.Point(71, 28);
            this.tbJudul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.Size = new System.Drawing.Size(176, 22);
            this.tbJudul.TabIndex = 13;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(116, 304);
            this.numStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(131, 22);
            this.numStock.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stok";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSoftCover
            // 
            this.rbSoftCover.AutoSize = true;
            this.rbSoftCover.Location = new System.Drawing.Point(16, 258);
            this.rbSoftCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSoftCover.Name = "rbSoftCover";
            this.rbSoftCover.Size = new System.Drawing.Size(95, 21);
            this.rbSoftCover.TabIndex = 9;
            this.rbSoftCover.TabStop = true;
            this.rbSoftCover.Text = "Soft Cover";
            this.rbSoftCover.UseVisualStyleBackColor = true;
            // 
            // rbHardCover
            // 
            this.rbHardCover.AutoSize = true;
            this.rbHardCover.Location = new System.Drawing.Point(16, 230);
            this.rbHardCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHardCover.Name = "rbHardCover";
            this.rbHardCover.Size = new System.Drawing.Size(101, 21);
            this.rbHardCover.TabIndex = 8;
            this.rbHardCover.TabStop = true;
            this.rbHardCover.Text = "Hard Cover";
            this.rbHardCover.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(117, 190);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 21);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Horror";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(117, 161);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Comedy";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(117, 133);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Romance";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Judul :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCheckoutStock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.cbBuku);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lbCheckout);
            this.groupBox2.Location = new System.Drawing.Point(279, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(660, 507);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jual Buku";
            // 
            // numCheckoutStock
            // 
            this.numCheckoutStock.Location = new System.Drawing.Point(75, 66);
            this.numCheckoutStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCheckoutStock.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCheckoutStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCheckoutStock.Name = "numCheckoutStock";
            this.numCheckoutStock.Size = new System.Drawing.Size(131, 22);
            this.numCheckoutStock.TabIndex = 14;
            this.numCheckoutStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stok : ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 63);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbBuku
            // 
            this.cbBuku.FormattingEnabled = true;
            this.cbBuku.Location = new System.Drawing.Point(75, 23);
            this.cbBuku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBuku.Name = "cbBuku";
            this.cbBuku.Size = new System.Drawing.Size(575, 24);
            this.cbBuku.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Buku : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 447);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Jual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCheckout
            // 
            this.lbCheckout.FormattingEnabled = true;
            this.lbCheckout.ItemHeight = 16;
            this.lbCheckout.Location = new System.Drawing.Point(12, 101);
            this.lbCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(639, 340);
            this.lbCheckout.TabIndex = 1;
            this.lbCheckout.DoubleClick += new System.EventHandler(this.lbCheckout_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sistem Jual Novel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbJudul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbSoftCover;
        private System.Windows.Forms.RadioButton rbHardCover;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbCheckout;
        private System.Windows.Forms.NumericUpDown numCheckoutStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbBuku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numStock;
    }
}

