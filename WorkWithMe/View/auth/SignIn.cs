using WorkWithMe.Constants;
using WorkWithMe.Controller;
using WorkWithMe.Utils;
using WorkWithMe.View.home;

namespace WorkWithMe;

public partial class SignIn : Form
{
    public SignIn()
    {
        InitializeComponent();
    }
 
    private void button1_Click(object sender, EventArgs e)
    {
        if (AuthController.CheckCredentials(passwordTextbox,  passwordErrorTextbox, usernameErrorTextBox, usernameTextbox)) return;
        var home = new Home();
        home.Show();
        this.Hide();

    }
}