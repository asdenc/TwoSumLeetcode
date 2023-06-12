//Leetcode Problem
//Given an array of integers nums and an integer target,
//return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution,
//and you may not use the same element twice.
//You can return the answer in any order.

int[] TwoSum(int[] nums, int target)
{
    IDictionary<int, int> result = new Dictionary<int, int>();
    int[] output = new int[2];
    for(int i = nums.GetLowerBound(0); i <= nums.GetUpperBound(0); i++)
    {
        var firstValue = nums[i];
        var secondValue = nums.ElementAtOrDefault(i + 1);
       
        if ((firstValue + secondValue) == target)
        {
            result.Add(firstValue, secondValue);

        }
       
            
    }

    foreach (KeyValuePair<int,int> kvp in result) 
    {
        output = new int[] { kvp.Key, kvp.Value };
    }
    return output;
    
}

int[] nums = new int[] {2, 7, 11, 15};
int target = 18;

var outPut = TwoSum(nums, target);

Console.WriteLine("[{0}]", string.Join(", ", outPut));
