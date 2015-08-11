public interface Subjects
{
	void RegisterObserver(Observers o);
	void RemoveObserver(Observers o);
	void NotifyObservers();
}