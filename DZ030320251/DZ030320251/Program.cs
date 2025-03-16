using System;

namespace DZ030320251
{
    internal class Program
    {
        static SynchronizationContext uiContext = null!;
        static Random random = new Random();
        static string PathDir = Directory.GetCurrentDirectory();
        static async Task Main(string[] args)
        {
            await Task.Run(ThreadMutexGenerateNums);
            await Task.Run(ThreadMutexIsSimpleNums);
            await Task.Run(ThreadMutexIsSimpleAndEndSeven);
        }
        public static void ThreadMutexGenerateNums()
        {
            bool isCreatedMut;

            using (Mutex mutex = new Mutex(true, "8903FC80-3E92-4720-A452-6B60D2DF45E2", out isCreatedMut))
            {
                mutex.WaitOne();
                GenerateNumbers();
                mutex.ReleaseMutex();
            }
        }
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }
        public static void IsPrimeSeven()
        {
            using FileStream file = new(Path.Combine(PathDir, "helloIsSimple.dat"), FileMode.Open, FileAccess.Read);
            using BinaryReader binaryReader = new(file);
            using FileStream fileWriter = new(Path.Combine(PathDir, "helloIsSimpleEndSeven.dat"), FileMode.OpenOrCreate, FileAccess.Write);
            using (BinaryWriter binaryWriter = new(fileWriter))
            {
                while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                    var num = binaryReader.ReadInt32();
                    if (IsPrime(num) && num % 10 == 7)
                    {
                        binaryWriter.Write(num);
                    }
                }
            }
        }
            
        public static void ThreadMutexIsSimpleAndEndSeven()
        {
            bool isMut;
            using (Mutex mutex = new(false, "f4420a68-86bc-4365-8f31-fb11ab50ceac", out isMut))
            {
                mutex.WaitOne();
                IsPrimeSeven();
                mutex.ReleaseMutex();
            }
        }
        public static void ThreadMutexIsSimpleNums()
        {
            bool isMut;
            using (Mutex mutex = new(false, "8903FC80-3E92-4720-A452-6B60D2DF45E2", out isMut))
            {
                mutex.WaitOne();

                try
                {

                    using FileStream file = new(Path.Combine(PathDir, "hello.dat"), FileMode.Open, FileAccess.Read);
                    using FileStream file_isSimple = new(Path.Combine(PathDir, "helloIsSimple.dat"), FileMode.OpenOrCreate, FileAccess.Write);
                    using BinaryReader binaryReader = new(file);
                    using (BinaryWriter binaryWriter_isSimple = new(file_isSimple))
                    {
                        int i = 0;
                        int[] ar = new int[file.Length / 4];
                        while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                        {
                            var num = binaryReader.ReadInt32();
                            if (IsPrime(num))
                            {
                                binaryWriter_isSimple.Write(num);
                            }
                            i++;
                        }
                    }

                }
                finally
                {
                    mutex.ReleaseMutex();
                }

            }
        }
        public static void GenerateNumbers()
        {
            FileStream file = new(Path.Combine(PathDir, "hello.dat"), FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(file);

            for (int i = 0; i < 100; i++)
            {
                var num = random.Next(3000);
                bw.Write(num);
            }
            bw.Close();
            file.Close();
            Thread.Sleep(1000);
        }
    }
}
