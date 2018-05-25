using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Recording {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/class[@name='VideoRecordingCallback']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/recording/VideoRecordingCallback", DoNotGenerateAcw=true)]
	public abstract partial class VideoRecordingCallback : global::Java.Lang.Object, global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/recording/VideoRecordingCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoRecordingCallback); }
		}

		protected VideoRecordingCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/class[@name='VideoRecordingCallback']/constructor[@name='VideoRecordingCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoRecordingCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VideoRecordingCallback)) {
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

		static Delegate cb_onError;
#pragma warning disable 0169
		static Delegate GetOnErrorHandler ()
		{
			if (cb_onError == null)
				cb_onError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnError);
			return cb_onError;
		}

		static void n_OnError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError ();
		}
#pragma warning restore 0169

		static IntPtr id_onError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/class[@name='VideoRecordingCallback']/method[@name='onError' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("onError", "()V", "GetOnErrorHandler")]
		public virtual unsafe void OnError ()
		{
			if (id_onError == IntPtr.Zero)
				id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "()V"));
			} finally {
			}
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/class[@name='VideoRecordingCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStarted;
#pragma warning disable 0169
		static Delegate GetOnStartedHandler ()
		{
			if (cb_onStarted == null)
				cb_onStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStarted);
			return cb_onStarted;
		}

		static void n_OnStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_onStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/class[@name='VideoRecordingCallback']/method[@name='onStarted' and count(parameter)=0]"
		[Register ("onStarted", "()V", "GetOnStartedHandler")]
		public virtual unsafe void OnStarted ()
		{
			if (id_onStarted == IntPtr.Zero)
				id_onStarted = JNIEnv.GetMethodID (class_ref, "onStarted", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStarted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStarted", "()V"));
			} finally {
			}
		}

		static Delegate cb_onStopped_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnStopped_Ljava_lang_String_Handler ()
		{
			if (cb_onStopped_Ljava_lang_String_ == null)
				cb_onStopped_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStopped_Ljava_lang_String_);
			return cb_onStopped_Ljava_lang_String_;
		}

		static void n_OnStopped_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.VideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStopped_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/class[@name='VideoRecordingCallback']/method[@name='onStopped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStopped", "(Ljava/lang/String;)V", "GetOnStopped_Ljava_lang_String_Handler")]
		public virtual unsafe void OnStopped (string p0)
		{
			if (id_onStopped_Ljava_lang_String_ == IntPtr.Zero)
				id_onStopped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStopped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopped_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStopped", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/recording/VideoRecordingCallback", DoNotGenerateAcw=true)]
	internal partial class VideoRecordingCallbackInvoker : VideoRecordingCallback {

		public VideoRecordingCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoRecordingCallbackInvoker); }
		}

	}

}
