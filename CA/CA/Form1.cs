using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(62, 120, 138);
            User.ForeColor = Color.FromArgb(62, 120, 138);
            panel3.BackColor = Color.WhiteSmoke;
            Pass.ForeColor = Color.WhiteSmoke;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginbtn.ForeColor= Color.FromArgb(62, 120, 138);
            loginbtn.BackColor = Color.FromArgb(41, 44, 51);
            if (User.Text == "Emperor" & Pass.Text=="StayComfy")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("wrong username or password please try again");
                loginbtn.BackColor = Color.FromArgb(62, 120, 138);
                loginbtn.ForeColor = Color.FromArgb(41, 44, 51);
            }
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            
            Pass.PasswordChar = '*';
            panel3.BackColor = Color.FromArgb(62, 120, 138);
            Pass.ForeColor = Color.FromArgb(62, 120, 138);
            panel2.BackColor = Color.WhiteSmoke;
            User.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
