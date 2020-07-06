using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace CompoletTest.Library
{
    public class Class1
    {
        public bool SharedMemTest()
        {
            try
            {
                using(MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("SharedMemory"))
                {
                    Mutex mutex = Mutex.OpenExisting("mutex");
                    mutex.WaitOne();

                    using (MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor())
                    {
                        var boolData = new bool[16];
                        var val = accessor.ReadArray(0, boolData, 0, 16);
                        var intData = new int[16];
                        var val2 = accessor.ReadArray(sizeof(bool) * boolData.Length, intData, 0, 16);
                    }
                    mutex.ReleaseMutex();
                }
            }
            catch (FileNotFoundException)
            {
                return false;
            }

            return true;
        }
    }
}
