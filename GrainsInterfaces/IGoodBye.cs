using System.Threading.Tasks;

namespace OrleansBasics
{
    public interface IGoodBye : Orleans.IGrainWithIntegerKey
    {
        Task<string> SayGoodbye(string farewell);
    }
}