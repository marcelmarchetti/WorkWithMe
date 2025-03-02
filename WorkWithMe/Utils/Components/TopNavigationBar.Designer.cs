using System.ComponentModel;
using WorkWithMe.Constants;

namespace WorkWithMe.Utils.Components;

partial class TopNavigationBar
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    
    private Button btnHome;
    private Button btnProjects;
    private Button btnAbout;
    private Button btnContact;
    
    private ContextMenuStrip projectsDropdown;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(10, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 30);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);

            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(120, 10);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(100, 30);
            this.btnProjects.TabIndex = 1;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);

            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(230, 10);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 30);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);

            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(340, 10);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(100, 30);
            this.btnContact.TabIndex = 3;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);

            // 
            // TopNavBar
            // 
            this.BackColor = AppColors.TopNavigationBar;
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnContact);
            this.Name = "TopNavBar";
            this.Size = new System.Drawing.Size(500, Values.topNavBarHeight);
            this.ResumeLayout(false);
        }

    #endregion
}