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
   public class PostGreSQL
   {
       List<string> dataItems = new List<string>();

        public void PostgreSQL()
      {
      }

      public void PostgreSQL_insert_into_table(string name_table, string text) // add into parent table 
      {
            try
            {
                bool exist = false;
                string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                string query = "select f_val from " + name_table;
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                
                while (dataReader.Read())
                    {
                        dataItems.Add(dataReader.GetString(0));
                    }
                connection.Close();
                for (int i = 0; i < dataItems.Count; i++)
                {
                    if (dataItems[i].Replace(" ", "") == text.Replace(" ", ""))
                    {

                        exist = true;
                    }
                }

                if (exist == false)
                    {
                        query = string.Format("INSERT INTO " + name_table + " (f_val) VALUES ('{0}')", text);
                        NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }   

            }
         catch (Exception msg)
         {
            MessageBox.Show(msg.ToString());
            throw;
         }
      }

      public void PostgreSQL_insert_into_table(string name, string field, string text) // add into main table telephone column
        {
            try
            {
                string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                string query = "INSERT INTO " + name + "(" + field + ")" + " VALUES (@p)";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("p", text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        public void PostgreSQL_insert_main(string name, string surname, string patr, string street) // insert into main table all params
        {
            try
            {
                string qName    =    string.Format("select f_id from name where f_val = '{0}'", name);
                string qSurname =    string.Format("select f_id from surname where f_val = '{0}'", surname);
                string qPatr    =    string.Format("select f_id from patronymic where f_val = '{0}'", patr);
                string qStreet  =    string.Format("select f_id from street where f_val = '{0}'", street);

                string maxindex = "(select max(u_id) from main)";
 
                string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=1415; Database=phonebook;";
                string query = String.Format("UPDATE main SET name = ({0}), surname = ({1}), " +
                                "patronymic = ({2}), street = ({3}) where u_id = ({4})",qName, qSurname, qPatr, qStreet, maxindex);
              
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

    }    
}
