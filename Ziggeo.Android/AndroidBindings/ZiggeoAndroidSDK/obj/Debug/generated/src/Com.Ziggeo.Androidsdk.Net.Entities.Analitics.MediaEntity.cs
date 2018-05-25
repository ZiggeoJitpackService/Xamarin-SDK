using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Entities.Analitics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/entities/analitics/MediaEntity", DoNotGenerateAcw=true)]
	public partial class MediaEntity : global::Com.Ziggeo.Androidsdk.Net.Entities.BaseEntity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/entities/analitics/MediaEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaEntity); }
		}

		protected MediaEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/constructor[@name='MediaEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaEntity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MediaEntity)) {
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

		static Delegate cb_getCreationType;
#pragma warning disable 0169
		static Delegate GetGetCreationTypeHandler ()
		{
			if (cb_getCreationType == null)
				cb_getCreationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreationType);
			return cb_getCreationType;
		}

		static IntPtr n_GetCreationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreationType);
		}
#pragma warning restore 0169

		static IntPtr id_getCreationType;
		public virtual unsafe string CreationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='getCreationType' and count(parameter)=0]"
			[Register ("getCreationType", "()Ljava/lang/String;", "GetGetCreationTypeHandler")]
			get {
				if (id_getCreationType == IntPtr.Zero)
					id_getCreationType = JNIEnv.GetMethodID (class_ref, "getCreationType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreationType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreationType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDuration);
			return cb_getDuration;
		}

		static int n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static Delegate cb_setDuration_I;
#pragma warning disable 0169
		static Delegate GetSetDuration_IHandler ()
		{
			if (cb_setDuration_I == null)
				cb_setDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDuration_I);
			return cb_setDuration_I;
		}

		static void n_SetDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_I;
		public virtual unsafe int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()I", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDuration", "(I)V", "GetSetDuration_IHandler")]
			set {
				if (id_setDuration_I == IntPtr.Zero)
					id_setDuration_I = JNIEnv.GetMethodID (class_ref, "setDuration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_I;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
			set {
				if (id_setHeight_I == IntPtr.Zero)
					id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		static Delegate cb_setTags_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTags_Ljava_util_List_Handler ()
		{
			if (cb_setTags_Ljava_util_List_ == null)
				cb_setTags_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTags_Ljava_util_List_);
			return cb_setTags_Ljava_util_List_;
		}

		static void n_SetTags_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTags;
		static IntPtr id_setTags_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/List;", "GetGetTagsHandler")]
			get {
				if (id_getTags == IntPtr.Zero)
					id_getTags = JNIEnv.GetMethodID (class_ref, "getTags", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTags), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTags", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='setTags' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setTags", "(Ljava/util/List;)V", "GetSetTags_Ljava_util_List_Handler")]
			set {
				if (id_setTags_Ljava_util_List_ == IntPtr.Zero)
					id_setTags_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTags", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTags_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTags", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity __this = global::Java.Lang.Object.GetObject<global::Com.Ziggeo.Androidsdk.Net.Entities.Analitics.MediaEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_I;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ziggeo.androidsdk.net.entities.analitics']/class[@name='MediaEntity']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
