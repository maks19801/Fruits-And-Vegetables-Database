using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsAndVegetablesTable
{
    public partial class FruitsAndVegetablesForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["FruitsAndVegetablesDatabase"]
                                                    .ConnectionString;
        SqlConnection _connection = null;
        SqlDataAdapter dataAdapter = null;
        DataSet  dataSet = null;
        public readonly List<SqlRequest> _sqlRequests;

        public FruitsAndVegetablesForm()
        {
            InitializeComponent();
            _sqlRequests = GetSqlRequests();
            _connection = new SqlConnection(connectionString);

            sqlRequestsComboBox.Items.AddRange(_sqlRequests.ToArray());
        }

        private List<SqlRequest> GetSqlRequests()
        {
            return new List<SqlRequest>
            {
                new SqlRequest("Отобразить всю информацию из таблицы с овощами и фруктами","select * from Fruits_And_Vegetables"),
                new SqlRequest("Отобразить все названия овощей и фруктов","select Name from Fruits_And_Vegetables"),
                new SqlRequest("Отобразить все цвета","select Color from Fruits_And_Vegetables"),
                new SqlRequest("Показать максимальную калорийность","select MAX(Calories) as MaxCalory from Fruits_And_Vegetables"),
                new SqlRequest("Показать минимальную калорийность","select MIN(Calories) as MinCalory from Fruits_And_Vegetables"),
                new SqlRequest("Показать среднюю калорийность","select AVG(Calories) as AverageCalory from Fruits_And_Vegetables"),
                new SqlRequest("Показать количество овощей","select COUNT(*) as NumberOfVegetables from Fruits_And_Vegetables Where Type = 'vegetable'"),
                new SqlRequest("Показать количество фруктов","select COUNT(*) as NumberOfFruits from Fruits_And_Vegetables Where Type = 'fruit'"),
                new SqlRequest("Показать количество овощей и фруктов заданного цвета(введите неоходимый цвет)", $"select  COUNT(*) from Fruits_And_Vegetables Where Color = @color"),
                new SqlRequest("Показать количество овощей фруктов каждого цвета","select Color, Count(Color) as NumberOfColors from Fruits_And_Vegetables Group by Color"),
                new SqlRequest("Показать овощи и фрукты с калорийностью ниже указанной(введите калорийность)","select Name from Fruits_And_Vegetables Where Calories < @calories"),
                new SqlRequest("Показать овощи и фрукты с калорийностью выше указанной(введите калорийность)","select Name from Fruits_And_Vegetables Where Calories > @calories"),
                new SqlRequest("Показать овощи и фрукты с калорийностью в указанном диапазоне(введите диапазон калорийности)","select Name from Fruits_And_Vegetables Where Calories >= @caloriesMin and Calories <= @caloriesMax"),
                new SqlRequest("Показать все овощи и фрукты, у которых цвет желтый или красный","select * from Fruits_And_Vegetables Where Color = 'red' or Color = 'yellow'")
            };
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                dataSet = new DataSet();
                var index = sqlRequestsComboBox.SelectedIndex;
                var color = "";
                int[] caloriesRange = { };
                var calories = 0;

                var sqlRequest = _sqlRequests[index].Request;
                var commandText = sqlRequest;
                
                dataAdapter = new SqlDataAdapter(commandText, _connection);

                if (index == 8)
                {
                    color = inputParameterTextBox.Text;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("color", color);
                }
                if(index == 10)
                {
                    calories = int.Parse(inputParameterTextBox.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("calories", calories);
                }
                if (index == 11)
                {
                    calories = int.Parse(inputParameterTextBox.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("calories", calories);
                }
                if (index == 12)
                {
                    var caloriesRangeStrings = inputParameterTextBox.Text.Split(',');
                    dataAdapter.SelectCommand.Parameters.AddWithValue("caloriesMin", int.Parse(caloriesRangeStrings[0]));
                    dataAdapter.SelectCommand.Parameters.AddWithValue("caloriesMax", int.Parse(caloriesRangeStrings[1]));
                }


                dataGridViewDatabaseTable.DataSource = null;
                var command = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataSet, "Fruits_And_Vegetables");
                dataGridViewDatabaseTable.DataSource = dataSet.Tables["Fruits_And_Vegetables"];
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
