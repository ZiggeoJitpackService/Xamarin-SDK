using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/io/IOUtils", DoNotGenerateAcw=true)]
	public partial class IOUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='DEFAULT_MAX_PLAYER_VIDEOS_COUNT']"
		[Register ("DEFAULT_MAX_PLAYER_VIDEOS_COUNT")]
		[Obsolete ("deprecated")]
		public const int DefaultMaxPlayerVideosCount = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='DEFAULT_MAX_PLAYER_VIDEOS_SIZE']"
		[Register ("DEFAULT_MAX_PLAYER_VIDEOS_SIZE")]
		[Obsolete ("deprecated")]
		public const int DefaultMaxPlayerVideosSize = (int) 536870912;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='DEFAULT_MAX_RECORDER_VIDEOS_COUNT']"
		[Register ("DEFAULT_MAX_RECORDER_VIDEOS_COUNT")]
		[Obsolete ("deprecated")]
		public const int DefaultMaxRecorderVideosCount = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='DEFAULT_MAX_RECORDER_VIDEOS_SIZE']"
		[Register ("DEFAULT_MAX_RECORDER_VIDEOS_SIZE")]
		[Obsolete ("deprecated")]
		public const int DefaultMaxRecorderVideosSize = (int) 536870912;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='DEFAULT_MIN_AVAILABLE_FREE_SPACE']"
		[Register ("DEFAULT_MIN_AVAILABLE_FREE_SPACE")]
		public const int DefaultMinAvailableFreeSpace = (int) 100;

		static IntPtr DEFAULT_PLAYER_CACHE_FOLDER_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='DEFAULT_PLAYER_CACHE_FOLDER_PATH']"
		[Register ("DEFAULT_PLAYER_CACHE_FOLDER_PATH")]
		public static string DefaultPlayerCacheFolderPath {
			get {
				if (DEFAULT_PLAYER_CACHE_FOLDER_PATH_jfieldId == IntPtr.Zero)
					DEFAULT_PLAYER_CACHE_FOLDER_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_PLAYER_CACHE_FOLDER_PATH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_PLAYER_CACHE_FOLDER_PATH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_RECORDER_CACHE_FOLDER_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='DEFAULT_RECORDER_CACHE_FOLDER_PATH']"
		[Register ("DEFAULT_RECORDER_CACHE_FOLDER_PATH")]
		public static string DefaultRecorderCacheFolderPath {
			get {
				if (DEFAULT_RECORDER_CACHE_FOLDER_PATH_jfieldId == IntPtr.Zero)
					DEFAULT_RECORDER_CACHE_FOLDER_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_RECORDER_CACHE_FOLDER_PATH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_RECORDER_CACHE_FOLDER_PATH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/io/IOUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOUtils); }
		}

		protected IOUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/constructor[@name='IOUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IOUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IOUtils)) {
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

		static IntPtr id_getAvailableExternalMemorySize;
		public static unsafe int AvailableExternalMemorySize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='getAvailableExternalMemorySize' and count(parameter)=0]"
			[Register ("getAvailableExternalMemorySize", "()I", "GetGetAvailableExternalMemorySizeHandler")]
			get {
				if (id_getAvailableExternalMemorySize == IntPtr.Zero)
					id_getAvailableExternalMemorySize = JNIEnv.GetStaticMethodID (class_ref, "getAvailableExternalMemorySize", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getAvailableExternalMemorySize);
				} finally {
				}
			}
		}

		static IntPtr id_getSnapshotFileName;
		public static unsafe string SnapshotFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='getSnapshotFileName' and count(parameter)=0]"
			[Register ("getSnapshotFileName", "()Ljava/lang/String;", "GetGetSnapshotFileNameHandler")]
			get {
				if (id_getSnapshotFileName == IntPtr.Zero)
					id_getSnapshotFileName = JNIEnv.GetStaticMethodID (class_ref, "getSnapshotFileName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSnapshotFileName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoFileName;
		public static unsafe string VideoFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='getVideoFileName' and count(parameter)=0]"
			[Register ("getVideoFileName", "()Ljava/lang/String;", "GetGetVideoFileNameHandler")]
			get {
				if (id_getVideoFileName == IntPtr.Zero)
					id_getVideoFileName = JNIEnv.GetStaticMethodID (class_ref, "getVideoFileName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVideoFileName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_deleteLastFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='deleteLastFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteLastFile", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteLastFile (global::Java.IO.File p0)
		{
			if (id_deleteLastFile_Ljava_io_File_ == IntPtr.Zero)
				id_deleteLastFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "deleteLastFile", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_deleteLastFile_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findVideoInCache_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='findVideoInCache' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("findVideoInCache", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File FindVideoInCache (global::Android.Content.Context p0, string p1)
		{
			if (id_findVideoInCache_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_findVideoInCache_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findVideoInCache", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findVideoInCache_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_findVideoInFolder_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='findVideoInFolder' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("findVideoInFolder", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File FindVideoInFolder (global::Java.IO.File p0, string p1)
		{
			if (id_findVideoInFolder_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_findVideoInFolder_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findVideoInFolder", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findVideoInFolder_Ljava_io_File_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_folderSize_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='folderSize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("folderSize", "(Ljava/io/File;)J", "")]
		public static unsafe long FolderSize (global::Java.IO.File p0)
		{
			if (id_folderSize_Ljava_io_File_ == IntPtr.Zero)
				id_folderSize_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "folderSize", "(Ljava/io/File;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_folderSize_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_formatSize_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='formatSize' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("formatSize", "(J)I", "")]
		public static unsafe int FormatSize (long p0)
		{
			if (id_formatSize_J == IntPtr.Zero)
				id_formatSize_J = JNIEnv.GetStaticMethodID (class_ref, "formatSize", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_formatSize_J, __args);
			} finally {
			}
		}

		static IntPtr id_getMimeType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='getMimeType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMimeType", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetMimeType (string p0)
		{
			if (id_getMimeType_Ljava_lang_String_ == IntPtr.Zero)
				id_getMimeType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMimeType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMimeType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getVideoFileName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='getVideoFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getVideoFileName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetVideoFileName (string p0)
		{
			if (id_getVideoFileName_Ljava_lang_String_ == IntPtr.Zero)
				id_getVideoFileName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getVideoFileName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVideoFileName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isCacheFilled_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='isCacheFilled' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("isCacheFilled", "(Ljava/io/File;)Z", "")]
		public static unsafe bool IsCacheFilled (global::Java.IO.File p0)
		{
			if (id_isCacheFilled_Ljava_io_File_ == IntPtr.Zero)
				id_isCacheFilled_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "isCacheFilled", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCacheFilled_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_saveSnapshot_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.io']/class[@name='IOUtils']/method[@name='saveSnapshot' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("saveSnapshot", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "")]
		public static unsafe string SaveSnapshot (global::Android.Graphics.Bitmap p0)
		{
			if (id_saveSnapshot_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_saveSnapshot_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "saveSnapshot", "(Landroid/graphics/Bitmap;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveSnapshot_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
