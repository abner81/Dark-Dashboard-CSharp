namespace Dashboard.View
{
    partial class Form1
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
            pnlNav = new Panel();
            panel1 = new Panel();
            btnSettings = new Button();
            label1 = new Label();
            btnContactUs = new Button();
            btnCalendar = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            textBox1 = new TextBox();
            lblTitle = new Label();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 189);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnContactUs);
            panel1.Controls.Add(btnCalendar);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 4;
            // 
            // btnSettings
            // 
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Location = new Point(0, 532);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 45);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Configurações";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 257);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // btnContactUs
            // 
            btnContactUs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnContactUs.Dock = DockStyle.Top;
            btnContactUs.FlatAppearance.BorderSize = 0;
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactUs.ForeColor = Color.FromArgb(0, 126, 249);
            btnContactUs.Image = Properties.Resources.Conact;
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
            btnCalendar.ForeColor = Color.FromArgb(0, 126, 249);
            btnCalendar.Image = Properties.Resources.home;
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
            btnAnalytics.ForeColor = Color.FromArgb(0, 126, 249);
            btnAnalytics.Image = Properties.Resources.diagram;
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
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = Properties.Resources.home;
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
            pictureBox1.Image = Properties.Resources.Untitled_11;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(907, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 24;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(609, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 22);
            textBox1.TabIndex = 23;
            textBox1.Text = "Pesquisar...";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(214, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(156, 31);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Dashboard";
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(186, 100);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(765, 477);
            pnlFormLoader.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(pnlFormLoader);
            Controls.Add(btnClose);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNav;
        private Panel panel1;
        private Button btnSettings;
        private Button btnContactUs;
        private Button btnCalendar;
        private Button btnAnalytics;
        private Button btnDashboard;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnClose;
        private TextBox textBox1;
        private Label lblTitle;
        private Panel pnlFormLoader;
    }
}