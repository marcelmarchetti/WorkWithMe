using WorkWithMe.Constants;
using WorkWithMe.Controller;
using WorkWithMe.Utils;

namespace WorkWithMe;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
 
    private void button1_Click(object sender, EventArgs e)
    {
        if (AuthController.CheckCredentials(passwordTextbox,  passwordErrorTextbox, usernameErrorTextBox, usernameTextbox)) return;
        
        //TODO Navigation to next screen
        throw new System.NotImplementedException();
        
    }
}