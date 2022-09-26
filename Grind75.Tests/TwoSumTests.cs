using System;
using System.Collections.Generic;
using Grind75.Problems.Easy.TwoSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grind75.Tests;

[TestClass]
public class TwoSumTests
{
    public static IEnumerable<object[]> InputNumbers => new List<object[]>
    {
        new object[]
        { 
            new int[] { 2, 7, 11, 15 }, 
            9, 
            new int[] { 0, 1 } 
        },
        new object[] 
        { 
            new int[] { 3, 2, 4 },
            6, 
            new int[] { 1, 2 } 
        },
        new object[]
        {
            new int[] { 3, 3 },
            6,
            new int[] { 0, 1 }
        },
        new object[]
        {
            new int[] { 3 },
            6,
            Array.Empty<int>()
        },
        new object[]
        {
            new int[] { 9, 6, 12, 134, 5, 7, 19 },
            26,
            new int[] { 5, 6 }
        }
    };

    [TestMethod]
    [DynamicData(nameof(InputNumbers))]
    public void WithValidInputs_CalculatesWithoutError(int[] input, int target, int[] expectedResults)
    {
        var results = TwoSumCalculator.Calculate_WithTwoForLoops(input, target);

        CollectionAssert.AreEquivalent(expectedResults, results);
    }
}