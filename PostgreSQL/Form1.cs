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
using PostgreSQL;
using PgSql;

namespace PgSql
{
    public partial class Form1 : Form
    {

        List<string> ColumnVals = new List<string>();
        List<string> ColumnIndex = new List<string>();
        DataTable dt = new DataTable(); //data table in grid
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // load data into comboboxes
        {
            this.comboShow("name");
            this.comboShow("surname");
            this.comboShow("patronymic");
            this.comboShow("street");

            this.fillPredictInput("name");
            this.fillPredictInput("surname");
            this.fillPredictInput("patronymic");
            this.fillPredictInput("street");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)  // clear all textBoxes
        {
            lastName.Text = "";
            name.Text = "";
            patronymic.Text = "";
            phNumber.Text = "";
            street.Text = "";

            comboBoxPredictName.SelectedIndex    = -1;
            comboBoxPredictSurname.SelectedIndex = -1;
            comboBoxPredictStreet.SelectedIndex  = -1;
            comboBoxPredictPatron.SelectedIndex  = -1;
        }

        private void add_Click(object sender, EventArgs e) // fills parents and main table, refreshes cmbxs
        {
            if ((lastName.Text == "") || (name.Text == "") || (patronymic.Text == "") || (phNumber.Text == "") || (street.Text == ""))
            {
                MessageBox.Show("Заполнены не все поля", "phonebook", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PostGreSQL pg = new PostGreSQL();

                pg.PostgreSQL_insert_into_table("surname", lastName.Text);
                pg.PostgreSQL_insert_into_table("name", name.Text);
                pg.PostgreSQL_insert_into_table("patronymic", patronymic.Text);
                pg.PostgreSQL_insert_into_table("main", "telephone", phNumber.Text);
                pg.PostgreSQL_insert_into_table("street", street.Text);

                pg.PostgreSQL_insert_main(name.Text, lastName.Text, patronymic.Text, street.Text);

                this.comboShow("name","refresh");
                this.comboShow("surname", "refresh");
                this.comboShow("patronymic", "refresh");
                this.comboShow("street", "refresh");

                MessageBox.Show("Пользователь внесен", "phonebook", MessageBoxButtons.OK, MessageBoxIcon.None);
            
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // fills datagrid 
        {
            try
            {
                dt.Clear();
                string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                string query = " select u_id, name.f_val, surname.f_val, patronymic.f_val ,street.f_val, telephone from main " +
                               " inner join surname on main.surname = surname.f_id " +
                               " inner join name on main.name = name.f_id " +
                               " inner join street on main.street = street.f_id " +
                               " inner join patronymic on main.patronymic = patronymic.f_id; ";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();

                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
                NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

                dt.Load(npgSqlDataReader);
                dataGridView1.DataSource = dt;
                dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

                connection.Close();

                // column names
                dataGridView1.Columns[1].HeaderText = "name";
                dataGridView1.Columns[2].HeaderText = "surname";
                dataGridView1.Columns[3].HeaderText = "patronymic";
                dataGridView1.Columns[4].HeaderText = "street";
                dataGridView1.Columns[5].HeaderText = "telephone";

                //reset filters
                comboBoxFilterName.SelectedItem = null;
                comboBoxFilterSurname.SelectedItem = null;
                comboBoxFilterStreet.SelectedItem = null;
                comboBoxFilterPatr.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        } 


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
      
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e) //deletes current row in main table
        {
            {


                if (dataGridView1.CurrentCellAddress.Y.Equals(null))

                    MessageBox.Show("Nothing picked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        int x = dataGridView1.CurrentCell.RowIndex; 

                        string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                        string query = String.Format("DELETE from main where u_id = {0}", dataGridView1[0, x].Value.ToString());

                        NpgsqlConnection connection = new NpgsqlConnection(connstring);
                        connection.Open();

                        NpgsqlCommand command = new NpgsqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.button1_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nothing picked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
                }
                
            }
        }



        private void button2_Click_1(object sender, EventArgs e) // shows form2 from button
        {
            if (comboBoxTable.SelectedItem != null)
            {
                Form2 changeParent = new Form2(comboBoxTable.SelectedItem.ToString());
                changeParent.Show();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboShow(string table_name) // fills combobox
        {
            string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
            string query = string.Format("select f_val from {0}", table_name);
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();

            switch (table_name)
            {
                case "street":
                { 
                    while (dataReader.Read())
                    {
                        comboBoxFilterStreet.Items.Add(dataReader.GetString(0));
                    }
                    break;
                }
                case "name":
                    {
                        while (dataReader.Read())
                        {
                            comboBoxFilterName.Items.Add(dataReader.GetString(0));
                        }
                        break;
                    }
                case "surname":
                    {
                        while (dataReader.Read())
                        {
                            comboBoxFilterSurname.Items.Add(dataReader.GetString(0));
                        }
                        break;
                    }
                case "patronymic":
                    {
                        while (dataReader.Read())
                        {
                            comboBoxFilterPatr.Items.Add(dataReader.GetString(0));
                        }
                        break;
                    }

            }
            connection.Close();
        }

        private void comboShow(string table_name, string refresh) // refrshes cobmobox
        {
            string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
            string last_element = string.Format("select max(f_id) from {0}", table_name);
            string query = string.Format("select f_val from {0} where f_id = ({1})", table_name, last_element);
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();

            switch (table_name)
            {
                case "street":
                    {
                        while (dataReader.Read())
                        {
                            comboBoxFilterStreet.Items.Add(dataReader.GetString(0));
                        }
                        break;
                    }
                case "name":
                    {
                        while (dataReader.Read())
                        {
                            comboBoxFilterName.Items.Add(dataReader.GetString(0));
                        }
                        break;
                    }
                case "surname":
                    {
                        while (dataReader.Read())
                        {
                            comboBoxFilterSurname.Items.Add(dataReader.GetString(0));
                        }
                        break;
                    }
                case "patronymic":
                    {
                        while (dataReader.Read())
                        {
                            comboBoxFilterPatr.Items.Add(dataReader.GetString(0));
                        }
                        break;
                    }

            }
            connection.Close();
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)   // filter by params
        {
            dt.Clear();
            string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
            string query = " select u_id, name.f_val, surname.f_val, patronymic.f_val ,street.f_val, telephone from main " +
                           " inner join surname on main.surname = surname.f_id " +
                           " inner join name on main.name = name.f_id " +
                           " inner join street on main.street = street.f_id " +
                           " inner join patronymic on main.patronymic = patronymic.f_id" +
                           " where 1 = 1 ";
            if (comboBoxFilterSurname.SelectedItem != null)
            {
                query += string.Format("AND surname.f_val = '{0}'", comboBoxFilterSurname.SelectedItem.ToString());
            }
            else


            if (comboBoxFilterName.SelectedItem != null)
            {
                query += string.Format("AND name.f_val = '{0}'", comboBoxFilterName.SelectedItem.ToString());
            }

            if (comboBoxFilterStreet.SelectedItem != null)
            {
                query += string.Format("AND street.f_val = '{0}'", comboBoxFilterStreet.SelectedItem.ToString());
            }

            if (comboBoxFilterPatr.SelectedItem != null)
            {
                query += string.Format("AND patronymic.f_val = '{0}'", comboBoxFilterPatr.SelectedItem.ToString());
            }

            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();

            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

            dt.Load(npgSqlDataReader);
            dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)  // update data in main table
        {
            try
            { 
                if (dataGridView1.CurrentCell.ColumnIndex == 0)
                {
                    MessageBox.Show("You can't change an id", "Error");
                }
                else
                { 
                    int x = dataGridView1.CurrentCell.RowIndex;
                    string id = (dataGridView1[0, x].Value.ToString());
                    string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                    string query = "";
                    string table_name = "";

                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {
                         table_name = "name";
                    }

                    if (dataGridView1.CurrentCell.ColumnIndex == 2)
                    {
                         table_name = "surname";
                    }

                    if (dataGridView1.CurrentCell.ColumnIndex == 3)
                    {
                         table_name = "patronymic";
                    }

                    if (dataGridView1.CurrentCell.ColumnIndex == 4)
                    {
                         table_name = "street";
                    }

                    if (dataGridView1.CurrentCell.ColumnIndex == 5)
                    {
                        table_name = "main";
                    }

                    this.fillList(table_name);

                    string index = "";

                    for (int i = 0; i < ColumnVals.Count(); i++)
                    {
                        if (dataGridView1.CurrentCell.Value.ToString().Replace(" ", "") == ColumnVals[i])
                        {
                            index = ColumnIndex[i];
                            break;
                        }
                    }

                    NpgsqlConnection connection = new NpgsqlConnection(connstring);
                    connection.Open();
                    if (table_name != "main")
                    {
                        if (index != "")
                        {
                            query = string.Format("update main set {0} = {1} where u_id = {2} ",
                            table_name, index, id);
                            MessageBox.Show("Succesfull update");
                        }
                        else
                        {
                            query = string.Format("insert into {0} (f_val) values ('{1}'); " +
                                                  "update main set {0} = ({2})  where u_id = {3} ",
                                                  table_name, dataGridView1.CurrentCell.Value.ToString().Replace(" ", ""), "select max(f_id) from " + table_name ,id);

                            MessageBox.Show("User added");
                        }

                    }

                    else
                    {
                        query = string.Format("update main set {0} = '{1}' where u_id = {2} ",
                        "telephone", dataGridView1.CurrentCell.Value.ToString(), id);
                        MessageBox.Show("Telephone updated");
                    }

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing pickedddd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillList(string table_name)    // fills id and val of table name in lists
        {
            string qVal = "";
            string qIndex = "";
            string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
            if (table_name == "main")
            {
                qVal = "select telephone from " + table_name;
                qIndex = "select u_id from " + table_name;
            }
            else
            {
                qVal = "select f_val from " + table_name;
                qIndex = "select f_id from " + table_name;
            }
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(qVal, connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ColumnVals.Add(dataReader.GetString(0));
            }
            connection.Close();
            for (int i = 0; i < ColumnVals.Count; i++)
            {
                ColumnVals[i] = ColumnVals[i].Replace(" ", "");
            }

            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(qIndex, connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ColumnIndex.Add(dr.GetString(0));
            }
            connection.Close();
            for (int i = 0; i < ColumnIndex.Count; i++)
            {
                ColumnIndex[i] = ColumnIndex[i].Replace(" ", "");

                Console.WriteLine(ColumnIndex[i]);
            }


        }

        private void comboBoxFilterStreet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillPredictInput(string field) // fills predict comboboxes
        {
            string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";

            string query = string.Format("select f_val from {0} ", field);

            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();

            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, connection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

            while (npgSqlDataReader.Read())
            {
                switch(field)
                {
                    case "name":
                        {
                            comboBoxPredictName.Items.Add(npgSqlDataReader.GetString(0));
                            break;
                        }
                    case "surname":
                        {
                            comboBoxPredictSurname.Items.Add(npgSqlDataReader.GetString(0));
                            break;
                        }
                    case "patronymic":
                        {
                            comboBoxPredictPatron.Items.Add(npgSqlDataReader.GetString(0));
                            break;
                        }
                    case "street":
                        {
                            comboBoxPredictStreet.Items.Add(npgSqlDataReader.GetString(0));
                            break;
                        }

                }

            }
            connection.Close();


        }

        private void pasteValues_Click(object sender, EventArgs e)  // pastes predicted values into textboxes
        {
            if (comboBoxPredictSurname.SelectedItem != null)
            {
                lastName.Text = comboBoxPredictSurname.SelectedItem.ToString();
            }

            if (comboBoxPredictName.SelectedItem != null)
            {
                name.Text = comboBoxPredictName.SelectedItem.ToString();
            }

            if (comboBoxPredictPatron.SelectedItem != null)
            {
                patronymic.Text = comboBoxPredictPatron.SelectedItem.ToString();
            }

            if (comboBoxPredictStreet.SelectedItem != null)
            {
                street.Text = comboBoxPredictStreet.SelectedItem.ToString();
            }

        }
    }
}
