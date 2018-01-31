using System;
using System.Threading.Tasks;

namespace Ziggeo
{
    public interface IZiggeoPlayer
    {
        Task Play(string videoToken);
    }
}
