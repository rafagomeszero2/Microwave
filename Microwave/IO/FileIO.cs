using System.IO;

namespace Microwave.IO
{
    public class FileIO
    {
        public static bool IsFile(string text)
        {
            try
            {
                using (StreamReader sr = File.OpenText(text))
                {
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }

        public static string ReadFile(string text)
        {
            try
            {
                using (StreamReader sr = File.OpenText(text))
                {
                    return sr.ReadLine();
                }
            }
            catch (FileNotFoundException e)
            {
                return ("Arquivo não encontrado." + e.Message);
            }
        }
    }
}
