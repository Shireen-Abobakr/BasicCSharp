// See https://aka.ms/new-console-template for more information
//----------------checked number enter by user is possitive or negative  -------------------------------------
//int num = int.Parse (Console.ReadLine());

//if (num > 0) { 
//    Console.WriteLine("The number is possitive");
//}
//else if (num < 0 ) 
//    Console.WriteLine("The number is negative");
//    else
//    Console.WriteLine("The number is not negative or positive");


//----------------checked number enter by user is even or odd -------------------------------------
//int num = int.Parse(Console.ReadLine());


//if (num % 2 == 0)
//{
//    Console.WriteLine("The number is even");
//}
//else 

//    Console.WriteLine("The number is Odd");


//----------------checked if a rectangle is square or not -------------------------------------
//Console.WriteLine("Enter width and length");

//int Width = int.Parse(Console.ReadLine());
//int Length = int.Parse(Console.ReadLine());

//if (Length == Width)
//{
//    Console.WriteLine("The shape is Square");
//}
//else

//    Console.WriteLine("The shape is Rectangle");
//---------------- prints your name, age, and favorite hobby on separate lines. -------------------------------------
//Console.Write("my name is ");
//Console.WriteLine("shireen abo bakr");
//Console.Write("my age is ");
//Console.WriteLine("38");
//Console.Write("my favorite hobby is ");
//Console.WriteLine("cooking");


//-- declares variables of different data types (int, double, string, bool) and assigns them values. Then, print these values to the  -------------------------------------
//int num = 8 ;
//double salary= 14500.54;
//string name= "Momen";
//bool  degree=true;
//Console.WriteLine(num);
//Console.WriteLine(salary);
//Console.WriteLine(name);
//Console.WriteLine(degree);


//// --converts a temperature value from Celsius to Fahrenheit. The Celsius temperature should be stored in a variable.
//Console.WriteLine("Enter The Celsius temperature:");
//double CelTemp = Convert.ToDouble(Console.ReadLine());
//double FahTemp = ( (CelTemp * 9 / 5) + 32);
//Console.WriteLine("Temperature " + CelTemp + " degree Celsius  " + " =   " +   FahTemp   + " degree Fahrenheit .");

using System;

/// ------- Question 4
//Console.WriteLine("Enter Two numbers");
//Double num1 = Convert.ToDouble(Console.ReadLine());
//Double num2 =Convert.ToDouble(Console.ReadLine());
//Double sum = num1 + num2;
//Double sub = num1 - num2;
//Double multiply = num1 * num2;
//Double division = num1 / num2;
//Console.WriteLine("the summion is " + sum  );
//Console.WriteLine("the subtraction is " +  sub);
//Console.WriteLine("the multiply is " + multiply);
//Console.WriteLine("the division is " + division);


//---Question 5 :
//Console.WriteLine("Enter the width and the length");
//Double length =Convert.ToDouble(Console.ReadLine());
//Double width =Convert.ToDouble(Console.ReadLine());
//if (length > 0 && width > 0)
//    Console.WriteLine("The area of Rectangle =   "+ length * width);
//else 
//    Console.WriteLine("Enter correct values");

//--------Question 7:
//Double age = Convert.ToDouble(Console.ReadLine());
//if ( age >= 18) 
//{ 
//Console.WriteLine("You are Eligible to vote");
//} 
//else 
// Console.WriteLine("You are Not Eligible to vote");

//------------Question 8 :

Console.WriteLine("Enter degree");
    double degree =Convert.ToDouble(Console.ReadLine());
while (degree <= 100)
{
    if (degree >= 90)
        Console.WriteLine("the Evaluation is    "  +  'A' + " For " +  degree + " Degree ");
    else if (degree >= 80)
    Console.WriteLine("the Evaluation is    " + 'B' + " For  " + degree + " Degree ");
    else if (degree >= 70)
        Console.WriteLine("the Evaluation is    " + 'C' + " For " + degree + " Degree ");
    else if (degree >= 60)
        Console.WriteLine("the Evaluation is   " + 'D' + " For " + degree + " Degree ");
    else 
        Console.WriteLine("the Evaluation is   " + 'F' + " For " + degree + " Degree ");
    break;
}




