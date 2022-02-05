``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.973 (1809/October2018Update/Redstone5)
Intel Core i5-8265U CPU 1.60GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|    Method |     Mean |    Error |   StdDev |
|---------- |---------:|---------:|---------:|
| ExeSender | 76.91 ms | 3.386 ms | 9.661 ms |
