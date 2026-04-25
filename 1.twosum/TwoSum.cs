using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class TwoSum
{
    public static int[]? FindIndices (int[] nums, int target)
    {
        if(nums == null || nums.Length == 0)
            return null;

        Console.WriteLine($"Find the indices of the two numbers that add up to the target ({target}).");

        var valuesChecked = new Dictionary<int,int>(nums.Length);
       
        for (var currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
            
            var currentValue = nums[currentIndex];
            var diff = target - currentValue; 
            int valuesCheckedIndex;
            var diffExists = valuesChecked.TryGetValue(diff, out valuesCheckedIndex);

            if(diffExists){
                Console.WriteLine($"The indices of the two numbers that add up to the target are: {currentIndex} and {valuesCheckedIndex}");
                return [currentIndex, valuesCheckedIndex];
            }

            valuesChecked.TryAdd(currentValue, currentIndex);
            
        }

        Console.WriteLine($"The indices of the two numbers that add up to the target are: None Found that adds up to the target");
        return null;
    }

//walk through test
            /*
                [1,2,3,4,5,6,7,8]
                Target 9
                ---------------------------------

                valuesChecked = [<1,0>,<2,1>,<3,2>,<4,3>]

                currentIdex = 4
                currentValue = 5
                diff = 4
                diffExists = true
                valuesCheckedIndex = 3

                return --> int[4,3] = 5 + 4 = 9
            */

}