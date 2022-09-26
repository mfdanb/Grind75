using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Grind75.Problems.Easy.TwoSum;

namespace Grind75.Tests.Benchmarking;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TwoSumBenchmarks
{
    public IEnumerable<object[]> InputNumbers() => TwoSumTests.InputNumbers;

    [Benchmark]
    [ArgumentsSource(nameof(InputNumbers))]
    public void TwoSum(int[] inputNumbers, int target, int[] expectedResults) => TwoSumCalculator.Calculate_WithTwoForLoops(inputNumbers, target);
}
