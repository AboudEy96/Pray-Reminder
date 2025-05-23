using TaskMAUI.Entity;
using TaskMAUI.Pray;

namespace TaskMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new PrayerStatusView();
	}
	private async void OnPrayersTapped(object sender, EventArgs e)
	{
		await AnimateButton(sender);
		Console.WriteLine("قائمة الصلوات");
	}

	private async void OnHighScoreTapped(object sender, EventArgs e)
	{
		await AnimateButton(sender);
		Console.WriteLine("أعلى النقاط");
	}

	private async void OnMissedPrayersTapped(object sender, EventArgs e)
	{
		await AnimateButton(sender);
		Console.WriteLine("الصلوات الفائتة");
	}

	private async void OnSettingsTapped(object sender, EventArgs e)
	{
		await AnimateButton(sender);
		//await Navigation.PushAsync(new SettingsPage());
		Student student = new Student { Name = "Aboud", ID = 1, Password = "uwma*23sz" };
		student.PrayerRecordList.Add(new PrayerRecord
		{
			PrayerStartegy = new MadeUpPrayerStrategy(),
			PrayerName = "Qada"
		});
	}

	private async Task AnimateButton(object sender)
	{
		if (sender is Frame frame)
		{
			await frame.ScaleTo(0.95, 100);
			await frame.ScaleTo(1, 100);
		}
	}
}

