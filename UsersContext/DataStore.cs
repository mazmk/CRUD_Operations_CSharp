using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using UsersContext.model;

// Data Store Layer
namespace UsersContext
{
    class DataStore
    {
        bool result = false;
        MySqlConnection connection = new MySqlConnection("server=localhost; uid=root; database=testcsharp");
        public dynamic Save(UserData user)
        {
            try
            {
                string cmd_text = $"INSERT into users(id, username, name, password, gender) values('{user.id}','{user.username}','{user.name}','{user.password}','{user.gender}')";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = cmd_text;
                command.Connection = connection;
                connection.Open();

                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    result = true;
                }

                connection.Close();
            }
            catch(Exception err)
            {
                result = false;
                return err.Message;
            }
            finally
            {
                connection.Close();
            }
            return "Saved Successfully!";
            //return result;
        }
        public dynamic Load(int id)
        {
            try
            {
                string cmd_text = $"SELECT * FROM users WHERE id={id}";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = cmd_text;
                command.Connection = connection;
                connection.Open();
                DbDataReader reader = command.ExecuteReader();
                UserData ud;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ud = new UserData((int)reader.GetValue(0), reader.GetValue(3).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(4).ToString());
                        return ud;
                        System.Windows.Forms.MessageBox.Show(reader.GetValue(0) + " - " + reader.GetValue(1) + " - " + reader.GetValue(2) + " - " + reader.GetValue(3) + " - " + reader.GetValue(4));
                    }
                }
                else
                {
                    //return "Empty";
                    throw new Exception($"Data not Found for id: {id}");
                    //System.Windows.Forms.MessageBox.Show("embty hehe", "rrrr");
                }
            }
            catch(Exception e)
            {
                //return e.Message;
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return "";
        }
        public dynamic Update(UserData user)
        {
            try
            {
                string cmd_text = $"UPDATE users SET id={user.id}, gender='{user.gender}', username='{user.username}', password='{user.password}', name='{user.name}' WHERE id={user.id}";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = cmd_text;
                command.Connection = connection;
                connection.Open();

                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    result = true;
                    return "Updated Successfully!";
                }
                connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public dynamic Delete(int id)
        {
            try
            {
                string cmd_text = $"DELETE FROM users WHERE id={id}";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = cmd_text;
                command.Connection = connection;
                connection.Open();

                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    result = true;
                    return "Deleted Successfully!";
                }
                connection.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                connection.Close();
            }
            return "";
            //return result;
        }
    }
}
