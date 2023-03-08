using System.Resources;

namespace Dashboard.View
{
    partial class DashboardForm
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
            panel1 = new Panel();
            btnSettings = new Button();
            btnContactUs = new Button();
            btnCalendar = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pnlNav = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            label12 = new Label();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            label15 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            label14 = new Label();
            panel8 = new Panel();
            label13 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 261);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnContactUs);
            panel1.Controls.Add(btnCalendar);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Image = Dashboard.Properties.Resources.settings;
            btnSettings.Location = new Point(0, 532);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 45);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Configurações";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            btnContactUs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnContactUs.Dock = DockStyle.Top;
            btnContactUs.FlatAppearance.BorderSize = 0;
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactUs.Image = Dashboard.Properties.Resources.Conact;
            btnContactUs.Location = new Point(0, 279);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(186, 45);
            btnContactUs.TabIndex = 7;
            btnContactUs.Text = "Contate-nos";
            btnContactUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContactUs.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            btnCalendar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendar.Image = Dashboard.Properties.Resources.home;
            btnCalendar.Location = new Point(0, 234);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(186, 45);
            btnCalendar.TabIndex = 6;
            btnCalendar.Text = "Calendário ";
            btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalendar.UseVisualStyleBackColor = true;
            // 
            // btnAnalytics
            // 
            btnAnalytics.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalytics.Image = Dashboard.Properties.Resources.diagram;
            btnAnalytics.Location = new Point(0, 189);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(186, 45);
            btnAnalytics.TabIndex = 5;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnalytics.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.Image = Dashboard.Properties.Resources.home;
            btnDashboard.Location = new Point(0, 144);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(36, 97);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 1;
            label2.Text = "Abner Machado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Dashboard.Properties.Resources.Untitled_11;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(220, 17);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 3;
            label3.Text = "Dashboard";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(615, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 22);
            textBox1.TabIndex = 4;
            textBox1.Text = "Pesquisar...";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(924, 24);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(220, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 130);
            panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Dashboard.Properties.Resources.money_bag;
            pictureBox2.Location = new Point(161, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(159, 151, 176);
            label6.Location = new Point(16, 100);
            label6.Name = "label6";
            label6.Size = new Size(104, 19);
            label6.TabIndex = 2;
            label6.Text = "Últimos 28 dias";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 146, 249);
            label5.Location = new Point(16, 59);
            label5.Name = "label5";
            label5.Size = new Size(117, 33);
            label5.TabIndex = 1;
            label5.Text = "$12234";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 21);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 0;
            label4.Text = "Ganhos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(512, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 130);
            panel4.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Dashboard.Properties.Resources.downloads;
            pictureBox3.Location = new Point(161, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(159, 151, 176);
            label7.Location = new Point(16, 100);
            label7.Name = "label7";
            label7.Size = new Size(104, 19);
            label7.TabIndex = 2;
            label7.Text = "Últimos 28 dias";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(50, 226, 178);
            label8.Location = new Point(16, 59);
            label8.Name = "label8";
            label8.Size = new Size(87, 33);
            label8.TabIndex = 1;
            label8.Text = "12K+";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(16, 21);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 0;
            label9.Text = "Downloads";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(circularProgressBar1);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(220, 261);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 259);
            panel5.TabIndex = 7;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.White;
            circularProgressBar1.InnerColor = Color.FromArgb(37, 42, 64);
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(50, 66);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.FromArgb(24, 30, 54);
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColor = Color.FromArgb(0, 162, 249);
            circularProgressBar1.ProgressWidth = 8;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(150, 150);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "";
            circularProgressBar1.TabIndex = 8;
            circularProgressBar1.Text = "67%";
            circularProgressBar1.TextMargin = new Padding(5, 0, 0, 0);
            circularProgressBar1.Value = 68;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(16, 21);
            label12.Name = "label12";
            label12.Size = new Size(132, 25);
            label12.TabIndex = 0;
            label12.Text = "Seu Progresso";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 42, 64);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(label15);
            panel6.Location = new Point(512, 261);
            panel6.Name = "panel6";
            panel6.Size = new Size(410, 175);
            panel6.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Bottom;
            pictureBox5.Image = Dashboard.Properties.Resources.chart_diagram1;
            pictureBox5.Location = new Point(0, 66);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(410, 109);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(16, 21);
            label15.Name = "label15";
            label15.Size = new Size(78, 25);
            label15.TabIndex = 0;
            label15.Text = "Acessos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(159, 151, 176);
            label10.Location = new Point(72, 228);
            label10.Name = "label10";
            label10.Size = new Size(104, 19);
            label10.TabIndex = 4;
            label10.Text = "Últimos 28 dias";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(37, 42, 64);
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label14);
            panel7.Location = new Point(788, 85);
            panel7.Name = "panel7";
            panel7.Size = new Size(134, 130);
            panel7.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Dashboard.Properties.Resources.downloads;
            pictureBox4.Location = new Point(161, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(97, 101);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(159, 151, 176);
            label11.Location = new Point(10, 56);
            label11.Name = "label11";
            label11.Size = new Size(121, 57);
            label11.TabIndex = 2;
            label11.Text = " it to make a type \r\n it to make a type \r\n it to make a type \r\n";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(13, 21);
            label14.Name = "label14";
            label14.Size = new Size(106, 25);
            label14.TabIndex = 0;
            label14.Text = "Downloads";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(37, 42, 64);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label16);
            panel8.Location = new Point(512, 442);
            panel8.Name = "panel8";
            panel8.Size = new Size(410, 78);
            panel8.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(159, 151, 176);
            label13.Location = new Point(3, 73);
            label13.Name = "label13";
            label13.Size = new Size(121, 57);
            label13.TabIndex = 2;
            label13.Text = " it to make a type \r\n it to make a type \r\n it to make a type \r\n";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(16, 10);
            label16.Name = "label16";
            label16.Size = new Size(106, 25);
            label16.TabIndex = 0;
            label16.Text = "Downloads";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(159, 151, 176);
            label17.Location = new Point(16, 46);
            label17.Name = "label17";
            label17.Size = new Size(337, 19);
            label17.TabIndex = 3;
            label17.Text = " it to make a type it to make a type it to make a type \r\n";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pnlNav);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 126, 249);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Off;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.FromArgb(0, 192, 0);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnSettings;
        private Button btnContactUs;
        private Button btnCalendar;
        private Button btnAnalytics;
        private Panel pnlNav;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Panel panel3;
        private Label label4;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel5;
        private Label label12;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label label15;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Label label10;
        private Panel panel7;
        private PictureBox pictureBox4;
        private Label label11;
        private Label label14;
        private Panel panel8;
        private Label label17;
        private Label label13;
        private Label label16;
    }
}