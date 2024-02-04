namespace AsynchronousApp
{
    public class AsynchronousBreakfast
    {

        internal class Bacon { }
        internal class Coffee { }
        internal class Egg { }
        internal class Juice { }
        internal class Toast { }

        public static async Task Create()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine($"coffee async is ready {DateTime.Now.Millisecond}");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine($"eggs are ready {DateTime.Now.Millisecond}");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine($"bacon is ready {DateTime.Now.Millisecond}");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine($"toast is ready {DateTime.Now.Millisecond}");
                }
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine($"oj is ready {DateTime.Now.Millisecond}");
            Console.WriteLine($"Breakfast is ready! {DateTime.Now.Millisecond}");
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine($"Pouring orange juice {DateTime.Now.Millisecond}");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine($"Putting jam on the toast {DateTime.Now.Millisecond}");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine($"Putting butter on the toast {DateTime.Now.Millisecond}");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"Putting a slice of bread in the toaster {DateTime.Now.Millisecond}");
            }
            Console.WriteLine($"Start toasting... {DateTime.Now.Millisecond}");
            await Task.Delay(6000);
            Console.WriteLine($"Remove toast from toaster {DateTime.Now.Millisecond}");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan {DateTime.Now.Millisecond}");
            Console.WriteLine($"cooking first side of bacon... {DateTime.Now.Millisecond}");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"flipping a slice of bacon {DateTime.Now.Millisecond}");
            }
            Console.WriteLine($"cooking the second side of bacon... {DateTime.Now.Millisecond}");
            await Task.Delay(4000);
            Console.WriteLine($"Put bacon on plate {DateTime.Now.Millisecond}");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine($"Warming the egg pan... {DateTime.Now.Millisecond}");
            await Task.Delay(5000);
            Console.WriteLine($"cracking {howMany} eggs {DateTime.Now.Millisecond}");
            Console.WriteLine($"cooking the eggs ... {DateTime.Now.Millisecond}");
            await Task.Delay(10000);
            Console.WriteLine($"Put eggs on plate {DateTime.Now.Millisecond}");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine($"Pouring coffee {DateTime.Now.Millisecond}");
            return new Coffee();
        }


    }
}
