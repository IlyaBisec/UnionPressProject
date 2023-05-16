#include "GraphicForm.h"
using namespace System::Configuration;

using namespace UnionPressOnC;

Void GraphicForm::btnGraph_Click(System::Object^ sender, System::EventArgs^ e)
{
	Press^ press = gcnew Press();
	//var commandPress, commandType, commandTransport;
	std::string sqlConnectionString = ConfigurationManager::ConnectionStrings["UnionPressDB"].ConnectionString;
	using (SqlConnection^ connection = gcnew SqlConnection(sqlConnectionString))
		using (SqlCommand^ commandPress = gcnew SqlCommand())
	{

		connection.Open();
		commandPress.Connection = connection;
		commandPress.CommandText = "Select [������������], [������_������], [����������] from �������2";
		using (auto reader = commandPress.ExecuteReader())
		{
			while (reader.Read())
			{
				//  chartDiagram.Series["SeriesD"].Points.Add(reader.GetInt32(Convert.ToInt32("[����������]")));
				chartDiagram.Series["SeriesD"].XValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)reader.GetInt32(Convert.ToInt32("[����������]"));
				chartDiagram.Series["SeriesD"].YValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)reader.GetInt32(Convert.ToInt32("[������_������]"));
			}
		}


		Logger logger;
		logger.Log("����� �������", "GraphicForm.cs", "btnGraph", "35");

	};

}