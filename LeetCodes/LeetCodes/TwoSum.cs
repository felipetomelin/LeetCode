namespace LeetCodes;

public class TwoSum
{
    // O(N^2)
    public int[] TwoSumMethodBruteForce(int[] nums, int target)
    {
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            for (var j = 0; j <= nums.Length - 1; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (nums[i] + nums[j] == target)
                {
                    var valorN1 = i;
                    var valorN2 = j;
                    return [valorN1, valorN2];
                }
            }
        }

        return [0, 0];
    }
    
    // O(N)
    public int[] TwoSumMethodBestCase(int[] nums, int target)
    {
        var hasher = new Dictionary<int, int>();
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            var number = hasher.ContainsKey(nums[i]) ;
            if (number)
            {
                return [hasher[nums[i]], i];
            }

            if (hasher.ContainsKey(target - nums[i]))
            {
                continue;
            }
            
            hasher.Add(target - nums[i], i);
        }

        return [];
    }
}