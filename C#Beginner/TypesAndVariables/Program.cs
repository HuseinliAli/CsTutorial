//Console.WriteLine("Hello, World!");
//Console.ReadLine(); We don't need doing it for disable closing screen.

#region Integer
/*
1)Integer is value type. We will see other value types next regions.
2)For declaration in c#:
3)type_of_variable name_of_variable =(assign operator) value_of_variable and ;
4)All daya types have limits.
5)int occupies 32 bits.
*/
int number1 = 999999999;
Console.WriteLine($"{nameof(number1)} is {number1}");
int maxValueOfInteger = int.MaxValue;
int minValueOfInteger = int.MinValue;
Console.WriteLine($"Max value of int: {maxValueOfInteger}\nMin value of int: {minValueOfInteger}");
#endregion

#region Long
/*
1)When our variable is over limit of int we can use long. 
2)But long takes 2x more space than int in RAM(Random Access Memory).
3)long occupies 64 bits.
 */
long maxValueOfLong = long.MaxValue;
long minValueOfLong = long.MinValue;
Console.WriteLine($"Max value of long: {maxValueOfLong}\nMin value of long: {minValueOfLong}");
#endregion

#region Short
/*
1)short occupies 16 bits.
 */
short maxValueOfShort = short.MaxValue; 
short minValueOfShort = short.MinValue;
Console.WriteLine($"Max value of short: {maxValueOfLong}\nMin value of short: {minValueOfLong}");
#endregion

#region Byte
/*
1)byte occupies 8 bits.
*/
byte maxValueOfByte = byte.MaxValue;
byte minValueOfByte = byte.MinValue;
Console.WriteLine($"Max value of byte: {maxValueOfByte}\nMin value of byte: {minValueOfByte}");
#endregion

#region Bool
/*
1)Using with if else blocks.
 */
bool conditionTrue = true;
bool conditionFalse = false;
#endregion

#region Char
/*
1)Characters can cast to the int.
 */
char character = 'A';
Console.WriteLine((int)character);
#endregion

#region Double
/*
1)double occupies 64 bits.
*/
double number2 = 20.3;
Console.WriteLine(number2);
#endregion

#region Decimal
/*
1)28-29
*/
decimal number3 = 20.3m;
Console.WriteLine(number3);
#endregion


#region IfElse
if (number3>100)
{
    Console.WriteLine("number3 higher than 100");
}
else
{
    Console.WriteLine("number3 lower than 100");
}
#endregion SingleLineIfElse
Console.WriteLine(number3>10?"number3>10":"number3<10") ;
#region

#endregion
#region Enums
enum Days
{
    Monday, Tuesday, Wednesday, ThursDay, Friday, Saturday, Sunday
}
#endregion

#region Var

#endregion

