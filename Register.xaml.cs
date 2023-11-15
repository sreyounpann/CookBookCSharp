using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace CookBook_Final
{
    public partial class Register : Window
    {
        private const string CredentialsFilePath = "vars.txt";

        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            textBoxUsername.Text = "";
            passwordBox1.Password = "";
            passwordBoxConfirm.Password = "";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = passwordBox1.Password;
            string passwordConfirm = passwordBoxConfirm.Password;

            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage.Text = "Enter a username.";
                textBoxUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage.Text = "Enter a password.";
                passwordBox1.Focus();
                return;
            }

            if (password != passwordConfirm)
            {
                errorMessage.Text = "Passwords do not match!";
                passwordBoxConfirm.Focus();
                return;
            }

            try
            {
                using (StreamWriter writer = File.AppendText(CredentialsFilePath))
                {
                    writer.WriteLine($"{username} {password}");
                }

                MessageBox.Show("You have registered successfully.");

                Login login = new Login();
                login.Show();

                Close();
            }
            catch (Exception ex)
            {
                errorMessage.Text = $"Error occurred during registration: {ex.Message}";
            }
        }
    }
}
