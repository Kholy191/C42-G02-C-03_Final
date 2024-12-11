namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //int.TryParse(Console.ReadLine(), out int num);
            //if ((num % 3) == 0 && (num % 4) == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q2 Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num >= 0)
            //    Console.WriteLine("positive");
            //else
            //    Console.WriteLine("negative");
            #endregion

            #region Q3 Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int Max = 0;
            //int Min = 0;
            //int.TryParse(Console.ReadLine(), out int Num1);
            //int.TryParse(Console.ReadLine(), out int Num2);
            //int.TryParse(Console.ReadLine(), out int Num3);
            //if (Num1 > Num2 && Num1 > Num3)
            //{
            //    Max = Num1;
            //    if (Num2 > Num3)
            //        Min = Num3;
            //    else
            //        Min = Num2;
            //}
            //else if (Num2 > Num1 && Num2 > Num3)
            //{
            //    Max = Num2;
            //    if (Num1 > Num3)
            //        Min = Num3;
            //    else
            //        Min = Num1;
            //}

            //else
            //{
            //    Max = Num3;
            //    if (Num1 > Num2)
            //        Min = Num2;
            //    else
            //        Min = Num1;
            //}

            //Console.WriteLine($"Max = {Max}, Min = {Min}");

            #endregion

            #region Q4 Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int.TryParse(Console.ReadLine(), out int num);
            //if ((num % 2) == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");
            #endregion

            #region Q5 Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //char.TryParse(Console.ReadLine(), out char Char_1);
            //switch (Char_1)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}
            #endregion

            #region Q6 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= num; i++)
            //    Console.WriteLine(i);
            #endregion


            #region Q7 Write a program that allows the user to insert an integer print a multiplication table up to 12.
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= 12; i++)
            //    Console.WriteLine(i * num);
            #endregion

            #region Q8 Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= num; i++)
            //    if ((i % 2) == 0) Console.WriteLine(i);
            #endregion

            #region Q9 Write a program that takes two integers then prints the power.
            //int Result = 1;
            //int.TryParse(Console.ReadLine(), out int num);
            //int.TryParse(Console.ReadLine(), out int Power);
            //for (int i = 1; i <= Power; i++)
            //    Result = Result * num;
            //Console.WriteLine(Result);
            #endregion

            #region Q10 Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int total, Average, Percentage;
            //int.TryParse(Console.ReadLine(), out int Sub1);
            //int.TryParse(Console.ReadLine(), out int Sub2);
            //int.TryParse(Console.ReadLine(), out int Sub3);
            //int.TryParse(Console.ReadLine(), out int Sub4);
            //int.TryParse(Console.ReadLine(), out int Sub5);

            //total = Sub1 + Sub2 + Sub3 + Sub4 + Sub5;
            //Average = total / 5;
            //Percentage = (total * 100) / (5 * 100); // Assuming 100 is the maximum mark for each subject
            //Console.WriteLine($"Total marks = {total} \nAverage Marks = {Average}\nPercentage = {Percentage}");
            #endregion


            #region Q11 Write a program to input the month number and print the number of days in that month.
            //int.TryParse(Console.ReadLine(), out int month);
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine(31);
            //        break;

            //    case 4: // April
            //    case 6: // June
            //    case 9: // September
            //    case 11: // November
            //        Console.WriteLine(30);
            //        break;
            //    case 2:
            //        Console.WriteLine(28);
            //        break;
            //}
            #endregion

            #region Q12 Write a program to create a Simple Calculator.
            //Console.Write("Enter Num1 ");
            //int.TryParse(Console.ReadLine(), out int Num1);
            //Console.Write("Enter Operator ");
            //char.TryParse(Console.ReadLine(), out char Operator);
            //Console.Write("Enter Num2 ");
            //int.TryParse(Console.ReadLine(), out int Num2);

            //switch (Operator)
            //{
            //    case '+':
            //        Console.WriteLine(Num1 + Num2);
            //        break;
            //    case '*':
            //        Console.WriteLine(Num1 * Num2);
            //        break;
            //    case '/':
            //        Console.WriteLine(Num1 / Num2);
            //        break;
            //    case '-':
            //        Console.WriteLine(Num1 - Num2);
            //        break;
            //}
            #endregion
        }
    }
}
