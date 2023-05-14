namespace StackAndQueue{
    class Program{
        public static void Main(string[] args){
            Stack stack = new Stack(70);
            stack=stack.Push(30);
            stack=stack.Push(56);
            stack.DisplayStack();

            Stack topElement = new Stack();
            topElement=stack.Peek();

            stack=stack.Pop();
            stack.DisplayStack();

        }
    }
}