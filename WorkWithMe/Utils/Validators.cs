using WorkWithMe.Constants;

namespace WorkWithMe.Utils;

public class Validators
{
    public static bool CheckUsername(TextBox usernameTextbox, TextBox usernameErrorTextBox)
    {
        if (string.IsNullOrWhiteSpace(usernameTextbox.Text))
        {
            usernameErrorTextBox.ForeColor = AppColors.Error;
            return true;
        }
        usernameErrorTextBox.ForeColor = AppColors.Background;
        return false;
    }
    
    public static bool CheckPassword(TextBox passwordTextbox, TextBox passwordErrorTextbox)
    {
        if (string.IsNullOrWhiteSpace(passwordTextbox.Text))
        {
            passwordErrorTextbox.ForeColor = AppColors.Error;
            return true;
        }
        passwordErrorTextbox.ForeColor = AppColors.Background;
        return false;
    }
}