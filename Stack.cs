using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackAndQueue{
    public class Stack{
        int data;
        Stack next=null;
        public Stack(){}

        public Stack(int data){
            this.data=data;
        }
        public Stack Push(int data){
            Stack stack=this;
            Stack dummy=new Stack(data);
            dummy.next=stack;
            return dummy;
        }

        public Stack Peek(){
            Stack stack=this;
            return stack;
        }

        public Stack Pop(){
            Stack stack=this;
            stack=stack.next;
            return stack;
        }

        public void DisplayStack(){
            Console.WriteLine("From Top to Bottom: ");
            Stack stack=this;
            while(stack!=null){
                Console.WriteLine(stack.data);
                stack=stack.next;
            }
        }
    }
    
}