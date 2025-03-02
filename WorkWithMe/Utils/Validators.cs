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
            passwordErrorTextbox.Text = "Password cannot be empty";
            passwordErrorTextbox.ForeColor = AppColors.Error;
            return true;
        }

        if (passwordTextbox.Text.Length < 8)
        {
            passwordErrorTextbox.Text = "Password must be at least 8 characters";
            passwordErrorTextbox.ForeColor = AppColors.Error;
            return true;
        }
        passwordErrorTextbox.ForeColor = AppColors.Background;
        return false;
    }
}