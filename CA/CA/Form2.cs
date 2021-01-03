using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CA
{
    public partial class Form2 : Form
    {
       public int left = 0;
       public DateTime current_date = DateTime.Now;
       public string target_date;
        public Form2()
        {
            InitializeComponent();          
            MC.DropDownStyle = ComboBoxStyle.DropDownList;
            DC.DropDownStyle = ComboBoxStyle.DropDownList;
            YC.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(62, 120, 138);
            CourseTB.ForeColor = Color.FromArgb(62, 120, 138);
            panel3.BackColor = Color.WhiteSmoke;
            MC.ForeColor = Color.WhiteSmoke;
            DC.ForeColor = Color.WhiteSmoke;
            YC.ForeColor = Color.WhiteSmoke;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subbtn_Click(object sender, EventArgs e)
        {          
            if (File.Exists(Application.StartupPath + "\\Courses\\" + CourseTB.Text + ".txt"))
            {
                string TL = File.ReadLines(Application.StartupPath + "\\Courses\\" + CourseTB.Text + ".txt").ElementAt(1);
                DateTime DTL= Convert.ToDateTime(TL);
                left = (DTL - current_date).Days+1;
                string [] lines = File.ReadAllLines(Application.StartupPath + "\\Courses\\" + CourseTB.Text + ".txt");
                using (StreamWriter writer = new StreamWriter(Application.StartupPath + "\\Courses\\" + CourseTB.Text + ".txt"))
                {
                    for (int currentLine = 0; currentLine < lines.Length; currentLine++)
                    {
                        if (currentLine == 2)
                        {
                            writer.WriteLine("Days Left: " + left);
                        }
                        else
                        {
                            writer.WriteLine(lines[currentLine]);
                        }
                    }
                }
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Courses\\" + CourseTB.Text + ".txt");
                OutputTB.Text = sr.ReadToEnd();
            }
            else
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Courses\\" + CourseTB.Text + ".txt");
                sw.WriteLine(label3.Text + CourseTB.Text + "   ");
                sw.WriteLine(MC.Text + "-" + DC.Text + "-" + YC.Text);
                target_date += MC.Text;
                target_date += "-";
                target_date += DC.Text;
                target_date += "-";
                target_date += YC.Text;
                DateTime TG = Convert.ToDateTime(target_date);
                left = (TG - current_date).Days + 1;
                sw.WriteLine("Days left: " + left);
                sw.Close();
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Courses\\" + CourseTB.Text + ".txt");
                OutputTB.Text = sr.ReadToEnd();
            }
        }             
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Gen_Click(object sender, EventArgs e)
        {
            string[] allLines = File.ReadAllLines(Application.StartupPath + "\\PosT\\" + "PosT" + ".txt");
            Random rnd1 = new Random();      
            PosRT.Text= allLines[rnd1.Next(allLines.Length)];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(62, 120, 138);
            MC.ForeColor = Color.FromArgb(62, 120, 138);
            panel1.BackColor = Color.WhiteSmoke;
            CourseTB.ForeColor = Color.WhiteSmoke;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(62, 120, 138);
            DC.ForeColor = Color.FromArgb(62, 120, 138);
            panel1.BackColor = Color.WhiteSmoke;
            CourseTB.ForeColor = Color.WhiteSmoke;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(62, 120, 138);
            YC.ForeColor = Color.FromArgb(62, 120, 138);
            panel1.BackColor = Color.WhiteSmoke;
            CourseTB.ForeColor = Color.WhiteSmoke;
        }
        private void MC_TextUpdate(object sender, EventArgs e)
        {
            
        }
        private void DC_TextUpdate(object sender, EventArgs e)
        {
            
        }
        private void YC_TextUpdate(object sender, EventArgs e)
        {
            
        }
        
       
    }
}
