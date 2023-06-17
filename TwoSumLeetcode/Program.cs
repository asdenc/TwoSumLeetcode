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
    for(int i = 0; i <= nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++) 
        {
            var firstValue = nums[i];
            var secondValue = nums[j];

            if ((firstValue + secondValue) == target)
            {
                result.Add(i,j);

            }
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
