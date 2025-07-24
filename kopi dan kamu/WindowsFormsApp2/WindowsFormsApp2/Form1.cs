using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class Form1: Form
    {
        List<MenuItem> keranjang = new List<MenuItem>();

        List<MenuItem> menuList = new List<MenuItem>
        {
            new MenuItem { Nama = "Nasi Goreng", Harga = 17000, Kategori = "Foods", NamaFileGambar = "Nasi_Goreng.jpg" },
            new MenuItem { Nama = "Americano", Harga = 15000, Kategori = "Drinks", NamaFileGambar = "Americano.jpg" },
            new MenuItem { Nama = "Mie Goreng", Harga = 13000, Kategori = "Foods", NamaFileGambar = "Mie_Goreng.jpg" },
            new MenuItem { Nama = "Matcha", Harga = 17000, Kategori = "Drinks", NamaFileGambar = "Matcha.jpg" },
            new MenuItem { Nama = "Mie Rebus", Harga = 13000, Kategori = "Foods", NamaFileGambar = "Mie_Rebus.jpg" },
            new MenuItem { Nama = "Cafe Latte", Harga = 18000, Kategori = "Drinks", NamaFileGambar = "Caffe_Latte.jpg" },
            new MenuItem { Nama = "Es Teh", Harga = 7000, Kategori = "Drinks", NamaFileGambar = "Es_Teh.jpg" },
            new MenuItem { Nama = "Katsu Curry", Harga = 22000, Kategori = "Foods", NamaFileGambar = "Katsu_Curry.jpg" }
        };
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilkanMenu();
        }

        private void TampilkanMenu()
        {

            flowFoods.Controls.Clear();
            flowDrinks.Controls.Clear();


            foreach (MenuItem item in menuList)
            {
                Panel panelItem = new Panel();
                panelItem.Size = new Size(100, 140);
                panelItem.BackColor = Color.White;
                panelItem.Margin = new Padding(10);

                PictureBox pic = new PictureBox();
                pic.Image = item.Gambar;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Size = new Size(80, 60);
                pic.Location = new Point(10, 5);

                Label lblNama = new Label();
                lblNama.Text = item.Nama;
                lblNama.TextAlign = ContentAlignment.MiddleCenter;
                lblNama.Location = new Point(10, 70);
                lblNama.Size = new Size(80, 20);

                Label lblHarga = new Label();
                lblHarga.Text = "Rp " + item.Harga.ToString("N0");
                lblHarga.ForeColor = Color.Gray;
                lblHarga.Font = new Font("Segoe UI", 8);
                lblHarga.Location = new Point(10, 90);
                lblHarga.Size = new Size(80, 15); 

                Button btnTambah = new Button();
                btnTambah.Text = "Tambah";
                btnTambah.Size = new Size(80, 23);
                btnTambah.Location = new Point(10, 108);
                btnTambah.Font = new Font("Segoe UI", 7.5f);
                btnTambah.Click += (s, e) => { TambahKeKeranjang(item); };

                panelItem.Controls.Add(pic);
                panelItem.Controls.Add(lblNama);
                panelItem.Controls.Add(lblHarga);
                panelItem.Controls.Add(btnTambah);

                if (item.Kategori == "Foods")
                    flowFoods.Controls.Add(panelItem);
                else if (item.Kategori == "Drinks")
                    flowDrinks.Controls.Add(panelItem);
            }
        }

        private void TambahKeKeranjang(MenuItem item)
        {
            keranjang.Add(item);
            labelBarang.Text = $"Item: {keranjang.Count}";
            int totalHarga = keranjang.Sum(i => i.Harga);
            labelTagihan.Text = $"Total: Rp {totalHarga:N0}";
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {

            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormKeranjang formKeranjang = new FormKeranjang(keranjang);
            var result = formKeranjang.ShowDialog();

            if (result == DialogResult.OK)
            {
                keranjang.Clear();
                labelBarang.Text = "Item: 0";
                labelTagihan.Text = "Total: Rp 0";
                MessageBox.Show("Pembayaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
            
            }
        }
    }
}
