using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersContext.model;


// Presentation and Controller Layer
namespace UsersContext
{
    public partial class Form1 : Form
    {
        public void alert(string message, string title)
        {
            if (!String.IsNullOrEmpty(message) && !String.IsNullOrEmpty(title))
            {
                MessageBox.Show(message, title);
            }
        }
        DAO dao;
        //DataStore dsl;
        public Form1()
        {
            InitializeComponent();
            dao = new DAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string name = name_text.Text;
            string password = password_text.Text;
            int id = Int32.Parse(id_text.Text);
            string gender = getGender();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Invalid Form");
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Invalid Form");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid Form");
                return;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Invalid Form");
                return;
            }
            UserData user = new UserData( id, name, username, password, gender);
            dynamic result;
            if (submit_button.Text == "Submit")
            {
                try
                {
                    result = dao.Save(user);
                    resetForm();
                    alert(result, "Success");
                }
                catch (Exception exc)
                {
                    alert(exc.Message, "Error");
                }
            } else {
                try
                {
                    result = dao.Update(user);
                    resetForm();
                    alert(result, "Success");
                }
                catch (Exception exc)
                {
                    alert(exc.Message, "Error");
                }
                
            }
            //if (result)
            //{
                //MessageBox.Show(result, "Info");
                //alert(result, "Info");
            //}
        }
        private void reset_form(object sender, EventArgs e)
        {
            resetForm();
        }
        private void resetForm()
        {
            username_text.Text = null;
            name_text.Text = null;
            password_text.Text = null;
            id_text.Text = null;
            gender_female.Checked = false;
            gender_male.Checked = false;
            gender_other.Checked = false;
            submit_button.Text = "Submit";
            id_text.ReadOnly = false;
        }
        private string getGender()
        {
            if (gender_female.Checked) return "f";
            if (gender_male.Checked) return "m";
            if (gender_other.Checked) return "o";
            return "";
        }
        private void gender_CheckedChanged(object sender, EventArgs e)
        {
            getGender();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void setGender(string gender)
        {
            if (gender == "f") gender_female.Checked = true;
            if (gender == "m") gender_male.Checked = true;
            if (gender == "o") gender_other.Checked = true;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(id_text.Text))
            {
                try
                {
                    UserData result = dao.Load(Int32.Parse(id_text.Text));
                    id_text.Text = result.id.ToString();
                    password_text.Text = result.password;
                    name_text.Text = result.name;
                    username_text.Text = result.username;
                    setGender(result.gender);
                    id_text.ReadOnly = true;
                    submit_button.Text = "Update";
                } catch(Exception eee)
                {
                    alert(eee.Message, "Error");
                }
                //if (typeof(result) == UserData)
                //{

                //}
                //alert(result,"asd");
                
            } else
            {
                //MessageBox.Show
                string msg = "Please enter ID.";
                alert(msg, "Error");
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(id_text.Text))
                {
                    string result = dao.Delete(Int32.Parse(id_text.Text));
                    resetForm();
                    alert(result, "Success");
                }
                else
                {
                    string msg = "Please enter ID.";
                    alert(msg, "Error");
                }
                
            }
            catch(Exception excep)
            {
                alert(excep.Message, "Error");
            }
        }
        private void mainBtnTextToggle()
        {
            if (submit_button.Text == "Submit") { submit_button.Text = "Update"; } else { submit_button.Text = "Submit"; }
        }
    }
}
