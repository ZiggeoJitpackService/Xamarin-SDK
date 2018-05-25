using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/AppForeground", DoNotGenerateAcw=true)]
	public partial class AppForeground : global::Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/field[@name='CHECK_DELAY']"
		[Register ("CHECK_DELAY")]
		public const long CheckDelay = (long) 500L;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ziggeo.androidsdk']/interface[@name='AppForeground.Listener']"
		[Register ("com/ziggeo/androidsdk/AppForeground$Listener", "", "Com.Ziggeo.Androidsdk.AppForeground/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/interface[@name='AppForeground.Listener']/method[@name='onBecameBackground' and count(parameter)=0]"
			[Register ("onBecameBackground", "()V", "GetOnBecameBackgroundHandler:Com.Ziggeo.Androidsdk.AppForeground/IListenerInvoker, ZiggeoAndroidSDK")]
			void OnBecameBackground ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/interface[@name='AppForeground.Listener']/method[@name='onBecomeForeground' and count(parameter)=0]"
			[Register ("onBecomeForeground", "()V", "GetOnBecomeForegroundHandler:Com.Ziggeo.Androidsdk.AppForeground/IListenerInvoker, ZiggeoAndroidSDK")]
			void OnBecomeForeground ();

		}

		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/AppForeground$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ziggeo/androidsdk/AppForeground$Listener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ziggeo.androidsdk.AppForeground.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBecameBackground;
#pragma warning disable 0169
			static Delegate GetOnBecameBackgroundHandler ()
			{
				if (cb_onBecameBackground == null)
					cb_onBecameBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBecameBackground);
				return cb_onBecameBackground;
			}

			static void n_OnBecameBackground (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.AppForeground.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBecameBackground ();
			}
#pragma warning restore 0169

			IntPtr id_onBecameBackground;
			public unsafe void OnBecameBackground ()
			{
				if (id_onBecameBackground == IntPtr.Zero)
					id_onBecameBackground = JNIEnv.GetMethodID (class_ref, "onBecameBackground", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBecameBackground);
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
				global::Com.Ziggeo.Androidsdk.AppForeground.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBecomeForeground ();
			}
#pragma warning restore 0169

			IntPtr id_onBecomeForeground;
			public unsafe void OnBecomeForeground ()
			{
				if (id_onBecomeForeground == IntPtr.Zero)
					id_onBecomeForeground = JNIEnv.GetMethodID (class_ref, "onBecomeForeground", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBecomeForeground);
			}

		}

		[global::Android.Runtime.Register ("mono/com/ziggeo/androidsdk/AppForeground_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ziggeo/androidsdk/AppForeground_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnBecameBackgroundHandler;
#pragma warning restore 0649

			public void OnBecameBackground ()
			{
				var __h = OnBecameBackgroundHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnBecomeForegroundHandler;
#pragma warning restore 0649

			public void OnBecomeForeground ()
			{
				var __h = OnBecomeForegroundHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnBecameBackgroundHandler == null && value.OnBecomeForegroundHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/AppForeground", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppForeground); }
		}

		protected AppForeground (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/constructor[@name='AppForeground' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppForeground (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AppForeground)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_isForeground;
#pragma warning disable 0169
		static Delegate GetIsForegroundHandler ()
		{
			if (cb_isForeground == null)
				cb_isForeground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsForeground);
			return cb_isForeground;
		}

		static bool n_IsForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsForeground;
		}
#pragma warning restore 0169

		static IntPtr id_isForeground;
		public virtual unsafe bool IsForeground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='isForeground' and count(parameter)=0]"
			[Register ("isForeground", "()Z", "GetIsForegroundHandler")]
			get {
				if (id_isForeground == IntPtr.Zero)
					id_isForeground = JNIEnv.GetMethodID (class_ref, "isForeground", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isForeground);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isForeground", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_Handler ()
		{
			if (cb_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ == null)
				cb_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_);
			return cb_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_;
		}

		static void n_AddListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ziggeo.Androidsdk.AppForeground.IListener p0 = (global::Com.Ziggeo.Androidsdk.AppForeground.IListener)global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.AppForeground.Listener']]"
		[Register ("addListener", "(Lcom/ziggeo/androidsdk/AppForeground$Listener;)V", "GetAddListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_Handler")]
		public virtual unsafe void AddListener (global::Com.Ziggeo.Androidsdk.AppForeground.IListener p0)
		{
			if (id_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ == IntPtr.Zero)
				id_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/ziggeo/androidsdk/AppForeground$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Lcom/ziggeo/androidsdk/AppForeground$Listener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isActivityRunning_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetIsActivityRunning_Ljava_lang_Class_Handler ()
		{
			if (cb_isActivityRunning_Ljava_lang_Class_ == null)
				cb_isActivityRunning_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsActivityRunning_Ljava_lang_Class_);
			return cb_isActivityRunning_Ljava_lang_Class_;
		}

		static bool n_IsActivityRunning_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsActivityRunning (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isActivityRunning_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='isActivityRunning' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
		[Register ("isActivityRunning", "(Ljava/lang/Class;)Z", "GetIsActivityRunning_Ljava_lang_Class_Handler")]
		public virtual unsafe bool IsActivityRunning (global::Java.Lang.Class p0)
		{
			if (id_isActivityRunning_Ljava_lang_Class_ == IntPtr.Zero)
				id_isActivityRunning_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "isActivityRunning", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isActivityRunning_Ljava_lang_Class_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isActivityRunning", "(Ljava/lang/Class;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivityCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Landroid_app_Activity_);
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityDestroyed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityDestroyed (global::Android.App.Activity p0)
		{
			if (id_onActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityDestroyed_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityDestroyed", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityPaused_Landroid_app_Activity_);
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityPaused_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityPaused (global::Android.App.Activity p0)
		{
			if (id_onActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityPaused", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityPaused_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityPaused", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityResumed_Landroid_app_Activity_);
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResumed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityResumed (global::Android.App.Activity p0)
		{
			if (id_onActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityResumed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResumed_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResumed", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivitySaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Landroid_app_Activity_);
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStarted_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStarted (global::Android.App.Activity p0)
		{
			if (id_onActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityStarted_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStarted", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Landroid_app_Activity_);
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityStopped_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStopped (global::Android.App.Activity p0)
		{
			if (id_onActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_onActivityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityStopped_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStopped", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_Handler ()
		{
			if (cb_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ == null)
				cb_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_);
			return cb_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_;
		}

		static void n_RemoveListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.AppForeground __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ziggeo.Androidsdk.AppForeground.IListener p0 = (global::Com.Ziggeo.Androidsdk.AppForeground.IListener)global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.AppForeground.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='AppForeground']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.AppForeground.Listener']]"
		[Register ("removeListener", "(Lcom/ziggeo/androidsdk/AppForeground$Listener;)V", "GetRemoveListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_Handler")]
		public virtual unsafe void RemoveListener (global::Com.Ziggeo.Androidsdk.AppForeground.IListener p0)
		{
			if (id_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ == IntPtr.Zero)
				id_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/ziggeo/androidsdk/AppForeground$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Lcom_ziggeo_androidsdk_AppForeground_Listener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Lcom/ziggeo/androidsdk/AppForeground$Listener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Ziggeo.Androidsdk.AppForeground.IListener"

		global::Com.Ziggeo.Androidsdk.AppForeground.IListenerImplementor __CreateIListenerImplementor ()
		{
			return new global::Com.Ziggeo.Androidsdk.AppForeground.IListenerImplementor (this);
		}
#endregion
	}
}
