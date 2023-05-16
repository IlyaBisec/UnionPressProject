#include <string>
using namespace System;
using namespace System::Collections::Generic;
using namespace System::IO;
using namespace System::Text;
using namespace System::Threading::Tasks;
using namespace System::Windows::Forms;

namespace UnionPressOnC {

	public class WordExport
	{

    public: void wordExport(DataGridView^ dataGridView, String^ filename)
        {
            String^ stOutput = "";
            // Export titles:
            String^ sHeaders = "";

            for (int j = 0; j < dataGridView->Columns->Count; j++)
                sHeaders = sHeaders->ToString() + Convert::ToString(dataGridView->Columns[j]->HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dataGridView->RowCount - 1; i++)
            {
                String^ stLine = "";
                for (int j = 0; j < dataGridView->Rows[i]->Cells->Count; j++)
                    stLine = stLine->ToString() + Convert::ToString(dataGridView->Rows[i]->Cells[j]->Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding^ utf16 = Encoding::GetEncoding("Windows-1251");
            int output;
            unsigned char byte[output];
            byte[output] = utf16->GetBytes(stOutput);
            FileStream^ fs = gcnew FileStream(filename, FileMode::Create);
            BinaryWriter^ bw = gcnew BinaryWriter(fs);
            bw->Write(byte, 0, byte->Length);
            bw->Flush();
            bw->Close();
            fs->Close();
        }


	};


}