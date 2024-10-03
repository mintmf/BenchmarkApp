using BenchmarkApp;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

FileStream filestream = new FileStream("out.txt", FileMode.Create);
var streamwriter = new StreamWriter(filestream);
streamwriter.AutoFlush = true;
Console.SetOut(streamwriter);
Console.SetError(streamwriter);

var config = DefaultConfig.Instance;
var summary = BenchmarkRunner.Run<BenchmarkTests>(config);

Console.ReadLine();
