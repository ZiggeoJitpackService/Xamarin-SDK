using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Entities.Analitics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/entities/analitics/TokensEntity", DoNotGenerateAcw=true)]
	public partial class TokensEntity : global::Com.Ziggeo.Androidsdk.Net.Entities.BaseEntity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/entities/analitics/TokensEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TokensEntity); }
		}

		protected TokensEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']/constructor[@name='TokensEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokensEntity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TokensEntity)) {
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

		static Delegate cb_getApplicationToken;
#pragma warning disable 0169
		static Delegate GetGetApplicationTokenHandler ()
		{
			if (cb_getApplicationToken == null)
				cb_getApplicationToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationToken);
			return cb_getApplicationToken;
		}

		static IntPtr n_GetApplicationToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationToken);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationToken_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationToken_Ljava_lang_String_ == null)
				cb_setApplicationToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationToken_Ljava_lang_String_);
			return cb_setApplicationToken_Ljava_lang_String_;
		}

		static void n_SetApplicationToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationToken;
		static IntPtr id_setApplicationToken_Ljava_lang_String_;
		public virtual unsafe string ApplicationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']/method[@name='getApplicationToken' and count(parameter)=0]"
			[Register ("getApplicationToken", "()Ljava/lang/String;", "GetGetApplicationTokenHandler")]
			get {
				if (id_getApplicationToken == IntPtr.Zero)
					id_getApplicationToken = JNIEnv.GetMethodID (class_ref, "getApplicationToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']/method[@name='setApplicationToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationToken", "(Ljava/lang/String;)V", "GetSetApplicationToken_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStreamToken;
#pragma warning disable 0169
		static Delegate GetGetStreamTokenHandler ()
		{
			if (cb_getStreamToken == null)
				cb_getStreamToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreamToken);
			return cb_getStreamToken;
		}

		static IntPtr n_GetStreamToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreamToken);
		}
#pragma warning restore 0169

		static Delegate cb_setStreamToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreamToken_Ljava_lang_String_Handler ()
		{
			if (cb_setStreamToken_Ljava_lang_String_ == null)
				cb_setStreamToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreamToken_Ljava_lang_String_);
			return cb_setStreamToken_Ljava_lang_String_;
		}

		static void n_SetStreamToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StreamToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamToken;
		static IntPtr id_setStreamToken_Ljava_lang_String_;
		public virtual unsafe string StreamToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']/method[@name='getStreamToken' and count(parameter)=0]"
			[Register ("getStreamToken", "()Ljava/lang/String;", "GetGetStreamTokenHandler")]
			get {
				if (id_getStreamToken == IntPtr.Zero)
					id_getStreamToken = JNIEnv.GetMethodID (class_ref, "getStreamToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreamToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreamToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']/method[@name='setStreamToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreamToken", "(Ljava/lang/String;)V", "GetSetStreamToken_Ljava_lang_String_Handler")]
			set {
				if (id_setStreamToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreamToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreamToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreamToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreamToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVideoToken;
#pragma warning disable 0169
		static Delegate GetGetVideoTokenHandler ()
		{
			if (cb_getVideoToken == null)
				cb_getVideoToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoToken);
			return cb_getVideoToken;
		}

		static IntPtr n_GetVideoToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VideoToken);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideoToken_Ljava_lang_String_Handler ()
		{
			if (cb_setVideoToken_Ljava_lang_String_ == null)
				cb_setVideoToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoToken_Ljava_lang_String_);
			return cb_setVideoToken_Ljava_lang_String_;
		}

		static void n_SetVideoToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VideoToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoToken;
		static IntPtr id_setVideoToken_Ljava_lang_String_;
		public virtual unsafe string VideoToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']/method[@name='getVideoToken' and count(parameter)=0]"
			[Register ("getVideoToken", "()Ljava/lang/String;", "GetGetVideoTokenHandler")]
			get {
				if (id_getVideoToken == IntPtr.Zero)
					id_getVideoToken = JNIEnv.GetMethodID (class_ref, "getVideoToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='TokensEntity']/method[@name='setVideoToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVideoToken", "(Ljava/lang/String;)V", "GetSetVideoToken_Ljava_lang_String_Handler")]
			set {
				if (id_setVideoToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setVideoToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVideoToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
