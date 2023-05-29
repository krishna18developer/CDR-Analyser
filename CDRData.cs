using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;

namespace CDR_Analyser
{
    public class CDRData
    {
        WorkBook workBook;
        WorkSheet workSheet;

        public string testVal { get; set; }
        public string CDRFilePath { get; set; }
        public string CDRName { get; set; }

        public CDRData()
        {

        }

        public void initialise()
        {
            try
            {
                workBook = WorkBook.Load(CDRFilePath);
                WorkSheet workSheet = workBook.WorkSheets.First();

                //testVal = workSheet["A1"].DecimalValue + "";
                testVal = workSheet["A1"].StringValue + "";
            }
            catch(Exception e)
            {
                if ((e + "").Contains("System.IO.IOException"))
                {
                    MessageBox.Show("CDR File used by another application, Please close it and try again.");
                }
            }                 
        }
    }
}
