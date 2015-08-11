using System;

public class ForecastDisplay : Observers, DisplayElement
{
	private float temperature;
	private float humidity;
	private Subjects weatherData;
	
	public ForecastDisplay(Subjects weatherData)
	{
		this.weatherData = weatherData;
		weatherData.RegisterObserver(this);
	}
	
	public void Update(float temperatue, float humidity, float pressure)
	{
		this.temperature = temperatue;
		this.humidity = humidity;
		this.Display();
	}
	
	public void Display()
	{
		Console.WriteLine("Current forecast: " + this.temperature + " F degrees and " + humidity + " % humidity");
	}
}