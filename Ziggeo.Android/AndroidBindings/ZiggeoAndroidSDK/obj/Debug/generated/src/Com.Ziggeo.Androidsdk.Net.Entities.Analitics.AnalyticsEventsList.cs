using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Entities.Analitics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventsList']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventsList", DoNotGenerateAcw=true)]
	public partial class AnalyticsEventsList : global::Com.Ziggeo.Androidsdk.Net.Entities.BaseEntity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventsList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnalyticsEventsList); }
		}

		protected AnalyticsEventsList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventsList']/constructor[@name='AnalyticsEventsList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnalyticsEventsList ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AnalyticsEventsList)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getEventsList;
#pragma warning disable 0169
		static Delegate GetGetEventsListHandler ()
		{
			if (cb_getEventsList == null)
				cb_getEventsList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventsList);
			return cb_getEventsList;
		}

		static IntPtr n_GetEventsList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventsList __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventsList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity>.ToLocalJniHandle (__this.EventsList);
		}
#pragma warning restore 0169

		static IntPtr id_getEventsList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity> EventsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventsList']/method[@name='getEventsList' and count(parameter)=0]"
			[Register ("getEventsList", "()Ljava/util/List;", "GetGetEventsListHandler")]
			get {
				if (id_getEventsList == IntPtr.Zero)
					id_getEventsList = JNIEnv.GetMethodID (class_ref, "getEventsList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventsList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventsList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setEvents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEvents_Ljava_util_List_Handler ()
		{
			if (cb_setEvents_Ljava_util_List_ == null)
				cb_setEvents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvents_Ljava_util_List_);
			return cb_setEvents_Ljava_util_List_;
		}

		static void n_SetEvents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventsList __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventsList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEvents (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEvents_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventsList']/method[@name='setEvents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ziggeo.androidsdk.net.entities.analitics.AnalyticsEventEntity&gt;']]"
		[Register ("setEvents", "(Ljava/util/List;)V", "GetSetEvents_Ljava_util_List_Handler")]
		public virtual unsafe void SetEvents (global::System.Collections.Generic.IList<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity> p0)
		{
			if (id_setEvents_Ljava_util_List_ == IntPtr.Zero)
				id_setEvents_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setEvents", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEvents_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEvents", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
