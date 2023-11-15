using System.IO;
using System.Linq;
using System.Windows;

namespace CookBook_Final
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        Register register = new Register();
        private const string CredentialsFilePath = "vars.txt";
        private readonly string[] defaultUsernames = { "admin" };
        private readonly string[] defaultPasswords = { "0000" };

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = passwordBox1.Password;

            // Check if the entered username and password match the default credentials
            if (defaultUsernames.Contains(username) && defaultPasswords.Contains(password) &&
                defaultPasswords[defaultUsernames.ToList().IndexOf(username)] == password)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
                return;
            }

            // Check if the entered username and password match the registered credentials
            if (ValidateUserCredentials(username, password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
                return;
            }

            errormessage.Text = "Incorrect Username or Password";
            errormessage.Focus();
        }

        private bool ValidateUserCredentials(string username, string password)
        {
            if (File.Exists(CredentialsFilePath))
            {
                string[] lines = File.ReadAllLines(CredentialsFilePath);

                foreach (string line in lines)
                {
                    string[] components = line.Split(' ');

                    if (components.Length >= 2 && components[0] == username && components[1] == password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            register.Show();
            Close();
        }
    }
}
