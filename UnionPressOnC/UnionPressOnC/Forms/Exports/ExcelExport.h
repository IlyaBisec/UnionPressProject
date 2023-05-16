using namespace System::Windows::Forms;

namespace UnionPressOnC {

	public class ExcelExport
	{
	public:
		void excelExport(DataGridView^ datagridView)
		{
			Microsoft::Office::Interop::Excel::Application^ exApp;
			exApp->Workbooks->Add();
			Microsoft::Office::Interop::Excel::Worksheet^ wsh = (Microsoft::Office::Interop::Excel::Worksheet^)exApp->ActiveSheet;
			for (int i = 0; i <= datagridView->Rows->Count - 2; i++)
			{
				for (int j = 0; j <= datagridView->Columns->Count - 1; j++)
				{
					wsh->Cells[i + 1, j + 1] = datagridView[j, i]->Value->ToString();
				}
			}
			exApp->Visible = true;
		
		}
	};

}