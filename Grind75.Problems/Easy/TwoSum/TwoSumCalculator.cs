namespace Grind75.Problems.Easy.TwoSum;

public static class TwoSumCalculator
{
    public static int[] Calculate_WithTwoForLoops(int[] numbers, int sum)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int ii = i + 1; ii < numbers.Length; ii++)
            {
                if (numbers[i] + numbers[ii] == sum)
                {
                    return new int[] { i, ii };
                }
            }
        }

        return Array.Empty<int>();
    }
}