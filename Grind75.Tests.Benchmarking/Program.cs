using BenchmarkDotNet.Running;

namespace Grind75.Tests.Benchmarking;

public class Program
{
    public static void Main(string[] args)
    {
        //BenchmarkRunner.Run<TwoSumBenchmarks>();
        BenchmarkRunner.Run<ValidParenthesesBenchmarks>();
    }
}