using System;
using System.Drawing;

namespace ModelingAutoTraffic
{
    internal class Car
    {
        private string[] CarsIcons = new string[]
        {
            "car1.ico",
            "car2.ico",
            "car3.ico",
            "car4.ico",
            "car5.ico",
        };

        private string[] ReverseCarsIcons = new string[]
        {
            "reverseCar1.ico",
            "reverseCar2.ico",
            "reverseCar3.ico",
            "reverseCar4.ico",
            "reverseCar5.ico"
        };

        private int _speed;

        public int speed
        {
            get => _speed;
            set
            {
                value = value == 0
                    ? 1
                    : value;

                _speed = value;
            }
        }

        public int size;
        public int start_x;
        public int start_y;
        public int cur_x;
        public int cur_y;
        public int goal_x;

        public bool isGenerate;

        public Icon IconCar;

        public Car()
        {
            this.speed = new Random().Next(30, 60);
            goal_x = 10_000;
        }

        public Car(int size_num, bool isRevers, bool isBig = false)
        {
            this.size = size_num;
            this.speed = new Random().Next(0, 30);
            goal_x = 10000;

            SetIcon(isRevers, isBig);
        }

        public Car(int speed_num, int size_num)
        {
            this.speed = speed_num;
            this.size = size_num;
            goal_x = 10000;
        }

        public void SetIcon(bool isRevers, bool isBig = false)
        {
            if (isRevers)
            {
                var index = new Random().Next(0, ReverseCarsIcons.Length);
                IconCar = new Icon(ReverseCarsIcons[index]);
            }
            else
            {
                var index = new Random().Next(0, CarsIcons.Length);
                IconCar = new Icon(CarsIcons[index]);
            }
        }
    }
}

