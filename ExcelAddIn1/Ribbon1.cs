using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Excel;

namespace ExcelAddIn1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Click(object sender, RibbonUIEventArgs e)
        {
            var Form = new F_USIMNAS();
            Form.Show();
        }

        private void BtnFormPedido_Click(object sender, RibbonControlEventArgs e)
        {
            var Form = new F_USIMNAS();
            Worksheet currentSheet = Globals.ThisAddIn.GetActiveWorkSheet();
            Form.Show();
        }
    }
}
