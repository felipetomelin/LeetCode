namespace LeetCodes;

public class MaximumUnitsOnATruck
{
    public int MaximumUnitsMethod(int[][] boxTypes, int truckSize)
    {
        if (boxTypes is null || boxTypes.Length == 0 || truckSize == 0)
        {
            return 0;
        }
        
        Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));
        
        int totalUnits = 0;
        int remainingSpace = truckSize;

        foreach (var box in boxTypes) {
            int boxesToTake = Math.Min(remainingSpace, box[0]);
            totalUnits += boxesToTake * box[1];
            remainingSpace -= boxesToTake;
            
            if (remainingSpace == 0) break;
        }
        
        return totalUnits;
    }
}