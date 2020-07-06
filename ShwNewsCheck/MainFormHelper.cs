using ShwNewsCheck.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShwNewsCheck
{
    public class MainFormHelper
    {
        public static MainForm GetMainForm()
        {
            return (MainForm)Application.OpenForms["MainForm"];
        }

        public static void SetSetupStatus(string text)
        {
            GetMainForm().statusStrip1.Items["stripText"].Text = text;
        }

        public static void CheckFolderSettings()
        {
            try
            {
                if (!Directory.Exists(Settings.Default.SetupFolder))
                {
                    Directory.CreateDirectory(Settings.Default.SetupFolder);
                    SetSetupStatus($"Folder: {Settings.Default.SetupFolder} created");
                }
                if (!Directory.Exists(Settings.Default.NewsFolder))
                {
                    Directory.CreateDirectory(Settings.Default.NewsFolder);
                    SetSetupStatus($"Folder: {Settings.Default.NewsFolder} created");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Exception CheckFolderSettings: {e.Message}","Error");
            }

        }

        public static void BindDatagridView()
        {
            var f = GetMainForm();

            Cursor.Current = Cursors.WaitCursor;
            f.dgViewBindingSource.Clear();

            var newsSpecItemsFilename = Settings.Default.SetupFolder + @"\NewsSpecItems.nsi";
            if (File.Exists(newsSpecItemsFilename))
            {
                using (FileStream fs = new FileStream(newsSpecItemsFilename, FileMode.Open))
                {
                    //slurp in a previously saved file
                    f.newsSpecItems = NewsSpecItem.DeserializeAllTable<NewsSpecItem>(fs).ToArray();

                    foreach (NewsSpecItem item in f.newsSpecItems)
                    {
                        f.dgViewBindingSource.Add(item);
                    }
                }

                //set the datasource
                f.dgView.DataSource = null;
                f.dgView.DataSource = f.dgViewBindingSource;
            }

            Cursor.Current = Cursors.Default;
            f.dgView.Focus();

        }

        internal static void InstallDataGridViewColumns()
        {
            var f = GetMainForm();

            if (f.dgView.Columns.Count > 0) f.dgView.Columns.Clear();

            f.dgView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name="ShareNumber",
                DataPropertyName="ShareNumber"
            });
            f.dgView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ShareName",
                DataPropertyName = "ShareName"
            });
            f.dgView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Search",
                DataPropertyName = "SearchTerms"
            });
            f.dgView.Focus();

        }
    }
}
