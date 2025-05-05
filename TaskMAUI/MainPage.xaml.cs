namespace TaskMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPrayerDoneClicked(object sender, EventArgs e)
	{
		if (sender is Button btn)
		{
			btn.Text = "✅ صليت";
			btn.IsEnabled = false;
			btn.BackgroundColor = Colors.LightGreen;
		}
	}
}

