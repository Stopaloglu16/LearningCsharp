namespace ConsoleAppFileDirectories.Methods
{
    public class ReadCsvFile
    {
        public static void Create(string fileFolder)
        {
            // Take a snapshot of the file system.  
            DirectoryInfo dir = new DirectoryInfo(fileFolder);

            // This method assumes that the application has discovery permissions  
            // for all folders under the specified path.  
            IEnumerable<FileInfo> fileList = dir.GetFiles("*.csv", SearchOption.AllDirectories);

            //Create the query  
            IEnumerable<FileInfo> fileQuery =
                from file in fileList
                    //where file.Extension == ".txt"
                orderby file.Name
                select file;


            foreach (FileInfo file in fileQuery)
            {
                ReadFileLines(file.FullName);
            }
        }

        static void ReadFileLines(string fileFolder)
        {
            string[] lines = System.IO.File.ReadAllLines(fileFolder);

            var columnQuery = from line in lines
                              let elements = line.Split(',')
                              select elements;

            foreach (var item in columnQuery)
            {
                Console.WriteLine("TrackingNo {0}, Code {1}, datetime {2}, location {3}", item[0], item[1], item[3], item[4]);
            }
        }

    }
}
