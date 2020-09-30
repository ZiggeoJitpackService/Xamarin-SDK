using System.Collections.Generic;

namespace Ziggeo
{
    public static class LogModelMapper
    {
        public static IList<Com.Ziggeo.Androidsdk.Log.LogModel> Map(IList<LogModel> logModels)
        {
            IList<Com.Ziggeo.Androidsdk.Log.LogModel> nativeLogsList = new List<Com.Ziggeo.Androidsdk.Log.LogModel>();
            foreach (LogModel logModel in logModels)
            {
                nativeLogsList.Add(new Com.Ziggeo.Androidsdk.Log.LogModel(
                    logModel.Timestamp, logModel.Name, logModel.Details
                ));
            }

            return nativeLogsList;
        }
    }
}