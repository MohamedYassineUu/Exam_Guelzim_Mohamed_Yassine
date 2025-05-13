namespace Exam_Guelzim_Mohamed_Yassine
{
    partial class Etudiant
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button6 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 37);
            label1.Name = "label1";
            label1.Size = new Size(151, 62);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(71, 282);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 1;
            button1.Text = "Exam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(340, 282);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 2;
            button2.Text = "Notes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(630, 282);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 3;
            button3.Text = "Relevé de note";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(883, 282);
            button4.Name = "button4";
            button4.Size = new Size(151, 29);
            button4.TabIndex = 4;
            button4.Text = "Inscription Exam";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(3, 830);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 232);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(468, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(628, 226);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(450, 38);
            label2.TabIndex = 2;
            label2.Text = "Recherche de tout les exam a venir";
            // 
            // button6
            // 
            button6.Location = new Point(251, 127);
            button6.Name = "button6";
            button6.Size = new Size(167, 45);
            button6.TabIndex = 1;
            button6.Text = "Recherche";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(36, 127);
            button5.Name = "button5";
            button5.Size = new Size(167, 45);
            button5.TabIndex = 0;
            button5.Text = "retour";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Location = new Point(3, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 229);
            panel2.TabIndex = 6;
            panel2.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(424, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(669, 229);
            dataGridView2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Normal", "Rattrapage" });
            comboBox1.Location = new Point(15, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 136);
            label5.Name = "label5";
            label5.Size = new Size(291, 20);
            label5.TabIndex = 5;
            label5.Text = "-----------------------------------------------";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 33);
            label3.Name = "label3";
            label3.Size = new Size(226, 38);
            label3.TabIndex = 3;
            label3.Text = "Rechercher par : ";
            // 
            // button9
            // 
            button9.Location = new Point(312, 132);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 2;
            button9.Text = "retour";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(202, 159);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 1;
            button8.Text = "matiere";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(202, 104);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 0;
            button7.Text = "Session";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Etudiant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Etudiant";
            Text = "Etudiant";
            Load += Etudiant_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Button button9;
        private Button button8;
        private Button button7;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Label label5;
    }
}