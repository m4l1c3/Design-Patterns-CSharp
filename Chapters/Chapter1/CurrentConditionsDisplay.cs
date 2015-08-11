using System;

public class CurrentConditionsDisplay : Observers, DisplayElement
{
	private float temperature;
	private float humidity;
	private Subjects weatherData;
	
	public CurrentConditionsDisplay(Subjects weatherData)
	{
		this.weatherData = weatherData;
		this.weatherData.RegisterObserver(this);
	}
	
	public void Update(float temperatue, float humidity, float pressure)
	{
		this.temperature = temperatue;
		this.humidity = humidity;
		this.Display();
	}
	
	public void Display()
	{
		Console.WriteLine("Current conditions: " + this.temperature + " F degrees and " + this.humidity + " % humidity");
	}
}