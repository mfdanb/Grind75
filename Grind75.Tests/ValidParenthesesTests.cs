using System.Collections.Generic;
using Grind75.Problems.Easy.ValidParentheses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grind75.Tests;

[TestClass]
public class ValidParenthesesTests
{
    public static IEnumerable<object[]> InputStrings => new List<object[]>
    {
        new object[]
        {
            "()",
            true
        },
        new object[]
        {
            "()[]{}",
            true
        },
        new object[]
        {
            "(]",
            false
        }
    };

    [TestMethod]
    [DynamicData(nameof(InputStrings))]
    public void WithValidInputs_CalculatesWithoutError(string input, bool expectedResult)
    {
        var result = ValidParenthesesCalculator.IsValid(input);

        Assert.AreEqual(expectedResult, result);
    }
}