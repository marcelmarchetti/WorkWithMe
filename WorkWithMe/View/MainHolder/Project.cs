using WorkWithMe.Constants;
using WorkWithMe.Utils.Components;
using static WorkWithMe.Controller.ImageController;

namespace WorkWithMe.View.home;

public partial class Project : Form
{
    public Project()
    {
        InitializeComponent();
        var topNavBar = new TopNavigationBar();
        topNavBar.Dock = DockStyle.Top;
        this.Controls.Add(topNavBar);
        InitializeKanbanBoard();
        
        iconAddTodo.Image = LoadEmbeddedImage("WorkWithMe.Resources.Icons.material_add.png");
        iconAddInProgress.Image = LoadEmbeddedImage("WorkWithMe.Resources.Icons.material_add.png");
        iconAddDone.Image = LoadEmbeddedImage("WorkWithMe.Resources.Icons.material_add.png");
    }
    
     private void InitializeKanbanBoard()
    {
        int topNavigationBarHeight = Values.topNavBarHeight;
        
        panelTodo.Location = new Point(panelTodo.Location.X, topNavigationBarHeight + 10);
        panelInProgress.Location = new Point(panelInProgress.Location.X, topNavigationBarHeight + 10);
        panelDone.Location = new Point(panelDone.Location.X, topNavigationBarHeight + 10);
        
        panelTodo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        panelInProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom; // se ajusta en el centro
        panelDone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        
        panelTodo.AutoScroll = true;
        panelInProgress.AutoScroll = true;
        panelDone.AutoScroll = true;
        
        panelTodo.AllowDrop = true;
        panelInProgress.AllowDrop = true;
        panelDone.AllowDrop = true;

        panelTodo.DragEnter += Panel_DragEnter;
        panelInProgress.DragEnter += Panel_DragEnter;
        panelDone.DragEnter += Panel_DragEnter;

        panelTodo.DragDrop += Panel_DragDrop;
        panelInProgress.DragDrop += Panel_DragDrop;
        panelDone.DragDrop += Panel_DragDrop;

        //TODO: Load from API
        AddTaskToPanel(panelTodo, "Task 1", "");
        AddTaskToPanel(panelTodo, "Task 2", "");
        AddTaskToPanel(panelInProgress, "Task 3", "");
        AddTaskToPanel(panelDone, "Task 4", "");
    }
     
    
    private void ShowAddTaskDialog(Panel targetPanel)
    {
        // Crear un formulario simple para ingresar datos
        Form dialog = new Form();
        dialog.Text = "Nueva Tarea";
        dialog.Size = new Size(350, 200);
        dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
        dialog.StartPosition = FormStartPosition.CenterParent;
        dialog.MaximizeBox = false;
        dialog.MinimizeBox = false;

        Label lblName = new Label() { Text = "Nombre:", Location = new Point(10, 20), AutoSize = true };
        TextBox txtName = new TextBox() { Location = new Point(100, 20), Width = 180 };

        Label lblDesc = new Label() { Text = "Descripción:", Location = new Point(10, 60), AutoSize = true };
        TextBox txtDesc = new TextBox() { Location = new Point(100, 60), Width = 180, Height = 60, Multiline = true };

        Button btnOk = new Button() { Text = "OK", Location = new Point(80, 130), DialogResult = DialogResult.OK };
        Button btnCancel = new Button() { Text = "Cancelar", Location = new Point(170, 130), DialogResult = DialogResult.Cancel };

        dialog.Controls.Add(lblName);
        dialog.Controls.Add(txtName);
        dialog.Controls.Add(lblDesc);
        dialog.Controls.Add(txtDesc);
        dialog.Controls.Add(btnOk);
        dialog.Controls.Add(btnCancel);

        dialog.AcceptButton = btnOk;
        dialog.CancelButton = btnCancel;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            string taskName = txtName.Text.Trim();
            string taskDesc = txtDesc.Text.Trim();
            if (!string.IsNullOrEmpty(taskName))
            {
                // Crear y agregar la nueva tarea al panel (sin olvidar reorganizar)
                AddTaskToPanel(targetPanel, taskName, taskDesc);
            }
        }
    }


     
    private void AddTaskToPanel(Panel panel, string taskName, string taskDesc)
    {
        TaskControl taskControl = new TaskControl(taskName, taskDesc)
        {
            Location = new Point(10, panel.Controls.Count * 45 + 10)
        };
        panel.Controls.Add(taskControl);
        OrganizeTasksInPanel(panel, false);
    }

   
    private void Panel_DragEnter(object? sender, DragEventArgs e)
    {
        if (e.Data != null && e.Data.GetDataPresent(typeof(TaskControl)))
            e.Effect = DragDropEffects.Move;
        else
            e.Effect = DragDropEffects.None;
    }

    
    private void Panel_DragDrop(object? sender, DragEventArgs e)
    {
        if (e.Data != null && e.Data.GetDataPresent(typeof(TaskControl)))
        {
            TaskControl task = (TaskControl)e.Data.GetData(typeof(TaskControl))!;
            Panel? sourcePanel = task.Parent as Panel;
            Panel? targetPanel = sender as Panel;
            
            if (targetPanel != null)
            {
                targetPanel.Controls.Add(task);
                OrganizeTasksInPanel(targetPanel, true);
            }
            
            if (sourcePanel != null && sourcePanel != targetPanel)
            {
                OrganizeTasksInPanel(sourcePanel, false);
            }
        
        }
    }
    private void OrganizeTasksInPanel(Panel panel, bool isToNewColumn)
    {
        int spacing = 10;
        int headerHeight = 30;
        int yOffset = headerHeight + spacing;

        var tasks= panel.Controls
            .OfType<TaskControl>()
            .ToList();
        
        var tasksSorted = panel.Controls
            .OfType<TaskControl>()
            .OrderBy(task => task.Location.Y)
            .ToList();

        //If we are moving a task to a new column (not only sorting the origin panel)
        //we do this little hack to avoid the previous Y value to interfere in the
        //task positioning
        if (isToNewColumn)
        {
            tasksSorted.Remove(tasks.Last());
            tasksSorted.Add(tasks.Last());
        }
        
        foreach (TaskControl task in tasksSorted)
        {
            task.Location = new Point(spacing, yOffset);
            task.BringToFront();
            yOffset += task.Height + spacing;
        }
    }

    private void IconAddTodo_Click(object sender, EventArgs e)
    {
        ShowAddTaskDialog(panelTodo);
    }

    private void IconAddInProgress_Click(object sender, EventArgs e)
    {
        ShowAddTaskDialog(panelInProgress);
    }

    private void IconAddDone_Click(object sender, EventArgs e)
    {
        ShowAddTaskDialog(panelDone);
    }
}