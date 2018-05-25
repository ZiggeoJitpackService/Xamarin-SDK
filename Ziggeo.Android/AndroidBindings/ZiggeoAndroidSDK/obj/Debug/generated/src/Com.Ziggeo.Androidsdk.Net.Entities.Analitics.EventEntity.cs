using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Entities.Analitics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/entities/analitics/EventEntity", DoNotGenerateAcw=true)]
	public partial class EventEntity : global::Com.Ziggeo.Androidsdk.Net.Entities.BaseEntity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/entities/analitics/EventEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventEntity); }
		}

		protected EventEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/constructor[@name='EventEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventEntity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EventEntity)) {
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

		static Delegate cb_getBandwidth;
#pragma warning disable 0169
		static Delegate GetGetBandwidthHandler ()
		{
			if (cb_getBandwidth == null)
				cb_getBandwidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBandwidth);
			return cb_getBandwidth;
		}

		static float n_GetBandwidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bandwidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBandwidth_F;
#pragma warning disable 0169
		static Delegate GetSetBandwidth_FHandler ()
		{
			if (cb_setBandwidth_F == null)
				cb_setBandwidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBandwidth_F);
			return cb_setBandwidth_F;
		}

		static void n_SetBandwidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bandwidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBandwidth;
		static IntPtr id_setBandwidth_F;
		public virtual unsafe float Bandwidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='getBandwidth' and count(parameter)=0]"
			[Register ("getBandwidth", "()F", "GetGetBandwidthHandler")]
			get {
				if (id_getBandwidth == IntPtr.Zero)
					id_getBandwidth = JNIEnv.GetMethodID (class_ref, "getBandwidth", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getBandwidth);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBandwidth", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='setBandwidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBandwidth", "(F)V", "GetSetBandwidth_FHandler")]
			set {
				if (id_setBandwidth_F == IntPtr.Zero)
					id_setBandwidth_F = JNIEnv.GetMethodID (class_ref, "setBandwidth", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBandwidth_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBandwidth", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDataSize;
#pragma warning disable 0169
		static Delegate GetGetDataSizeHandler ()
		{
			if (cb_getDataSize == null)
				cb_getDataSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataSize);
			return cb_getDataSize;
		}

		static int n_GetDataSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataSize;
		}
#pragma warning restore 0169

		static Delegate cb_setDataSize_I;
#pragma warning disable 0169
		static Delegate GetSetDataSize_IHandler ()
		{
			if (cb_setDataSize_I == null)
				cb_setDataSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDataSize_I);
			return cb_setDataSize_I;
		}

		static void n_SetDataSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DataSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSize;
		static IntPtr id_setDataSize_I;
		public virtual unsafe int DataSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='getDataSize' and count(parameter)=0]"
			[Register ("getDataSize", "()I", "GetGetDataSizeHandler")]
			get {
				if (id_getDataSize == IntPtr.Zero)
					id_getDataSize = JNIEnv.GetMethodID (class_ref, "getDataSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDataSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='setDataSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDataSize", "(I)V", "GetSetDataSize_IHandler")]
			set {
				if (id_setDataSize_I == IntPtr.Zero)
					id_setDataSize_I = JNIEnv.GetMethodID (class_ref, "setDataSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEmbedType;
#pragma warning disable 0169
		static Delegate GetGetEmbedTypeHandler ()
		{
			if (cb_getEmbedType == null)
				cb_getEmbedType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmbedType);
			return cb_getEmbedType;
		}

		static IntPtr n_GetEmbedType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EmbedType);
		}
#pragma warning restore 0169

		static Delegate cb_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_;
#pragma warning disable 0169
		static Delegate GetSetEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_Handler ()
		{
			if (cb_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_ == null)
				cb_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_);
			return cb_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_;
		}

		static void n_SetEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmbedType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmbedType;
		static IntPtr id_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType EmbedType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='getEmbedType' and count(parameter)=0]"
			[Register ("getEmbedType", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;", "GetGetEmbedTypeHandler")]
			get {
				if (id_getEmbedType == IntPtr.Zero)
					id_getEmbedType = JNIEnv.GetMethodID (class_ref, "getEmbedType", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmbedType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEmbedType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmbedType", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='setEmbedType' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.net.entities.analitics.EventEmbedType']]"
			[Register ("setEmbedType", "(Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;)V", "GetSetEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_Handler")]
			set {
				if (id_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_ == IntPtr.Zero)
					id_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_ = JNIEnv.GetMethodID (class_ref, "setEmbedType", "(Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmbedType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventEmbedType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmbedType", "(Lcom/ziggeo/androidsdk/net/entities/analitics/EventEmbedType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaTime;
#pragma warning disable 0169
		static Delegate GetGetMediaTimeHandler ()
		{
			if (cb_getMediaTime == null)
				cb_getMediaTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMediaTime);
			return cb_getMediaTime;
		}

		static int n_GetMediaTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaTime;
		}
#pragma warning restore 0169

		static Delegate cb_setMediaTime_I;
#pragma warning disable 0169
		static Delegate GetSetMediaTime_IHandler ()
		{
			if (cb_setMediaTime_I == null)
				cb_setMediaTime_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMediaTime_I);
			return cb_setMediaTime_I;
		}

		static void n_SetMediaTime_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MediaTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMediaTime;
		static IntPtr id_setMediaTime_I;
		public virtual unsafe int MediaTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='getMediaTime' and count(parameter)=0]"
			[Register ("getMediaTime", "()I", "GetGetMediaTimeHandler")]
			get {
				if (id_getMediaTime == IntPtr.Zero)
					id_getMediaTime = JNIEnv.GetMethodID (class_ref, "getMediaTime", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMediaTime);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaTime", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='setMediaTime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMediaTime", "(I)V", "GetSetMediaTime_IHandler")]
			set {
				if (id_setMediaTime_I == IntPtr.Zero)
					id_setMediaTime_I = JNIEnv.GetMethodID (class_ref, "setMediaTime", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediaTime_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediaTime", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeSeconds;
#pragma warning disable 0169
		static Delegate GetGetTimeSecondsHandler ()
		{
			if (cb_getTimeSeconds == null)
				cb_getTimeSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeSeconds);
			return cb_getTimeSeconds;
		}

		static int n_GetTimeSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeSeconds;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeSeconds_I;
#pragma warning disable 0169
		static Delegate GetSetTimeSeconds_IHandler ()
		{
			if (cb_setTimeSeconds_I == null)
				cb_setTimeSeconds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeSeconds_I);
			return cb_setTimeSeconds_I;
		}

		static void n_SetTimeSeconds_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimeSeconds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeSeconds;
		static IntPtr id_setTimeSeconds_I;
		public virtual unsafe int TimeSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='getTimeSeconds' and count(parameter)=0]"
			[Register ("getTimeSeconds", "()I", "GetGetTimeSecondsHandler")]
			get {
				if (id_getTimeSeconds == IntPtr.Zero)
					id_getTimeSeconds = JNIEnv.GetMethodID (class_ref, "getTimeSeconds", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTimeSeconds);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeSeconds", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='setTimeSeconds' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeSeconds", "(I)V", "GetSetTimeSeconds_IHandler")]
			set {
				if (id_setTimeSeconds_I == IntPtr.Zero)
					id_setTimeSeconds_I = JNIEnv.GetMethodID (class_ref, "setTimeSeconds", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeSeconds_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeSeconds", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_Handler ()
		{
			if (cb_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_ == null)
				cb_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_);
			return cb_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_;
		}

		static void n_SetType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType p0 = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_;
		public virtual unsafe global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.EventType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='EventEntity']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.ziggeo.androidsdk.net.entities.analitics.EventType']]"
			[Register ("setType", "(Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;)V", "GetSetType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_Handler")]
			set {
				if (id_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_ == IntPtr.Zero)
					id_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Lcom_ziggeo_androidsdk_net_entities_analitics_EventType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/ziggeo/androidsdk/net/entities/analitics/EventType;)V"), __args);
				} finally {
				}
			}
		}

	}
}
