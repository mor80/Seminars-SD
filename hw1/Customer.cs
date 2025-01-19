﻿namespace hw1;

public class Customer
{
    public string Name { get; set; }
    public Car? Car { get; set; }

    public Customer(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Имя: {Name}, Номер машины: {Car?.Number ?? -1}";
    }
}