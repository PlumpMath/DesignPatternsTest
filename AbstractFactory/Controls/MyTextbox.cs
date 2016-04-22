using System;

namespace AbstractFactory.Controls
{
    public class MyTextbox : IRender
    {
        public void Render()
        {
            Console.WriteLine("Аз съм текстово поле");
        }
    }
}
