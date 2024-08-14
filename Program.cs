using PasswordGenerator;

// Same as above but you can set the length. Must be between 8 and 128
// Will return a password which is 32 characters long
var pwd = new Password(32);
var password = pwd.Next();
Console.WriteLine($"{password}");
Console.WriteLine("");


// === Data Type ===
int myNum = 19;               // integer (whole number)
double myDoubleNum = 19.99D;  // floating point number
bool myBool = true;          // boolean

Console.WriteLine(myNum);
Console.WriteLine(myDoubleNum);
Console.WriteLine(myBool);

const int myConst = 15;
long myLong = 15000000000L;
float myFloat = 5.75F;
int myInt = 100000;

Console.WriteLine(myConst);
Console.WriteLine(myLong);
Console.WriteLine(myFloat);
Console.WriteLine(myInt);
Console.WriteLine("");

// === Scientific Numbers ===
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);

int x, y, z;
x = y = z = 50;
int xs = 5;
int ys = 6;
int minutesPerHour = 60; // Good

Console.WriteLine(minutesPerHour);
Console.WriteLine(x + y + z);
Console.WriteLine(xs + ys); // Print the value of x + y
Console.WriteLine("");

// === Booleans === 
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False  
Console.WriteLine("");

// == Characters ===
char myGrade = 'A';
char myLetter = 'B';         // character

Console.WriteLine(myGrade);
Console.WriteLine(myLetter);
Console.WriteLine("");

// === Strings ===
string myText = "Hi";
string greeting = "Hello World";
string firstName = "John ";
string lastName = "Doe";

Console.WriteLine(myText);
Console.WriteLine(greeting);
string fullName = firstName + lastName;
Console.WriteLine($"Hello {fullName}!");
Console.WriteLine($"Hello {fullName.ToUpper()}!");
Console.WriteLine("");


// === Type Casting ===
// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double

int myInts = 9;
double myDoubles = myInts;       // Automatic casting: int to double
Console.WriteLine(myInts);      // Outputs 9
Console.WriteLine(myDoubles);   // Outputs 9
Console.WriteLine("");

// === Type Casting ===
// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char
double ExplicitMyDouble = 9.78;
int ExplicitMyInt = (int)ExplicitMyDouble;    // Manual casting: double to int

Console.WriteLine(ExplicitMyDouble);   // Outputs 9.78
Console.WriteLine(ExplicitMyInt);      // Outputs 9
Console.WriteLine("");

/*
 * Type Conversion Methods
 * It is also possible to convert data types explicitly by using built-in methods,
 * such as: 
 * Convert.ToBoolean, 
 * Convert.ToDouble, 
 * Convert.ToString, 
 * Convert.ToInt32 (int) 
 * Convert.ToInt64 (long):
*/

int ints = 10;
double doubles = 5.25;
bool bool_ens = true;

Console.WriteLine(Convert.ToString(ints));    // Convert int to string
Console.WriteLine(Convert.ToDouble(ints));    // Convert int to double
Console.WriteLine(Convert.ToInt32(doubles));  // Convert double to int
Console.WriteLine(Convert.ToString(bool_ens));   // Convert bool to string

// === Array ===
var names = new[] { "Anna", "Erik", "Emma" };
foreach (var newName in names)
{
    Console.WriteLine($"Hello {newName.ToUpper()}!");
}
Console.WriteLine("");


// === Get User Input ===
Console.Write("what is your name: ");

// Create a string variable and get user input from the keyboard and store it in the variable
var name = Console.ReadLine();
var currentDate = DateTime.Now;

// Print the value of the variable (userName), which will display the input value
Console.WriteLine($"{Environment.NewLine}Hello {name} on {currentDate}");
Console.WriteLine("");

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your age is: {age}");
Console.WriteLine("");

// === Operators ===
int sum1 = 100 + 50;     // 150 (100 + 50)
int sum2 = sum1 + 250;   // 400 (150 + 250)
int sum3 = sum2 + sum2;  // 800 (400 + 400)
Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);

// === Assignment Operators ===
int s = 10;
s += 5;
Console.WriteLine(s);