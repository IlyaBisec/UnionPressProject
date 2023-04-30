using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Repositories;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using UnionPressOnSharp.Forms;

namespace UnionPressOnSharp.Forms.Chart
{
    public class ChartView
    {
        //CPressRepository pressRepository;
        //CTypeRepository cTypeRepository;
        //CTransportRepository cTransportRepository;
        //GraphicForm graphicForm;
        //Press press;
        public void chart()
        {
            ////var commandPress, commandType, commandTransport;
            //string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
            //using (var connection = new SqlConnection(sqlConnectionString))
            //using (var commandPress = new SqlCommand())
            //{
            //    using (var commandTransport = new SqlCommand())
            //    {
            //        connection.Open();
            //        commandPress.Connection = connection;
            //        commandTransport.Connection = connection;
            //        commandPress.CommandText = "Select [Наименование], [Период_выхода] from Издания";
            //        commandTransport.CommandText = "Select [Дата_начала], [Дата_окончания]from Доставка";
            //        using (var reader = commandPress.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                for(int i = 0; i < press.gridPress.RowCount; i++)
            //                graphicForm.chartDiagram.Series["Наименование"].Points.AddXY(press.gridPress[i][0], press.gridPress[i][1]));
            //            }
            //        }

            //    }

                //chart1.Series["kolvo"].Points.Add(reader.GetInt32("kol"), reader.GetInt32("kol"));

                //reader.Close();
            

        }
    }

}
