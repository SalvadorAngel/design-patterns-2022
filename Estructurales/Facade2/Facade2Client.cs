public class Facade2Cliente : IConsumer
{
    // TODO implementa el patron de diseño Facade
    public void runClient()
    {

        Console.WriteLine("Ejecución Facade2Cliente.");

        FileManager fileManager = new FileManager();
        AudioProcessor audioProcessor = new AudioProcessor(fileManager);
        ImageProcessor imageProcessor = new ImageProcessor(fileManager);
        VideoConverter videoConverter = new VideoConverter(audioProcessor, imageProcessor);

        string file = "vide.mp4";

        videoConverter.Convert(file);
        
    }
}