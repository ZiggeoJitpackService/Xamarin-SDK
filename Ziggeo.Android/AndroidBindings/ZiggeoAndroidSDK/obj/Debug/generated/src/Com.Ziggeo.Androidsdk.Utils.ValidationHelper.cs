using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/utils/ValidationHelper", DoNotGenerateAcw=true)]
	public sealed partial class ValidationHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/utils/ValidationHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ValidationHelper); }
		}

		internal ValidationHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isNull", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsNull (global::Java.Lang.Object p0)
		{
			if (id_isNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_isNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isNull", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNull_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNullOrEmpty_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("isNullOrEmpty", "(Landroid/os/Bundle;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::Android.OS.Bundle p0)
		{
			if (id_isNullOrEmpty_Landroid_os_Bundle_ == IntPtr.Zero)
				id_isNullOrEmpty_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Landroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Landroid_os_Bundle_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNullOrEmpty_Landroid_text_Editable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("isNullOrEmpty", "(Landroid/text/Editable;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::Android.Text.IEditable p0)
		{
			if (id_isNullOrEmpty_Landroid_text_Editable_ == IntPtr.Zero)
				id_isNullOrEmpty_Landroid_text_Editable_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Landroid/text/Editable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Landroid_text_Editable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNullOrEmpty_Landroid_widget_EditText_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='android.widget.EditText']]"
		[Register ("isNullOrEmpty", "(Landroid/widget/EditText;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::Android.Widget.EditText p0)
		{
			if (id_isNullOrEmpty_Landroid_widget_EditText_ == IntPtr.Zero)
				id_isNullOrEmpty_Landroid_widget_EditText_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Landroid/widget/EditText;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Landroid_widget_EditText_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNullOrEmpty_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isNullOrEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::Java.Lang.ICharSequence p0)
		{
			if (id_isNullOrEmpty_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isNullOrEmpty_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("isNullOrEmpty", "(Ljava/lang/Long;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::Java.Lang.Long p0)
		{
			if (id_isNullOrEmpty_Ljava_lang_Long_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/lang/Long;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_lang_Long_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNullOrEmpty_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("isNullOrEmpty", "([Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::Java.Lang.Object[] p0)
		{
			if (id_isNullOrEmpty_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isNullOrEmpty_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "([Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_isNullOrEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNullOrEmpty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsNullOrEmpty (string p0)
		{
			if (id_isNullOrEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isNullOrEmpty_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("isNullOrEmpty", "(Ljava/util/Collection;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::System.Collections.ICollection p0)
		{
			if (id_isNullOrEmpty_Ljava_util_Collection_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/util/Collection;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_util_Collection_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isNullOrEmpty_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.utils']/class[@name='ValidationHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("isNullOrEmpty", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::System.Collections.IDictionary p0)
		{
			if (id_isNullOrEmpty_Ljava_util_Map_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_util_Map_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
