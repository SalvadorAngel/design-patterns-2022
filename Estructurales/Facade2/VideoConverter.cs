public class VideoConverter{

    private AudioProcessor audioProcessor { get; set; }
    private ImageProcessor imageProcessor { get; set; }

    public VideoConverter(AudioProcessor audioProcessor, ImageProcessor imageProcessor)
    {
        this.audioProcessor = audioProcessor;
        this.imageProcessor = imageProcessor;
    }


    public void Convert(string file){
        Console.WriteLine($"Procesando {file}");
        audioProcessor.Process();
        imageProcessor.Process();
        Console.WriteLine($"Se termino de procesar {file}");
    }

}