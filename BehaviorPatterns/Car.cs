using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Car
    {
        public int Passengers { get; set; }
        public string Model { get; set; }

        public IMoveble Moveble { get; set; }
        public Car(int passengers, string model, IMoveble moveble)
        {
            Passengers = passengers;

            Model = model;

            Moveble = moveble;
        }
        public void Move()
        {
            Moveble.Move();
        }
    }
}
