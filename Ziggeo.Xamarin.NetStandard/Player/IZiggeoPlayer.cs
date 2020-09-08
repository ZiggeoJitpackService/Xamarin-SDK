using System.Threading.Tasks;

namespace Ziggeo
{
    public interface IZiggeoPlayer
    {
        Task StartPlayer(string videoToken);
    }
}