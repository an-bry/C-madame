namespace location_film
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1484, 57);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.picture_1_1505503146;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1370, 0);
            button2.Name = "button2";
            button2.Size = new Size(114, 57);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.notification_bell_ring_1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1310, 0);
            button1.Name = "button1";
            button1.Size = new Size(54, 51);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Hamburger_icon_svg;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(45, 40);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 6);
            label1.Margin = new Padding(3, 0, 3, 45);
            label1.Name = "label1";
            label1.Size = new Size(233, 51);
            label1.TabIndex = 0;
            label1.Text = "WOLFLIX";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 73, 94);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(panel5);
            panel2.Font = new Font("Segoe UI Black", 50F);
            panel2.Location = new Point(2, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 629);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            // panel3
            // 
            panel3.Font = new Font("Segoe UI Black", 10F);
            panel3.Location = new Point(298, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(1188, 585);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
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
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1489, 690);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Panel panel5;
        private Button button3;
    }
}
