namespace Ziggeo.Services
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