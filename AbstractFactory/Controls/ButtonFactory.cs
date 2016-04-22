namespace AbstractFactory.Controls
{
    public class ButtonFactory : AbstractFactory
    {
        public static IRender GetButtonControl()
        {
            return new MyButton();
        }
    }
}
