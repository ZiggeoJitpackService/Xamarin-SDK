using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/LocalPlaybackConfig", DoNotGenerateAcw=true)]
	public partial class LocalPlaybackConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig.Builder']"
		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/LocalPlaybackConfig$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ziggeo/androidsdk/LocalPlaybackConfig$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig.Builder']/constructor[@name='LocalPlaybackConfig.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/ziggeo/androidsdk/LocalPlaybackConfig;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/ziggeo/androidsdk/LocalPlaybackConfig;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_cacheDirectory_Ljava_io_File_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig.Builder']/method[@name='cacheDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register ("cacheDirectory", "(Ljava/io/File;)Lcom/ziggeo/androidsdk/LocalPlaybackConfig$Builder;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig.Builder CacheDirectory (global::Java.IO.File p0)
			{
				if (id_cacheDirectory_Ljava_io_File_ == IntPtr.Zero)
					id_cacheDirectory_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "cacheDirectory", "(Ljava/io/File;)Lcom/ziggeo/androidsdk/LocalPlaybackConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cacheDirectory_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_maxCacheSize_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig.Builder']/method[@name='maxCacheSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("maxCacheSize", "(J)Lcom/ziggeo/androidsdk/LocalPlaybackConfig$Builder;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig.Builder MaxCacheSize (long p0)
			{
				if (id_maxCacheSize_J == IntPtr.Zero)
					id_maxCacheSize_J = JNIEnv.GetMethodID (class_ref, "maxCacheSize", "(J)Lcom/ziggeo/androidsdk/LocalPlaybackConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_maxCacheSize_J, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_maxFilesCount_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig.Builder']/method[@name='maxFilesCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxFilesCount", "(I)Lcom/ziggeo/androidsdk/LocalPlaybackConfig$Builder;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig.Builder MaxFilesCount (int p0)
			{
				if (id_maxFilesCount_I == IntPtr.Zero)
					id_maxFilesCount_I = JNIEnv.GetMethodID (class_ref, "maxFilesCount", "(I)Lcom/ziggeo/androidsdk/LocalPlaybackConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_maxFilesCount_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/LocalPlaybackConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalPlaybackConfig); }
		}

		protected LocalPlaybackConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCacheRoot;
#pragma warning disable 0169
		static Delegate GetGetCacheRootHandler ()
		{
			if (cb_getCacheRoot == null)
				cb_getCacheRoot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheRoot);
			return cb_getCacheRoot;
		}

		static IntPtr n_GetCacheRoot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheRoot);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheRoot;
		public virtual unsafe global::Java.IO.File CacheRoot {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig']/method[@name='getCacheRoot' and count(parameter)=0]"
			[Register ("getCacheRoot", "()Ljava/io/File;", "GetGetCacheRootHandler")]
			get {
				if (id_getCacheRoot == IntPtr.Zero)
					id_getCacheRoot = JNIEnv.GetMethodID (class_ref, "getCacheRoot", "()Ljava/io/File;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCacheRoot), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheRoot", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxCacheSize;
#pragma warning disable 0169
		static Delegate GetGetMaxCacheSizeHandler ()
		{
			if (cb_getMaxCacheSize == null)
				cb_getMaxCacheSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxCacheSize);
			return cb_getMaxCacheSize;
		}

		static long n_GetMaxCacheSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxCacheSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCacheSize;
		public virtual unsafe long MaxCacheSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig']/method[@name='getMaxCacheSize' and count(parameter)=0]"
			[Register ("getMaxCacheSize", "()J", "GetGetMaxCacheSizeHandler")]
			get {
				if (id_getMaxCacheSize == IntPtr.Zero)
					id_getMaxCacheSize = JNIEnv.GetMethodID (class_ref, "getMaxCacheSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxCacheSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCacheSize", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxFilesCount;
#pragma warning disable 0169
		static Delegate GetGetMaxFilesCountHandler ()
		{
			if (cb_getMaxFilesCount == null)
				cb_getMaxFilesCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxFilesCount);
			return cb_getMaxFilesCount;
		}

		static int n_GetMaxFilesCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.LocalPlaybackConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxFilesCount;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxFilesCount;
		public virtual unsafe int MaxFilesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='LocalPlaybackConfig']/method[@name='getMaxFilesCount' and count(parameter)=0]"
			[Register ("getMaxFilesCount", "()I", "GetGetMaxFilesCountHandler")]
			get {
				if (id_getMaxFilesCount == IntPtr.Zero)
					id_getMaxFilesCount = JNIEnv.GetMethodID (class_ref, "getMaxFilesCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxFilesCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxFilesCount", "()I"));
				} finally {
				}
			}
		}

	}
}
