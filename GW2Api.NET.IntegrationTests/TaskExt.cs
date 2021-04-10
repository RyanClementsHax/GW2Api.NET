using System.Collections.Generic;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests
{
    public static class TaskExt
    {
        public static IAsyncEnumerable<T> Race<T>(this IEnumerable<Task<T>> tasks)
        {
            var channel = Channel.CreateUnbounded<T>();

            Task.Run(async () =>
            {
                foreach (var task in tasks)
                {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                    task.ContinueWith(async x => await channel.Writer.WriteAsync(await x), CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                    await Task.Delay(120);
                }
            });

            return channel.Reader.ReadAllAsync();
        }
    }
}
