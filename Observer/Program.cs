Console.WriteLine("Test");

public interface Subject
{
    void registerObserver(Observer o);
    void removeObserver(Observer o);
    void notifyObservers();
}

public interface Observer
{
    void update(float temp, float humidity, float pressure);
}

public interface DisplayElement
{
    void display();
}

