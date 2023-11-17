public interface Subject
{
    void registerObserver(Observer o);
    void removeObserver(Observer o);
    void notifyObservers();
}

public interface Observer
{
    void update(double temp, double humidity, double pressure);
}

public interface DisplayElement
{
    void display();
}

public class WeatherData : Subject
{
    private List<Observer> observers;
    public double temperature { get; private set;  }
    public double humidity { get; private set; }
    public double pressure { get; private set; }

    public WeatherData()
    {
        observers = new List<Observer>();
    }

    public void registerObserver(Observer o)
    {
        observers.Add(o);
    }

    public void removeObserver(Observer o)
    {
        observers.Remove(o);
    }

    public void notifyObservers()
    {
        foreach (Observer o in observers)
        {
            o.update(temperature, humidity, pressure);
        }
    }

    public void measurementsChanged()
    {
        notifyObservers();
    }

    // Manually update the measurements
    public void setMeasurements(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();
        weatherData.setMeasurements(80, 65, 30.4);
        Console.WriteLine(string.Format("Weather data: temp: {0}; humidity: {1}; pressure: {2};", weatherData.temperature, weatherData.humidity, weatherData.pressure));
        weatherData.setMeasurements(82, 70, 29.2);
        Console.WriteLine(string.Format("Weather data: temp: {0}; humidity: {1}; pressure: {2};", weatherData.temperature, weatherData.humidity, weatherData.pressure));
        weatherData.setMeasurements(78, 90, 29.2);
        Console.WriteLine(string.Format("Weather data: temp: {0}; humidity: {1}; pressure: {2};", weatherData.temperature, weatherData.humidity, weatherData.pressure));
    }
}