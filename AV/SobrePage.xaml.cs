namespace AV;

public partial class SobrePage : ContentPage
{
	public SobrePage()
	{
		InitializeComponent();
	}

    private void GitHubButton_Clicked(object sender, EventArgs e)
    {
        Launcher.OpenAsync("https://github.com/Dennis12278");
    }
}
