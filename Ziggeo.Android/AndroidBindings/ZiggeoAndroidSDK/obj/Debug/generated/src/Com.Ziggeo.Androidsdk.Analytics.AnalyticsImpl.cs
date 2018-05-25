using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/analytics/AnalyticsImpl", DoNotGenerateAcw=true)]
	public partial class AnalyticsImpl : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/analytics/AnalyticsImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnalyticsImpl); }
		}

		protected AnalyticsImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/constructor[@name='AnalyticsImpl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe AnalyticsImpl (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AnalyticsImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getEvents;
#pragma warning disable 0169
		static Delegate GetGetEventsHandler ()
		{
			if (cb_getEvents == null)
				cb_getEvents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEvents);
			return cb_getEvents;
		}

		static IntPtr n_GetEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Events);
		}
#pragma warning restore 0169

		static IntPtr id_getEvents;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventsList Events {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='getEvents' and count(parameter)=0]"
			[Register ("getEvents", "()Lcom/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventsList;", "GetGetEventsHandler")]
			get {
				if (id_getEvents == IntPtr.Zero)
					id_getEvents = JNIEnv.GetMethodID (class_ref, "getEvents", "()Lcom/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventsList;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventsList> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEvents), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventsList> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEvents", "()Lcom/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventsList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addCoverSelectEvent_I;
#pragma warning disable 0169
		static Delegate GetAddCoverSelectEvent_IHandler ()
		{
			if (cb_addCoverSelectEvent_I == null)
				cb_addCoverSelectEvent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AddCoverSelectEvent_I);
			return cb_addCoverSelectEvent_I;
		}

		static void n_AddCoverSelectEvent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddCoverSelectEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCoverSelectEvent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addCoverSelectEvent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addCoverSelectEvent", "(I)V", "GetAddCoverSelectEvent_IHandler")]
		public virtual unsafe void AddCoverSelectEvent (int p0)
		{
			if (id_addCoverSelectEvent_I == IntPtr.Zero)
				id_addCoverSelectEvent_I = JNIEnv.GetMethodID (class_ref, "addCoverSelectEvent", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCoverSelectEvent_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCoverSelectEvent", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addCoverSkipEvent;
#pragma warning disable 0169
		static Delegate GetAddCoverSkipEventHandler ()
		{
			if (cb_addCoverSkipEvent == null)
				cb_addCoverSkipEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddCoverSkipEvent);
			return cb_addCoverSkipEvent;
		}

		static void n_AddCoverSkipEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddCoverSkipEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addCoverSkipEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addCoverSkipEvent' and count(parameter)=0]"
		[Register ("addCoverSkipEvent", "()V", "GetAddCoverSkipEventHandler")]
		public virtual unsafe void AddCoverSkipEvent ()
		{
			if (id_addCoverSkipEvent == IntPtr.Zero)
				id_addCoverSkipEvent = JNIEnv.GetMethodID (class_ref, "addCoverSkipEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCoverSkipEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCoverSkipEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addEmbeddingPlayerLoadedEvent;
#pragma warning disable 0169
		static Delegate GetAddEmbeddingPlayerLoadedEventHandler ()
		{
			if (cb_addEmbeddingPlayerLoadedEvent == null)
				cb_addEmbeddingPlayerLoadedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddEmbeddingPlayerLoadedEvent);
			return cb_addEmbeddingPlayerLoadedEvent;
		}

		static void n_AddEmbeddingPlayerLoadedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddEmbeddingPlayerLoadedEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addEmbeddingPlayerLoadedEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addEmbeddingPlayerLoadedEvent' and count(parameter)=0]"
		[Register ("addEmbeddingPlayerLoadedEvent", "()V", "GetAddEmbeddingPlayerLoadedEventHandler")]
		public virtual unsafe void AddEmbeddingPlayerLoadedEvent ()
		{
			if (id_addEmbeddingPlayerLoadedEvent == IntPtr.Zero)
				id_addEmbeddingPlayerLoadedEvent = JNIEnv.GetMethodID (class_ref, "addEmbeddingPlayerLoadedEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEmbeddingPlayerLoadedEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEmbeddingPlayerLoadedEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addEmbeddingRecorderLoadedEvent;
#pragma warning disable 0169
		static Delegate GetAddEmbeddingRecorderLoadedEventHandler ()
		{
			if (cb_addEmbeddingRecorderLoadedEvent == null)
				cb_addEmbeddingRecorderLoadedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddEmbeddingRecorderLoadedEvent);
			return cb_addEmbeddingRecorderLoadedEvent;
		}

		static void n_AddEmbeddingRecorderLoadedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddEmbeddingRecorderLoadedEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addEmbeddingRecorderLoadedEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addEmbeddingRecorderLoadedEvent' and count(parameter)=0]"
		[Register ("addEmbeddingRecorderLoadedEvent", "()V", "GetAddEmbeddingRecorderLoadedEventHandler")]
		public virtual unsafe void AddEmbeddingRecorderLoadedEvent ()
		{
			if (id_addEmbeddingRecorderLoadedEvent == IntPtr.Zero)
				id_addEmbeddingRecorderLoadedEvent = JNIEnv.GetMethodID (class_ref, "addEmbeddingRecorderLoadedEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEmbeddingRecorderLoadedEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEmbeddingRecorderLoadedEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_;
#pragma warning disable 0169
		static Delegate GetAddEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_Handler ()
		{
			if (cb_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_ == null)
				cb_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_);
			return cb_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_;
		}

		static void n_AddEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addEvent' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.net.entities.analitics.AnalyticsEventEntity']]"
		[Register ("addEvent", "(Lcom/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventEntity;)V", "GetAddEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_Handler")]
		public virtual unsafe void AddEvent (global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity p0)
		{
			if (id_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_ == IntPtr.Zero)
				id_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_ = JNIEnv.GetMethodID (class_ref, "addEvent", "(Lcom/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventEntity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEvent_Lcom_ziggeo_androidsdk_net_entities_analitics_AnalyticsEventEntity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEvent", "(Lcom/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventEntity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addInitAnalyticsEventToQueue;
#pragma warning disable 0169
		static Delegate GetAddInitAnalyticsEventToQueueHandler ()
		{
			if (cb_addInitAnalyticsEventToQueue == null)
				cb_addInitAnalyticsEventToQueue = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddInitAnalyticsEventToQueue);
			return cb_addInitAnalyticsEventToQueue;
		}

		static void n_AddInitAnalyticsEventToQueue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddInitAnalyticsEventToQueue ();
		}
#pragma warning restore 0169

		static IntPtr id_addInitAnalyticsEventToQueue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addInitAnalyticsEventToQueue' and count(parameter)=0]"
		[Register ("addInitAnalyticsEventToQueue", "()V", "GetAddInitAnalyticsEventToQueueHandler")]
		public virtual unsafe void AddInitAnalyticsEventToQueue ()
		{
			if (id_addInitAnalyticsEventToQueue == IntPtr.Zero)
				id_addInitAnalyticsEventToQueue = JNIEnv.GetMethodID (class_ref, "addInitAnalyticsEventToQueue", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addInitAnalyticsEventToQueue);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addInitAnalyticsEventToQueue", "()V"));
			} finally {
			}
		}

		static Delegate cb_addPlayerEndEvent;
#pragma warning disable 0169
		static Delegate GetAddPlayerEndEventHandler ()
		{
			if (cb_addPlayerEndEvent == null)
				cb_addPlayerEndEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddPlayerEndEvent);
			return cb_addPlayerEndEvent;
		}

		static void n_AddPlayerEndEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPlayerEndEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addPlayerEndEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addPlayerEndEvent' and count(parameter)=0]"
		[Register ("addPlayerEndEvent", "()V", "GetAddPlayerEndEventHandler")]
		public virtual unsafe void AddPlayerEndEvent ()
		{
			if (id_addPlayerEndEvent == IntPtr.Zero)
				id_addPlayerEndEvent = JNIEnv.GetMethodID (class_ref, "addPlayerEndEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPlayerEndEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPlayerEndEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addPlayerPauseEvent;
#pragma warning disable 0169
		static Delegate GetAddPlayerPauseEventHandler ()
		{
			if (cb_addPlayerPauseEvent == null)
				cb_addPlayerPauseEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddPlayerPauseEvent);
			return cb_addPlayerPauseEvent;
		}

		static void n_AddPlayerPauseEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPlayerPauseEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addPlayerPauseEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addPlayerPauseEvent' and count(parameter)=0]"
		[Register ("addPlayerPauseEvent", "()V", "GetAddPlayerPauseEventHandler")]
		public virtual unsafe void AddPlayerPauseEvent ()
		{
			if (id_addPlayerPauseEvent == IntPtr.Zero)
				id_addPlayerPauseEvent = JNIEnv.GetMethodID (class_ref, "addPlayerPauseEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPlayerPauseEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPlayerPauseEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addPlayerPlayingEvent;
#pragma warning disable 0169
		static Delegate GetAddPlayerPlayingEventHandler ()
		{
			if (cb_addPlayerPlayingEvent == null)
				cb_addPlayerPlayingEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddPlayerPlayingEvent);
			return cb_addPlayerPlayingEvent;
		}

		static void n_AddPlayerPlayingEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPlayerPlayingEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addPlayerPlayingEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addPlayerPlayingEvent' and count(parameter)=0]"
		[Register ("addPlayerPlayingEvent", "()V", "GetAddPlayerPlayingEventHandler")]
		public virtual unsafe void AddPlayerPlayingEvent ()
		{
			if (id_addPlayerPlayingEvent == IntPtr.Zero)
				id_addPlayerPlayingEvent = JNIEnv.GetMethodID (class_ref, "addPlayerPlayingEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPlayerPlayingEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPlayerPlayingEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addPlayerSeekEvent;
#pragma warning disable 0169
		static Delegate GetAddPlayerSeekEventHandler ()
		{
			if (cb_addPlayerSeekEvent == null)
				cb_addPlayerSeekEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddPlayerSeekEvent);
			return cb_addPlayerSeekEvent;
		}

		static void n_AddPlayerSeekEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPlayerSeekEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addPlayerSeekEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addPlayerSeekEvent' and count(parameter)=0]"
		[Register ("addPlayerSeekEvent", "()V", "GetAddPlayerSeekEventHandler")]
		public virtual unsafe void AddPlayerSeekEvent ()
		{
			if (id_addPlayerSeekEvent == IntPtr.Zero)
				id_addPlayerSeekEvent = JNIEnv.GetMethodID (class_ref, "addPlayerSeekEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPlayerSeekEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPlayerSeekEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addPlayerStartEvent;
#pragma warning disable 0169
		static Delegate GetAddPlayerStartEventHandler ()
		{
			if (cb_addPlayerStartEvent == null)
				cb_addPlayerStartEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddPlayerStartEvent);
			return cb_addPlayerStartEvent;
		}

		static void n_AddPlayerStartEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPlayerStartEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addPlayerStartEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addPlayerStartEvent' and count(parameter)=0]"
		[Register ("addPlayerStartEvent", "()V", "GetAddPlayerStartEventHandler")]
		public virtual unsafe void AddPlayerStartEvent ()
		{
			if (id_addPlayerStartEvent == IntPtr.Zero)
				id_addPlayerStartEvent = JNIEnv.GetMethodID (class_ref, "addPlayerStartEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPlayerStartEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPlayerStartEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addRecordEndEvent;
#pragma warning disable 0169
		static Delegate GetAddRecordEndEventHandler ()
		{
			if (cb_addRecordEndEvent == null)
				cb_addRecordEndEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddRecordEndEvent);
			return cb_addRecordEndEvent;
		}

		static void n_AddRecordEndEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddRecordEndEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addRecordEndEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addRecordEndEvent' and count(parameter)=0]"
		[Register ("addRecordEndEvent", "()V", "GetAddRecordEndEventHandler")]
		public virtual unsafe void AddRecordEndEvent ()
		{
			if (id_addRecordEndEvent == IntPtr.Zero)
				id_addRecordEndEvent = JNIEnv.GetMethodID (class_ref, "addRecordEndEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRecordEndEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRecordEndEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addRecordStartEvent;
#pragma warning disable 0169
		static Delegate GetAddRecordStartEventHandler ()
		{
			if (cb_addRecordStartEvent == null)
				cb_addRecordStartEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddRecordStartEvent);
			return cb_addRecordStartEvent;
		}

		static void n_AddRecordStartEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddRecordStartEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addRecordStartEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addRecordStartEvent' and count(parameter)=0]"
		[Register ("addRecordStartEvent", "()V", "GetAddRecordStartEventHandler")]
		public virtual unsafe void AddRecordStartEvent ()
		{
			if (id_addRecordStartEvent == IntPtr.Zero)
				id_addRecordStartEvent = JNIEnv.GetMethodID (class_ref, "addRecordStartEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRecordStartEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRecordStartEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addUploadingEndEvent;
#pragma warning disable 0169
		static Delegate GetAddUploadingEndEventHandler ()
		{
			if (cb_addUploadingEndEvent == null)
				cb_addUploadingEndEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddUploadingEndEvent);
			return cb_addUploadingEndEvent;
		}

		static void n_AddUploadingEndEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddUploadingEndEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addUploadingEndEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addUploadingEndEvent' and count(parameter)=0]"
		[Register ("addUploadingEndEvent", "()V", "GetAddUploadingEndEventHandler")]
		public virtual unsafe void AddUploadingEndEvent ()
		{
			if (id_addUploadingEndEvent == IntPtr.Zero)
				id_addUploadingEndEvent = JNIEnv.GetMethodID (class_ref, "addUploadingEndEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addUploadingEndEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addUploadingEndEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_addUploadingStartEvent;
#pragma warning disable 0169
		static Delegate GetAddUploadingStartEventHandler ()
		{
			if (cb_addUploadingStartEvent == null)
				cb_addUploadingStartEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddUploadingStartEvent);
			return cb_addUploadingStartEvent;
		}

		static void n_AddUploadingStartEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddUploadingStartEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_addUploadingStartEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='addUploadingStartEvent' and count(parameter)=0]"
		[Register ("addUploadingStartEvent", "()V", "GetAddUploadingStartEventHandler")]
		public virtual unsafe void AddUploadingStartEvent ()
		{
			if (id_addUploadingStartEvent == IntPtr.Zero)
				id_addUploadingStartEvent = JNIEnv.GetMethodID (class_ref, "addUploadingStartEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addUploadingStartEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addUploadingStartEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_applyAppToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetApplyAppToken_Ljava_lang_String_Handler ()
		{
			if (cb_applyAppToken_Ljava_lang_String_ == null)
				cb_applyAppToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplyAppToken_Ljava_lang_String_);
			return cb_applyAppToken_Ljava_lang_String_;
		}

		static void n_ApplyAppToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplyAppToken (p0);
		}
#pragma warning restore 0169

		static IntPtr id_applyAppToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='applyAppToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("applyAppToken", "(Ljava/lang/String;)V", "GetApplyAppToken_Ljava_lang_String_Handler")]
		public virtual unsafe void ApplyAppToken (string p0)
		{
			if (id_applyAppToken_Ljava_lang_String_ == IntPtr.Zero)
				id_applyAppToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "applyAppToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyAppToken_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyAppToken", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onBecomeBackground;
#pragma warning disable 0169
		static Delegate GetOnBecomeBackgroundHandler ()
		{
			if (cb_onBecomeBackground == null)
				cb_onBecomeBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBecomeBackground);
			return cb_onBecomeBackground;
		}

		static void n_OnBecomeBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBecomeBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_onBecomeBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='onBecomeBackground' and count(parameter)=0]"
		[Register ("onBecomeBackground", "()V", "GetOnBecomeBackgroundHandler")]
		public virtual unsafe void OnBecomeBackground ()
		{
			if (id_onBecomeBackground == IntPtr.Zero)
				id_onBecomeBackground = JNIEnv.GetMethodID (class_ref, "onBecomeBackground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBecomeBackground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBecomeBackground", "()V"));
			} finally {
			}
		}

		static Delegate cb_onBecomeForeground;
#pragma warning disable 0169
		static Delegate GetOnBecomeForegroundHandler ()
		{
			if (cb_onBecomeForeground == null)
				cb_onBecomeForeground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBecomeForeground);
			return cb_onBecomeForeground;
		}

		static void n_OnBecomeForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Analytics.AnalyticsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBecomeForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_onBecomeForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.analytics']/class[@name='AnalyticsImpl']/method[@name='onBecomeForeground' and count(parameter)=0]"
		[Register ("onBecomeForeground", "()V", "GetOnBecomeForegroundHandler")]
		public virtual unsafe void OnBecomeForeground ()
		{
			if (id_onBecomeForeground == IntPtr.Zero)
				id_onBecomeForeground = JNIEnv.GetMethodID (class_ref, "onBecomeForeground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBecomeForeground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBecomeForeground", "()V"));
			} finally {
			}
		}

	}
}
