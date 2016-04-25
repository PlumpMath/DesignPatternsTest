using System.Windows.Forms;

namespace Mediator.Mediator
{
    public class MyMediator
    {
        private TextBox TextBox;
        private ListBox ListBox;
        private Button AddButton;
        private Button ClearButton;

        public void Register(TextBox obj)
        {
            TextBox = obj;
        }

        public void Register(ListBox obj)
        {
            ListBox = obj;
        }

        public void Register(Button obj)
        {
            if (obj.Name == "btnAdd")
            {
                AddButton = obj;
            }
            else
            {
                ClearButton = obj;
            }
            obj.Enabled = false;
        }

        public void TextChanged()
        {
            if (TextBox.Text.Length > 0)
            {
                ClearButton.Enabled = true;
                AddButton.Enabled = true;
            }
            else
            {
                ClearButton.Enabled = false;
                AddButton.Enabled = false;
            }
        }

        public void Add()
        {
            ListBox.Items.Add(TextBox.Text);
            ClearButton.Enabled = false;
            AddButton.Enabled = false;
            TextBox.Text = string.Empty;
        }

        public void Clear()
        {
            ClearButton.Enabled = false;
            AddButton.Enabled = false;
            TextBox.Text = string.Empty;
        }
    }
}
