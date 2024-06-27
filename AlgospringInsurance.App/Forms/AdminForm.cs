using AlgospringInsurance.App.Dtos;
using AlgospringInsurance.Infrastructure;
using MySql.Data.MySqlClient;
using System.Data;

namespace AlgospringInsurance.App.Forms
{
    public partial class AdminForm : Form
    {
        private readonly IConnectionProvider _connectionProvider;

        public AdminForm(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
            InitializeComponent();
            LoadUserNameItems();
        }

        private void LoadUserNameItems()
        {
            var con = new MySqlConnection();
            AdminForm_Search_ComboBox.Items.Clear();

            try
            {
                using (con = new MySqlConnection(_connectionProvider.GetConnectionString()))
                {
                    con.Open();
                    var command = con.CreateCommand();
                    command.CommandText = "select Id, Name, Email from user where email != @email";
                    command.Parameters.AddWithValue("@email", LoginFormDataParser.Email);
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            AddNewUserSearchComboBoxItem(
                                Convert.ToInt32(reader["Id"].ToString()), reader["Name"].ToString()!, reader["Email"].ToString()!);
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void AdminForm_Search_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = new MySqlConnection();
            var selectedItem = AdminForm_Search_ComboBox.SelectedItem as DropDownItem;
            var query = "select Name, Email, Username, IsAdmin from user where Id = @id";

            try
            {
                using (con = new MySqlConnection(_connectionProvider.GetConnectionString()))
                {
                    con.Open();
                    var command = con.CreateCommand();
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@id", selectedItem!.Id);
                    var reader = command.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        AdminForm_Email_TextBox.Text = reader["Email"].ToString();
                        AdminForm_Name_TextBox.Text = reader["Name"].ToString();
                        AdminForm_Username_TextBox.Text = reader["Username"].ToString();
                        AdminForm_IsAdmin_CheckBox.Checked = reader["IsAdmin"].ToString() is "1" ? true : false;
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void UseRegistrationForm_Register_Button_Click(object sender, EventArgs e)
        {
            var con = new MySqlConnection();
            var query = @$"insert into user (`Name`, `Username`, `Password`, `Email`, `IsAdmin`)" +
                    "values (@name, @username, @password, @email, @isAdmin)";

            try
            {
                using (con = new MySqlConnection(_connectionProvider.GetConnectionString()))
                {
                    var name = AdminForm_Name_TextBox.Text.Trim().ToString();
                    var email = AdminForm_Email_TextBox.Text.Trim().ToString();
                    var username = AdminForm_Username_TextBox.Text.Trim().ToString();

                    con.Open();
                    var command = con.CreateCommand();
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", SecurityProvider.Encrypt(AdminForm_Password_TextBox.Text.ToString()));
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@isAdmin", AdminForm_IsAdmin_CheckBox.Checked);
                    var reader = command.ExecuteReader();

                    MessageBox.Show("Record Added Succesfully", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUserForm();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void UseRegistrationForm_Update_Button_Click(object sender, EventArgs e)
        {
            var con = new MySqlConnection();
            var userContext = GetUserContext();
            var query = @"update user set `Name` = @name, `Username` = @username, `Password` = @password, `Email` = @email, `IsAdmin` = @isAdmin where email = @email";

            try
            {            
                if (userContext.isValid)
                {
                    using (con = new MySqlConnection(_connectionProvider.GetConnectionString()))
                    {
                        var name = AdminForm_Name_TextBox.Text.Trim().ToString();
                        var email = AdminForm_Email_TextBox.Text.Trim().ToString();
                        var username = AdminForm_Username_TextBox.Text.Trim().ToString();
                        var rawPassword = AdminForm_Password_TextBox.Text.ToString();
                        var hashPassword = string.IsNullOrWhiteSpace(rawPassword) ? userContext.passwordHash : SecurityProvider.Encrypt(rawPassword);

                        con.Open();
                        var command = con.CreateCommand();
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashPassword);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@isAdmin", AdminForm_IsAdmin_CheckBox.Checked);
                        var reader = command.ExecuteReader();

                        MessageBox.Show("Record Updated Succesfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetUserForm();
                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid record", "Update User",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void UseRegistrationForm_Delete_Button_Click(object sender, EventArgs e)
        {
            var con = new MySqlConnection();
            var userContext = GetUserContext();
            var query = @"delete from user where Id = @id";

            try
            {
                if (userContext.isValid)
                {
                    var deleteDialog = MessageBox.Show(
                            "Are you sure, Do you really want to Delete this Record...?",
                            "Delete",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (deleteDialog == DialogResult.Yes)
                    {
                        using (con = new MySqlConnection(_connectionProvider.GetConnectionString()))
                        {
                            con.Open();
                            var command = con.CreateCommand();
                            command.CommandText = query;
                            command.Parameters.AddWithValue("@id", userContext.Id);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Record Deleted Succesfully", "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetUserForm();
                        }
                    }         
                }
                else
                {
                    MessageBox.Show("Invalid record", "Delete User",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void ResetUserForm()
        {

            LoadUserNameItems();
            AdminForm_Name_TextBox.ResetText();
            AdminForm_Email_TextBox.ResetText();
            AdminForm_Password_TextBox.ResetText();
            AdminForm_Username_TextBox.ResetText();
            AdminForm_IsAdmin_CheckBox.Checked = false;
        }

        private (bool isValid, string? Id, string? passwordHash) GetUserContext()
        {
            var con = new MySqlConnection();
            var email = AdminForm_Email_TextBox.Text.Trim().ToString();

            try
            {
                var query = @"select Id, Password from user where email = @email";

                using (con = new MySqlConnection(_connectionProvider.GetConnectionString()))
                {
                    con.Open();
                    var command = con.CreateCommand();
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@email", email);

                    using (var reader = command.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                            return (true, reader["Id"].ToString(), reader["Password"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return (false, null, null);
        }

        private void AddNewUserSearchComboBoxItem(int id, string name, string email) =>
            AdminForm_Search_ComboBox.Items.Add(new DropDownItem
            {
                Id = id,
                Text = $"{name} - {email}"
            });

        private void UseRegistrationForm_Clear_Button_Click(object sender, EventArgs e) => ResetUserForm();
    }
}
