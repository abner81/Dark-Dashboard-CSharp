using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class ButtonEvents
{
    public Button button { get; set; }
    public string pageTitle { get; set; }
    public Form onClickGoTo { get; set; }

    public ButtonEvents(Button button, Form onClickGoTo, string pageTitle)
    {
        this.button = button;
        this.onClickGoTo = onClickGoTo;
        this.pageTitle = pageTitle;
    }
}

namespace Dashboard.View
{
    public partial class Form1 : Form
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

        //nome da classe ButtonEvents pode ser algo com side menu
        private void RaiseSideMenuEvents(ButtonEvents[] sideMenus)
        {
            foreach (var item in sideMenus)
            {
                PinNavOnClickIn(item.button);
                FixBackColorOnLeaveIn(item.button);
                OnClickButtonGoTo(item);
            }
        }


        private void OnClickButtonGoTo(ButtonEvents item)
        {
            item.button.Click += delegate
            {
                lblTitle.Text = item.pageTitle;
                pnlFormLoader.Controls.Clear();

                item.onClickGoTo.Dock = DockStyle.Fill;
                item.onClickGoTo.TopMost = true;
                item.onClickGoTo.TopLevel = false;
                item.onClickGoTo.FormBorderStyle = FormBorderStyle.None;

                pnlFormLoader.Controls.Add(item.onClickGoTo);
                item.onClickGoTo.Show();
            };
        }

        private void PinNavOnClickIn(Button button)
        {
            button.Click += delegate
            {
                pnlNav.Height = button.Height;
                pnlNav.Top = button.Top;
                pnlNav.Left = button.Left;
                button.BackColor = backColorClick;
            };
        }

        private void FixBackColorOnLeaveIn(Button button)
        {
            button.Leave += delegate { button.BackColor = backColorLeave; };
        }

        private ButtonEvents[] SideMenuEventsFactory()
        {
            var dashboard = new ButtonEvents(btnDashboard, new FormDashboard(), "Dashboard");
            var analytics = new ButtonEvents(btnAnalytics, new FormDashboard(), "Analytics");
            var calendar = new ButtonEvents(btnCalendar, new FormDashboard(), "Calendario");
            var contactUs = new ButtonEvents(btnContactUs, new FormDashboard(), "Contate-nos");
            var settings = new ButtonEvents(btnSettings, new FormDashboard(), "Configuracoes");

            return new ButtonEvents[] { dashboard, analytics, calendar, contactUs, settings };
        }

        private void AssociateAndRaiseEvents()
        {
            var buttons = SideMenuEventsFactory();
            RaiseSideMenuEvents(buttons);
            btnClose.Click += delegate { Close(); };
        }

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            AssociateAndRaiseEvents();
        }
    }
}
