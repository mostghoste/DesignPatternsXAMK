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

public class CurrentConditionsDisplay : Observer, DisplayElement
{
    private double temperature;
    private double humidity;
    private Subject weatherData;

    public CurrentConditionsDisplay(Subject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void update(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        display();
    }

    public void display()
    {
        Console.WriteLine("Current conditions: " + temperature + " degrees and " + humidity + "% humidity");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);
        weatherData.setMeasurements(80, 65, 30.4);
        weatherData.setMeasurements(82, 70, 29.2);
        weatherData.setMeasurements(78, 90, 29.2);
    }
}