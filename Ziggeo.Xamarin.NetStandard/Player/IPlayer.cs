using System.Threading.Tasks;

namespace Ziggeo
{
    public interface IPlayer
    {
        Task StartPlayer(string videoToken);
    }
}