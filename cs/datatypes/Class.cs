namespace datatypes
{
    partial class Program
    {
        class Person
        {
            private string _name;
            private int _age;
            private bool _isHappy;

            // read-only
            public string Name => _name;

            // read-write
            public int Age
            {
                get => _age;
                set => _age = value;
            }            

            // read-write
            public bool IsHappy
            {
                get => _isHappy;
                set => _isHappy = value;
            }            

            public Person() {}

            public Person(string name, int age, bool isHappy)
            {
                _name = name; // direct to private field since Name is read-only property
                Age = age;
                IsHappy = isHappy; 
            }

            public override string ToString() => $"Name:{Name}, Age:{Age}, IsHappy:{IsHappy}"; 
        }
    }
}