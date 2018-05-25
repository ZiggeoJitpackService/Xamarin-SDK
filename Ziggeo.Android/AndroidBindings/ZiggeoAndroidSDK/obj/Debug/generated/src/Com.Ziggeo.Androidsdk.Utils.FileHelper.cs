using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='FileHelper']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/utils/FileHelper", DoNotGenerateAcw=true)]
	public partial class FileHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='FileHelper']/field[@name='EXTENSION_SEPARATOR']"
		[Register ("EXTENSION_SEPARATOR")]
		public const char ExtensionSeparator = (char) (char)46;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/utils/FileHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileHelper); }
		}

		protected FileHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='FileHelper']/constructor[@name='FileHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FileHelper)) {
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

		static IntPtr id_getExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='FileHelper']/method[@name='getExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtension", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetExtension (string p0)
		{
			if (id_getExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_getExtension_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExtension_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_indexOfExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='FileHelper']/method[@name='indexOfExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("indexOfExtension", "(Ljava/lang/String;)I", "")]
		public static unsafe int IndexOfExtension (string p0)
		{
			if (id_indexOfExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_indexOfExtension_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfExtension", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfExtension_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_indexOfLastSeparator_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='FileHelper']/method[@name='indexOfLastSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("indexOfLastSeparator", "(Ljava/lang/String;)I", "")]
		public static unsafe int IndexOfLastSeparator (string p0)
		{
			if (id_indexOfLastSeparator_Ljava_lang_String_ == IntPtr.Zero)
				id_indexOfLastSeparator_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfLastSeparator", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfLastSeparator_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
