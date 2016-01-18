namespace tastFrom1to4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path firstPath)
        {
            try
            {
                StreamWriter save = new StreamWriter(@"..\..\fileFolder\PathStorage.txt", false, Encoding.GetEncoding("UTF-8"));
                using (save)
                {
                    foreach (var path in firstPath.GetListPath())
                    {
                        save.WriteLine(path);
                    }
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ivalid input");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Can not find file!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid directory in the file path!");
            }
            catch (IOException)
            {
                Console.WriteLine("Can not open the file!");
            }
            catch (Exception)
            {
                Console.WriteLine("Fatal Error!!!");
            }
        }

        public static string LoadPath()
        {
            try
            {
                StreamReader load = new StreamReader(@"..\..\fileFolder\PathStorage.txt", Encoding.GetEncoding("UTF-8"));
                
                using (load)
                {
                    StringBuilder line = new StringBuilder();
                    line.Append(load.ReadToEnd());

                    return line.ToString();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ivalid input");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Can not find file!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid directory in the file path!");
            }
            catch (IOException)
            {
                Console.WriteLine("Can not open the file!");
            }
            catch (Exception)
            {
                Console.WriteLine("Fatal Error!!!");
            }

            return string.Empty;
        }
                
    }
}
