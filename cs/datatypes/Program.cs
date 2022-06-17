using System;
using System.Collections.Generic;

namespace datatypes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Data Types\n");

            //---------------------
            // Built-In Value Types
            //---------------------
            Console.WriteLine("***Built-In Value Types***\n");

            // Signed 8-bit integer
            sbyte sbyte0; // unassigned so can't use
            sbyte sbyte1 = -128;
            SByte sbyte2 = 127;
            Console.WriteLine($"Type(sbyte): sbyte1:{sbyte1}, sbyte2:{sbyte2}");

            // Unsigned 8-bit integer
            byte byte0;
            byte byte1 = 0;
            Byte byte2 = 255;
            Console.WriteLine($"Type(byte): byte1:{byte1}, byte2:{byte2}");

            // Signed 16-bit integer
            short short0; // unassigned so can't use
            short short1 = -32768;
            Int16 short2 = 32767;
            Console.WriteLine($"Type(short): short1:{short1}, short2:{short2}");
            unchecked // to allow overflowing 
            {
                short short3 = (short)(32767 + 1); // overflowing short, will wrap around to min -32768
                Console.WriteLine($"Type(short): short3:{short3}");
            }

            // Unsigned 16-bit integer
            ushort ushort0; // unassigned so can't use
            ushort ushort1 = 0;
            UInt16 ushort2 = 65535;
            Console.WriteLine($"Type(ushort): ushort1:{ushort1}, ushort2:{ushort2}");

            // Signed 32-bit integer
            int int0; // unassigned so can't use
            int int1 = -2147483648;
            Int32 int2 = 2147483647;
            // int int3 = null; // can't set value types (such as int) to null unless use 'nullable' syntax, like "int?" (see next line), which allows a value type to have THREE states: unset/null, zero/default-value, other-value
            int? int4 = null;
            Console.WriteLine($"Type(int): int1:{int1}, int2:{int2}, int4:{int4}");

            // Unsigned 32-bit integer
            uint uint0; // unassigned so can't use
            uint uint1 = 0;
            UInt32 uint2 = 4294967295;
            Console.WriteLine($"Type(uint): uint1:{uint1}, uint2:{uint2}");

            // Signed 64-bit integer
            long long0; // unassigned so can't use
            long long1 = -9223372036854775808;
            Int64 long2 = 9223372036854775807;
            Console.WriteLine($"Type(long): long1:{long1}, long2:{long2}");

            // Unsigned 64-bit integer
            ulong ulong0; // unassigned so can't use
            ulong ulong1 = 0;
            UInt64 ulong2 = 18446744073709551615;
            Console.WriteLine($"Type(ulong): ulong1:{ulong1}, ulong2:{ulong2}");

            // Signed 32-bit or 64-bit integer  (requires .NET 5 / C# 9)
            // nint intptr0; // unassigned so can't use
            // nint intptr1 = 1;
            IntPtr intptr2 = (IntPtr)0x7FFFFFFF;
            Console.WriteLine($"Type(IntPtr): intptr2:{intptr2}");

            // Unsigned 32-bit or 64-bit integer (requires .NET 5 / C# 9)
            // nuint uintptr0; // unassigned so can't use
            // nuint uintptr1 = 1;
            UIntPtr uintptr2 = (UIntPtr)0x7FFFFFFF;
            Console.WriteLine($"Type(UIntPtr): uintptr2:{uintptr2}");

            // U+0000 (aka '\0') to U+FFFF (16 bit)
            char char0; // unassigned so can't use
            char char1 = 'a';
            Char char2 = (char)0x7A;  // 7A is 'z' in ascii table
            Console.WriteLine($"Type(char): char1:{char1}, char2:{char2}");

            // ±1.5 x 10^-45 to ±3.4 x 10^38 (~6-9 digits) [4 bytes]
            float float0; // unassigned so can't use
            float float1 = 1.5f;
            Single float2 = 1.5f;
            Console.WriteLine($"Type(float): float1:{float1}, float2:{float2}");

            // ±5.0 × 10^−324 to ±1.7 × 10^308 (~15-17 digits) [8 bytes]
            double double0; // unassigned so can't use
            double double1 = 1.5;
            Double double2 = 1 + .5;
            Console.WriteLine($"Type(double): double1:{double1}, double2:{double2}");

            // ±1.0 x 10^-28 to ±7.9228 x 10^28 (28-29 digits) [16 bytes]
            decimal decimal0; // unassigned so can't use
            decimal decimal1 = 1.5m;
            Decimal decimal2 = 1.5m;
            Console.WriteLine($"Type(decimal): decimal1:{decimal1}, decimal2:{decimal2}");

            // casting

            int someInt = 50;
            Console.WriteLine($"Casting: somInt:{someInt}");
            float floatFromInt = (float)50;
            Console.WriteLine($"Casting: floatFromInt:{floatFromInt}");
            floatFromInt += (float).5;
            Console.WriteLine($"Casting: floatFromInt:{floatFromInt}");
            int intFromFloat = (int)floatFromInt;
            Console.WriteLine($"Casting: intFromFloat:{intFromFloat}");

            bool bool0; // unassigned so can't use
            bool bool1 = true;
            bool bool2 = !bool1;
            bool bool3 = true || false;
            Console.WriteLine($"Type(bool): bool1:{bool1}, bool2:{bool2}, bool3:{bool3}");

            //-------------------------
            // Built-In Reference Types
            //-------------------------
            Console.WriteLine("\n***Built-In Reference Types***\n");

            string string0; // unassigned so can't use
            string string1 = "Hello";
            String string2 = new string(new char[] { 'G', 'o', 'o', 'd', 'b', 'y', 'e' });
            Console.WriteLine($"Type(string): string1:{string1}, string2:{string2}");
            string string3 = @"Here are ""double-quotes"" in a string";  // if want to have " in the string (notice start with @)...OR can use \" instead of "" and don't need @
            string string4 = "Let's try apostrophe";  // Nothing special
            Console.WriteLine($"Type(string): string3:{string3}, string4:{string4}, type(string4):{string4.GetType()}");

            string strWrap0 = @"This is 
a multi-line string";
            Console.WriteLine($"Type(string): strWrap0:{strWrap0}");

            Console.WriteLine($"Type(string): string1.Length: {string1.Length}");
            Console.WriteLine($"Type(string): string1[0]: {string1[0]}"); // first character
            Console.WriteLine($"Type(string): string1[string1.Length - 1]: {string1[string1.Length - 1]}"); // last character

            // "slicing", via Substring though  :/

            string someText = "SomeText";
            // slicing 2nd character to end
            Console.WriteLine("Slicing: someText[1:] = " + someText.Substring(1));
            // slicing 2nd to 5th character
            Console.WriteLine("Slicing: someText[1:5] = " + someText.Substring(1, 5));
            // slicing uyp to 5th character
            //Console.WriteLine('Slicing: someText[:5] = " + someText.Substring([:5]));
            // slicing 6th to 2nd last character
            Console.WriteLine("Slicing: someText[5:-2] = " + someText.Substring(5, someText.Length - 2));

            object object0; // unassigned so can't use
            object object1 = null;
            object someNewInt = new int();
            Object object3 = null;
            Object person = new Person();
            Console.WriteLine($"Type(object): object1:{object1}, someNewInt:{someNewInt}, object3:{object3}, person:{person}");

            // mostly like Object
            dynamic dynamic0; // unassigned so can't use
            dynamic dynamic1 = null;
            dynamic someData = new Data();
            Console.WriteLine($"Type(dynamic): dynamic1:{dynamic1}, someData:{someData}");

            // uncommon but can allow interesting things
            unsafe // also have to compile in /unsafe mode, which for VS Code, add <AllowUnsafeBlocks>true</AllowUnsafeBlocks> to <PropertyGroup>
            {
                int num = 50;
                void* voidPtr = &num;
                Console.WriteLine($"Type(void): num:{num}, voidPtr:{*(int*)voidPtr}"); // convert void* back to int* then derefence that to get to value
            }

            //--------------
            // Implicit Type
            //--------------
            Console.WriteLine("\n***Implicit Type***\n");

            // var blah; // error: implicitly-typed variables must be initialized, even to compile
            var whole = 10;
            var real = 10.5;
            var text = "Hello";
            var isYepNope = true;
            var kvp = new KeyValuePair<int, string>(10, "Ten");
            Console.WriteLine($"Type(implicit): whole:{whole}, real:{real}, text:{text}, isYepNope:{isYepNope}, kvp:{kvp}");

            //---------------
            // Anonymous Type
            //---------------
            Console.WriteLine("\n***Anonymous Type***\n");

            var somethin = new { ProductName = "Honey Combs", Price = 4.99 };
            Console.WriteLine($"Type(anonymous): ProductName:{somethin.ProductName}, Price:{somethin.Price}");

            //-----------
            // Tuple Type
            //-----------
            Console.WriteLine("\n***Tuple Type***\n");

            (double, int) tuple0; // unassigned fields so can't use
            (double, int) tuple1 = (1.5, 5);
            Console.WriteLine($"Type(tuple): Item1:{tuple1.Item1}, Item2:{tuple1.Item2}.");
            (double Sum, int Count) tuple2 = (4.5, 3);
            Console.WriteLine($"Type(tuple): Sum:{tuple2.Sum}, Count:{tuple2.Count}.");

            //-----------------------------------------------
            // Custom Types (some Value some Reference types)
            //-----------------------------------------------
            Console.WriteLine("\n***Custom Types***\n");

            // enumeration (see Enum.cs)
            Height height0; // unassigned so can't use
            Height height1 = Height.VeryShort;
            Height height2 = height1 + 1; // not sure if common to dec/increment to get to another value (be mindful of overflowing enum size)
            Console.WriteLine($"Type(enum): height1:{height1}, height2:{height2}");

            // struct (see Struct.cs)
            Data struct0; // unassigned so can't use
            Data someData1 = new Data() { Name = "SomeName", Age = 25, Height = Height.Average };
            Data someData2 = new Data("Namey", 100, Height.Short);
            Data someData3 = new Data();
            someData3.Name = "SomeOtherName";
            someData3.Age = 51;
            someData3.Height = Height.VeryTall;
            Console.WriteLine($"Type(struct): someData1:{someData1}, someData2:{someData2}, someData3:{someData3}");

            // class (see Class.cs)
            Person person0; // unassigned so can't use
            Person person1 = new Person();
            Person person2 = new Person("SomeName", 35, true);
            Console.WriteLine($"Type(class): person1:{person1}, person2:{person2}");

            // interface (see Interface.cs)
            IShape square = new Square(22);
            Console.WriteLine($"Type(interface): square:{square}, area:{square.GetArea()}");
            IShape rectangle;
            rectangle = new Rectangle(50, 100);
            Console.WriteLine($"Type(interface): rectangle:{rectangle}, area:{rectangle.GetArea()}");

            // delegate (see Delegate.cs)
            PrintSomeTextCallback printer;
            printer = PrintText;
            printer("SomeText");

            CalcCallback add = Add;
            Console.WriteLine($"Type(delegate): Add:{add(10, 20)}");
            CalcCallback sub = Subtract;
            Console.WriteLine($"Type(delegate): Subtract:{sub(10, 20)}");
            CalcCallback mult = Multiply;
            Console.WriteLine($"Type(delegate): Multiply:{mult(10, 20)}");
            CalcCallback div = Divide;
            Console.WriteLine($"Type(delegate): Divide:{div(10, 20)}");

            DoSomethingCallback hello = Hello;
            DoSomethingCallback sup = Sup;
            DoSomethingCallback goodbye = Goodbye;
            DoSomethingCallback doIt = hello + sup;
            doIt += goodbye;
            Console.WriteLine("Type(delegate:multicast)");
            doIt();

            // record (never used so not sure atm)

            //--------------
            // Generic Types (have to import System.Collections.Generic and System.Collections.Dictionary)
            //--------------
            Console.WriteLine("\n***Generic Types***\n");

            List<int> myInts0; // unassigned fields so can't use
            List<int> myInts1 = new List<int>();
            Console.WriteLine($"Type(generic): myInts1:{string.Join("\t", myInts1)}");

            List<string> myStrings = new List<string>() { "10", "25", "50", "100" };
            Console.WriteLine($"Type(generic): myStrings:{string.Join("\t", myStrings)}");

            List<Person> myPersons = new List<Person>(new Person[] { new Person(), new Person("SomeName", 35, true), null, new Person() });
            Console.WriteLine($"Type(generic): myPersons:{string.Join("\t", myPersons)}");

            Dictionary<string, int> myInfo1 = new Dictionary<string, int>();
            Console.WriteLine($"Type(generic): myInfo1:{string.Join("\t", myInfo1)}");
            Dictionary<string, int> myInfo2 = new Dictionary<string, int>
            {
                { "Name1", 25 },
                { "Name2", 27 }
            };
            Console.WriteLine($"Type(generic): myInfo2:{string.Join("\t", myInfo2)}");
            Dictionary<string, int> myInfo3 = new Dictionary<string, int>
            {
                ["Name3"] = 55,
                ["Name5"] = 65,
                ["Name6"] = 75
            };
            Console.WriteLine($"Type(generic): myInfo3:{string.Join("\t", myInfo3)}");

            Console.WriteLine("\nDone!");
        }
    }
}
