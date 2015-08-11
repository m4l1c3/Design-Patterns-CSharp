using System;

public class StatisticsDisplay : Observers, DisplayElement
{
	private float temperature;
	private float humidity;
	private Subjects weatherData;
	
	public StatisticsDisplay(Subjects weatherData)
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
		Console.WriteLine("Current statistics are: " + this.temperature + " F degrees and " + humidity + " % humidity");
	}
}