namespace WorkWithMe;

partial class SignIn
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        usernameTextbox = new System.Windows.Forms.TextBox();
        passwordTextbox = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        textBox3 = new System.Windows.Forms.TextBox();
        usernameErrorTextBox = new System.Windows.Forms.TextBox();
        passwordErrorTextbox = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // usernameTextbox
        // 
        usernameTextbox.Location = new System.Drawing.Point(320, 160);
        usernameTextbox.Name = "usernameTextbox";
        usernameTextbox.Size = new System.Drawing.Size(136, 23);
        usernameTextbox.TabIndex = 0;
        // 
        // passwordTextbox
        // 
        passwordTextbox.Location = new System.Drawing.Point(320, 222);
        passwordTextbox.Name = "passwordTextbox";
        passwordTextbox.PasswordChar = '*';
        passwordTextbox.Size = new System.Drawing.Size(136, 23);
        passwordTextbox.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(346, 292);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(81, 25);
        button1.TabIndex = 2;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox3
        // 
        textBox3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
        textBox3.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox3.Location = new System.Drawing.Point(233, 28);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(342, 44);
        textBox3.TabIndex = 3;
        textBox3.Text = "WorkWithMe";
        textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // usernameErrorTextBox
        // 
        usernameErrorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        usernameErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        usernameErrorTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        usernameErrorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        usernameErrorTextBox.Location = new System.Drawing.Point(322, 189);
        usernameErrorTextBox.Name = "usernameErrorTextBox";
        usernameErrorTextBox.Size = new System.Drawing.Size(136, 13);
        usernameErrorTextBox.TabIndex = 4;
        usernameErrorTextBox.Text = "Username cannot be empty";
        // 
        // passwordErrorTextbox
        // 
        passwordErrorTextbox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        passwordErrorTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        passwordErrorTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        passwordErrorTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        passwordErrorTextbox.Location = new System.Drawing.Point(322, 251);
        passwordErrorTextbox.Name = "passwordErrorTextbox";
        passwordErrorTextbox.Size = new System.Drawing.Size(317, 13);
        passwordErrorTextbox.TabIndex = 5;
        passwordErrorTextbox.Text = "Password cannot be empty";
        // 
        // SignIn
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(passwordErrorTextbox);
        Controls.Add(usernameErrorTextBox);
        Controls.Add(textBox3);
        Controls.Add(button1);
        Controls.Add(passwordTextbox);
        Controls.Add(usernameTextbox);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox passwordErrorTextbox;

    private System.Windows.Forms.TextBox usernameErrorTextBox;

    private System.Windows.Forms.TextBox usernameTextbox;
    private System.Windows.Forms.TextBox passwordTextbox;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox3;

    #endregion
}