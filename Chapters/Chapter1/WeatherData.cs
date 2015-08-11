using System.Collections.Generic;

public class WeatherData : Subjects
{
	private List<Observers> Observers;
	private float temperature;
	private float humidity;
	private float presure;
	
	public WeatherData()
	{
		this.Observers = new List<Observers>();
	}
	
	public void RegisterObserver(Observers o)
	{
		Observers.Add(o);
	}
	
	public void RemoveObserver(Observers o)
	{	
		int i = Observers.IndexOf(o); 
		if(i >= 0)
		{
			Observers.Remove(o);
		}	
	}
	
	public void NotifyObservers()
	{
		foreach(var observer in this.Observers)
		{
			Observers o = (Observers)observer;
			o.Update(this.temperature, this.humidity, this.presure);
		}
	}
	
	public void MeasurementChanged()
	{
		this.NotifyObservers();
	}
	
	public void SetMeasurements(float temperature, float humidity, float pressure)
	{
		this.temperature = temperature;
		this.humidity = humidity;
		this.presure = pressure;
		this.MeasurementChanged();
	}
}