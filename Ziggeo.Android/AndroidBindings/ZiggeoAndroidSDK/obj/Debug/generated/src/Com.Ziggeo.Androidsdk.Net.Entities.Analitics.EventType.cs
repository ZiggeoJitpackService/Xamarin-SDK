using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Entities.Analitics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/entities/analitics/EventType", DoNotGenerateAcw=true)]
	public sealed partial class EventType : global::Java.Lang.Enum {


		static IntPtr COVER_SELECT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='COVER_SELECT']"
		[Register ("COVER_SELECT")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType CoverSelect {
			get {
				if (COVER_SELECT_jfieldId == IntPtr.Zero)
					COVER_SELECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COVER_SELECT", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COVER_SELECT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COVER_SKIP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='COVER_SKIP']"
		[Register ("COVER_SKIP")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType CoverSkip {
			get {
				if (COVER_SKIP_jfieldId == IntPtr.Zero)
					COVER_SKIP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COVER_SKIP", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COVER_SKIP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOWNSTREAM_BANDWIDTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='DOWNSTREAM_BANDWIDTH']"
		[Register ("DOWNSTREAM_BANDWIDTH")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType DownstreamBandwidth {
			get {
				if (DOWNSTREAM_BANDWIDTH_jfieldId == IntPtr.Zero)
					DOWNSTREAM_BANDWIDTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNSTREAM_BANDWIDTH", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNSTREAM_BANDWIDTH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMBEDDING_LOADED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='EMBEDDING_LOADED']"
		[Register ("EMBEDDING_LOADED")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType EmbeddingLoaded {
			get {
				if (EMBEDDING_LOADED_jfieldId == IntPtr.Zero)
					EMBEDDING_LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMBEDDING_LOADED", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMBEDDING_LOADED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INIT_APPLICATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='INIT_APPLICATION']"
		[Register ("INIT_APPLICATION")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType InitApplication {
			get {
				if (INIT_APPLICATION_jfieldId == IntPtr.Zero)
					INIT_APPLICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INIT_APPLICATION", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INIT_APPLICATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAY_END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='PLAY_END']"
		[Register ("PLAY_END")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType PlayEnd {
			get {
				if (PLAY_END_jfieldId == IntPtr.Zero)
					PLAY_END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY_END", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_END_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAY_PAUSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='PLAY_PAUSE']"
		[Register ("PLAY_PAUSE")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType PlayPause {
			get {
				if (PLAY_PAUSE_jfieldId == IntPtr.Zero)
					PLAY_PAUSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY_PAUSE", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_PAUSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAY_PLAYING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='PLAY_PLAYING']"
		[Register ("PLAY_PLAYING")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType PlayPlaying {
			get {
				if (PLAY_PLAYING_jfieldId == IntPtr.Zero)
					PLAY_PLAYING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY_PLAYING", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_PLAYING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAY_SEEK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='PLAY_SEEK']"
		[Register ("PLAY_SEEK")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType PlaySeek {
			get {
				if (PLAY_SEEK_jfieldId == IntPtr.Zero)
					PLAY_SEEK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY_SEEK", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_SEEK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAY_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='PLAY_START']"
		[Register ("PLAY_START")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType PlayStart {
			get {
				if (PLAY_START_jfieldId == IntPtr.Zero)
					PLAY_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY_START", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_START_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROCESSING_END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='PROCESSING_END']"
		[Register ("PROCESSING_END")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType ProcessingEnd {
			get {
				if (PROCESSING_END_jfieldId == IntPtr.Zero)
					PROCESSING_END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROCESSING_END", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROCESSING_END_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROCESSING_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='PROCESSING_START']"
		[Register ("PROCESSING_START")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType ProcessingStart {
			get {
				if (PROCESSING_START_jfieldId == IntPtr.Zero)
					PROCESSING_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROCESSING_START", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROCESSING_START_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECORD_END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='RECORD_END']"
		[Register ("RECORD_END")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType RecordEnd {
			get {
				if (RECORD_END_jfieldId == IntPtr.Zero)
					RECORD_END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECORD_END", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECORD_END_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECORD_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='RECORD_START']"
		[Register ("RECORD_START")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType RecordStart {
			get {
				if (RECORD_START_jfieldId == IntPtr.Zero)
					RECORD_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECORD_START", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECORD_START_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RERECORD_CONFIRM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='RERECORD_CONFIRM']"
		[Register ("RERECORD_CONFIRM")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType RerecordConfirm {
			get {
				if (RERECORD_CONFIRM_jfieldId == IntPtr.Zero)
					RERECORD_CONFIRM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RERECORD_CONFIRM", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RERECORD_CONFIRM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPLOADING_END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='UPLOADING_END']"
		[Register ("UPLOADING_END")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType UploadingEnd {
			get {
				if (UPLOADING_END_jfieldId == IntPtr.Zero)
					UPLOADING_END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOADING_END", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOADING_END_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPLOADING_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='UPLOADING_START']"
		[Register ("UPLOADING_START")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType UploadingStart {
			get {
				if (UPLOADING_START_jfieldId == IntPtr.Zero)
					UPLOADING_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOADING_START", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOADING_START_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPLOAD_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='UPLOAD_START']"
		[Register ("UPLOAD_START")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType UploadStart {
			get {
				if (UPLOAD_START_jfieldId == IntPtr.Zero)
					UPLOAD_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOAD_START", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOAD_START_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPSTREAM_BANDWIDTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/field[@name='UPSTREAM_BANDWIDTH']"
		[Register ("UPSTREAM_BANDWIDTH")]
		public static global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType UpstreamBandwidth {
			get {
				if (UPSTREAM_BANDWIDTH_jfieldId == IntPtr.Zero)
					UPSTREAM_BANDWIDTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPSTREAM_BANDWIDTH", "Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPSTREAM_BANDWIDTH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/entities/analitics/EventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventType); }
		}

		internal EventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/method[@name='getValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;", "")]
		public static unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType __ret = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;", "")]
		public static unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
			try {
				return (global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType));
			} finally {
			}
		}

	}
}
