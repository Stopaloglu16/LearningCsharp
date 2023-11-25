namespace ConsoleAppFileDirectories.Methods
{
    public class FindFileByExtension
    {
        public static void Create(string fileFolder)
        {

            // Take a snapshot of the file system.  
            DirectoryInfo dir = new DirectoryInfo(fileFolder);

            // This method assumes that the application has discovery permissions  
            // for all folders under the specified path.  
            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

            //Create the query  
            IEnumerable<FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".txt"
                orderby file.Name
                select file;

            //Execute the query. This might write out a lot of files!  
            foreach (FileInfo fi in fileQuery)
            {
                Console.WriteLine("Name:{0} Size:{1}", fi.Name, fi.Length);
            }

            // Create and execute a new query by using the previous
            // query as a starting point. fileQuery is not
            // executed again until the call to Last()  
            var newestFile =
                (from file in fileQuery
                 orderby file.CreationTime
                 select new { file.FullName, file.CreationTime })
                .Last();

            Console.WriteLine("\r\nThe newest .txt file is {0}. Creation time: {1}",
                newestFile.FullName, newestFile.CreationTime);
        }

    }
}
