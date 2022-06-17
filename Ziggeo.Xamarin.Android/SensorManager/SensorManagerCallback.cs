using System;
using Java.Interop;
using System.Collections.Generic;
using Java.Lang;

namespace Ziggeo
{
    public class SensorManagerCallback : Com.Ziggeo.Androidsdk.SensorManager.ICallback
    {
        public ISensorManagerEventsListener EventsListener { get; set; }

        public SensorManagerCallback(ISensorManagerEventsListener eventsListener)
        {
            EventsListener = eventsListener;
        }

        public void LightSensorLevel(float level)
        {
            EventsListener.InvokeLightLevel(level);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IntPtr Handle { get; }

        public void SetJniIdentityHashCode(int value)
        {
            throw new NotImplementedException();
        }

        public void SetPeerReference(JniObjectReference reference)
        {
            throw new NotImplementedException();
        }

        public void SetJniManagedPeerState(JniManagedPeerStates value)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFromRuntime()
        {
            throw new NotImplementedException();
        }

        public void DisposeUnlessReferenced()
        {
            throw new NotImplementedException();
        }

        public void Disposed()
        {
            throw new NotImplementedException();
        }

        public void Finalized()
        {
            throw new NotImplementedException();
        }

        public int JniIdentityHashCode { get; }
        public JniObjectReference PeerReference { get; }
        public JniPeerMembers JniPeerMembers { get; }
        public JniManagedPeerStates JniManagedPeerState { get; }
    }
}