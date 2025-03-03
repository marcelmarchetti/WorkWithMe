using WorkWithMe.Utils.Components;

namespace WorkWithMe.View.home;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
        var topNavBar = new TopNavigationBar();
        topNavBar.Dock = DockStyle.Top;
        this.Controls.Add(topNavBar);
    }
}