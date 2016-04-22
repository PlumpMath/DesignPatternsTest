using System;

namespace AbstractFactory.Controls
{
    public class MyButton : IRender
    {
        public void Render()
        {
            Console.WriteLine("Аз съм копче");
        }
    }
}
