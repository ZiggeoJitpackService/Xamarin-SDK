using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Rest.Services.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest.services.base']/class[@name='BaseService']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/rest/services/base/BaseService", DoNotGenerateAcw=true)]
	public abstract partial class BaseService : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest.services.base']/class[@name='BaseService']/field[@name='ARG_CLIENT_AUTH']"
		[Register ("ARG_CLIENT_AUTH")]
		protected const string ArgClientAuth = (string) "client_auth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest.services.base']/class[@name='BaseService']/field[@name='ARG_SERVER_AUTH']"
		[Register ("ARG_SERVER_AUTH")]
		protected const string ArgServerAuth = (string) "server_auth";

		static IntPtr appToken_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest.services.base']/class[@name='BaseService']/field[@name='appToken']"
		[Register ("appToken")]
		protected string AppToken {
			get {
				if (appToken_jfieldId == IntPtr.Zero)
					appToken_jfieldId = JNIEnv.GetFieldID (class_ref, "appToken", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appToken_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appToken_jfieldId == IntPtr.Zero)
					appToken_jfieldId = JNIEnv.GetFieldID (class_ref, "appToken", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appToken_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest.services.base']/class[@name='BaseService']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/rest/services/base/BaseService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseService); }
		}

		protected BaseService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest.services.base']/class[@name='BaseService']/constructor[@name='BaseService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe BaseService (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (BaseService)) {
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

	}

	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/rest/services/base/BaseService", DoNotGenerateAcw=true)]
	internal partial class BaseServiceInvoker : BaseService {

		public BaseServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseServiceInvoker); }
		}

	}

}
