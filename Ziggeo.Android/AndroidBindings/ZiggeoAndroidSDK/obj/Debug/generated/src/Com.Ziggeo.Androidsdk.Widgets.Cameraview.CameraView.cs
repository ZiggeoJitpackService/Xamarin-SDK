using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Widgets.Cameraview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView", DoNotGenerateAcw=true)]
	public partial class CameraView : global::Android.Widget.FrameLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='FACING_BACK']"
		[Register ("FACING_BACK")]
		public const int FacingBack = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='FACING_FRONT']"
		[Register ("FACING_FRONT")]
		public const int FacingFront = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='FLASH_AUTO']"
		[Register ("FLASH_AUTO")]
		public const int FlashAuto = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='FLASH_OFF']"
		[Register ("FLASH_OFF")]
		public const int FlashOff = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='FLASH_ON']"
		[Register ("FLASH_ON")]
		public const int FlashOn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='FLASH_RED_EYE']"
		[Register ("FLASH_RED_EYE")]
		public const int FlashRedEye = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='FLASH_TORCH']"
		[Register ("FLASH_TORCH")]
		public const int FlashTorch = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='QUALITY_HIGH']"
		[Register ("QUALITY_HIGH")]
		public const int QualityHigh = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='QUALITY_LOW']"
		[Register ("QUALITY_LOW")]
		public const int QualityLow = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/field[@name='QUALITY_MEDIUM']"
		[Register ("QUALITY_MEDIUM")]
		public const int QualityMedium = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']"
		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback", DoNotGenerateAcw=true)]
		public abstract partial class Callback : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Callback); }
			}

			protected Callback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']/constructor[@name='CameraView.Callback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Callback ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Callback)) {
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

			static Delegate cb_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_;
#pragma warning disable 0169
			static Delegate GetOnCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Handler ()
			{
				if (cb_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ == null)
					cb_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_);
				return cb_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_;
			}

			static void n_OnCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraClosed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']/method[@name='onCameraClosed' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.widgets.cameraview.CameraView']]"
			[Register ("onCameraClosed", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;)V", "GetOnCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Handler")]
			public virtual unsafe void OnCameraClosed (global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView p0)
			{
				if (id_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ == IntPtr.Zero)
					id_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ = JNIEnv.GetMethodID (class_ref, "onCameraClosed", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraClosed_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraClosed", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_;
#pragma warning disable 0169
			static Delegate GetOnCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Handler ()
			{
				if (cb_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ == null)
					cb_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_);
				return cb_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_;
			}

			static void n_OnCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraOpened (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']/method[@name='onCameraOpened' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.widgets.cameraview.CameraView']]"
			[Register ("onCameraOpened", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;)V", "GetOnCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Handler")]
			public virtual unsafe void OnCameraOpened (global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView p0)
			{
				if (id_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ == IntPtr.Zero)
					id_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_ = JNIEnv.GetMethodID (class_ref, "onCameraOpened", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraOpened_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraOpened", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB;
#pragma warning disable 0169
			static Delegate GetOnPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayBHandler ()
			{
				if (cb_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB == null)
					cb_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB);
				return cb_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB;
			}

			static void n_OnPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (native_p0, JniHandleOwnership.DoNotTransfer);
				byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnPictureTaken (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			static IntPtr id_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']/method[@name='onPictureTaken' and count(parameter)=2 and parameter[1][@type='com.ziggeo.androidsdk.widgets.cameraview.CameraView'] and parameter[2][@type='byte[]']]"
			[Register ("onPictureTaken", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;[B)V", "GetOnPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayBHandler")]
			public virtual unsafe void OnPictureTaken (global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView p0, byte[] p1)
			{
				if (id_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB == IntPtr.Zero)
					id_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB = JNIEnv.GetMethodID (class_ref, "onPictureTaken", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;[B)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPictureTaken_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPictureTaken", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView;[B)V"), __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_onRecodingError_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnRecodingError_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onRecodingError_Ljava_lang_Throwable_ == null)
					cb_onRecodingError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRecodingError_Ljava_lang_Throwable_);
				return cb_onRecodingError_Ljava_lang_Throwable_;
			}

			static void n_OnRecodingError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRecodingError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onRecodingError_Ljava_lang_Throwable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']/method[@name='onRecodingError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onRecodingError", "(Ljava/lang/Throwable;)V", "GetOnRecodingError_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void OnRecodingError (global::Java.Lang.Throwable p0)
			{
				if (id_onRecodingError_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onRecodingError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onRecodingError", "(Ljava/lang/Throwable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecodingError_Ljava_lang_Throwable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRecodingError", "(Ljava/lang/Throwable;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onRecodingStarted;
#pragma warning disable 0169
			static Delegate GetOnRecodingStartedHandler ()
			{
				if (cb_onRecodingStarted == null)
					cb_onRecodingStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRecodingStarted);
				return cb_onRecodingStarted;
			}

			static void n_OnRecodingStarted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRecodingStarted ();
			}
#pragma warning restore 0169

			static IntPtr id_onRecodingStarted;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']/method[@name='onRecodingStarted' and count(parameter)=0]"
			[Register ("onRecodingStarted", "()V", "GetOnRecodingStartedHandler")]
			public virtual unsafe void OnRecodingStarted ()
			{
				if (id_onRecodingStarted == IntPtr.Zero)
					id_onRecodingStarted = JNIEnv.GetMethodID (class_ref, "onRecodingStarted", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecodingStarted);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRecodingStarted", "()V"));
				} finally {
				}
			}

			static Delegate cb_onRecodingStopped;
#pragma warning disable 0169
			static Delegate GetOnRecodingStoppedHandler ()
			{
				if (cb_onRecodingStopped == null)
					cb_onRecodingStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRecodingStopped);
				return cb_onRecodingStopped;
			}

			static void n_OnRecodingStopped (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRecodingStopped ();
			}
#pragma warning restore 0169

			static IntPtr id_onRecodingStopped;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.Callback']/method[@name='onRecodingStopped' and count(parameter)=0]"
			[Register ("onRecodingStopped", "()V", "GetOnRecodingStoppedHandler")]
			public virtual unsafe void OnRecodingStopped ()
			{
				if (id_onRecodingStopped == IntPtr.Zero)
					id_onRecodingStopped = JNIEnv.GetMethodID (class_ref, "onRecodingStopped", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecodingStopped);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRecodingStopped", "()V"));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback", DoNotGenerateAcw=true)]
		internal partial class CallbackInvoker : Callback {

			public CallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']"
		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$CallbackBridge", DoNotGenerateAcw=true)]
		public partial class CallbackBridge : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$CallbackBridge", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackBridge); }
			}

			protected CallbackBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
#pragma warning disable 0169
			static Delegate GetAdd_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler ()
			{
				if (cb_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == null)
					cb_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_);
				return cb_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
			}

			static void n_Add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0);
			}
#pragma warning restore 0169

			static IntPtr id_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.widgets.cameraview.CameraView.Callback']]"
			[Register ("add", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V", "GetAdd_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler")]
			public virtual unsafe void Add (global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0)
			{
				if (id_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == IntPtr.Zero)
					id_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCameraClosed;
#pragma warning disable 0169
			static Delegate GetOnCameraClosedHandler ()
			{
				if (cb_onCameraClosed == null)
					cb_onCameraClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraClosed);
				return cb_onCameraClosed;
			}

			static void n_OnCameraClosed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraClosed ();
			}
#pragma warning restore 0169

			static IntPtr id_onCameraClosed;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onCameraClosed' and count(parameter)=0]"
			[Register ("onCameraClosed", "()V", "GetOnCameraClosedHandler")]
			public virtual unsafe void OnCameraClosed ()
			{
				if (id_onCameraClosed == IntPtr.Zero)
					id_onCameraClosed = JNIEnv.GetMethodID (class_ref, "onCameraClosed", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraClosed);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraClosed", "()V"));
				} finally {
				}
			}

			static Delegate cb_onCameraOpened;
#pragma warning disable 0169
			static Delegate GetOnCameraOpenedHandler ()
			{
				if (cb_onCameraOpened == null)
					cb_onCameraOpened = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraOpened);
				return cb_onCameraOpened;
			}

			static void n_OnCameraOpened (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraOpened ();
			}
#pragma warning restore 0169

			static IntPtr id_onCameraOpened;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onCameraOpened' and count(parameter)=0]"
			[Register ("onCameraOpened", "()V", "GetOnCameraOpenedHandler")]
			public virtual unsafe void OnCameraOpened ()
			{
				if (id_onCameraOpened == IntPtr.Zero)
					id_onCameraOpened = JNIEnv.GetMethodID (class_ref, "onCameraOpened", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraOpened);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraOpened", "()V"));
				} finally {
				}
			}

			static Delegate cb_onPictureTaken_arrayB;
#pragma warning disable 0169
			static Delegate GetOnPictureTaken_arrayBHandler ()
			{
				if (cb_onPictureTaken_arrayB == null)
					cb_onPictureTaken_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPictureTaken_arrayB);
				return cb_onPictureTaken_arrayB;
			}

			static void n_OnPictureTaken_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnPictureTaken (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPictureTaken_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onPictureTaken' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onPictureTaken", "([B)V", "GetOnPictureTaken_arrayBHandler")]
			public virtual unsafe void OnPictureTaken (byte[] p0)
			{
				if (id_onPictureTaken_arrayB == IntPtr.Zero)
					id_onPictureTaken_arrayB = JNIEnv.GetMethodID (class_ref, "onPictureTaken", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPictureTaken_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPictureTaken", "([B)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_onRecodingError_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnRecodingError_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onRecodingError_Ljava_lang_Throwable_ == null)
					cb_onRecodingError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRecodingError_Ljava_lang_Throwable_);
				return cb_onRecodingError_Ljava_lang_Throwable_;
			}

			static void n_OnRecodingError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRecodingError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onRecodingError_Ljava_lang_Throwable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onRecodingError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onRecodingError", "(Ljava/lang/Throwable;)V", "GetOnRecodingError_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void OnRecodingError (global::Java.Lang.Throwable p0)
			{
				if (id_onRecodingError_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onRecodingError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onRecodingError", "(Ljava/lang/Throwable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecodingError_Ljava_lang_Throwable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRecodingError", "(Ljava/lang/Throwable;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onRecodingStarted;
#pragma warning disable 0169
			static Delegate GetOnRecodingStartedHandler ()
			{
				if (cb_onRecodingStarted == null)
					cb_onRecodingStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRecodingStarted);
				return cb_onRecodingStarted;
			}

			static void n_OnRecodingStarted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRecodingStarted ();
			}
#pragma warning restore 0169

			static IntPtr id_onRecodingStarted;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onRecodingStarted' and count(parameter)=0]"
			[Register ("onRecodingStarted", "()V", "GetOnRecodingStartedHandler")]
			public virtual unsafe void OnRecodingStarted ()
			{
				if (id_onRecodingStarted == IntPtr.Zero)
					id_onRecodingStarted = JNIEnv.GetMethodID (class_ref, "onRecodingStarted", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecodingStarted);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRecodingStarted", "()V"));
				} finally {
				}
			}

			static Delegate cb_onRecodingStopped;
#pragma warning disable 0169
			static Delegate GetOnRecodingStoppedHandler ()
			{
				if (cb_onRecodingStopped == null)
					cb_onRecodingStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRecodingStopped);
				return cb_onRecodingStopped;
			}

			static void n_OnRecodingStopped (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRecodingStopped ();
			}
#pragma warning restore 0169

			static IntPtr id_onRecodingStopped;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onRecodingStopped' and count(parameter)=0]"
			[Register ("onRecodingStopped", "()V", "GetOnRecodingStoppedHandler")]
			public virtual unsafe void OnRecodingStopped ()
			{
				if (id_onRecodingStopped == IntPtr.Zero)
					id_onRecodingStopped = JNIEnv.GetMethodID (class_ref, "onRecodingStopped", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecodingStopped);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRecodingStopped", "()V"));
				} finally {
				}
			}

			static Delegate cb_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
#pragma warning disable 0169
			static Delegate GetRemove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler ()
			{
				if (cb_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == null)
					cb_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_);
				return cb_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
			}

			static void n_Remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			static IntPtr id_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.widgets.cameraview.CameraView.Callback']]"
			[Register ("remove", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V", "GetRemove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler")]
			public virtual unsafe void Remove (global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0)
			{
				if (id_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == IntPtr.Zero)
					id_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_reserveRequestLayoutOnOpen;
#pragma warning disable 0169
			static Delegate GetReserveRequestLayoutOnOpenHandler ()
			{
				if (cb_reserveRequestLayoutOnOpen == null)
					cb_reserveRequestLayoutOnOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReserveRequestLayoutOnOpen);
				return cb_reserveRequestLayoutOnOpen;
			}

			static void n_ReserveRequestLayoutOnOpen (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ReserveRequestLayoutOnOpen ();
			}
#pragma warning restore 0169

			static IntPtr id_reserveRequestLayoutOnOpen;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='reserveRequestLayoutOnOpen' and count(parameter)=0]"
			[Register ("reserveRequestLayoutOnOpen", "()V", "GetReserveRequestLayoutOnOpenHandler")]
			public virtual unsafe void ReserveRequestLayoutOnOpen ()
			{
				if (id_reserveRequestLayoutOnOpen == IntPtr.Zero)
					id_reserveRequestLayoutOnOpen = JNIEnv.GetMethodID (class_ref, "reserveRequestLayoutOnOpen", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reserveRequestLayoutOnOpen);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reserveRequestLayoutOnOpen", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/interface[@name='CameraView.Facing']"
		[Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Facing", "", "Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView/IFacingInvoker")]
		public partial interface IFacing : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Facing", DoNotGenerateAcw=true)]
		internal class IFacingInvoker : global::Java.Lang.Object, IFacing {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Facing");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFacingInvoker); }
			}

			IntPtr class_ref;

			public static IFacing GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFacing> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ziggeo.androidsdk.widgets.cameraview.CameraView.Facing"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFacingInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/interface[@name='CameraView.Flash']"
		[Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Flash", "", "Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView/IFlashInvoker")]
		public partial interface IFlash : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Flash", DoNotGenerateAcw=true)]
		internal class IFlashInvoker : global::Java.Lang.Object, IFlash {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Flash");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFlashInvoker); }
			}

			IntPtr class_ref;

			public static IFlash GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFlash> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ziggeo.androidsdk.widgets.cameraview.CameraView.Flash"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFlashInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/interface[@name='CameraView.Quality']"
		[Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Quality", "", "Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView/IQualityInvoker")]
		public partial interface IQuality : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Quality", DoNotGenerateAcw=true)]
		internal class IQualityInvoker : global::Java.Lang.Object, IQuality {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ziggeo/androidsdk/widgets/cameraview/CameraView$Quality");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IQualityInvoker); }
			}

			IntPtr class_ref;

			public static IQuality GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQuality> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ziggeo.androidsdk.widgets.cameraview.CameraView.Quality"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQualityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.IQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/widgets/cameraview/CameraView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraView); }
		}

		protected CameraView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/constructor[@name='CameraView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CameraView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (CameraView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/constructor[@name='CameraView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CameraView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (CameraView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/constructor[@name='CameraView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CameraView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CameraView)) {
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

		static Delegate cb_getAdjustViewBounds;
#pragma warning disable 0169
		static Delegate GetGetAdjustViewBoundsHandler ()
		{
			if (cb_getAdjustViewBounds == null)
				cb_getAdjustViewBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAdjustViewBounds);
			return cb_getAdjustViewBounds;
		}

		static bool n_GetAdjustViewBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdjustViewBounds;
		}
#pragma warning restore 0169

		static Delegate cb_setAdjustViewBounds_Z;
#pragma warning disable 0169
		static Delegate GetSetAdjustViewBounds_ZHandler ()
		{
			if (cb_setAdjustViewBounds_Z == null)
				cb_setAdjustViewBounds_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAdjustViewBounds_Z);
			return cb_setAdjustViewBounds_Z;
		}

		static void n_SetAdjustViewBounds_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdjustViewBounds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdjustViewBounds;
		static IntPtr id_setAdjustViewBounds_Z;
		public virtual unsafe bool AdjustViewBounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getAdjustViewBounds' and count(parameter)=0]"
			[Register ("getAdjustViewBounds", "()Z", "GetGetAdjustViewBoundsHandler")]
			get {
				if (id_getAdjustViewBounds == IntPtr.Zero)
					id_getAdjustViewBounds = JNIEnv.GetMethodID (class_ref, "getAdjustViewBounds", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustViewBounds);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdjustViewBounds", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='setAdjustViewBounds' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAdjustViewBounds", "(Z)V", "GetSetAdjustViewBounds_ZHandler")]
			set {
				if (id_setAdjustViewBounds_Z == IntPtr.Zero)
					id_setAdjustViewBounds_Z = JNIEnv.GetMethodID (class_ref, "setAdjustViewBounds", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdjustViewBounds_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdjustViewBounds", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetAspectRatioHandler ()
		{
			if (cb_getAspectRatio == null)
				cb_getAspectRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAspectRatio);
			return cb_getAspectRatio;
		}

		static IntPtr n_GetAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AspectRatio);
		}
#pragma warning restore 0169

		static IntPtr id_getAspectRatio;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.AspectRatio AspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getAspectRatio' and count(parameter)=0]"
			[Register ("getAspectRatio", "()Lcom/ziggeo/androidsdk/widgets/cameraview/AspectRatio;", "GetGetAspectRatioHandler")]
			get {
				if (id_getAspectRatio == IntPtr.Zero)
					id_getAspectRatio = JNIEnv.GetMethodID (class_ref, "getAspectRatio", "()Lcom/ziggeo/androidsdk/widgets/cameraview/AspectRatio;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.AspectRatio> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAspectRatio), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.AspectRatio> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAspectRatio", "()Lcom/ziggeo/androidsdk/widgets/cameraview/AspectRatio;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAutoFocus;
#pragma warning disable 0169
		static Delegate GetGetAutoFocusHandler ()
		{
			if (cb_getAutoFocus == null)
				cb_getAutoFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoFocus);
			return cb_getAutoFocus;
		}

		static bool n_GetAutoFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoFocus;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoFocus_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoFocus_ZHandler ()
		{
			if (cb_setAutoFocus_Z == null)
				cb_setAutoFocus_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoFocus_Z);
			return cb_setAutoFocus_Z;
		}

		static void n_SetAutoFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoFocus = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutoFocus;
		static IntPtr id_setAutoFocus_Z;
		public virtual unsafe bool AutoFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getAutoFocus' and count(parameter)=0]"
			[Register ("getAutoFocus", "()Z", "GetGetAutoFocusHandler")]
			get {
				if (id_getAutoFocus == IntPtr.Zero)
					id_getAutoFocus = JNIEnv.GetMethodID (class_ref, "getAutoFocus", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoFocus);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutoFocus", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='setAutoFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoFocus", "(Z)V", "GetSetAutoFocus_ZHandler")]
			set {
				if (id_setAutoFocus_Z == IntPtr.Zero)
					id_setAutoFocus_Z = JNIEnv.GetMethodID (class_ref, "setAutoFocus", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoFocus_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoFocus", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFacing;
#pragma warning disable 0169
		static Delegate GetGetFacingHandler ()
		{
			if (cb_getFacing == null)
				cb_getFacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFacing);
			return cb_getFacing;
		}

		static int n_GetFacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Facing;
		}
#pragma warning restore 0169

		static Delegate cb_setFacing_I;
#pragma warning disable 0169
		static Delegate GetSetFacing_IHandler ()
		{
			if (cb_setFacing_I == null)
				cb_setFacing_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFacing_I);
			return cb_setFacing_I;
		}

		static void n_SetFacing_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Facing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFacing;
		static IntPtr id_setFacing_I;
		public virtual unsafe int Facing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getFacing' and count(parameter)=0]"
			[Register ("getFacing", "()I", "GetGetFacingHandler")]
			get {
				if (id_getFacing == IntPtr.Zero)
					id_getFacing = JNIEnv.GetMethodID (class_ref, "getFacing", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFacing);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFacing", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='setFacing' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFacing", "(I)V", "GetSetFacing_IHandler")]
			set {
				if (id_setFacing_I == IntPtr.Zero)
					id_setFacing_I = JNIEnv.GetMethodID (class_ref, "setFacing", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFacing_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFacing", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFlash;
#pragma warning disable 0169
		static Delegate GetGetFlashHandler ()
		{
			if (cb_getFlash == null)
				cb_getFlash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFlash);
			return cb_getFlash;
		}

		static int n_GetFlash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flash;
		}
#pragma warning restore 0169

		static Delegate cb_setFlash_I;
#pragma warning disable 0169
		static Delegate GetSetFlash_IHandler ()
		{
			if (cb_setFlash_I == null)
				cb_setFlash_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFlash_I);
			return cb_setFlash_I;
		}

		static void n_SetFlash_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flash = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFlash;
		static IntPtr id_setFlash_I;
		public virtual unsafe int Flash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getFlash' and count(parameter)=0]"
			[Register ("getFlash", "()I", "GetGetFlashHandler")]
			get {
				if (id_getFlash == IntPtr.Zero)
					id_getFlash = JNIEnv.GetMethodID (class_ref, "getFlash", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFlash);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlash", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='setFlash' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFlash", "(I)V", "GetSetFlash_IHandler")]
			set {
				if (id_setFlash_I == IntPtr.Zero)
					id_setFlash_I = JNIEnv.GetMethodID (class_ref, "setFlash", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFlash_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlash", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCameraOpened;
#pragma warning disable 0169
		static Delegate GetIsCameraOpenedHandler ()
		{
			if (cb_isCameraOpened == null)
				cb_isCameraOpened = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCameraOpened);
			return cb_isCameraOpened;
		}

		static bool n_IsCameraOpened (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCameraOpened;
		}
#pragma warning restore 0169

		static IntPtr id_isCameraOpened;
		public virtual unsafe bool IsCameraOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='isCameraOpened' and count(parameter)=0]"
			[Register ("isCameraOpened", "()Z", "GetIsCameraOpenedHandler")]
			get {
				if (id_isCameraOpened == IntPtr.Zero)
					id_isCameraOpened = JNIEnv.GetMethodID (class_ref, "isCameraOpened", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCameraOpened);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCameraOpened", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRecording;
#pragma warning disable 0169
		static Delegate GetIsRecordingHandler ()
		{
			if (cb_isRecording == null)
				cb_isRecording = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRecording);
			return cb_isRecording;
		}

		static bool n_IsRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecording;
		}
#pragma warning restore 0169

		static IntPtr id_isRecording;
		public virtual unsafe bool IsRecording {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='isRecording' and count(parameter)=0]"
			[Register ("isRecording", "()Z", "GetIsRecordingHandler")]
			get {
				if (id_isRecording == IntPtr.Zero)
					id_isRecording = JNIEnv.GetMethodID (class_ref, "isRecording", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRecording);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRecording", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getQuality;
#pragma warning disable 0169
		static Delegate GetGetQualityHandler ()
		{
			if (cb_getQuality == null)
				cb_getQuality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQuality);
			return cb_getQuality;
		}

		static int n_GetQuality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quality;
		}
#pragma warning restore 0169

		static Delegate cb_setQuality_I;
#pragma warning disable 0169
		static Delegate GetSetQuality_IHandler ()
		{
			if (cb_setQuality_I == null)
				cb_setQuality_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQuality_I);
			return cb_setQuality_I;
		}

		static void n_SetQuality_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quality = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getQuality;
		static IntPtr id_setQuality_I;
		public virtual unsafe int Quality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getQuality' and count(parameter)=0]"
			[Register ("getQuality", "()I", "GetGetQualityHandler")]
			get {
				if (id_getQuality == IntPtr.Zero)
					id_getQuality = JNIEnv.GetMethodID (class_ref, "getQuality", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQuality);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuality", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='setQuality' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setQuality", "(I)V", "GetSetQuality_IHandler")]
			set {
				if (id_setQuality_I == IntPtr.Zero)
					id_setQuality_I = JNIEnv.GetMethodID (class_ref, "setQuality", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuality_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuality", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecorder;
#pragma warning disable 0169
		static Delegate GetGetRecorderHandler ()
		{
			if (cb_getRecorder == null)
				cb_getRecorder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecorder);
			return cb_getRecorder;
		}

		static IntPtr n_GetRecorder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Recorder);
		}
#pragma warning restore 0169

		static IntPtr id_getRecorder;
		public virtual unsafe global::Android.Media.MediaRecorder Recorder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getRecorder' and count(parameter)=0]"
			[Register ("getRecorder", "()Landroid/media/MediaRecorder;", "GetGetRecorderHandler")]
			get {
				if (id_getRecorder == IntPtr.Zero)
					id_getRecorder = JNIEnv.GetMethodID (class_ref, "getRecorder", "()Landroid/media/MediaRecorder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRecorder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecorder", "()Landroid/media/MediaRecorder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedAspectRatios;
#pragma warning disable 0169
		static Delegate GetGetSupportedAspectRatiosHandler ()
		{
			if (cb_getSupportedAspectRatios == null)
				cb_getSupportedAspectRatios = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedAspectRatios);
			return cb_getSupportedAspectRatios;
		}

		static IntPtr n_GetSupportedAspectRatios (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.AspectRatio>.ToLocalJniHandle (__this.SupportedAspectRatios);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedAspectRatios;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.AspectRatio> SupportedAspectRatios {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='getSupportedAspectRatios' and count(parameter)=0]"
			[Register ("getSupportedAspectRatios", "()Ljava/util/Set;", "GetGetSupportedAspectRatiosHandler")]
			get {
				if (id_getSupportedAspectRatios == IntPtr.Zero)
					id_getSupportedAspectRatios = JNIEnv.GetMethodID (class_ref, "getSupportedAspectRatios", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.AspectRatio>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedAspectRatios), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.AspectRatio>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportedAspectRatios", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
#pragma warning disable 0169
		static Delegate GetAddCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler ()
		{
			if (cb_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == null)
				cb_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_);
			return cb_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
		}

		static void n_AddCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.widgets.cameraview.CameraView.Callback']]"
		[Register ("addCallback", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V", "GetAddCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler")]
		public virtual unsafe void AddCallback (global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0)
		{
			if (id_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == IntPtr.Zero)
				id_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCallback", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
#pragma warning disable 0169
		static Delegate GetRemoveCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler ()
		{
			if (cb_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == null)
				cb_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_);
			return cb_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
		}

		static void n_RemoveCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.widgets.cameraview.CameraView.Callback']]"
		[Register ("removeCallback", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V", "GetRemoveCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_Handler")]
		public virtual unsafe void RemoveCallback (global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView.Callback p0)
		{
			if (id_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ == IntPtr.Zero)
				id_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback_Lcom_ziggeo_androidsdk_widgets_cameraview_CameraView_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallback", "(Lcom/ziggeo/androidsdk/widgets/cameraview/CameraView$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_;
#pragma warning disable 0169
		static Delegate GetSetMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_Handler ()
		{
			if (cb_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_ == null)
				cb_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_);
			return cb_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_;
		}

		static void n_SetMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaRecorder.IOnErrorListener p0 = (global::Android.Media.MediaRecorder.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMrOnErrorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='setMrOnErrorListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaRecorder.OnErrorListener']]"
		[Register ("setMrOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V", "GetSetMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_Handler")]
		public virtual unsafe void SetMrOnErrorListener (global::Android.Media.MediaRecorder.IOnErrorListener p0)
		{
			if (id_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_ == IntPtr.Zero)
				id_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setMrOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMrOnErrorListener_Landroid_media_MediaRecorder_OnErrorListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMrOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_Handler ()
		{
			if (cb_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_ == null)
				cb_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_);
			return cb_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_;
		}

		static void n_SetMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaRecorder.IOnInfoListener p0 = (global::Android.Media.MediaRecorder.IOnInfoListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder.IOnInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMrOnInfoListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='setMrOnInfoListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaRecorder.OnInfoListener']]"
		[Register ("setMrOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V", "GetSetMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_Handler")]
		public virtual unsafe void SetMrOnInfoListener (global::Android.Media.MediaRecorder.IOnInfoListener p0)
		{
			if (id_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_ == IntPtr.Zero)
				id_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_ = JNIEnv.GetMethodID (class_ref, "setMrOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMrOnInfoListener_Landroid_media_MediaRecorder_OnInfoListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMrOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_startRecording_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetStartRecording_Ljava_lang_String_IHandler ()
		{
			if (cb_startRecording_Ljava_lang_String_I == null)
				cb_startRecording_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_StartRecording_Ljava_lang_String_I);
			return cb_startRecording_Ljava_lang_String_I;
		}

		static void n_StartRecording_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartRecording (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startRecording_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='startRecording' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("startRecording", "(Ljava/lang/String;I)V", "GetStartRecording_Ljava_lang_String_IHandler")]
		public virtual unsafe void StartRecording (string p0, int p1)
		{
			if (id_startRecording_Ljava_lang_String_I == IntPtr.Zero)
				id_startRecording_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "startRecording", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startRecording_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRecording", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopRecording;
#pragma warning disable 0169
		static Delegate GetStopRecordingHandler ()
		{
			if (cb_stopRecording == null)
				cb_stopRecording = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopRecording);
			return cb_stopRecording;
		}

		static void n_StopRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_stopRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='stopRecording' and count(parameter)=0]"
		[Register ("stopRecording", "()V", "GetStopRecordingHandler")]
		public virtual unsafe void StopRecording ()
		{
			if (id_stopRecording == IntPtr.Zero)
				id_stopRecording = JNIEnv.GetMethodID (class_ref, "stopRecording", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopRecording);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopRecording", "()V"));
			} finally {
			}
		}

		static Delegate cb_takePicture;
#pragma warning disable 0169
		static Delegate GetTakePictureHandler ()
		{
			if (cb_takePicture == null)
				cb_takePicture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TakePicture);
			return cb_takePicture;
		}

		static void n_TakePicture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TakePicture ();
		}
#pragma warning restore 0169

		static IntPtr id_takePicture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.widgets.cameraview']/class[@name='CameraView']/method[@name='takePicture' and count(parameter)=0]"
		[Register ("takePicture", "()V", "GetTakePictureHandler")]
		public virtual unsafe void TakePicture ()
		{
			if (id_takePicture == IntPtr.Zero)
				id_takePicture = JNIEnv.GetMethodID (class_ref, "takePicture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_takePicture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "takePicture", "()V"));
			} finally {
			}
		}

	}
}
