public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> distinctNumbers = new();
        HashSet<int> duplicateNumbers = new();
        
        foreach (int number in nums)
        {
            if (!distinctNumbers.Add(number))
                duplicateNumbers.Add(number);
        }
        
        return duplicateNumbers.Count > 0 ? true : false;
    }
}
