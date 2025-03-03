using System.ComponentModel;
using System.Reflection;
using static WorkWithMe.Controller.ImageController;

namespace WorkWithMe.View.home;

partial class Project
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    private System.Windows.Forms.Panel panelTodo;
    private System.Windows.Forms.Panel panelInProgress;
    private System.Windows.Forms.Panel panelDone;

    private System.Windows.Forms.Panel headerTodo;
    private System.Windows.Forms.Label labelTodo;
    private System.Windows.Forms.PictureBox iconAddTodo;

    private System.Windows.Forms.Panel headerInProgress;
    private System.Windows.Forms.Label labelInProgress;
    private System.Windows.Forms.PictureBox iconAddInProgress;

    private System.Windows.Forms.Panel headerDone;
    private System.Windows.Forms.Label labelDone;
    private System.Windows.Forms.PictureBox iconAddDone;
    
    
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panelTodo = new System.Windows.Forms.Panel();
        headerTodo = new System.Windows.Forms.Panel();
        labelTodo = new System.Windows.Forms.Label();
        iconAddTodo = new System.Windows.Forms.PictureBox();
        panelInProgress = new System.Windows.Forms.Panel();
        headerInProgress = new System.Windows.Forms.Panel();
        labelInProgress = new System.Windows.Forms.Label();
        iconAddInProgress = new System.Windows.Forms.PictureBox();
        panelDone = new System.Windows.Forms.Panel();
        headerDone = new System.Windows.Forms.Panel();
        labelDone = new System.Windows.Forms.Label();
        iconAddDone = new System.Windows.Forms.PictureBox();
        panelTodo.SuspendLayout();
        headerTodo.SuspendLayout();
        panelInProgress.SuspendLayout();
        headerInProgress.SuspendLayout();
        panelDone.SuspendLayout();
        headerDone.SuspendLayout();
        SuspendLayout();
        // 
        // panelTodo
        // 
        panelTodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelTodo.Controls.Add(headerTodo);
        panelTodo.Location = new System.Drawing.Point(10, 10);
        panelTodo.Name = "panelTodo";
        panelTodo.Size = new System.Drawing.Size(250, 400);
        panelTodo.TabIndex = 0;
        // 
        // headerTodo
        // 
        headerTodo.BackColor = System.Drawing.Color.LightGray;
        headerTodo.Controls.Add(labelTodo);
        headerTodo.Controls.Add(iconAddTodo);
        headerTodo.Location = new System.Drawing.Point(0, 0);
        headerTodo.Name = "headerTodo";
        headerTodo.Size = new System.Drawing.Size(250, 30);
        headerTodo.TabIndex = 0;
        // 
        // labelTodo
        // 
        labelTodo.AutoSize = true;
        labelTodo.Location = new System.Drawing.Point(10, 7);
        labelTodo.Name = "labelTodo";
        labelTodo.Size = new System.Drawing.Size(49, 15);
        labelTodo.TabIndex = 0;
        labelTodo.Text = "Backlog";
        
        //
        // iconAddTodo
        //
        
        this.iconAddTodo.Size = new System.Drawing.Size(20, 20);
        this.iconAddTodo.Location = new System.Drawing.Point(210, 5);
        this.iconAddTodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.iconAddTodo.Cursor = System.Windows.Forms.Cursors.Hand;
        this.iconAddTodo.Click += new System.EventHandler(this.IconAddTodo_Click);
        // 
        // panelInProgress
        // 
        panelInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelInProgress.Controls.Add(headerInProgress);
        panelInProgress.Location = new System.Drawing.Point(270, 10);
        panelInProgress.Name = "panelInProgress";
        panelInProgress.Size = new System.Drawing.Size(250, 400);
        panelInProgress.TabIndex = 1;
        // 
        // headerInProgress
        // 
        headerInProgress.BackColor = System.Drawing.Color.LightGray;
        headerInProgress.Controls.Add(labelInProgress);
        headerInProgress.Controls.Add(iconAddInProgress);
        headerInProgress.Location = new System.Drawing.Point(0, 0);
        headerInProgress.Name = "headerInProgress";
        headerInProgress.Size = new System.Drawing.Size(250, 30);
        headerInProgress.TabIndex = 0;
        // 
        // labelInProgress
        // 
        labelInProgress.AutoSize = true;
        labelInProgress.Location = new System.Drawing.Point(10, 7);
        labelInProgress.Name = "labelInProgress";
        labelInProgress.Size = new System.Drawing.Size(65, 15);
        labelInProgress.TabIndex = 0;
        labelInProgress.Text = "In Progress";
        //
        // iconAddInProgress
        //
        this.iconAddInProgress.Size = new System.Drawing.Size(20, 20);
        this.iconAddInProgress.Location = new System.Drawing.Point(210, 5);
        this.iconAddInProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.iconAddInProgress.Cursor = System.Windows.Forms.Cursors.Hand;
        this.iconAddInProgress.Click += new System.EventHandler(this.IconAddInProgress_Click);

        // 
        // panelDone
        // 
        panelDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelDone.Controls.Add(headerDone);
        panelDone.Location = new System.Drawing.Point(530, 10);
        panelDone.Name = "panelDone";
        panelDone.Size = new System.Drawing.Size(250, 400);
        panelDone.TabIndex = 2;
        // 
        // headerDone
        // 
        headerDone.BackColor = System.Drawing.Color.LightGray;
        headerDone.Controls.Add(labelDone);
        headerDone.Controls.Add(iconAddDone);
        headerDone.Location = new System.Drawing.Point(0, 0);
        headerDone.Name = "headerDone";
        headerDone.Size = new System.Drawing.Size(250, 30);
        headerDone.TabIndex = 0;
        // 
        // labelDone
        // 
        labelDone.AutoSize = true;
        labelDone.Location = new System.Drawing.Point(10, 7);
        labelDone.Name = "labelDone";
        labelDone.Size = new System.Drawing.Size(35, 15);
        labelDone.TabIndex = 0;
        labelDone.Text = "Done";
        //
        // iconAddDone
        //
        this.iconAddDone.Size = new System.Drawing.Size(20, 20);
        this.iconAddDone.Location = new System.Drawing.Point(210, 5);
        this.iconAddDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.iconAddDone.Cursor = System.Windows.Forms.Cursors.Hand;
        this.iconAddDone.Click += new System.EventHandler(this.IconAddDone_Click);
        // 
        // Project
        // 
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panelTodo);
        Controls.Add(panelInProgress);
        Controls.Add(panelDone);
        Text = "Tablero Kanban";
        panelTodo.ResumeLayout(false);
        headerTodo.ResumeLayout(false);
        headerTodo.PerformLayout();
        panelInProgress.ResumeLayout(false);
        headerInProgress.ResumeLayout(false);
        headerInProgress.PerformLayout();
        panelDone.ResumeLayout(false);
        headerDone.ResumeLayout(false);
        headerDone.PerformLayout();
        ResumeLayout(false);
    }

    
    
    #endregion
}