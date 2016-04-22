namespace AbstractFactory.Controls
{
    public class TextboxFactory : AbstractFactory
    {
        public static IRender GetTextControl()
        {
            return new MyTextbox();
        }
    }
}
