namespace CA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.subbtn = new System.Windows.Forms.Button();
            this.OutputTB = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gen = new System.Windows.Forms.Button();
            this.PosRT = new System.Windows.Forms.RichTextBox();
            this.MC = new System.Windows.Forms.ComboBox();
            this.DC = new System.Windows.Forms.ComboBox();
            this.YC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comfy App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CA.Properties.Resources.CA_logo;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 95);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(656, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the course you wish to study and the deadline.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CourseTB
            // 
            this.CourseTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CourseTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourseTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.CourseTB.Location = new System.Drawing.Point(176, 225);
            this.CourseTB.Name = "CourseTB";
            this.CourseTB.Size = new System.Drawing.Size(346, 22);
            this.CourseTB.TabIndex = 5;
            this.CourseTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Course Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(176, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 1);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "The deadline:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(677, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 1);
            this.panel3.TabIndex = 10;
            this.panel3.Click += new System.EventHandler(this.label3_Click);
            // 
            // subbtn
            // 
            this.subbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.subbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.subbtn.Location = new System.Drawing.Point(966, 288);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(99, 45);
            this.subbtn.TabIndex = 11;
            this.subbtn.Text = "Submit";
            this.subbtn.UseVisualStyleBackColor = false;
            this.subbtn.Click += new System.EventHandler(this.subbtn_Click);
            // 
            // OutputTB
            // 
            this.OutputTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.OutputTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.OutputTB.Location = new System.Drawing.Point(0, 490);
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ReadOnly = true;
            this.OutputTB.Size = new System.Drawing.Size(1100, 129);
            this.OutputTB.TabIndex = 12;
            this.OutputTB.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Click on the button to generate a motivational message";
            // 
            // Gen
            // 
            this.Gen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Gen.Location = new System.Drawing.Point(514, 359);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(123, 32);
            this.Gen.TabIndex = 14;
            this.Gen.Text = "Generate";
            this.Gen.UseVisualStyleBackColor = false;
            this.Gen.Click += new System.EventHandler(this.Gen_Click);
            // 
            // PosRT
            // 
            this.PosRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.PosRT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PosRT.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosRT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.PosRT.Location = new System.Drawing.Point(0, 419);
            this.PosRT.Name = "PosRT";
            this.PosRT.ReadOnly = true;
            this.PosRT.Size = new System.Drawing.Size(1100, 71);
            this.PosRT.TabIndex = 15;
            this.PosRT.Text = "";
            // 
            // MC
            // 
            this.MC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.MC.FormattingEnabled = true;
            this.MC.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.MC.Location = new System.Drawing.Point(677, 217);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(69, 30);
            this.MC.TabIndex = 16;
            this.MC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.MC.TextUpdate += new System.EventHandler(this.MC_TextUpdate);
            // 
            // DC
            // 
            this.DC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DC.FormattingEnabled = true;
            this.DC.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DC.Location = new System.Drawing.Point(770, 217);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(69, 30);
            this.DC.TabIndex = 17;
            this.DC.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.DC.TextUpdate += new System.EventHandler(this.DC_TextUpdate);
            // 
            // YC
            // 
            this.YC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.YC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.YC.FormattingEnabled = true;
            this.YC.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.YC.Location = new System.Drawing.Point(869, 217);
            this.YC.Name = "YC";
            this.YC.Size = new System.Drawing.Size(69, 30);
            this.YC.TabIndex = 18;
            this.YC.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.YC.TextUpdate += new System.EventHandler(this.YC_TextUpdate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(865, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(766, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Day";
            // 
            // Form2
            // 
            this.AcceptButton = this.subbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YC);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.PosRT);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.subbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CourseTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "CA";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CourseTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button subbtn;
        private System.Windows.Forms.RichTextBox OutputTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.RichTextBox PosRT;
        private System.Windows.Forms.ComboBox MC;
        private System.Windows.Forms.ComboBox DC;
        private System.Windows.Forms.ComboBox YC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}