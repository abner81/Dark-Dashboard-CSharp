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
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Paint += panel1_Paint;
            // 
            // btnSettings
            // 
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Image = Properties.Resources.settings;
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
            label2.Click += label2_Click;
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
            label3.Location = new Point(196, 17);
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
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(924, 26);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(411, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 130);
            panel3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 28);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 0;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
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
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}