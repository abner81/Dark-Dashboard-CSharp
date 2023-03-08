﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard.View
{
    public partial class DashboardForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
     int nLeftRect,
     int nTopRect,
     int nRightRect,
     int nBottomRect,
     int nWidthEllipse,
    int nHeightEllipse

 );

        private readonly Color backColorClick = Color.FromArgb(46, 51, 73);
        private readonly Color backColorLeave = Color.FromArgb(24, 30, 54);

        private void PinNavOnClickIn(Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.Click += delegate
                {
                    pnlNav.Height = button.Height;
                    pnlNav.Top = button.Top;
                    pnlNav.Left = button.Left;
                    button.BackColor = backColorClick;
                };

            };
        }

        private void FixBackColorOnLeaveIn(Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.Leave += delegate { button.BackColor = backColorLeave; };
            };
        }

        public DashboardForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            var buttons = new Button[] { btnAnalytics, btnCalendar, btnContactUs, btnSettings, btnDashboard };

            PinNavOnClickIn(buttons);
            FixBackColorOnLeaveIn(buttons);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}