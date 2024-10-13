using MultimediaPlayer;

string filePath;
Console.Write("Введите путь до файла: ");
filePath = Console.ReadLine();
MultimediaPlayer.MultimediaPlayer player = new MultimediaPlayer.MultimediaPlayer(filePath);
player.FormatFile();