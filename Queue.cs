namespace StackAndQueue{
    public class Queue{

        int data;
        Queue next;
        public Queue(){}

        public Queue(int data){
            this.data=data;
        }

        public void EnQueue(int data){
            this.next=new Queue(data);
        }
        
        public Queue DeQueue(){
            return this.next;
        }

        public void DisplayQueue(){
            Console.Write("\nCurrent Elements in Queue: ");
            Queue q=this;
            while(q!=null){
                Console.Write(q.data);
                q=q.next;
                if(q!=null)
                    Console.Write("<--");
            }
            Console.Write("\n");
        }
    }
}