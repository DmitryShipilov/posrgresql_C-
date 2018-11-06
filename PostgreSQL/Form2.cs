using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace PostgreSQL
{
    public partial class Form2 : Form
    {
        public Form2(string inType)
        {
            InitializeComponent();

            switch (inType)
            {
                case "name":
                    Item = inType.ToString();
                    break;
                case "surname":
                    Item = inType.ToString();
                    break;
                case "patronymic":
                    Item = inType.ToString();
                    break;
                case "street":
                    Item = inType.ToString();
                    break;
                case "telephone":
                    Item = inType.ToString();
                    break;
            }
        }

        public string Item;
        DataTable dt = new DataTable();
        private void Form2_Load(object sender, EventArgs e) // shows datagrid depended from cunstructor
        {
            try
            {
                dt.Clear();
                string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                string query;

                if (this.Item.Equals("telephone"))  //e.g telephone in main table
                {
                     query = "select u_id, telephone from main";
                }

                else
                {
                     query = String.Format("select * from {0}", this.Item);
                }

                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();

                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                dt.Load(npgSqlDataReader);
                dataGridView1.DataSource = dt;
                dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

                connection.Close();

                dataGridView1.Columns[1].HeaderText = this.Item;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonUpdate_Click(object sender, EventArgs e) // update parent table
        {
            try
            {

                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    int x = dataGridView1.CurrentCell.RowIndex;
                    string id = (dataGridView1[0, x].Value.ToString());
                    string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                    string query;
                    if (this.Item.Equals("telephone"))
                    {
                        query = String.Format("UPDATE {0} SET telephone = '{1}' where u_id = {2}", "main", dataGridView1.CurrentCell.Value.ToString(), id);
                    }
                    else
                    {
                        query = String.Format("UPDATE {0} SET f_val = '{1}' where f_id = {2}", this.Item, dataGridView1.CurrentCell.Value.ToString(), id);
                    }

                    NpgsqlConnection connection = new NpgsqlConnection(connstring);
                    connection.Open();

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    this.Form2_Load(sender, e);
                    MessageBox.Show("User was update", "Warning");

                    connection.Close();
                    
                }
                else
                {
                    MessageBox.Show("You can not change id", "Warning");
                    this.Form2_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing pickedddd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}



