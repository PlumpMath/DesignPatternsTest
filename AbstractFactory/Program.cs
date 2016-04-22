using AbstractFactory.Controls;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IRender control;
            Console.WriteLine("Моля, въведете тип на контролата");

            int type = Convert.ToInt32(Console.ReadLine());
            control = Controls.AbstractFactory.GetUiObject(type);
            control.Render();
        }
    }
}
