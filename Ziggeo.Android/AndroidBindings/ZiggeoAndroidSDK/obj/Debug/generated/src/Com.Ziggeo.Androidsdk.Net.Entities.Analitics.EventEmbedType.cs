using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Entities.Analitics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEmbedType']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/entities/analitics/EventEmbedType", DoNotGenerateAcw=true)]
	public sealed partial class EventEmbedType : global::Java.Lang.Enum {


		static IntPtr PLAYER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEmbedType']/field[@name='PLAYER']"
		[Register ("PLAYER")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType Player {
			get {
				if (PLAYER_jfieldId == IntPtr.Zero)
					PLAYER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECORDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEmbedType']/field[@name='RECORDER']"
		[Register ("RECORDER")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType Recorder {
			get {
				if (RECORDER_jfieldId == IntPtr.Zero)
					RECORDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECORDER", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECORDER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RERECORDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEmbedType']/field[@name='RERECORDER']"
		[Register ("RERECORDER")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType Rerecorder {
			get {
				if (RERECORDER_jfieldId == IntPtr.Zero)
					RERECORDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RERECORDER", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RERECORDER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/entities/analitics/EventEmbedType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventEmbedType); }
		}

		internal EventEmbedType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEmbedType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEmbedType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;", "")]
		public static unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType __ret = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEmbedType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;", "")]
		public static unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;");
			try {
				return (global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType));
			} finally {
			}
		}

	}
}
