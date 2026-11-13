using System;

class Building
{
    private static int lastNumber = 0;

    private int number;
    private double height;
    private int floors;
    private int apartments;
    private int entrances;

    public void SetData(double h, int f, int a, int e)
    {
        lastNumber++;
        number = lastNumber;

        height = h;
        floors = f;
        apartments = a;
        entrances = e;
    }

    public double GetFloorHeight()
    {
        return height / floors;
    }

    public double GetApartmentsInEntrance()
    {
        return (double)apartments / entrances;
    }

    public double GetApartmentsOnFloor()
    {
        return (double)apartments / (floors * entrances);
    }

    public void ShowData()
    {
        Console.WriteLine("Номер здания: " + number);
        Console.WriteLine("Высота здания: " + height);
        Console.WriteLine("Количество этажей: " + floors);
        Console.WriteLine("Количество квартир: " + apartments);
        Console.WriteLine("Количество подъездов: " + entrances);

        Console.WriteLine("Высота этажа: " + GetFloorHeight());
        Console.WriteLine("Квартир в подъезде: " + GetApartmentsInEntrance());
        Console.WriteLine("Квартир на этаже: " + GetApartmentsOnFloor());
    }
}

class Program
{
    static void Main()
    {
        Building building1 = new Building();
        Building building2 = new Building();

        building1.SetData(30, 10, 100, 2);
        building2.SetData(45, 15, 180, 3);

        building1.ShowData();

        Console.WriteLine();

        building2.ShowData();
    }
}
