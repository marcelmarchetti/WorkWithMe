using System.ComponentModel;

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
        this.panelTodo = new System.Windows.Forms.Panel();
        this.panelInProgress = new System.Windows.Forms.Panel();
        this.panelDone = new System.Windows.Forms.Panel();

        // panelTodo
        this.panelTodo.Location = new System.Drawing.Point(10, 10);
        this.panelTodo.Size = new System.Drawing.Size(250, 400);
        this.panelTodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Controls.Add(this.panelTodo);

        Label labelTodo = new Label();
        labelTodo.Text = "Backlog";
        labelTodo.Location = new System.Drawing.Point(10, 10);
        this.panelTodo.Controls.Add(labelTodo);

        // panelInProgress
        this.panelInProgress.Location = new System.Drawing.Point(270, 10);
        this.panelInProgress.Size = new System.Drawing.Size(250, 400);
        this.panelInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Controls.Add(this.panelInProgress);

        Label labelInProgress = new Label();
        labelInProgress.Text = "In Progress";
        labelInProgress.Location = new System.Drawing.Point(10, 10);
        this.panelInProgress.Controls.Add(labelInProgress);

        // panelDone
        this.panelDone.Location = new System.Drawing.Point(530, 10);
        this.panelDone.Size = new System.Drawing.Size(250, 400);
        this.panelDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Controls.Add(this.panelDone);

        Label labelDone = new Label();
        labelDone.Text = "Done";
        labelDone.Location = new System.Drawing.Point(10, 10);
        this.panelDone.Controls.Add(labelDone);

        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Name = "KanbanBoardForm";
        this.Text = "Tablero Kanban";
        }
    
    
    #endregion
}