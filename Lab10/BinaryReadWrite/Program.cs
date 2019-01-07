using System;
using System.IO;

namespace BinaryReadWrite {
    class Program {
        static void Main(string[] args) {
            try {
                FileStream readStream = new FileStream("music.mp3", FileMode.Open);
                BinaryReader br = new BinaryReader(readStream);
                byte[] n = br.ReadBytes(1000000);
                br.Close();

                FileStream writeStream = new
                FileStream("newmusic.mp3", FileMode.CreateNew, FileAccess.Write);

                BinaryWriter wr = new BinaryWriter(writeStream);
                wr.Write(n);
                br.Close();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
