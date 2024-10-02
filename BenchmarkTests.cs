using BenchmarkDotNet.Attributes;

namespace BenchmarkApp
{
    public class BenchmarkTests
    {
        [Benchmark]
        public List<int> BenchmarkTest1()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000000; i++)
            {
                intList.Add(new Random().Next(0, 1000000));
            }

            return intList;
        }

        [Benchmark]
        public List<int> BenchmarkTest2()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                intList.Add(new Random().Next(0, 100));
            }

            return intList;
        }

        [Benchmark]
        public List<int> BenchmarkTest3()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000000; i++)
            {
                intList.Add(Convert.ToInt32(i.ToString()));
            }

            return intList;
        }

        [Benchmark]
        public List<int> BenchmarkTest4()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000000; i++)
            {
                intList.Add(i);
            }

            return intList;
        }
    }
}
