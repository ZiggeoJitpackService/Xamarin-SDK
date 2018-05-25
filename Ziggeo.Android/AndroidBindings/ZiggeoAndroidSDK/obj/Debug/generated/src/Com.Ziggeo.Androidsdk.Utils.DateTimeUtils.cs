using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='DateTimeUtils']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/utils/DateTimeUtils", DoNotGenerateAcw=true)]
	public partial class DateTimeUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/utils/DateTimeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateTimeUtils); }
		}

		protected DateTimeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='DateTimeUtils']/constructor[@name='DateTimeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateTimeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateTimeUtils)) {
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

		static IntPtr id_getDateFormatted;
		public static unsafe string DateFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='DateTimeUtils']/method[@name='getDateFormatted' and count(parameter)=0]"
			[Register ("getDateFormatted", "()Ljava/lang/String;", "GetGetDateFormattedHandler")]
			get {
				if (id_getDateFormatted == IntPtr.Zero)
					id_getDateFormatted = JNIEnv.GetStaticMethodID (class_ref, "getDateFormatted", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateFormatted), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_formatTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='DateTimeUtils']/method[@name='formatTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("formatTime", "(J)Ljava/lang/String;", "")]
		public static unsafe string FormatTime (long p0)
		{
			if (id_formatTime_J == IntPtr.Zero)
				id_formatTime_J = JNIEnv.GetStaticMethodID (class_ref, "formatTime", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatTime_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getTimeStatus_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='DateTimeUtils']/method[@name='getTimeStatus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("getTimeStatus", "(JJ)Ljava/lang/String;", "")]
		public static unsafe string GetTimeStatus (long p0, long p1)
		{
			if (id_getTimeStatus_JJ == IntPtr.Zero)
				id_getTimeStatus_JJ = JNIEnv.GetStaticMethodID (class_ref, "getTimeStatus", "(JJ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeStatus_JJ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
