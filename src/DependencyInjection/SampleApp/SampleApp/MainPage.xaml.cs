using SampleApp.Services;

namespace SampleApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	private readonly ISampleData sampleData;

	public MainPage()
	{
		InitializeComponent();

		sampleData = MauiApplication.Current.Services.GetService(typeof(ISampleData)) as ISampleData;
		
		var result = sampleData.RetrieveData();

		var msgService = MauiApplication.Current.Services.GetService(typeof(IDealMsg)) as IDealMsg;
		var intResult = msgService.Deal();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

