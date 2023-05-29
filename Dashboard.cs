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

namespace CDR_Analyser
{
    public partial class Dashboard : Form
    {
        public string cdrFilePath = "";
        public CDRData data;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCDRDialog.Title = "Browse CDR File";
            openCDRDialog.DefaultExt = "xlsx";
            if (openCDRDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openCDRDialog.FileName))
                {
                    cdrFilePath = openCDRDialog.FileName;
                }
                else
                {
                    MessageBox.Show("File Does Not Exist");
                }
            }
            LoadCDRIntoApp();
        }

        private void LoadCDRIntoApp()
        {
            data = new CDRData();
            data.CDRFilePath = cdrFilePath;

            data.initialise();

            MessageBox.Show("A1 -> " + data.testVal);
        }
    }
}
