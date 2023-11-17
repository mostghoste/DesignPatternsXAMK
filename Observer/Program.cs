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
        Console.WriteLine(String.Format("New data! T: {0}; H: {1}; P: {2}", temperature, humidity, pressure));
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

public class StatisticsDisplay : Observer, DisplayElement
{
    private List<double> temperatureHistory;
    private Subject weatherData;

    public StatisticsDisplay(Subject WeatherData)
    {
        this.weatherData = WeatherData;
        weatherData.registerObserver(this);

        temperatureHistory = new List<double>();
    }
    public void update(double temp, double humidity, double pressure)
    {
        temperatureHistory.Add(temp);
        display();
    }
    public void display()
    {
        double avgTemp = temperatureHistory.Average();
        double maxTemp = temperatureHistory.Max();
        double minTemp = temperatureHistory.Min();
        Console.WriteLine(String.Format("Statistics (Temperature): Average: {0}; Maximum {1}; Minimum: {2};", avgTemp, maxTemp, minTemp));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statistics = new StatisticsDisplay(weatherData);

        weatherData.setMeasurements(80, 65, 30.4);
        Console.WriteLine();
        weatherData.setMeasurements(82, 70, 29.2);
        Console.WriteLine();
        weatherData.setMeasurements(78, 90, 29.2);
        Console.WriteLine();
    }
}