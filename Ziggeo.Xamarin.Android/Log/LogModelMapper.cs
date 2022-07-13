using System.Collections.Generic;

namespace Ziggeo
{
    public static class LogModelMapper
    {
        public static IList<string> Map(IList<LogModel> logModels)
        {
            IList<string> nativeLogsList = new List<string>();
            foreach (LogModel logModel in logModels)
            {
                nativeLogsList.Add(logModel.FormattedOutput);
            }

            return nativeLogsList;
        }
    }
}