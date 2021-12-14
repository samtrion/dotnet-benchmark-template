namespace NetEvolve.Benchmark;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Benchmark
{
  [Benchmark(Baseline = true, Description = "Default Impl.")]
  public int Baseline() => BenchmarkImpl.Baseline();
}

public static class BenchmarkImpl
{
  public static int Baseline() => default;
}
