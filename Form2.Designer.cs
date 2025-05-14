namespace location_film
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(677, 11);
            label1.Name = "label1";
            label1.Size = new Size(104, 34);
            label1.TabIndex = 0;
            label1.Text = "FILMS";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 73, 94);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(panel5);
            panel2.Font = new Font("Segoe UI Black", 50F);
            panel2.Location = new Point(2, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 627);
            panel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 10F);
            button3.Location = new Point(57, 44);
            button3.Name = "button3";
            button3.Size = new Size(220, 48);
            button3.TabIndex = 5;
            button3.Text = "FIMLS";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.istockphoto_1329174235_612x612;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(10, 44);
            panel5.Name = "panel5";
            panel5.RightToLeft = RightToLeft.Yes;
            panel5.Size = new Size(45, 48);
            panel5.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(789, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(656, 510);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "TITRE";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "GENRE";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "PRIX";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "DISPONILITE";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(207, 409);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "ouii";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 186);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 9;
            label2.Text = "TITRE:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 260);
            label3.Name = "label3";
            label3.Size = new Size(97, 27);
            label3.TabIndex = 10;
            label3.Text = "GENRE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 411);
            label5.Name = "label5";
            label5.Size = new Size(89, 27);
            label5.TabIndex = 12;
            label5.Text = "LIBRE:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.Location = new Point(41, 469);
            button1.Name = "button1";
            button1.Size = new Size(124, 57);
            button1.TabIndex = 13;
            button1.Text = "AJOUTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(241, 196, 15);
            button2.Location = new Point(187, 469);
            button2.Name = "button2";
            button2.Size = new Size(126, 57);
            button2.TabIndex = 14;
            button2.Text = "MODIFIER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(231, 76, 60);
            button4.Location = new Point(346, 469);
            button4.Name = "button4";
            button4.Size = new Size(115, 57);
            button4.TabIndex = 15;
            button4.Text = "SUPPRIMER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(checkBox1);
            panel3.Location = new Point(298, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 567);
            panel3.TabIndex = 16;
            panel3.Paint += panel3_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 31);
            textBox1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 105);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(40, 27);
            label7.TabIndex = 21;
            label7.Text = "ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(187, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(251, 31);
            textBox5.TabIndex = 20;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 327);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 31);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonShadow;
            label6.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 331);
            label6.Name = "label6";
            label6.Size = new Size(76, 27);
            label6.TabIndex = 17;
            label6.Text = "PRIX:";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(780, 50);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(403, 31);
            textBox6.TabIndex = 21;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(1189, 48);
            button5.Name = "button5";
            button5.Size = new Size(140, 34);
            button5.TabIndex = 22;
            button5.Text = "RECHERCHER";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Location = new Point(1335, 44);
            button6.Name = "button6";
            button6.Size = new Size(129, 42);
            button6.TabIndex = 23;
            button6.Text = "RAFRAICHIR";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 665);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Panel panel5;
        private Label label1;
        private FileSystemWatcher fileSystemWatcher1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button5;
        private Button button6;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
    }
}