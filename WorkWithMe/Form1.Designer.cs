namespace WorkWithMe;

partial class Form1
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
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        textBox3 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(320, 160);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(136, 23);
        textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(320, 222);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(136, 23);
        textBox2.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(346, 292);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(81, 25);
        button1.TabIndex = 2;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = true;
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
        textBox3.TextChanged += textBox3_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox3);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox3;

    #endregion
}