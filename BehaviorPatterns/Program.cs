using System;

namespace Strategy
{
    public class Program
    {
        public static void Main()
        {
            Car car = new Car(4, "Volvo", new ElecticCar());
            car.Move();
            car.Moveble = new GasOilCar();
            car.Move();
        }
    }
}