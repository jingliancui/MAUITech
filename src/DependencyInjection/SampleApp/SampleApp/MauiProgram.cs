using SampleApp.Services;

namespace SampleApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddTransient(typeof(ISampleData), typeof(SampleData));

		builder.Services.AddTransient(typeof(IDealMsg), (serviceProvider) =>
		{
			return new DealMsg("一些文字");
		});

		return builder.Build();
	}
}
