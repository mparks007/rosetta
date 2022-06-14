namespace datatypes
{
    partial class Program
    {
        struct Data
        {
            public string Name;
            public int Age;
            public Height Height;

            public Data(string name, int age, Height height)
            {
                Name = name;
                Age = age;
                Height = height;
            }

            public override string ToString() => $"Name:{Name}, Age:{Age}, Height:{Height}"; 
        }
    }
}