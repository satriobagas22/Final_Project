using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormKeranjang : Form
    {
        public List<MenuItem> keranjang { get; set; }

        private FlowLayoutPanel flowKeranjang;
        private Label labelTotal;
        private Button btnBayar;
        private Button btnKembali;
        private TextBox txtNomorMeja;
        public string NomorMeja { get; private set; }

        public FormKeranjang(List<MenuItem> keranjang)
        {
            this.keranjang = keranjang;
            this.Text = "Keranjang";
            this.Size = new Size(420, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Label lblMeja = new Label();
            lblMeja.Text = "Nomor Meja:";
            lblMeja.Location = new Point(10, 10);
            lblMeja.Size = new Size(100, 20);
            lblMeja.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            txtNomorMeja = new TextBox();
            txtNomorMeja.Location = new Point(110, 10);
            txtNomorMeja.Size = new Size(100, 20);
            txtNomorMeja.Name = "txtNomorMeja";

            Panel panelAtas = new Panel();
            panelAtas.Dock = DockStyle.Top;
            panelAtas.Height = 40;
            panelAtas.Padding = new Padding(10);
            panelAtas.Controls.Add(lblMeja);
            panelAtas.Controls.Add(txtNomorMeja);

            flowKeranjang = new FlowLayoutPanel();
            flowKeranjang.Dock = DockStyle.Fill;
            flowKeranjang.FlowDirection = FlowDirection.TopDown;
            flowKeranjang.WrapContents = false;
            flowKeranjang.AutoScroll = true;
            flowKeranjang.Padding = new Padding(10);

            
            Panel panelBottom = new Panel();
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Height = 60;
            panelBottom.Padding = new Padding(10);
            panelBottom.BackColor = Color.LightGray;

            labelTotal = new Label();
            labelTotal.Text = "Total: Rp 0";
            labelTotal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(10, 20);

            btnBayar = new Button();
            btnBayar.Text = "Bayar";
            btnBayar.Size = new Size(75, 30);
            btnBayar.Location = new Point(220, 15);
            btnBayar.Click += buttonBayar_Click;

            btnKembali = new Button();
            btnKembali.Text = "Kembali";
            btnKembali.Size = new Size(75, 30);
            btnKembali.Location = new Point(300, 15);
            btnKembali.Click += buttonKembali_Click;

            panelBottom.Controls.Add(labelTotal);
            panelBottom.Controls.Add(btnBayar);
            panelBottom.Controls.Add(btnKembali);

           
            this.Controls.Add(flowKeranjang);
            this.Controls.Add(panelBottom);
            this.Controls.Add(panelAtas);

            TampilkanKeranjang();
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomorMeja.Text))
            {
                MessageBox.Show("Silakan masukkan nomor meja.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = keranjang.Sum(i => i.Harga);
            DialogResult result = MessageBox.Show($"Total: Rp {total:N0}\nLanjutkan pembayaran?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                total = keranjang.Sum(i => i.Harga);
                MessageBox.Show($"Meja: {txtNomorMeja.Text}\nTotal: Rp {total:N0}\nTerima kasih!", "Sukses");

                NomorMeja = txtNomorMeja.Text;
                keranjang.Clear();
                TampilkanKeranjang();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void TampilkanKeranjang()
        {


            flowKeranjang.Controls.Clear();

            foreach (var item in keranjang.ToList())
            {
                Panel panelItem = new Panel();
                panelItem.Size = new Size(370, 60);
                panelItem.BorderStyle = BorderStyle.FixedSingle;

                Label lblNama = new Label();
                lblNama.Text = item.Nama;
                lblNama.Location = new Point(10, 10);
                lblNama.Size = new Size(200, 20);

                Label lblHarga = new Label();
                lblHarga.Text = "Rp " + item.Harga.ToString("N0");
                lblHarga.Location = new Point(10, 30);
                lblHarga.Size = new Size(120, 20);

                Button btnHapus = new Button();
                btnHapus.Text = "Hapus";
                btnHapus.Size = new Size(60, 25);
                btnHapus.Location = new Point(290, 18);
                btnHapus.Click += (s, e) =>
                {
                    keranjang.Remove(item);
                    TampilkanKeranjang();
                };

                panelItem.Controls.Add(lblNama);
                panelItem.Controls.Add(lblHarga);
                panelItem.Controls.Add(btnHapus);
                flowKeranjang.Controls.Add(panelItem);
            }

            int total = keranjang.Sum(i => i.Harga);
            labelTotal.Text = $"Total: Rp {total:N0}";
        }
    }
}

