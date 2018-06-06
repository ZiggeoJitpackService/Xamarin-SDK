using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;
using Android.Content;
using Com.Ziggeo.Androidsdk;

namespace Ziggeo
{
    public class BaseService
    {
        public BaseService(string token, Context context)
        {
            this.Ziggeo = new Com.Ziggeo.Androidsdk.Ziggeo(token, context);
        }

        public IZiggeo Ziggeo { get; private set; }
    }
}