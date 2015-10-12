using System;

namespace Domain.DoorStates
{
    public abstract class DoorState : DomainObject, IDoorAction
    {
        public Door Door { get; private set; }

        public DoorState(string name, Door arg):base(name){
            Door = arg;
        }

        public virtual void Open()
        {
        }
        public virtual void Close()
        {
        }
        public virtual void Lock()
        {
        }
        public virtual void Unlock()
        {
        }

        protected void ChangeState(DoorState arg){
            Door.CurrentState = arg;
        }
    }

    public class OpenState:DoorState{
        public OpenState(Door arg):base("Open", arg){}

        public override void Open()
        {
            Console.WriteLine("No Change");
        }

        public override void Close()
        {
            ChangeState(new CloseState(Door));
        }

        public override void Lock()
        {
            Console.WriteLine("Not Possible");
        }

        public override void Unlock()
        {
            Console.WriteLine("Not Possible");
        }
    }
    
    public class CloseState:DoorState{
        public CloseState(Door arg):base("Close", arg){}

        public override void Open()
        {
            ChangeState(new OpenState(Door));
        }

        public override void Close()
        {
            Console.WriteLine("No Change");
        }

        public override void Lock()
        {
            ChangeState(new LockState(Door));
        }

        public override void Unlock()
        {
            Console.WriteLine("Not Possible");
        }
    }

    public class LockState : DoorState
    {
        public LockState(Door arg) : base("Lock", arg) { }

        public override void Open()
        {
            Console.WriteLine("Not Possible");
        }

        public override void Close()
        {
            Console.WriteLine("Not Possible");
        }

        public override void Lock()
        {
            Console.WriteLine("Not Possible");
        }

        public override void Unlock()
        {
            ChangeState(new CloseState(Door));
        }
    }
}
