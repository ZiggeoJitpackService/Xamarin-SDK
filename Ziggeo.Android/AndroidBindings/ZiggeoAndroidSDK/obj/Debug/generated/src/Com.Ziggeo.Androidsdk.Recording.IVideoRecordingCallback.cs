using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Recording {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/interface[@name='IVideoRecordingCallback']"
	[Register ("com/ziggeo/androidsdk/recording/IVideoRecordingCallback", "", "Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallbackInvoker")]
	public partial interface IVideoRecordingCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/interface[@name='IVideoRecordingCallback']/method[@name='onError' and count(parameter)=0]"
[Obsolete (@"deprecated")]
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallbackInvoker, ZiggeoAndroidSDK")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/interface[@name='IVideoRecordingCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallbackInvoker, ZiggeoAndroidSDK")]
		void OnError (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/interface[@name='IVideoRecordingCallback']/method[@name='onStarted' and count(parameter)=0]"
		[Register ("onStarted", "()V", "GetOnStartedHandler:Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallbackInvoker, ZiggeoAndroidSDK")]
		void OnStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.recording']/interface[@name='IVideoRecordingCallback']/method[@name='onStopped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStopped", "(Ljava/lang/String;)V", "GetOnStopped_Ljava_lang_String_Handler:Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallbackInvoker, ZiggeoAndroidSDK")]
		void OnStopped (string p0);

	}

	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/recording/IVideoRecordingCallback", DoNotGenerateAcw=true)]
	internal class IVideoRecordingCallbackInvoker : global::Java.Lang.Object, IVideoRecordingCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ziggeo/androidsdk/recording/IVideoRecordingCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoRecordingCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IVideoRecordingCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoRecordingCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ziggeo.androidsdk.recording.IVideoRecordingCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoRecordingCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError ();
		}
#pragma warning restore 0169

		IntPtr id_onError;
		public unsafe void OnError ()
		{
			if (id_onError == IntPtr.Zero)
				id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
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
			global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
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
			global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onStarted;
		public unsafe void OnStarted ()
		{
			if (id_onStarted == IntPtr.Zero)
				id_onStarted = JNIEnv.GetMethodID (class_ref, "onStarted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStarted);
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
			global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Recording.IVideoRecordingCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStopped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStopped_Ljava_lang_String_;
		public unsafe void OnStopped (string p0)
		{
			if (id_onStopped_Ljava_lang_String_ == IntPtr.Zero)
				id_onStopped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStopped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopped_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
