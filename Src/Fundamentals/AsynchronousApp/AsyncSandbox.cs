using System.Text;

namespace AsynchronousApp
{
    public class AsyncSandbox
    {

        public async Task StartSandbox(CancellationToken token)
        {

            
            IEnumerable<Task> tasks = new List<Task>()
            {
                Process1(token), Process2(token)
            };

            await Task.WhenAll(tasks);

            //await Process1();

            //await Process2();

            ProcessHelp();
        }

        public async Task Process1(CancellationToken cancellationToken)
        {

            string fileName = @"..\Process1.txt";

            Console.WriteLine("Process 1 started");

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    for (int i = 0; i < 15; i++)
                    {
                        await Task.Delay(300);

                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append($"hello {i.ToString()} {DateTime.Now.ToString()}");
                        await writer.WriteLineAsync(stringBuilder, cancellationToken);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public async Task Process2(CancellationToken cancellationToken)
        {
            string fileName = @"..\Process2.txt";
            Console.WriteLine("Process 2 started");

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    for (int i = 0; i < 15; i++)
                    {
                        await Task.Delay(500);

                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append($"hello {i.ToString()} {DateTime.Now.ToString()}");
                        await writer.WriteLineAsync(stringBuilder, cancellationToken);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void ProcessHelp()
        {
            string fileName = @"..\ProcessHelp.txt";
            Console.WriteLine("Process help started");

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Task.Delay(500).Wait();
                        writer.WriteLine($"hello {i.ToString()} {DateTime.Now.ToString()}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }


}
