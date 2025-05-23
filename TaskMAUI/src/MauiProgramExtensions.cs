using Microsoft.Extensions.Logging;
using TaskMAUI.Entity;
using TaskMAUI.Pray;

namespace TaskMAUI;

public static class MauiProgramExtensions
{
	public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
	{
		Student student = new Student { Name = "Aboudey", ID = 1, Password = "ahh" };
		student.ShowInfo();
		student.PrayerRecordList.Add(new PrayerRecord
		{
			PrayerName = "test",
			PrayerStartegy = new MadeUpPrayerStrategy()
		});
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder;
	}
}
