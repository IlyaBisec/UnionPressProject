using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionPressOnSharp.Forms.Classes;

namespace UnionPressOnSharp.Forms
{
    public partial class GraphicForm : Form
    {
        public GraphicForm()
        {
            InitializeComponent();
        }

        private void GraphicForm_Load(object sender, EventArgs e)
        {
            chart();
            ColorSet();
            chartDiagram.BackColor = Properties.Settings.Default.ColorPanelSet;
        }

        public void chart()
        {
            

        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Press press = new Press();
            //var commandPress, commandType, commandTransport;
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["UnionPressDB"].ConnectionString;
            using (var connection = new SqlConnection(sqlConnectionString))
            using (var commandPress = new SqlCommand())
            {

                connection.Open();
                commandPress.Connection = connection;
                commandPress.CommandText = "Select [Наименование], [Период_выхода], [Количество] from Издания2";
                using (var reader = commandPress.ExecuteReader())
                {
                    while (reader.Read())
                    {
                      //  chartDiagram.Series["SeriesD"].Points.Add(reader.GetInt32(Convert.ToInt32("[Количество]")));
                        chartDiagram.Series["SeriesD"].XValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)reader.GetInt32(Convert.ToInt32("[Количество]"));
                        chartDiagram.Series["SeriesD"].YValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)reader.GetInt32(Convert.ToInt32("[Период_выхода]"));
                    }
                }


                Logger logger = new Logger();
                logger.Log("Показ графика", "GraphicForm.cs", "btnGraph", "35");

                // reader.GetString(Convert.ToInt32("[Период_выхода]"))



                //chart1.Series["kolvo"].Points.Add(reader.GetInt32("kol"), reader.GetInt32("kol"));

                //reader.Close();
            }
        }

        private void ColorSet()
        {
            var settings = Properties.Settings.Default;
            BackColor = settings.ColorPanelSet;
        }
    }
}

