using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Entities.Analitics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventEntity']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventEntity", DoNotGenerateAcw=true)]
	public partial class AnalyticsEventEntity : global::Com.Ziggeo.Androidsdk.Net.Entities.BaseEntity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/entities/analitics/AnalyticsEventEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnalyticsEventEntity); }
		}

		protected AnalyticsEventEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventEntity']/constructor[@name='AnalyticsEventEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnalyticsEventEntity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AnalyticsEventEntity)) {
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

		static Delegate cb_getClientEntity;
#pragma warning disable 0169
		static Delegate GetGetClientEntityHandler ()
		{
			if (cb_getClientEntity == null)
				cb_getClientEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientEntity);
			return cb_getClientEntity;
		}

		static IntPtr n_GetClientEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientEntity);
		}
#pragma warning restore 0169

		static IntPtr id_getClientEntity;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.ClientEntity ClientEntity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventEntity']/method[@name='getClientEntity' and count(parameter)=0]"
			[Register ("getClientEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/ClientEntity;", "GetGetClientEntityHandler")]
			get {
				if (id_getClientEntity == IntPtr.Zero)
					id_getClientEntity = JNIEnv.GetMethodID (class_ref, "getClientEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/ClientEntity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.ClientEntity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientEntity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.ClientEntity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/ClientEntity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEventEntity;
#pragma warning disable 0169
		static Delegate GetGetEventEntityHandler ()
		{
			if (cb_getEventEntity == null)
				cb_getEventEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventEntity);
			return cb_getEventEntity;
		}

		static IntPtr n_GetEventEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventEntity);
		}
#pragma warning restore 0169

		static IntPtr id_getEventEntity;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity EventEntity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventEntity']/method[@name='getEventEntity' and count(parameter)=0]"
			[Register ("getEventEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventEntity;", "GetGetEventEntityHandler")]
			get {
				if (id_getEventEntity == IntPtr.Zero)
					id_getEventEntity = JNIEnv.GetMethodID (class_ref, "getEventEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventEntity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventEntity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventEntity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaEntity;
#pragma warning disable 0169
		static Delegate GetGetMediaEntityHandler ()
		{
			if (cb_getMediaEntity == null)
				cb_getMediaEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaEntity);
			return cb_getMediaEntity;
		}

		static IntPtr n_GetMediaEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaEntity);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaEntity;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity MediaEntity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventEntity']/method[@name='getMediaEntity' and count(parameter)=0]"
			[Register ("getMediaEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/MediaEntity;", "GetGetMediaEntityHandler")]
			get {
				if (id_getMediaEntity == IntPtr.Zero)
					id_getMediaEntity = JNIEnv.GetMethodID (class_ref, "getMediaEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/MediaEntity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaEntity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/MediaEntity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokensEntity;
#pragma warning disable 0169
		static Delegate GetGetTokensEntityHandler ()
		{
			if (cb_getTokensEntity == null)
				cb_getTokensEntity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokensEntity);
			return cb_getTokensEntity;
		}

		static IntPtr n_GetTokensEntity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.AnalyticsEventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TokensEntity);
		}
#pragma warning restore 0169

		static IntPtr id_getTokensEntity;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity TokensEntity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='AnalyticsEventEntity']/method[@name='getTokensEntity' and count(parameter)=0]"
			[Register ("getTokensEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/TokensEntity;", "GetGetTokensEntityHandler")]
			get {
				if (id_getTokensEntity == IntPtr.Zero)
					id_getTokensEntity = JNIEnv.GetMethodID (class_ref, "getTokensEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/TokensEntity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokensEntity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.TokensEntity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokensEntity", "()Lcom/ziggeo/androidsdk/net/entities/analitics/TokensEntity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
