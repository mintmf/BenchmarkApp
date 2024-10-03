using BenchmarkDotNet.Attributes;

namespace BenchmarkApp
{
    public class BenchmarkTests
    {
        //[Benchmark]
        public List<int> BenchmarkTest1()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000000; i++)
            {
                intList.Add(new Random().Next(0, 1000000));
            }

            return intList;
        }

        //[Benchmark]
        public List<int> BenchmarkTest2()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                intList.Add(new Random().Next(0, 100));
            }

            return intList;
        }

        //[Benchmark]
        public List<int> BenchmarkTest3()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000000; i++)
            {
                intList.Add(Convert.ToInt32(i.ToString()));
            }

            return intList;
        }

        //[Benchmark]
        public List<int> BenchmarkTest4()
        {
            var intList = new List<int>();

            for (int i = 0; i < 1000000; i++)
            {
                intList.Add(i);
            }

            return intList;
        }

        [Benchmark]
        public int GetReverseWordCount()
        {
            var text = File.ReadAllText("world2.txt");
            var words = text.Split(' ');
            var result = words.Distinct().Count(word => words
                .Any(anotherWord => anotherWord == new String(word.ToCharArray().Reverse().ToArray())));

            return result;
        }

        [Benchmark]
        public int GetReverseWordCountNew()
        {
            var text = File.ReadAllText("world2.txt");
            var words = text.Split(' ').ToList().Distinct();
            var reverseWordDictionary = words.ToDictionary(w => w, w => new String(w.ToCharArray().Reverse().ToArray()));

            var wordsCount = 0;
            var outString = String.Empty;

            foreach(var word in words)
            {
                if (reverseWordDictionary.TryGetValue(new String(word.ToCharArray().Reverse().ToArray()), out outString))
                {
                    wordsCount++;
                }
            }

            return wordsCount;
        }
    }
}
