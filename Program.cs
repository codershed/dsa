using System.Reflection.Metadata.Ecma335;

namespace dsa;

class Program
{
    static void Main(string[] args)
    {
        var process = "";

        Console.WriteLine("Select the number for the process you want to run?");
        Console.WriteLine("1 - Two Sum");
        Console.WriteLine("2 - Validate Parentheses");
        Console.WriteLine("3 - Link List Cycle Check");
        Console.WriteLine("4 - Find Longest Sub string");
        Console.WriteLine("5 - Binary search");

        process = Console.ReadLine();

        if(String.IsNullOrEmpty(process))
            Main(args);

        Run(process!);
    }

    private static void Run(string process)
    {
        var result = process switch
        {
            "1" => TwoSum.FindIndices([1, 2, 3, 4, 5, 6, 7, 8], 9)?.ToString(),
            "2" => ValidParentheses.IsValid("([])}").ToString(),
            "3" => LinkListCycle.HasCycle(LinkListCycle.GetHead()).ToString(),
            "4" => LongestSubstring.GetSubstring("pwwkew"),
            "5" => BinarySearch.Search([-1, 0, 3, 5, 9, 12], 9).ToString(),
            _ => ""

        };

    }
}
