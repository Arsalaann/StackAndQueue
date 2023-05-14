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
        
        public void DisplayQueue(){
            Queue q=this;
            while(q!=null){
                Console.WriteLine(q.data+"  ");
                q=q.next;
            }
        }
    }
}