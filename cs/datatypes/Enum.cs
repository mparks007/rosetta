namespace datatypes
{
    partial class Program
    {
        enum Height // defaults to int
        {
            // defaults the values, from 0 to n
            VeryShort,
            Short,
            Average,
            Tall,
            VeryTall
        }

        enum HeightAlt : ushort // override type to ushort
        {
            // and force the values
            VeryShort = 1,
            Short = 2,
            Average = 5, 
            Tall = 100,
            VeryTall = 200
        }
    }
}