using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Question 1: Even numbers.");
            Console.WriteLine("Question 2: From the numbers entered by the user, print the numbers that are divisible by m to the console.");
            Console.WriteLine("Question 3: Reverse Words.");
            Console.WriteLine("Question 4: The total number of Words and letters in the sentence");
            int caseNum;
            Console.WriteLine("Please enter a case number including 1 and 4");
            caseNum = Convert.ToInt32(Console.ReadLine());
            int arrLength;
            int[] arr;  


            switch (caseNum)
            {
                case 1:
                    System.Console.WriteLine("Please enter a positive integer.");
                    arrLength= int.Parse(Console.ReadLine());
                    arr = new int[arrLength];
                    for (int i = 0; i < arrLength; i++)
                    {
                        System.Console.WriteLine("Please enter {0}. number ", i + 1);
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                            System.Console.WriteLine("Even Numbers: " + arr[i]);
                    }
                    break;

                case 2:
                    System.Console.WriteLine("Please enter two positive integer.");
                    System.Console.WriteLine("Please enter N.");
                    int n = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Please enter M.");
                    int m = int.Parse(Console.ReadLine());
                    arr = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        System.Console.WriteLine("Please enter {0}. number ", i + 1);
                        arr[i] = int.Parse(Console.ReadLine());
                    }


                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] % m == 0) || (arr[i] == m))
                            System.Console.WriteLine(arr[i]);
                    }
                    break;

                case 3:
                    System.Console.WriteLine("Please enter N.");
                    int NumberN = int.Parse(Console.ReadLine());
                    string[] StringArr = new string[NumberN];
                    for (int i = 0; i < StringArr.Length; i++)
                    {
                        System.Console.WriteLine("Please enter {0}. word ", i + 1);
                        StringArr[i] = Console.ReadLine();
                    }
                    System.Console.WriteLine("******Reverse Words******");
                    for (int i = 0; i < StringArr.Length; i++)
                    {
                        char[] CharArr = StringArr[i].ToCharArray();
                        Array.Reverse(CharArr);
                        string returnmetin = new string(CharArr);
                        System.Console.WriteLine(returnmetin);
                    }
                    System.Console.WriteLine("******Reverse List******");
                    Array.Reverse(StringArr);
                    foreach (var item in StringArr)
                    {
                        System.Console.WriteLine(item);
                    }
                    break;
                case 4:
                    int numberOfLetter = 0;
                    System.Console.WriteLine("Please enter a sentence. ");
                    string sentence = Console.ReadLine();
                    string[] wordsArr = sentence.Split(" ");
                    System.Console.WriteLine("There are " + "{0}" + " word(s) in the sentence.", wordsArr.Length);
                    for (int i = 0; i < wordsArr.Length; i++)
                    {
                        char[] letter = wordsArr[i].ToCharArray();
                        numberOfLetter += letter.Length;
                    }
                    System.Console.WriteLine("There are " + "{0}" + " letter(s) in the sentence.", numberOfLetter);
                    break;
                default:
                    Console.WriteLine("***************************************************************************");
                    break;

            }
        }

    }
}
