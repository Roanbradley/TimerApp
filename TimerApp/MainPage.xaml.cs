namespace TimerApp;

public partial class MainPage : ContentPage
{
	int count = 60;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnTimerClicked(object? sender, EventArgs e)
	{

		while(count > 0)
		{
			TimerBtn.Text = $"{count} left";
			--count;
			await Task.Delay(1000);
		}
		
	}
}
