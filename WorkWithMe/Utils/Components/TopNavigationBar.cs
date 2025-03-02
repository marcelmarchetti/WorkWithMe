using WorkWithMe.View.home;

namespace WorkWithMe.Utils.Components;

public partial class TopNavigationBar : UserControl
{
    public TopNavigationBar()
    {
        InitializeComponent();
        this.projectsDropdown = new ContextMenuStrip();
        this.btnProjects.Click += BtnProjects_Click;
    }
    
    private void BtnProjects_Click(object sender, EventArgs e)
    {
        LoadDropdownItems();
        projectsDropdown.Show(btnProjects, new System.Drawing.Point(0, btnProjects.Height));
        
    }

    
    private void LoadDropdownItems()
    {
        projectsDropdown.Items.Clear();
        List<string> items = new List<string>();

        //TODO Load projects from API
        items.Add("Project 1");
        items.Add("Project 2");
        items.Add("Project 3");
        
        foreach (var item in items)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(item);
            menuItem.Click += (s, e) => MenuItem_Click(s, e, item); 
            projectsDropdown.Items.Add(menuItem);
        }
    }
    
    private void MenuItem_Click(object sender, EventArgs e, string itemName)
    {
        var project = new Project();
        var form = this.FindForm();
        
        project.Show();
        form?.Hide();

    }

    private void btnHome_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Home Page");
    }

    private void btnProjects_Click(object sender, EventArgs e)
    {
        projectsDropdown.Show(btnProjects, new Point(0, btnProjects.Height));
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
        MessageBox.Show("About Page");
    }

    private void btnContact_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Contact Page");
    }
}
