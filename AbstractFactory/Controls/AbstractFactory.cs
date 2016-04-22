namespace AbstractFactory.Controls
{
    public abstract class AbstractFactory
    {
        public static IRender GetUiObject(int type)
        {
            if (type == 1)
            {
                return TextboxFactory.GetTextControl();
            }
            else
            {
                return ButtonFactory.GetButtonControl();
            }
        }
    }
}
