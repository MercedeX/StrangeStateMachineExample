using System;


namespace Domain
{
    public class Door : DomainObject, IDoorAction
    {
        private Device _device;


        public Door(Device device, string name)
            : base(name)
        {
            _device = device;
            CurrentState = new DoorStates.CloseState(this);
        }



        public Device Device
        {
            get { return _device; }
        }

        public DoorStates.DoorState CurrentState { get; set; }

        public void Close()
        {
            CurrentState.Close();
        }

        public void Open()
        {
            CurrentState.Open();
        }


        public void Lock()
        {
            CurrentState.Lock();
        }

        public void Unlock()
        {
            CurrentState.Unlock();
        }

    }
    public class Device : DomainObject
    {
        public Device(string name) : base(name)
        {
            Door = new Door(this, "The Stupid Door"); 
        }

        public Door Door{get; private set;}
    }
}
