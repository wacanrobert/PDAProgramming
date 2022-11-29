
using PDAProgramming;
int n = 0;

do
{
    Console.WriteLine("\n\nCheck for Palindrome or Equal Brackets\n" +
"Type 1 for Palindrome, Type 2 for Brackets, Type 0 to Exit\n");

    string? input = Console.ReadLine();

    if (input != null)
        n = Int32.Parse(input);

    if (n == 1)
    {
        Palindrome pal = new Palindrome();
        Console.WriteLine("\nInput string: ");
        string? str = Console.ReadLine();
        char[] arr = str.ToCharArray();

        if (pal.IsPalindrome(arr))
        {
            Console.WriteLine(str + " is a palindrome.");
        }
        else
        {
            Console.WriteLine(str + " is NOT a palindrome.");
        }
    }
    else if (n == 2)
    {
        Brackets brkt = new Brackets();
        Console.WriteLine("Input brackets: ");
        string? str = Console.ReadLine();
        char[] arr = str.ToCharArray();

        switch (brkt.CheckBalanced(arr))
        {
            case 1: Console.WriteLine(str + " is a balanced expression.");
                    break;
            case 0: Console.WriteLine(str + " is NOT a balanced expression.");
                    break;
            default: Console.WriteLine("Please input only brackets");
                break;
        }
    }
} while (n != 0);


