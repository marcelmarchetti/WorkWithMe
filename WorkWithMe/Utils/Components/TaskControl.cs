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
    
    private Timer clickTimer;
    private bool isDragging = false;

    public TaskControl(string taskName)
    {
        InitializeComponent();
        TaskName = taskName;
        lblTaskName.Text = taskName;
        
        this.MouseDown += TaskControl_MouseDown;
        this.MouseUp += TaskControl_MouseUp;

        clickTimer = new Timer { Interval = 200 };
        clickTimer.Tick += (s, e) =>
        {
            clickTimer.Stop();
            isDragging = true;
            this.DoDragDrop(this, DragDropEffects.Move);
        };
    }

    private void TaskControl_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isDragging = false;
            clickTimer.Start();
        }
    }
    
    private void TaskControl_MouseUp(object sender, MouseEventArgs e)
    {
        clickTimer.Stop();

        if (!isDragging)
        {
            MessageBox.Show($"Descripción de la tarea: {TaskName}", "Detalle de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void lblTaskName_Click(object sender, EventArgs e)
    {
       
        MessageBox.Show($"Detalles de la tarea: {TaskName}\nDescripción: {TaskDescription}", "Detalles de la tarea");
    }
}
