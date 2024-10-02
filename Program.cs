using BenchmarkApp;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");
var result = BenchmarkRunner.Run<BenchmarkTests>();
Console.ReadLine();