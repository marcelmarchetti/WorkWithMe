using System.ComponentModel;

namespace WorkWithMe.Utils.Components;

partial class TaskControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    private System.Windows.Forms.Label lblTaskName;

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
        this.lblTaskName = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // lblTaskName
        // 
        this.lblTaskName.AutoSize = true;
        this.lblTaskName.Cursor = System.Windows.Forms.Cursors.Hand;
        this.lblTaskName.Location = new System.Drawing.Point(5, 5);
        this.lblTaskName.Name = "lblTaskName";
        this.lblTaskName.Size = new System.Drawing.Size(46, 17);
        this.lblTaskName.TabIndex = 0;
        this.lblTaskName.Text = "Tarea 1";
        this.lblTaskName.Click += new System.EventHandler(this.lblTaskName_Click);
        // 
        // TaskControl
        // 
        this.Controls.Add(this.lblTaskName);
        this.Name = "TaskControl";
        this.Size = new System.Drawing.Size(200, 40);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}