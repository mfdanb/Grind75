using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Grind75.Problems.Easy.ValidParentheses;

namespace Grind75.Tests.Benchmarking;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class ValidParenthesesBenchmarks
{
    public IEnumerable<object[]> InputStrings() => ValidParenthesesTests.InputStrings;

    [Benchmark]
    [ArgumentsSource(nameof(InputStrings))]
    public void IsValid(string inputString, bool expectedResult) => ValidParenthesesCalculator.IsValid(inputString);
}
