using ShwNewsCheck.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace ShwNewsCheck
{
    public partial class MainForm : Form
    {
        public BindingSource dgViewBindingSource = new BindingSource();
        public NewsSpecItem[] newsSpecItems;

        public Calendar calendar;
        public MonthView monthView;
        
        public MainForm()
        {
            InitializeComponent();

            AddCalendars();

        }

        private void AddCalendars()
        {
            monthView = new MonthView
            {
                Dock = DockStyle.Fill,
                FirstDayOfWeek = DayOfWeek.Sunday,
                WorkWeekStart = DayOfWeek.Monday,
                WorkWeekEnd = DayOfWeek.Friday,
                SelectionMode = MonthView.MonthViewSelection.WorkWeek,
                Anchor = AnchorStyles.Top,
              
            };

            calendar = new Calendar
            {
                Dock = DockStyle.Fill,
                FirstDayOfWeek = DayOfWeek.Sunday,
                //MaximumFullDays=14,
                //MaximumViewDays=14,
                ShowWeekHeader = true,
                TimeScale = TimeScales.SixtyMinutes,
                //Padding=new Padding(4),
                RendererMode= RendererModes.Professional,
            };

            tabControlMain.TabPages[1].Controls["PanelOperationsLeft"].Controls.Add(monthView);
            tabControlMain.TabPages[1].Controls["PanelOperationsRight"].Controls.Add(calendar);
            tabControlMain.SelectTab(1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Shw News Check v{ Application.ProductVersion}.";

            MainFormHelper.CheckFolderSettings();

            dgView.AutoGenerateColumns = false;
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; //  DisplayedCells;  //ColumnHeader;  //AllCells;
            MainFormHelper.BindDatagridView();

            dgView.Focus();
            statusStrip1.Items["stripText"].Text = "Ready";
            
            MainFormHelper.InstallDataGridViewColumns();

        }




    }
}
