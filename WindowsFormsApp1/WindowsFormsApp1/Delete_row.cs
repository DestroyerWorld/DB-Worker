using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Btc_project
{
    public partial class Delete_row : Form
    {
        void updete() {
            try
            {
                Login_window.ConToDB.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT Name_requisites FROM requisites where User_name = '" + Login_window.Users_name + "';", Login_window.ConToDB);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                this.comboBox1.DataSource = DATA;
                this.comboBox1.ValueMember = "Name_requisites";//столбец с id
                this.comboBox1.SelectedIndex = -1;
                Login_window.ConToDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Delete_row()
        {
            InitializeComponent();
            updete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try 
                {
                    if (comboBox1.Text != "")
                    {
                        Login_window.ConToDB.Open();
                        MySqlCommand cmd = Login_window.ConToDB.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "CALL delete_row('" + comboBox1.Text + "')";//Делаем запрос на удаление строки
                        cmd.ExecuteNonQuery();
                        Login_window.ConToDB.Close();
                        MessageBox.Show("Строка удалена");
                    }
                    else MessageBox.Show("Неверный выбор пункта");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    updete();
                }
            }
        }
    }
}
