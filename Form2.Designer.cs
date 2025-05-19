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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(782, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(736, 379);
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
            checkBox1.Location = new Point(485, 538);
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
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 251);
            label2.Name = "label2";
            label2.Size = new Size(66, 27);
            label2.TabIndex = 9;
            label2.Text = "TITRE:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(318, 349);
            label3.Name = "label3";
            label3.Size = new Size(87, 27);
            label3.TabIndex = 10;
            label3.Text = "GENRE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(318, 537);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 12;
            label5.Text = "LIBRE:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.Location = new Point(845, 596);
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
            button2.Location = new Point(1078, 596);
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
            button4.Location = new Point(1313, 596);
            button4.Name = "button4";
            button4.Size = new Size(115, 57);
            button4.TabIndex = 15;
            button4.Text = "SUPPRIMER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(485, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(485, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 31);
            textBox1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(318, 155);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(33, 27);
            label7.TabIndex = 21;
            label7.Text = "ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(485, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(251, 31);
            textBox5.TabIndex = 20;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(485, 448);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 31);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 448);
            label6.Name = "label6";
            label6.Size = new Size(64, 27);
            label6.TabIndex = 17;
            label6.Text = "PRIX:";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(782, 53);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(533, 31);
            textBox6.TabIndex = 21;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(178, 8, 5);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(1339, 53);
            button5.Name = "button5";
            button5.Size = new Size(140, 31);
            button5.TabIndex = 22;
            button5.Text = "RECHERCHER";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 45, 45);
            button6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(318, 42);
            button6.Name = "button6";
            button6.Size = new Size(129, 42);
            button6.TabIndex = 23;
            button6.Text = "RAFRAICHIR";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 681);
            panel1.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(178, 8, 55);
            panel6.Location = new Point(3, 208);
            panel6.Name = "panel6";
            panel6.Size = new Size(19, 77);
            panel6.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 493);
            button3.Name = "button3";
            button3.Size = new Size(287, 77);
            button3.TabIndex = 3;
            button3.Text = "Location";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 348);
            button7.Name = "button7";
            button7.Size = new Size(287, 77);
            button7.TabIndex = 2;
            button7.Text = "Clients";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 208);
            button8.Name = "button8";
            button8.Size = new Size(287, 77);
            button8.TabIndex = 1;
            button8.Text = "Films";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 80);
            button9.Name = "button9";
            button9.Size = new Size(284, 74);
            button9.TabIndex = 0;
            button9.Text = "Accueil";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(591, 535);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(69, 29);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "non";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 665);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel panel1;
        private Panel panel6;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}