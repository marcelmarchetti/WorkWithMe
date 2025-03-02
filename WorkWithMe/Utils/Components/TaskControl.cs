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
    

    public TaskControl(string taskName)
    {
        InitializeComponent();
        TaskName = taskName;
        lblTaskName.Text = taskName;
    }
    
    
    private void lblTaskName_Click(object sender, EventArgs e)
    {
       
        MessageBox.Show($"Detalles de la tarea: {TaskName}\nDescripción: {TaskDescription}", "Detalles de la tarea");
    }
    
}
