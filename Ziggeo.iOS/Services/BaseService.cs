using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Ziggeo
{
    public class BaseService
    {
        public BaseService(ZiggeoConnect connection)
        {
            this.Connection = connection;
        }

        public ZiggeoConnect Connection { get; private set; }
    }
}