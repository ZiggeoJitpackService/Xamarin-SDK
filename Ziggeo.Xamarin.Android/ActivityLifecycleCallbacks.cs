using System;
using Android.App;
using Android.OS;

namespace Ziggeo
{
    public class ActivityLifecycleCallbacks : Java.Lang.Object, Application.IActivityLifecycleCallbacks
    {
        public Action<Activity, Bundle> OnCreated { get; set; }
        public Action<Activity> OnDestroyed = null;
        public Action<Activity> OnPaused = null;
        public Action<Activity> OnResumed = null;
        public Action<Activity, Bundle> OnSavedInstanceState = null;
        public Action<Activity> OnStarted = null;
        public Action<Activity> OnStopped = null;

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            OnCreated?.Invoke(activity, savedInstanceState);
        }

        public void OnActivityDestroyed(Activity activity)
        {
            OnDestroyed?.Invoke(activity);
        }

        public void OnActivityPaused(Activity activity)
        {
            OnPaused?.Invoke(activity);
        }

        public void OnActivityResumed(Activity activity)
        {
            OnResumed?.Invoke(activity);
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
            OnSavedInstanceState?.Invoke(activity, outState);
        }

        public void OnActivityStarted(Activity activity)
        {
            OnStarted?.Invoke(activity);
        }

        public void OnActivityStopped(Activity activity)
        {
            OnStopped?.Invoke(activity);
        }
    }
}