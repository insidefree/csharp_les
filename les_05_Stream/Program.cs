using System;
using System.IO;

namespace les_05_Stream
{
    class StreamClass
    {
        string path;

        public StreamClass(string path)
        {
            this.path = path;
        }
        public string Path { set { path = value; } get { return path; } }
        // StreamWriter sw = new StreamWriter((string)"file.txt");

        // methods
        public void ShowPath()
        {
            Console.WriteLine(path);
        }

        public void WriteToFile()
        {
            // FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            // StreamWriter sw = new StreamWriter(fs);
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
            {
                sw.Write("bench\tbench");
            }

            // StreamWriter sw = null;
            // try
            // {
            //     sw = new StreamWriter(fs);
            //     sw.Write("bench\tbench123123123123");
            // }
            // finally
            // {
            //     if (sw != null) sw.Dispose();
            // }
        }
    }
}
