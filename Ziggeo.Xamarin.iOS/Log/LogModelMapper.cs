using Foundation;
using System.Collections.Generic;

namespace Ziggeo
{
    public static class LogModelMapper
    {
        public static NSObject[] Map(IList<LogModel> logModels)
        {
            NSObject[] nativeLogsList = new NSObject[logModels.Count];
            for (uint i = 0; i < logModels.Count; i++)
                foreach (LogModel logModel in logModels)
            {
                NSString item = new NSString(logModel.FormattedOutput);
                nativeLogsList[i] = item;
            }

            return nativeLogsList;
        }
    }
}