// Parallel Programming: For CPU intensive tasks
// TPL - Task Parallel Library
// Threads, Tasks

using System;
using System.Threading;
using System.Threading.Tasks;

class ParallelLearner
{
    public void Learn()
    {
        string[] names = ["Ram", "Bishnu", "Sapana", "Harendra", "Ritesh"];
        // Sequential
        Console.WriteLine("Sequential Loop");
        foreach (var name in names)
        {
            // Name printing
            Thread.Sleep(1000);
            Console.WriteLine(name);
        }

        Console.WriteLine("Parallel Loop");
        Parallel.ForEach(names, name =>
        {
            // Name printing
            Thread.Sleep(1000);
            Console.WriteLine(name);
        });
    }
}

// Asynchronous Programming: I/O bound, Scaling
// async, await
class AsyncLearner
{
    async Task MakeTea()
    {
        await IgniteBurner();
        await GrindMasala();
        await PourMilk();
    }

    async Task IgniteBurner()
    {
        await Task.Delay(1000);
    }

    async Task GrindMasala()
    {
        await Task.Delay(1000);
    }

    async Task PourMilk()
    {        
        await Task.Delay(1000);
    }
}
