using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public interface IZiggeoPlayer
    {
        Dictionary<string, string> AdditionalParameters
        {
            get;
            set;
        }

        Task Play(string videoToken);
    }
}
