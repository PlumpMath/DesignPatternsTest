namespace Adapter.Pattern
{
    public class CollectionAdapter : MyCollection
    {
        private MyStack MyStack = new MyStack();

        public override void Add(string str)
        {
            MyStack.Push(str);
        }
    }
}
