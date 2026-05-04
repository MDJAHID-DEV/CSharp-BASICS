
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("Welcome to C#");

            // Console.Write("Hello");
            // Console.WriteLine();
            // Console.WriteLine("World!");
            // ConsoleKeyInfo key =Console.ReadKey();
            // Console.Clear();
            // Console.WriteLine("World!");
            // Console.ForegroundColor=ConsoleColor.Green;
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("Welcome to C#");
            // Console.BackgroundColor=ConsoleColor.DarkGreen;

            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("Welcome to C#");
            // Console.ResetColor();


            Console.WriteLine("Line 1\nLine 2\nLine 3");

            Console.WriteLine("Name:\tJohn Doe");

            Console.WriteLine("He Said \"Hello,world!\"");
            
            Console.WriteLine("C:\\program files\\Documents");

            string path = "C:\\program files\\Documents";
            Console.WriteLine(path);
             path=@"C:\User\Documents\file.txt";
            Console.WriteLine(path);

            string poem =@"Roses are red
Violets are blue
C# is awesome
And so are you!";
            Console.WriteLine(poem);
            string json="""
            {
            "name":"John Doe",
            "age":25}
            """;
            Console.WriteLine(json);

// 1. Single Line Comment
int age=25; // have declared variable
/*
2. multi line comment
this can cover multiple lines
*/
///<summary>
/// 3. XML Documentation comment
/// This is used for describe methods or classes
/// </summary>
/// <param name="name">The name of the person</param>
/// <returns> Greeting message</returns>

//    public string Greet(string name)
// {
//     return $"Hello, {name}!";
// }

//Calculate compound interest using formula: A=P(1+r/n)^(nt)
// double CalculateCompoundInterest(double principal,double rate,int years){}

//TODO: Add validation for negative numbers
//FIXME: This breaks when input is zero
// HACK: Temporary fix until API is ready


// Numeric Types

//Integer types (whole numbers)
byte smallNumber=255;  //0 to 255(1byte)
sbyte signedByte =-128; //-128 to 127(1 byte)
short shortNum=32000; // -32,768 to 32,767(2 bytes)
ushort unsignedShort=65000; //0 to 65,535(2 bytes)
int normalNum =2000000000; //-2.1 billion to 2.1 billion(4 bytes)
uint unsignedInt=4000000000; //0 to 4.2 billion (4 bytes)
long bigNum=9000000000000000000; // very large numbers (8 bytes)
ulong unsignedLong=18000000000000000000L;

// Decimal types (floating point)

float salary = 50000.50f; // 7 digits of precision (4 bytes)
double price =99.99; // 15-17 digits of precision (8 bytes)
decimal money =1000.50m; // 28-29 digits of precision (16 bytes ) - for money

// Specials types:
object anything ="Can hold anything";
dynamic flexible ="Can change type at runtime"; // type checked at runtime
var inferred = "type inferred by compiler";

// var = compiler decides type
var age1 = 25;       //int
var name = "john"; //string
var price1 = 19.99; //double
var isActive = true; //bool

// Equivalnet to:
int age2 =25;
string name2 = "john";
double price2 = 19.99;
bool isActive2=true;

// var only works with initialized variables

// var y; // X error: Implicitly-typed variables must be initialized
var y = 10; // works fine, type inferred as int


int smallNumber =100;
long bigNumber=smallNumber; // Implicit conversion from int to long
int x =50;
double y=x;
