using WorkWithMe.Utils.Components;

namespace WorkWithMe.View.home;

public partial class Project : Form
{
    public Project()
    {
        InitializeComponent();
        var topNavBar = new TopNavigationBar();
        topNavBar.Dock = DockStyle.Top;
        this.Controls.Add(topNavBar);
    }
}