using System;
using System.Windows.Forms;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace WorkWithMe.Utils.Components;

public partial class TaskControl : UserControl
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string TaskName { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string TaskDescription { get; set; }

    public TaskControl(string taskName, string taskDesc)
    {
        InitializeComponent();
        TaskName = taskName;
        TaskDescription = taskDesc;
        lblTaskName.Text = taskName;
        
        this.MouseDown += TaskControl_MouseDown;
        
    }
    
    private void TaskControl_MouseDown(object? sender, MouseEventArgs e)
    {
        this.DoDragDrop(this, DragDropEffects.Move);
    }
    
    
    private void lblTaskName_Click(object sender, EventArgs e)
    {
       
        MessageBox.Show($"Detalles de la tarea: {TaskName}\nDescripción: {TaskDescription}", "Detalles de la tarea");
    }
    
}
