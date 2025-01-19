namespace hw1;

public class Car
{
    public int Number { get; set; }

    public Engine Engine { get; }

    public Car(int number)
    {
        Random rnd = new Random();
        Engine = new Engine(rnd.Next(1, 10));
        Number = number;
    }

    public override string ToString()
    {
        return $"Номер: {Number}, Размер педалей: {Engine.Size}";
    }
}