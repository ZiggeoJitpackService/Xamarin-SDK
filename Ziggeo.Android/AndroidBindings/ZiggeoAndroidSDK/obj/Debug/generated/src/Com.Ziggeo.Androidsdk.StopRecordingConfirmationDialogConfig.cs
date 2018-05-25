using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig", DoNotGenerateAcw=true)]
	public partial class StopRecordingConfirmationDialogConfig : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig.Builder']"
		[global::Android.Runtime.Register ("com/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig.Builder']/constructor[@name='StopRecordingConfirmationDialogConfig.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_mesResId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig.Builder']/method[@name='mesResId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("mesResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder MesResId (int p0)
			{
				if (id_mesResId_I == IntPtr.Zero)
					id_mesResId_I = JNIEnv.GetMethodID (class_ref, "mesResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mesResId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_negBtnResId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig.Builder']/method[@name='negBtnResId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("negBtnResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder NegBtnResId (int p0)
			{
				if (id_negBtnResId_I == IntPtr.Zero)
					id_negBtnResId_I = JNIEnv.GetMethodID (class_ref, "negBtnResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_negBtnResId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_posBtnResId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig.Builder']/method[@name='posBtnResId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("posBtnResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder PosBtnResId (int p0)
			{
				if (id_posBtnResId_I == IntPtr.Zero)
					id_posBtnResId_I = JNIEnv.GetMethodID (class_ref, "posBtnResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_posBtnResId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_titleResId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig.Builder']/method[@name='titleResId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("titleResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;", "")]
			public unsafe global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder TitleResId (int p0)
			{
				if (id_titleResId_I == IntPtr.Zero)
					id_titleResId_I = JNIEnv.GetMethodID (class_ref, "titleResId", "(I)Lcom/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_titleResId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/StopRecordingConfirmationDialogConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StopRecordingConfirmationDialogConfig); }
		}

		protected StopRecordingConfirmationDialogConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMesResId;
#pragma warning disable 0169
		static Delegate GetGetMesResIdHandler ()
		{
			if (cb_getMesResId == null)
				cb_getMesResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMesResId);
			return cb_getMesResId;
		}

		static int n_GetMesResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MesResId;
		}
#pragma warning restore 0169

		static IntPtr id_getMesResId;
		public virtual unsafe int MesResId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig']/method[@name='getMesResId' and count(parameter)=0]"
			[Register ("getMesResId", "()I", "GetGetMesResIdHandler")]
			get {
				if (id_getMesResId == IntPtr.Zero)
					id_getMesResId = JNIEnv.GetMethodID (class_ref, "getMesResId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMesResId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMesResId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNegBtnResId;
#pragma warning disable 0169
		static Delegate GetGetNegBtnResIdHandler ()
		{
			if (cb_getNegBtnResId == null)
				cb_getNegBtnResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNegBtnResId);
			return cb_getNegBtnResId;
		}

		static int n_GetNegBtnResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NegBtnResId;
		}
#pragma warning restore 0169

		static IntPtr id_getNegBtnResId;
		public virtual unsafe int NegBtnResId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig']/method[@name='getNegBtnResId' and count(parameter)=0]"
			[Register ("getNegBtnResId", "()I", "GetGetNegBtnResIdHandler")]
			get {
				if (id_getNegBtnResId == IntPtr.Zero)
					id_getNegBtnResId = JNIEnv.GetMethodID (class_ref, "getNegBtnResId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNegBtnResId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNegBtnResId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPosBtnResId;
#pragma warning disable 0169
		static Delegate GetGetPosBtnResIdHandler ()
		{
			if (cb_getPosBtnResId == null)
				cb_getPosBtnResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPosBtnResId);
			return cb_getPosBtnResId;
		}

		static int n_GetPosBtnResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PosBtnResId;
		}
#pragma warning restore 0169

		static IntPtr id_getPosBtnResId;
		public virtual unsafe int PosBtnResId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig']/method[@name='getPosBtnResId' and count(parameter)=0]"
			[Register ("getPosBtnResId", "()I", "GetGetPosBtnResIdHandler")]
			get {
				if (id_getPosBtnResId == IntPtr.Zero)
					id_getPosBtnResId = JNIEnv.GetMethodID (class_ref, "getPosBtnResId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosBtnResId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosBtnResId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTitleResId;
#pragma warning disable 0169
		static Delegate GetGetTitleResIdHandler ()
		{
			if (cb_getTitleResId == null)
				cb_getTitleResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTitleResId);
			return cb_getTitleResId;
		}

		static int n_GetTitleResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TitleResId;
		}
#pragma warning restore 0169

		static IntPtr id_getTitleResId;
		public virtual unsafe int TitleResId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk']/class[@name='StopRecordingConfirmationDialogConfig']/method[@name='getTitleResId' and count(parameter)=0]"
			[Register ("getTitleResId", "()I", "GetGetTitleResIdHandler")]
			get {
				if (id_getTitleResId == IntPtr.Zero)
					id_getTitleResId = JNIEnv.GetMethodID (class_ref, "getTitleResId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTitleResId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleResId", "()I"));
				} finally {
				}
			}
		}

	}
}
