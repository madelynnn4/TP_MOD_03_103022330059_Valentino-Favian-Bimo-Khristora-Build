using System;
using System.Drawing;
using System.Windows.Forms;

namespace BelajarGUI
{
    public partial class Form1 : Form
    {
        private Label label1;
        private TextBox textBox1;
        private Button button1;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Belajar GUI";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue;

            // Membuat Label
            label1 = new Label();
            label1.Text = "Masukkan Nama:";
            label1.Font = new Font("Arial", 10, FontStyle.Bold);
            label1.Location = new Point(30, 30);
            label1.AutoSize = true;

            // Membuat TextBox
            textBox1 = new TextBox();
            textBox1.Location = new Point(30, 60);
            textBox1.Size = new Size(200, 20);

            // Membuat Button
            button1 = new Button();
            button1.Text = "Submit";
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Size = new Size(100, 30);
            button1.Location = new Point(30, 100);
            button1.Click += new EventHandler(Button1_Click);

            // Menambahkan elemen ke dalam form
            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            label1.Text = "Halo, " + nama + "!";
        }
    }
}
