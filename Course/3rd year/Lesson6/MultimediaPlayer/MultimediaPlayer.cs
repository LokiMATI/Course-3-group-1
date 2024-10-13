namespace MultimediaPlayer
{
    public class MultimediaPlayer
    {
        public string FilePath { get; set; }
        public MultimediaPlayer(string _FilePath)
        {
            this.FilePath = _FilePath;
        }

        public void FormatFile()
        {
            Console.WriteLine("Начало проверки");
            if (this.FilePath == null)
            {
                Console.Write("Введите путь до файла: ");
                this.FilePath = Console.ReadLine();
                Console.WriteLine(this.FilePath.Substring(this.FilePath.Length - 4));
                FormatFile();
            }
            else if (this.FilePath.Substring(this.FilePath.Length - 4) == ".mp4")
            {
                IVideoPlayer videoPlayer = new Mp4Player();
                Console.WriteLine(this.FilePath.Substring(this.FilePath.Length - 4));
                videoPlayer.IsVideo();
            }
            else if (this.FilePath.Substring(this.FilePath.Length - 4) == ".mp3")
            {
                IAudioPlayer audioPlayer = new Mp3Player();
                audioPlayer.IsAudio();
            }
            else if (this.FilePath.Substring(this.FilePath.Length - 4) == ".wav")
            {
                IAudioPlayer audioPlayer = new WavPlayer();
                audioPlayer.IsAudio();
            }
            else
            {
                Console.WriteLine("Неверно введён путь или нет такого формата");
            }
        }

    }
}