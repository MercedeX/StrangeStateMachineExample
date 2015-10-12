using System;


namespace Domain
{
    public class DomainObject
    {
        public string Name { get; private set; }

        public override string ToString()
        {
            return Name;
        }
        public DomainObject(string name)
        {
            Name = name;
        }
    }
}
