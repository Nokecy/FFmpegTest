using System;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace FFmpegTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var inputFile = "rtsp://184.72.239.149/vod/mp4:BigBuckBunny_115k.mov";
            var outputPath = "rtsp://127.0.0.1:8554/PUSH/todo";

            FFmpeg.ExecutablesPath = @"C:\Program Files\ffmpeg\bin";
            //-re -i sample.mp4 -vcodec copy -rtsp_transport udp -f rtsp rtsp://127.0.0.1:8554/PUSH/toto

            string arguments = $"-i \"{inputFile}\"  -vcodec copy -rtsp_transport udp -f rtsp \"{outputPath}\"";

            var result = await Conversion.New().Start(arguments);

            if (result.Success)
            {
                Console.WriteLine("正在转换");
            }
        }
    }
}
