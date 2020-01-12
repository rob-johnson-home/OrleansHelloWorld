using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace OrleansBasics
{
    public class GoodByeGrain : Orleans.Grain, IGoodBye
    {
        private readonly ILogger logger;

        public GoodByeGrain(ILogger<IGoodBye> logger)
        {
            this.logger = logger;
        }

        Task<string> IGoodBye.SayGoodbye(string farewell)
        {
            logger.LogInformation($"\n SayGoodBye message received: farewell = '{farewell}'");
            return Task.FromResult($"\n Client said: '{farewell}', so HelloGrain says: Hello!");
        }
    }
}

