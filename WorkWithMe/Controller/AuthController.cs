using WorkWithMe.Utils;

namespace WorkWithMe.Controller;

public class AuthController
{
    static public bool CheckCredentials(TextBox passwordTextbox, TextBox passwordErrorTextbox, TextBox usernameErrorTextbox, TextBox userNameTextbox)
    {
        bool nameError = Validators.CheckUsername(userNameTextbox, usernameErrorTextbox);
        bool passwordError = Validators.CheckPassword(passwordTextbox, passwordErrorTextbox);
        return nameError || passwordError;
    }

}