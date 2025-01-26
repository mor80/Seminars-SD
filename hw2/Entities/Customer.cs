namespace hw1;

public class Customer
{
    public string Name { get; set; }
    public Car? Car { get; set; }
    
    public int LegStrength { get; set; }

    public int HandStrength { get; set; }


    public Customer(string name, int legStrength, int handStrength)
    {
        Name = name;
        LegStrength = legStrength;
        LegStrength = handStrength;
    }

    public override string ToString()
    {
        if (Car is null)
            return $"Имя: {Name}, Сила ног: {LegStrength}, Сила рук: {LegStrength}, Автомобиль: Нет";

        return $"Имя: {Name}, Сила ног: {LegStrength}, Сила рук: {LegStrength},\n" +
               $"Автомобиль: {{ {Car} }}";
    }
}