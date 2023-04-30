using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnionPressOnSharp.Forms.Exports
{
    public class WordExport
    {
        public void wordExport(DataGridView dataGridView, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dataGridView.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dataGridView.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dataGridView.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding("Windows-1251");
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }

    }
}
