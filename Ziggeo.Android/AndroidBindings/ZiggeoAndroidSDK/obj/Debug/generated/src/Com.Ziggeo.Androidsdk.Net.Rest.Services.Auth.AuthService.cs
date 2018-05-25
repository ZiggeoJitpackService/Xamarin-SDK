using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Rest.Services.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest.services.auth']/class[@name='AuthService']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/rest/services/auth/AuthService", DoNotGenerateAcw=true)]
	public partial class AuthService : global::Com.Ziggeo.Androidsdk.Net.Rest.Services.Base.BaseService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/rest/services/auth/AuthService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthService); }
		}

		protected AuthService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
