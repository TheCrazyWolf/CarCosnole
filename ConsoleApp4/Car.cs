using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car
    {

        public string Model; // Модель
        public int YearBuild; //Год выпуска
        public const float MaxSpeed = 320; // Макс. скорость
        public int Run; //Пробег

        public bool StartEngine; // Статус двигателя

        public Vector3 Position;

        public Car()
        {
            Position = new Vector3();
            Model = "Неизвестно";
            YearBuild = 0000;
            Run = 0;
            StartEngine = false;
        }

        public Car(string model, Vector3 pos)
        {
            Position = pos;
            Model = model;
            YearBuild = DateTime.Today.Year;
            Run = 0;
            StartEngine = false;
        }

        public void Start()
        {
            Console.WriteLine($"Машина {Model} включилась");
            StartEngine = true;
        }

        public void Off()
        {
            Console.WriteLine($"Машина {Model} выключилась");
            StartEngine = false;
        }

        public void Move(Vector3 vector)
        { 
            if (!StartEngine)  // (StartEngine != true) or (StartEngine == false)
                return;

            Position.X += vector.X;
            Position.Y += vector.Y;
            Position.Z += vector.Z;
            Run++;

            Console.WriteLine($"Машина {Model} передвинулась на Позиция = X: {Position.X} Y: {Position.Y} Z: {Position.Z}");
        }

        public string GetInfo() => $"Тачка {Model}. {YearBuild} года выпуска. Двигатель {StartEngine}. Позиция = X: {Position.X} Y: {Position.Y} Z: {Position.Z}. Пробег {Run}";
    }
}
