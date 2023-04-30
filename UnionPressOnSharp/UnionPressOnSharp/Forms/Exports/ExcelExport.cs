using System.Windows.Forms;

namespace UnionPressOnSharp.Forms.Exports
{
    public class ExcelExport
    {

        public void excelExport(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            exApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet wsh = (Microsoft.Office.Interop.Excel.Worksheet)exApp.ActiveSheet;
            for (int i = 0; i <= dataGridView.Rows.Count - 2; i++)
            {
                for (int j = 0; j <= dataGridView.Columns.Count - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;

        }
    }
}
