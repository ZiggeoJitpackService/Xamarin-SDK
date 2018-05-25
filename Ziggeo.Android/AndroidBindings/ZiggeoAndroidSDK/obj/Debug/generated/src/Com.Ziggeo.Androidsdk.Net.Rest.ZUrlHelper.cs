using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ziggeo.Androidsdk.Net.Rest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']"
	[global::Android.Runtime.Register ("com/ziggeo/androidsdk/net/rest/ZUrlHelper", DoNotGenerateAcw=true)]
	public partial class ZUrlHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='SCHEME']"
		[Register ("SCHEME")]
		public const string Scheme = (string) "https";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='SERVICE_AUTH']"
		[Register ("SERVICE_AUTH")]
		public const string ServiceAuth = (string) "session";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='SERVICE_STREAMS']"
		[Register ("SERVICE_STREAMS")]
		public const string ServiceStreams = (string) "streams";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='SERVICE_VIDEOS']"
		[Register ("SERVICE_VIDEOS")]
		public const string ServiceVideos = (string) "videos";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='SUBMIT_URI_PART']"
		[Register ("SUBMIT_URI_PART")]
		public const string SubmitUriPart = (string) "/recordersubmit/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PART_BASE']"
		[Register ("URL_PART_BASE")]
		public const string UrlPartBase = (string) "ziggeo.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PATH_ANALYTICS']"
		[Register ("URL_PATH_ANALYTICS")]
		public const string UrlPathAnalytics = (string) "scitylana/kcart";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PATH_BIND_STREAM']"
		[Register ("URL_PATH_BIND_STREAM")]
		public const string UrlPathBindStream = (string) "recordersubmit";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PATH_IMAGE_ATTACH']"
		[Register ("URL_PATH_IMAGE_ATTACH")]
		public const string UrlPathImageAttach = (string) "imageattach";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PATH_IMAGE_DOWNLOAD']"
		[Register ("URL_PATH_IMAGE_DOWNLOAD")]
		public const string UrlPathImageDownload = (string) "image";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PATH_VIDEO_ATTACH']"
		[Register ("URL_PATH_VIDEO_ATTACH")]
		public const string UrlPathVideoAttach = (string) "videoattach";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PATH_VIDEO_DOWNLOAD']"
		[Register ("URL_PATH_VIDEO_DOWNLOAD")]
		public const string UrlPathVideoDownload = (string) "video.mp4";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PREFIX_DEFAULT']"
		[Register ("URL_PREFIX_DEFAULT")]
		public const string UrlPrefixDefault = (string) "embed.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PREFIX_DEFAULT_R1']"
		[Register ("URL_PREFIX_DEFAULT_R1")]
		public const string UrlPrefixDefaultR1 = (string) "embed-eu-west-1.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PREFIX_NEW']"
		[Register ("URL_PREFIX_NEW")]
		public const string UrlPrefixNew = (string) "api-us-east-1.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PREFIX_NEW_R1']"
		[Register ("URL_PREFIX_NEW_R1")]
		public const string UrlPrefixNewR1 = (string) "api-eu-west-1.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/field[@name='URL_PREFIX_SWITCHER']"
		[Register ("URL_PREFIX_SWITCHER")]
		public const string UrlPrefixSwitcher = (string) "r1";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ziggeo/androidsdk/net/rest/ZUrlHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZUrlHelper); }
		}

		protected ZUrlHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ziggeo.androidsdk.net.rest']/class[@name='ZUrlHelper']/constructor[@name='ZUrlHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ZUrlHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ZUrlHelper)) {
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

	}
}
