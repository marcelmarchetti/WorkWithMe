using System.Reflection;

namespace WorkWithMe.Controller;

public class ImageController
{
    public static Image? LoadEmbeddedImage(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourcePath = assembly.GetManifestResourceNames()
            .FirstOrDefault(name => name.EndsWith(resourceName, StringComparison.OrdinalIgnoreCase));

        if (resourcePath != null)
        {
            using (Stream? stream = assembly.GetManifestResourceStream(resourcePath))
            {
                if (stream != null)
                {
                    Console.WriteLine($"Se encontro: {resourceName}");
                    return Image.FromStream(stream);
                }
            }
        }

        Console.WriteLine($"No se encontró el recurso: {resourceName}");
        return null;
    }
}