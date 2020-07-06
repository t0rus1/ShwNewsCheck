using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.Calendar;

namespace ShwNewsCheck
{
    public partial class MainForm : Form
    {
        //MonthCalendar monthCalendar;
        //MonthView monthView;

        public MainForm()
        {
            InitializeComponent();

            AddCalendars();

        }

        private void AddCalendars()
        {
            //monthCalendar = new MonthCalendar();
            //monthCalendar.Dock = DockStyle.Fill;

            //monthView = new MonthView();
            //monthView.Dock = DockStyle.Left;

            //tabControlMain.TabPages[1].Controls.Add(monthCalendar);
        }
    }
}
