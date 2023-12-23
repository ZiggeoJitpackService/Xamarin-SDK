using System;
using AVFoundation;
using AVKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using ReplayKit;
using UIKit;

namespace ZiggeoMediaSDK
{

	// @interface AspectRatio : NSObject
	[BaseType(typeof(NSObject))]
	interface AspectRatio
	{
		// @property (nonatomic) int mX;
		[Export("mX")]
		int MX { get; set; }

		// @property (nonatomic) int mY;
		[Export("mY")]
		int MY { get; set; }

		// -(instancetype)initWithX:(int)x y:(int)y;
		[Export("initWithX:y:")]
		IntPtr Constructor(int x, int y);

		// +(int)gcd:(int)a :(int)b;
		[Static]
		[Export("gcd::")]
		int Gcd(int a, int b);

		// +(AspectRatio *)of:(int)width :(int)height;
		[Static]
		[Export("of::")]
		AspectRatio Of(int width, int height);

		// +(AspectRatio *)parse:(NSString *)string;
		[Static]
		[Export("parse:")]
		AspectRatio Parse(string @string);

		// -(int)getX;
		[Export("getX")]

		int X { get; }

		// -(int)getY;
		[Export("getY")]

		int Y { get; }

		// -(NSString *)toString;
		[Export("toString")]

		string ToString { get; }

		// -(float)toFloat;
		[Export("toFloat")]

		float ToFloat { get; }

		// -(_Bool)matches:(VideoSize *)size;
		[Export("matches:")]
		bool Matches(VideoSize size);

		// -(_Bool)equals:(AspectRatio *)ratio;
		[Export("equals:")]
		bool Equals(AspectRatio ratio);

		// -(int)compareTo:(AspectRatio *)ratio;
		[Export("compareTo:")]
		int CompareTo(AspectRatio ratio);

		// -(AspectRatio *)inverse;
		[Export("inverse")]

		AspectRatio Inverse { get; }
	}

	// @interface ContentModel : NSObject
	[BaseType(typeof(NSObject))]
	interface ContentModel
	{
		// @property (nonatomic, strong) NSString * key;
		[Export("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _description;
		[Export("_description", ArgumentSemantic.Strong)]
		string _description { get; set; }

		// @property (nonatomic, strong) NSString * stateString;
		[Export("stateString", ArgumentSemantic.Strong)]
		string StateString { get; set; }

		// @property (nonatomic, strong) NSString * token;
		[Export("token", ArgumentSemantic.Strong)]
		string Token { get; set; }

		// @property (nonatomic, strong) NSString * streamToken;
		[Export("streamToken", ArgumentSemantic.Strong)]
		string StreamToken { get; set; }

		// @property (nonatomic) long date;
		[Export("date")]
		nint Date { get; set; }

		// @property (nonatomic) double duration;
		[Export("duration")]
		double Duration { get; set; }

		// -(NSString *)getDescription;
		[Export("getDescription")]

		string Description { get; }

		// -(void)setDescription:(NSString *)description;
		[Export("setDescription:")]
		void SetDescription(string description);
	}

	// @interface DeviceInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface DeviceInfo
	{
		// @property (nonatomic, strong) NSString * os;
		[Export("os", ArgumentSemantic.Strong)]
		string Os { get; set; }

		// @property (nonatomic, strong) NSString * ziggeoSdkVer;
		[Export("ziggeoSdkVer", ArgumentSemantic.Strong)]
		string ZiggeoSdkVer { get; set; }

		// @property (nonatomic, strong) NSString * deviceModel;
		[Export("deviceModel", ArgumentSemantic.Strong)]
		string DeviceModel { get; set; }

		// @property (nonatomic, strong) NSString * systemVersion;
		[Export("systemVersion", ArgumentSemantic.Strong)]
		string SystemVersion { get; set; }

		// @property (nonatomic, strong) NSString * deviceName;
		[Export("deviceName", ArgumentSemantic.Strong)]
		string DeviceName { get; set; }

		// -(id)initWithJson:(NSDictionary *)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);

		// -(void)setInfo:(NSDictionary *)json;
		[Export("setInfo:")]
		void SetInfo(NSDictionary json);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// -(NSString *)toString;
		[Export("toString")]

		string ToString { get; }

		// -(NSDictionary *)toDictionary;
		[Export("toDictionary")]

		NSDictionary ToDictionary { get; }
	}

	// @interface StreamModel : NSObject
	[BaseType(typeof(NSObject))]
	interface StreamModel
	{
		// @property (nonatomic) _Bool _volatile;
		[Export("_volatile")]
		bool _volatile { get; set; }

		// @property (nonatomic, strong) NSString * token;
		[Export("token", ArgumentSemantic.Strong)]
		string Token { get; set; }

		// @property (nonatomic, strong) NSString * key;
		[Export("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic) int creationType;
		[Export("creationType")]
		int CreationType { get; set; }

		// @property (nonatomic) int state;
		[Export("state")]
		int State { get; set; }

		// @property (nonatomic) int streamable;
		[Export("streamable")]
		int Streamable { get; set; }

		// @property (nonatomic, strong) NSDictionary * videoAnalysis;
		[Export("videoAnalysis", ArgumentSemantic.Strong)]
		NSDictionary VideoAnalysis { get; set; }

		// @property (nonatomic, strong) NSDictionary * audioTranscription;
		[Export("audioTranscription", ArgumentSemantic.Strong)]
		NSDictionary AudioTranscription { get; set; }

		// @property (nonatomic, strong) NSArray * audioKeywords;
		[Export("audioKeywords", ArgumentSemantic.Strong)]

		NSObject[] AudioKeywords { get; set; }

		// @property (nonatomic, strong) NSArray * pushServicesSuccess;
		[Export("pushServicesSuccess", ArgumentSemantic.Strong)]

		NSObject[] PushServicesSuccess { get; set; }

		// @property (nonatomic, strong) NSString * defaultStreamId;
		[Export("defaultStreamId", ArgumentSemantic.Strong)]
		string DefaultStreamId { get; set; }

		// @property (nonatomic, strong) NSString * effectProfile;
		[Export("effectProfile", ArgumentSemantic.Strong)]
		string EffectProfile { get; set; }

		// @property (nonatomic, strong) NSString * effectProfileId;
		[Export("effectProfileId", ArgumentSemantic.Strong)]
		string EffectProfileId { get; set; }

		// @property (nonatomic, strong) NSString * videoProfileTranscoding;
		[Export("videoProfileTranscoding", ArgumentSemantic.Strong)]
		string VideoProfileTranscoding { get; set; }

		// @property (nonatomic, strong) NSString * videoType;
		[Export("videoType", ArgumentSemantic.Strong)]
		string VideoType { get; set; }

		// @property (nonatomic, strong) NSString * videoSubType;
		[Export("videoSubType", ArgumentSemantic.Strong)]
		string VideoSubType { get; set; }

		// @property (nonatomic) int imageSize;
		[Export("imageSize")]
		int ImageSize { get; set; }

		// @property (nonatomic) int audioSize;
		[Export("audioSize")]
		int AudioSize { get; set; }

		// @property (nonatomic) int videoSize;
		[Export("videoSize")]
		int VideoSize { get; set; }

		// @property (nonatomic) int videoWidth;
		[Export("videoWidth")]
		int VideoWidth { get; set; }

		// @property (nonatomic) int videoHeight;
		[Export("videoHeight")]
		int VideoHeight { get; set; }

		// @property (nonatomic) double duration;
		[Export("duration")]
		double Duration { get; set; }

		// @property (nonatomic) _Bool hasVideo;
		[Export("hasVideo")]
		bool HasVideo { get; set; }

		// @property (nonatomic) _Bool hasImage;
		[Export("hasImage")]
		bool HasImage { get; set; }

		// @property (nonatomic) _Bool hasAudio;
		[Export("hasAudio")]
		bool HasAudio { get; set; }

		// @property (nonatomic) _Bool videoHasAudio;
		[Export("videoHasAudio")]
		bool VideoHasAudio { get; set; }

		// @property (nonatomic, strong) NSDictionary * nsfw;
		[Export("nsfw", ArgumentSemantic.Strong)]
		NSDictionary Nsfw { get; set; }

		// @property (nonatomic) int submissionDate;
		[Export("submissionDate")]
		int SubmissionDate { get; set; }

		// @property (nonatomic, strong) NSArray * subtitles;
		[Export("subtitles", ArgumentSemantic.Strong)]

		NSObject[] Subtitles { get; set; }

		// @property (nonatomic, strong) NSString * type;
		[Export("type", ArgumentSemantic.Strong)]
		string Type { get; set; }

		// @property (nonatomic) int created;
		[Export("created")]
		int Created { get; set; }

		// @property (nonatomic) _Bool owned;
		[Export("owned")]
		bool Owned { get; set; }

		// @property (nonatomic, strong) NSString * creationTypeString;
		[Export("creationTypeString", ArgumentSemantic.Strong)]
		string CreationTypeString { get; set; }

		// @property (nonatomic, strong) NSString * streamableString;
		[Export("streamableString", ArgumentSemantic.Strong)]
		string StreamableString { get; set; }

		// @property (nonatomic, strong) NSString * stateString;
		[Export("stateString", ArgumentSemantic.Strong)]
		string StateString { get; set; }

		// @property (nonatomic, strong) NSString * videoToken;
		[Export("videoToken", ArgumentSemantic.Strong)]
		string VideoToken { get; set; }

		// @property (nonatomic, strong) NSString * parentStream;
		[Export("parentStream", ArgumentSemantic.Strong)]
		string ParentStream { get; set; }

		// -(id)initWithJson:(NSDictionary *)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);

		// -(void)setInfo:(NSDictionary *)json;
		[Export("setInfo:")]
		void SetInfo(NSDictionary json);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// -(NSDictionary *)toDictionary;
		[Export("toDictionary")]

		NSDictionary ToDictionary { get; }

		// -(_Bool)isVolatile;
		[Export("isVolatile")]

		bool IsVolatile { get; }

		// -(void)setVolatile:(_Bool)_volatile;
		[Export("setVolatile:")]
		void SetVolatile(bool _volatile);
	}

	// @interface Audio : ContentModel
	[BaseType(typeof(ContentModel))]
	interface Audio
	{
		// @property (nonatomic, strong) NSString * _id;
		[Export("_id", ArgumentSemantic.Strong)]
		string _id { get; set; }

		// @property (nonatomic, strong) NSString * created;
		[Export("created", ArgumentSemantic.Strong)]
		string Created { get; set; }

		// @property (nonatomic, strong) NSString * updated;
		[Export("updated", ArgumentSemantic.Strong)]
		string Updated { get; set; }

		// @property (nonatomic, strong) NSString * applicationId;
		[Export("applicationId", ArgumentSemantic.Strong)]
		string ApplicationId { get; set; }

		// @property (nonatomic) int state;
		[Export("state")]
		int State { get; set; }

		// @property (nonatomic) double minDuration;
		[Export("minDuration")]
		double MinDuration { get; set; }

		// @property (nonatomic, strong) NSString * maxDuration;
		[Export("maxDuration", ArgumentSemantic.Strong)]
		string MaxDuration { get; set; }

		// @property (nonatomic) _Bool enforceDuration;
		[Export("enforceDuration")]
		bool EnforceDuration { get; set; }

		// @property (nonatomic, strong) NSString * originalStreamId;
		[Export("originalStreamId", ArgumentSemantic.Strong)]
		string OriginalStreamId { get; set; }

		// @property (nonatomic, strong) NSString * defaultStreamId;
		[Export("defaultStreamId", ArgumentSemantic.Strong)]
		string DefaultStreamId { get; set; }

		// @property (nonatomic, strong) NSArray * tags;
		[Export("tags", ArgumentSemantic.Strong)]

		NSObject[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * data;
		[Export("data", ArgumentSemantic.Strong)]
		string Data { get; set; }

		// @property (nonatomic, strong) DeviceInfo * deviceInfo;
		[Export("deviceInfo", ArgumentSemantic.Strong)]
		DeviceInfo DeviceInfo { get; set; }

		// @property (nonatomic) long submissionDate;
		[Export("submissionDate")]
		nint SubmissionDate { get; set; }

		// @property (nonatomic, strong) NSString * expirationDays;
		[Export("expirationDays", ArgumentSemantic.Strong)]
		string ExpirationDays { get; set; }

		// @property (nonatomic, strong) NSString * resubmissionDate;
		[Export("resubmissionDate", ArgumentSemantic.Strong)]
		string ResubmissionDate { get; set; }

		// @property (nonatomic) long streamSubmissionDate;
		[Export("streamSubmissionDate")]
		nint StreamSubmissionDate { get; set; }

		// @property (nonatomic) _Bool userLanguage;
		[Export("userLanguage")]
		bool UserLanguage { get; set; }

		// @property (nonatomic) _Bool deleteOldStreams;
		[Export("deleteOldStreams")]
		bool DeleteOldStreams { get; set; }

		// @property (nonatomic) _Bool autoCrop;
		[Export("autoCrop")]
		bool AutoCrop { get; set; }

		// @property (nonatomic, strong) NSString * creationAuthSessionId;
		[Export("creationAuthSessionId", ArgumentSemantic.Strong)]
		string CreationAuthSessionId { get; set; }

		// @property (nonatomic) int averageRating;
		[Export("averageRating")]
		int AverageRating { get; set; }

		// @property (nonatomic, strong) NSString * ratings;
		[Export("ratings", ArgumentSemantic.Strong)]
		string Ratings { get; set; }

		// @property (nonatomic, strong) NSArray * comments;
		[Export("comments", ArgumentSemantic.Strong)]

		NSObject[] Comments { get; set; }

		// @property (nonatomic) _Bool submitted;
		[Export("submitted")]
		bool Submitted { get; set; }

		// @property (nonatomic, strong) NSString * approved;
		[Export("approved", ArgumentSemantic.Strong)]
		string Approved { get; set; }

		// @property (nonatomic, strong) NSString * moderationReason;
		[Export("moderationReason", ArgumentSemantic.Strong)]
		string ModerationReason { get; set; }

		// @property (nonatomic, strong) NSString * audioProfileId;
		[Export("audioProfileId", ArgumentSemantic.Strong)]
		string AudioProfileId { get; set; }

		// @property (nonatomic, strong) NSString * metaProfileId;
		[Export("metaProfileId", ArgumentSemantic.Strong)]
		string MetaProfileId { get; set; }

		// @property (nonatomic) _Bool _volatile;
		[Export("_volatile")]
		bool _volatile { get; set; }

		// @property (nonatomic, strong) NSDictionary * defaultStream;
		[Export("defaultStream", ArgumentSemantic.Strong)]
		NSDictionary DefaultStream { get; set; }

		// @property (nonatomic, strong) StreamModel * originalStream;
		[Export("originalStream", ArgumentSemantic.Strong)]
		StreamModel OriginalStream { get; set; }

		// -(id)initWithJson:(NSDictionary *)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);

		// -(void)setInfo:(NSDictionary *)json;
		[Export("setInfo:")]
		void SetInfo(NSDictionary json);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// -(NSDictionary *)toDictionary;
		[Export("toDictionary")]

		NSDictionary ToDictionary { get; }

		// -(NSString *)getId;
		[Export("getId")]

		string Id { get; }

		// -(void)setId:(NSString *)_id;
		[Export("setId:")]
		void SetId(string _id);
	}

	// @interface CacheConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface CacheConfig
	{
		// @property (nonatomic) int maxCacheSize;
		[Export("maxCacheSize")]
		int MaxCacheSize { get; set; }

		// @property (nonatomic) NSString * cacheRoot;
		[Export("cacheRoot")]
		string CacheRoot { get; set; }

		// -(NSString *)toString;
		[Export("toString")]

		string ToString { get; }

		// -(NSString *)stringValueConfig;
		[Export("stringValueConfig")]

		string StringValueConfig { get; }
	}

	// @interface CameraRecorderStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface CameraRecorderStyle
	{
		// @property (nonatomic) _Bool hideControls;
		[Export("hideControls")]
		bool HideControls { get; set; }
	}

	// @interface FileInfoData : NSObject
	[BaseType(typeof(NSObject))]
	interface FileInfoData
	{
		// @property (nonatomic, strong) NSString * path;
		[Export("path", ArgumentSemantic.Strong)]
		string Path { get; set; }

		// @property (nonatomic, strong) NSURL * url;
		[Export("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; set; }

		// @property (nonatomic, strong) NSString * mimeType;
		[Export("mimeType", ArgumentSemantic.Strong)]
		string MimeType { get; set; }

		// @property (nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// -(id)initWithPath:(NSString *)path mimeType:(NSString *)mimeType name:(NSString *)name;
		[Export("initWithPath:mimeType:name:")]
		IntPtr Constructor(string path, string mimeType, string name);

		// -(id)initWithUrl:(NSURL *)url mimeType:(NSString *)mimeType name:(NSString *)name;
		[Export("initWithUrl:mimeType:name:")]
		IntPtr Constructor(NSUrl url, string mimeType, string name);
	}

	// @interface FileSelectorConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface FileSelectorConfig
	{
		// @property (nonatomic) long maxDuration;
		[Export("maxDuration")]
		nint MaxDuration { get; set; }

		// @property (nonatomic) long minDuration;
		[Export("minDuration")]
		nint MinDuration { get; set; }

		// @property (nonatomic) _Bool shouldAllowMultipleSelection;
		[Export("shouldAllowMultipleSelection")]
		bool ShouldAllowMultipleSelection { get; set; }

		// @property (nonatomic) int mediaType;
		[Export("mediaType")]
		int MediaType { get; set; }

		// @property (nonatomic, strong) NSDictionary * extraArgs;
		[Export("extraArgs", ArgumentSemantic.Strong)]
		NSDictionary ExtraArgs { get; set; }

		// -(void)addExtraArgs:(NSDictionary *)extraArgs;
		[Export("addExtraArgs:")]
		void AddExtraArgs(NSDictionary extraArgs);

		// -(NSString *)stringValueConfig;
		[Export("stringValueConfig")]

		string StringValueConfig { get; }
	}

	// @interface Image : ContentModel
	[BaseType(typeof(ContentModel))]
	interface Image
	{
		// @property (nonatomic, strong) NSString * _id;
		[Export("_id", ArgumentSemantic.Strong)]
		string _id { get; set; }

		// @property (nonatomic, strong) NSString * created;
		[Export("created", ArgumentSemantic.Strong)]
		string Created { get; set; }

		// @property (nonatomic, strong) NSString * updated;
		[Export("updated", ArgumentSemantic.Strong)]
		string Updated { get; set; }

		// @property (nonatomic, strong) NSString * applicationId;
		[Export("applicationId", ArgumentSemantic.Strong)]
		string ApplicationId { get; set; }

		// @property (nonatomic) int state;
		[Export("state")]
		int State { get; set; }

		// @property (nonatomic) double imageSource;
		[Export("imageSource")]
		double ImageSource { get; set; }

		// @property (nonatomic, strong) NSString * originalStreamId;
		[Export("originalStreamId", ArgumentSemantic.Strong)]
		string OriginalStreamId { get; set; }

		// @property (nonatomic, strong) NSString * defaultStreamId;
		[Export("defaultStreamId", ArgumentSemantic.Strong)]
		string DefaultStreamId { get; set; }

		// @property (nonatomic, strong) NSArray * tags;
		[Export("tags", ArgumentSemantic.Strong)]

		NSObject[] Tags { get; set; }

		// @property (nonatomic, strong) NSString * data;
		[Export("data", ArgumentSemantic.Strong)]
		string Data { get; set; }

		// @property (nonatomic, strong) DeviceInfo * deviceInfo;
		[Export("deviceInfo", ArgumentSemantic.Strong)]
		DeviceInfo DeviceInfo { get; set; }

		// @property (nonatomic) long submissionDate;
		[Export("submissionDate")]
		nint SubmissionDate { get; set; }

		// @property (nonatomic, strong) NSString * expirationDays;
		[Export("expirationDays", ArgumentSemantic.Strong)]
		string ExpirationDays { get; set; }

		// @property (nonatomic, strong) NSString * resubmissionDate;
		[Export("resubmissionDate", ArgumentSemantic.Strong)]
		string ResubmissionDate { get; set; }

		// @property (nonatomic, strong) NSString * streamSubmissionDate;
		[Export("streamSubmissionDate", ArgumentSemantic.Strong)]
		string StreamSubmissionDate { get; set; }

		// @property (nonatomic, strong) NSString * userLanguage;
		[Export("userLanguage", ArgumentSemantic.Strong)]
		string UserLanguage { get; set; }

		// @property (nonatomic, strong) NSString * deleteOldStreams;
		[Export("deleteOldStreams", ArgumentSemantic.Strong)]
		string DeleteOldStreams { get; set; }

		// @property (nonatomic, strong) NSString * autoCrop;
		[Export("autoCrop", ArgumentSemantic.Strong)]
		string AutoCrop { get; set; }

		// @property (nonatomic) _Bool autoPad;
		[Export("autoPad")]
		bool AutoPad { get; set; }

		// @property (nonatomic) _Bool hd;
		[Export("hd")]
		bool Hd { get; set; }

		// @property (nonatomic, strong) NSString * creationAuthSessionId;
		[Export("creationAuthSessionId", ArgumentSemantic.Strong)]
		string CreationAuthSessionId { get; set; }

		// @property (nonatomic) int averageRating;
		[Export("averageRating")]
		int AverageRating { get; set; }

		// @property (nonatomic, strong) NSString * ratings;
		[Export("ratings", ArgumentSemantic.Strong)]
		string Ratings { get; set; }

		// @property (nonatomic, strong) NSArray * comments;
		[Export("comments", ArgumentSemantic.Strong)]

		NSObject[] Comments { get; set; }

		// @property (nonatomic, strong) NSString * submitted;
		[Export("submitted", ArgumentSemantic.Strong)]
		string Submitted { get; set; }

		// @property (nonatomic, strong) NSString * approved;
		[Export("approved", ArgumentSemantic.Strong)]
		string Approved { get; set; }

		// @property (nonatomic, strong) NSString * moderationReason;
		[Export("moderationReason", ArgumentSemantic.Strong)]
		string ModerationReason { get; set; }

		// @property (nonatomic) int facebookLikes;
		[Export("facebookLikes")]
		int FacebookLikes { get; set; }

		// @property (nonatomic) int facebookShares;
		[Export("facebookShares")]
		int FacebookShares { get; set; }

		// @property (nonatomic, strong) NSString * imageFileName;
		[Export("imageFileName", ArgumentSemantic.Strong)]
		string ImageFileName { get; set; }

		// -(id)initWithJson:(NSDictionary *)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);

		// -(void)setInfo:(NSDictionary *)json;
		[Export("setInfo:")]
		void SetInfo(NSDictionary json);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// -(NSDictionary *)toDictionary;
		[Export("toDictionary")]

		NSDictionary ToDictionary { get; }

		// -(NSString *)getId;
		[Export("getId")]

		string Id { get; }

		// -(void)setId:(NSString *)_id;
		[Export("setId:")]
		void SetId(string _id);
	}

	// @interface MediaFields : NSObject
	[BaseType(typeof(NSObject))]
	interface MediaFields
	{
		// @property (nonatomic, strong) NSString * key;
		[Export("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSString * contentType;
		[Export("contentType", ArgumentSemantic.Strong)]
		string ContentType { get; set; }

		// @property (nonatomic, strong) NSString * bucket;
		[Export("bucket", ArgumentSemantic.Strong)]
		string Bucket { get; set; }

		// @property (nonatomic, strong) NSString * xAmzAlgorithm;
		[Export("xAmzAlgorithm", ArgumentSemantic.Strong)]
		string XAmzAlgorithm { get; set; }

		// @property (nonatomic, strong) NSString * xAmzCredential;
		[Export("xAmzCredential", ArgumentSemantic.Strong)]
		string XAmzCredential { get; set; }

		// @property (nonatomic, strong) NSString * xAmzSignature;
		[Export("xAmzSignature", ArgumentSemantic.Strong)]
		string XAmzSignature { get; set; }

		// @property (nonatomic, strong) NSString * xAmzDate;
		[Export("xAmzDate", ArgumentSemantic.Strong)]
		string XAmzDate { get; set; }

		// @property (nonatomic, strong) NSString * xAmzSecurityToken;
		[Export("xAmzSecurityToken", ArgumentSemantic.Strong)]
		string XAmzSecurityToken { get; set; }

		// @property (nonatomic, strong) NSString * policy;
		[Export("policy", ArgumentSemantic.Strong)]
		string Policy { get; set; }

		// -(id)initWithJson:(NSDictionary *)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);

		// -(void)setInfo:(NSDictionary *)json;
		[Export("setInfo:")]
		void SetInfo(NSDictionary json);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// -(NSString *)toString;
		[Export("toString")]

		string ToString { get; }

		// -(NSDictionary *)toDictionary;
		[Export("toDictionary")]

		NSDictionary ToDictionary { get; }
	}

	// @interface PlayerStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface PlayerStyle
	{
		// @property (nonatomic) _Bool hideControls;
		[Export("hideControls")]
		bool HideControls { get; set; }
	}

	// @interface PlayerConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface PlayerConfig
	{
		// @property (nonatomic, strong) PlayerStyle * style;
		[Export("style", ArgumentSemantic.Strong)]
		PlayerStyle Style { get; set; }

		// @property (nonatomic) _Bool shouldShowSubtitles;
		[Export("shouldShowSubtitles")]
		bool ShouldShowSubtitles { get; set; }

		// @property (nonatomic) _Bool shouldPreload;
		[Export("shouldPreload")]
		bool ShouldPreload { get; set; }

		// @property (nonatomic) _Bool isMuted;
		[Export("isMuted")]
		bool IsMuted { get; set; }

		// @property (nonatomic) _Bool isCachingEnabled;
		[Export("isCachingEnabled")]
		bool IsCachingEnabled { get; set; }

		// @property (nonatomic, strong) NSString * adsUri;
		[Export("adsUri", ArgumentSemantic.Strong)]
		string AdsUri { get; set; }

		// @property (nonatomic, strong) NSDictionary * extraArgs;
		[Export("extraArgs", ArgumentSemantic.Strong)]
		NSDictionary ExtraArgs { get; set; }

		// -(void)addExtraArgs:(NSDictionary *)extraArgs;
		[Export("addExtraArgs:")]
		void AddExtraArgs(NSDictionary extraArgs);

		// -(NSString *)toString;
		[Export("toString")]

		string ToString { get; }

		// -(NSString *)stringValueConfig;
		[Export("stringValueConfig")]

		string StringValueConfig { get; }
	}

	// @interface QrScannerConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface QrScannerConfig
	{
		// @property (nonatomic) _Bool shouldCloseAfterSuccessfulScan;
		[Export("shouldCloseAfterSuccessfulScan")]
		bool ShouldCloseAfterSuccessfulScan { get; set; }

		// -(NSString *)stringValueConfig;
		[Export("stringValueConfig")]

		string StringValueConfig { get; }
	}

	// @interface VideoSize : NSObject
	[BaseType(typeof(NSObject))]
	interface VideoSize
	{
		// @property (nonatomic) int width;
		[Export("width")]
		int Width { get; set; }

		// @property (nonatomic) int height;
		[Export("height")]
		int Height { get; set; }

		// @property (nonatomic) AspectRatio * aspectRatio;
		[Export("aspectRatio", ArgumentSemantic.Assign)]
		AspectRatio AspectRatio { get; set; }

		// -(instancetype)initWithWidth:(int)width height:(int)height;
		[Export("initWithWidth:height:")]
		IntPtr Constructor(int width, int height);

		// -(instancetype)initWithWidth:(int)width height:(int)height aspectRatio:(AspectRatio *)aspectRatio;
		[Export("initWithWidth:height:aspectRatio:")]
		IntPtr Constructor(int width, int height, AspectRatio aspectRatio);

		// -(_Bool)equals:(VideoSize *)size;
		[Export("equals:")]
		bool Equals(VideoSize size);

		// -(NSString *)toString;
		[Export("toString")]

		string ToString { get; }

		// -(int)compareTo:(VideoSize *)size;
		[Export("compareTo:")]
		int CompareTo(VideoSize size);
	}

	// @interface StopRecordingConfirmationDialogConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface StopRecordingConfirmationDialogConfig
	{
		// @property (nonatomic, strong) NSString * titleText;
		[Export("titleText", ArgumentSemantic.Strong)]
		string TitleText { get; set; }

		// @property (nonatomic, strong) NSString * mesText;
		[Export("mesText", ArgumentSemantic.Strong)]
		string MesText { get; set; }

		// @property (nonatomic, strong) NSString * posBtnText;
		[Export("posBtnText", ArgumentSemantic.Strong)]
		string PosBtnText { get; set; }

		// @property (nonatomic, strong) NSString * negBtnText;
		[Export("negBtnText", ArgumentSemantic.Strong)]
		string NegBtnText { get; set; }

		// -(NSString *)stringValueConfig;
		[Export("stringValueConfig")]

		string StringValueConfig { get; }
	}

	// @interface RecorderConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface RecorderConfig
	{
		// @property (nonatomic, strong) CameraRecorderStyle * style;
		[Export("style", ArgumentSemantic.Strong)]
		CameraRecorderStyle Style { get; set; }

		// @property (nonatomic) _Bool shouldShowFaceOutline;
		[Export("shouldShowFaceOutline")]
		bool ShouldShowFaceOutline { get; set; }

		// @property (nonatomic, strong) UIImage * faceOutlineDrawable;
		[Export("faceOutlineDrawable", ArgumentSemantic.Strong)]
		UIImage FaceOutlineDrawable { get; set; }

		// @property (nonatomic) _Bool isLiveStreaming;
		[Export("isLiveStreaming")]
		bool IsLiveStreaming { get; set; }

		// @property (nonatomic) _Bool shouldAutoStartRecording;
		[Export("shouldAutoStartRecording")]
		bool ShouldAutoStartRecording { get; set; }

		// @property (nonatomic) _Bool isImageOnlyMode;
		[Export("isImageOnlyMode")]
		bool IsImageOnlyMode { get; set; }

		// @property (nonatomic) _Bool isPausedMode;
		[Export("isPausedMode")]
		bool IsPausedMode { get; set; }

		// @property (nonatomic) int startDelay;
		[Export("startDelay")]
		int StartDelay { get; set; }

		// @property (nonatomic) _Bool shouldSendImmediately;
		[Export("shouldSendImmediately")]
		bool ShouldSendImmediately { get; set; }

		// @property (nonatomic) _Bool shouldDisableCameraSwitch;
		[Export("shouldDisableCameraSwitch")]
		bool ShouldDisableCameraSwitch { get; set; }

		// @property (nonatomic) int videoQuality;
		[Export("videoQuality")]
		int VideoQuality { get; set; }

		// @property (nonatomic) int facing;
		[Export("facing")]
		int Facing { get; set; }

		// @property (nonatomic) _Bool blurMode;
		[Export("blurMode")]
		bool BlurMode { get; set; }

		// @property (nonatomic) long maxDuration;
		[Export("maxDuration")]
		nint MaxDuration { get; set; }

		// @property (nonatomic) _Bool shouldEnableCoverShot;
		[Export("shouldEnableCoverShot")]
		bool ShouldEnableCoverShot { get; set; }

		// @property (nonatomic) UIColor * colorForStoppedCameraOverlay;
		[Export("colorForStoppedCameraOverlay", ArgumentSemantic.Assign)]
		UIColor ColorForStoppedCameraOverlay { get; set; }

		// @property (nonatomic) UIImage * drawableForStoppedCameraOverlay;
		[Export("drawableForStoppedCameraOverlay", ArgumentSemantic.Assign)]
		UIImage DrawableForStoppedCameraOverlay { get; set; }

		// @property (nonatomic) _Bool shouldConfirmStopRecording;
		[Export("shouldConfirmStopRecording")]
		bool ShouldConfirmStopRecording { get; set; }

		// @property (nonatomic, strong) VideoSize * resolution;
		[Export("resolution", ArgumentSemantic.Strong)]
		VideoSize Resolution { get; set; }

		// @property (nonatomic) int videoBitrate;
		[Export("videoBitrate")]
		int VideoBitrate { get; set; }

		// @property (nonatomic) int audioBitrate;
		[Export("audioBitrate")]
		int AudioBitrate { get; set; }

		// @property (nonatomic) int audioSampleRate;
		[Export("audioSampleRate")]
		int AudioSampleRate { get; set; }

		// @property (nonatomic, strong) CacheConfig * cacheConfig;
		[Export("cacheConfig", ArgumentSemantic.Strong)]
		CacheConfig CacheConfig { get; set; }

		// @property (nonatomic, strong) StopRecordingConfirmationDialogConfig * stopRecordingConfirmationDialogConfig;
		[Export("stopRecordingConfirmationDialogConfig", ArgumentSemantic.Strong)]
		StopRecordingConfirmationDialogConfig StopRecordingConfirmationDialogConfig { get; set; }

		// @property (nonatomic, strong) NSDictionary * extraArgs;
		[Export("extraArgs", ArgumentSemantic.Strong)]
		NSDictionary ExtraArgs { get; set; }

		// -(void)setLiveStreaming:(_Bool)liveStreaming;
		[Export("setLiveStreaming:")]
		void SetLiveStreaming(bool liveStreaming);

		// -(void)setImageOnlyMode:(_Bool)imageOnlyMode;
		[Export("setImageOnlyMode:")]
		void SetImageOnlyMode(bool imageOnlyMode);

		// -(void)addExtraArgs:(NSDictionary *)extraArgs;
		[Export("addExtraArgs:")]
		void AddExtraArgs(NSDictionary extraArgs);

		// -(NSString *)stringValueConfig;
		[Export("stringValueConfig")]

		string StringValueConfig { get; }
	}

	// @protocol ZiggeoHardwarePermissionDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoHardwarePermissionDelegate
	{
		// @optional -(void)checkCameraPermission:(BOOL)granted;
		[Export("checkCameraPermission:")]
		void CheckCameraPermission(bool granted);

		// @optional -(void)checkMicrophonePermission:(BOOL)granted;
		[Export("checkMicrophonePermission:")]
		void CheckMicrophonePermission(bool granted);

		// @optional -(void)checkPhotoLibraryPermission:(BOOL)granted;
		[Export("checkPhotoLibraryPermission:")]
		void CheckPhotoLibraryPermission(bool granted);

		// @optional -(void)checkHasCamera:(BOOL)hasCamera;
		[Export("checkHasCamera:")]
		void CheckHasCamera(bool hasCamera);

		// @optional -(void)checkHasMicrophone:(BOOL)hasMicrophone;
		[Export("checkHasMicrophone:")]
		void CheckHasMicrophone(bool hasMicrophone);
	}

	// @protocol ZiggeoUploadingDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoUploadingDelegate
	{
		// @optional -(void)preparingToUploadWithPath:(NSString *)sourcePath;
		[Export("preparingToUploadWithPath:")]
		void PreparingToUploadWithPath(string sourcePath);

		// @optional -(void)uploadStartedWithPath:(NSString *)sourcePath token:(NSString *)token streamToken:(NSString *)streamToken backgroundTask:(NSUrlSessionTask *)uploadingTask;
		[Export("uploadStartedWithPath:token:streamToken:backgroundTask:")]
		void UploadStartedWithPath(string sourcePath, string token, string streamToken, NSUrlSessionTask uploadingTask);

		// @optional -(void)uploadProgressWithPath:(NSString *)sourcePath token:(NSString *)token streamToken:(NSString *)streamToken totalBytesSent:(int)bytesSent totalBytesExpectedToSend:(int)totalBytes;
		[Export("uploadProgressWithPath:token:streamToken:totalBytesSent:totalBytesExpectedToSend:")]
		void UploadProgressWithPath(string sourcePath, string token, string streamToken, int bytesSent, int totalBytes);

		// @optional -(void)uploadFinishedWithPath:(NSString *)sourcePath token:(NSString *)token streamToken:(NSString *)streamToken;
		[Export("uploadFinishedWithPath:token:streamToken:")]
		void UploadFinishedWithPath(string sourcePath, string token, string streamToken);

		// @optional -(void)uploadVerifiedWithPath:(NSString *)sourcePath token:(NSString *)token streamToken:(NSString *)streamToken withResponse:(NSUrlResponse *)response error:(NSError *)error json:(NSDictionary *)json;
		[Export("uploadVerifiedWithPath:token:streamToken:withResponse:error:json:")]
		void UploadVerifiedWithPath(string sourcePath, string token, string streamToken, NSUrlResponse response, NSError error, NSDictionary json);

		// @optional -(void)uploadProcessingWithPath:(NSString *)sourcePath token:(NSString *)token streamToken:(NSString *)streamToken;
		[Export("uploadProcessingWithPath:token:streamToken:")]
		void UploadProcessingWithPath(string sourcePath, string token, string streamToken);

		// @optional -(void)uploadProcessedWithPath:(NSString *)sourcePath token:(NSString *)token streamToken:(NSString *)streamToken;
		[Export("uploadProcessedWithPath:token:streamToken:")]
		void UploadProcessedWithPath(string sourcePath, string token, string streamToken);

		// @optional -(void)deleteWithToken:(NSString *)token streamToken:(NSString *)streamToken withResponse:(NSUrlResponse *)response error:(NSError *)error json:(NSDictionary *)json;
		[Export("deleteWithToken:streamToken:withResponse:error:json:")]
		void DeleteWithToken(string token, string streamToken, NSUrlResponse response, NSError error, NSDictionary json);

		// @optional -(void)cancelUploadByPath:(NSString *)sourcePath deleteFile:(BOOL)deleteFile;
		[Export("cancelUploadByPath:deleteFile:")]
		void CancelUploadByPath(string sourcePath, bool deleteFile);

		// @optional -(void)cancelCurrentUpload:(BOOL)deleteFile;
		[Export("cancelCurrentUpload:")]
		void CancelCurrentUpload(bool deleteFile);

		// @optional -(void)errorWithInfo:(RecordingInfo *)info error:(NSError *)error lostConnectionAction:(int)lostConnectionAction;
		[Export("errorWithInfo:error:lostConnectionAction:")]
		void ErrorWithInfo(RecordingInfo info, NSError error, int lostConnectionAction);

		// @optional -(void)errorWithError:(NSError *)error;
		[Export("errorWithError:")]
		void ErrorWithError(NSError error);
	}

	// @protocol ZiggeoFileSelectorDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoFileSelectorDelegate
	{
		// @optional -(void)uploadSelected:(NSArray<NSString *> *)paths;
		[Export("uploadSelected:")]
		void UploadSelected(string[] paths);

		// @optional -(void)uploadCancelledByUser;
		[Export("uploadCancelledByUser")]
		void UploadCancelledByUser();
	}

	// @protocol ZiggeoRecorderDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoRecorderDelegate
	{
		// @optional -(void)recorderCountdown:(int)secondsLeft;
		[Export("recorderCountdown:")]
		void RecorderCountdown(int secondsLeft);

		// @optional -(void)recorderReady;
		[Export("recorderReady")]
		void RecorderReady();

		// @optional -(void)recorderStarted;
		[Export("recorderStarted")]
		void RecorderStarted();

		// @optional -(void)recorderCurrentRecordedDurationSeconds:(double)seconds;
		[Export("recorderCurrentRecordedDurationSeconds:")]
		void RecorderCurrentRecordedDurationSeconds(double seconds);

		// @optional -(void)recorderPaused;
		[Export("recorderPaused")]
		void RecorderPaused();

		// @optional -(void)recorderStopped:(NSString *)path;
		[Export("recorderStopped:")]
		void RecorderStopped(string path);

		// @optional -(void)recorderRerecord;
		[Export("recorderRerecord")]
		void RecorderRerecord();

		// @optional -(void)recorderPlaying;
		[Export("recorderPlaying")]
		void RecorderPlaying();

		// @optional -(void)recorderManuallySubmitted;
		[Export("recorderManuallySubmitted")]
		void RecorderManuallySubmitted();

		// @optional -(void)streamingStarted;
		[Export("streamingStarted")]
		void StreamingStarted();

		// @optional -(void)streamingStopped;
		[Export("streamingStopped")]
		void StreamingStopped();

		// @optional -(void)recorderCancelledByUser;
		[Export("recorderCancelledByUser")]
		void RecorderCancelledByUser();
	}

	// @protocol ZiggeoSensorDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoSensorDelegate
	{
		// @optional -(void)luxMeter:(double)luminousity;
		[Export("luxMeter:")]
		void LuxMeter(double luminousity);

		// @optional -(void)audioMeter:(double)audioLevel;
		[Export("audioMeter:")]
		void AudioMeter(double audioLevel);

		// @optional -(void)faceDetected:(int)faceID rect:(CGRect)rect;
		[Export("faceDetected:rect:")]
		void FaceDetected(int faceID, CGRect rect);
	}

	// @protocol ZiggeoPlayerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoPlayerDelegate
	{
		// @optional -(void)playerPlaying;
		[Export("playerPlaying")]
		void PlayerPlaying();

		// @optional -(void)playerPaused;
		[Export("playerPaused")]
		void PlayerPaused();

		// @optional -(void)playerEnded;
		[Export("playerEnded")]
		void PlayerEnded();

		// @optional -(void)playerSeek:(double)positionMillis;
		[Export("playerSeek:")]
		void PlayerSeek(double positionMillis);

		// @optional -(void)playerReadyToPlay;
		[Export("playerReadyToPlay")]
		void PlayerReadyToPlay();

		// @optional -(void)playerCancelledByUser;
		[Export("playerCancelledByUser")]
		void PlayerCancelledByUser();
	}

	// @protocol ZiggeoQRScannerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoQRScannerDelegate
	{
		// @optional -(void)qrCodeScaned:(NSString *)qrCode;
		[Export("qrCodeScaned:")]
		void QrCodeScaned(string qrCode);

		// @optional -(void)qrCodeScanCancelledByUser;
		[Export("qrCodeScanCancelledByUser")]
		void QrCodeScanCancelledByUser();
	}

	// @protocol ZiggeoScreenRecorderDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface ZiggeoScreenRecorderDelegate
	{
	}

	// @interface Ziggeo : NSObject
	[BaseType(typeof(NSObject))]
	interface Ziggeo
	{
		// @property (nonatomic, strong) NSString * token;
		[Export("token", ArgumentSemantic.Strong)]
		string Token { get; set; }

		// @property (nonatomic) _Bool enableDebugLogs;
		[Export("enableDebugLogs")]
		bool EnableDebugLogs { get; set; }

		// -(id)initWithToken:(NSString *)token;
		[Export("initWithToken:")]
		IntPtr Constructor(string token);

		// -(void)sendLocalNotification:(NSString *)message;
		[Export("sendLocalNotification:")]
		void SendLocalNotification(string message);

		// -(void)setQRScannerDelegate:(id<ZiggeoQRScannerDelegate>)delegate;
		[Export("setQRScannerDelegate:")]
		void SetQRScannerDelegate(ZiggeoQRScannerDelegate @delegate);

		// -(void)setHardwarePermissionDelegate:(id<ZiggeoHardwarePermissionDelegate>)delegate;
		[Export("setHardwarePermissionDelegate:")]
		void SetHardwarePermissionDelegate(ZiggeoHardwarePermissionDelegate @delegate);

		// -(void)setUploadingDelegate:(id<ZiggeoUploadingDelegate>)delegate;
		[Export("setUploadingDelegate:")]
		void SetUploadingDelegate(ZiggeoUploadingDelegate @delegate);

		// -(void)setFileSelectorDelegate:(id<ZiggeoFileSelectorDelegate>)delegate;
		[Export("setFileSelectorDelegate:")]
		void SetFileSelectorDelegate(ZiggeoFileSelectorDelegate @delegate);

		// -(void)setRecorderDelegate:(id<ZiggeoRecorderDelegate>)delegate;
		[Export("setRecorderDelegate:")]
		void SetRecorderDelegate(ZiggeoRecorderDelegate @delegate);

		// -(void)setSensorDelegate:(id<ZiggeoSensorDelegate>)delegate;
		[Export("setSensorDelegate:")]
		void SetSensorDelegate(ZiggeoSensorDelegate @delegate);

		// -(void)setPlayerDelegate:(id<ZiggeoPlayerDelegate>)delegate;
		[Export("setPlayerDelegate:")]
		void SetPlayerDelegate(ZiggeoPlayerDelegate @delegate);

		// -(void)setScreenRecorderDelegate:(id<ZiggeoScreenRecorderDelegate>)delegate;
		[Export("setScreenRecorderDelegate:")]
		void SetScreenRecorderDelegate(ZiggeoScreenRecorderDelegate @delegate);

		// -(id<ZiggeoQRScannerDelegate>)getQRScannerDelegate;
		[Export("getQRScannerDelegate")]

		ZiggeoQRScannerDelegate QRScannerDelegate { get; }

		// -(id<ZiggeoHardwarePermissionDelegate>)getHardwarePermissionDelegate;
		[Export("getHardwarePermissionDelegate")]

		ZiggeoHardwarePermissionDelegate HardwarePermissionDelegate { get; }

		// -(id<ZiggeoUploadingDelegate>)getUploadingDelegate;
		[Export("getUploadingDelegate")]

		ZiggeoUploadingDelegate UploadingDelegate { get; }

		// -(id<ZiggeoFileSelectorDelegate>)getFileSelectorDelegate;
		[Export("getFileSelectorDelegate")]

		ZiggeoFileSelectorDelegate FileSelectorDelegate { get; }

		// -(id<ZiggeoRecorderDelegate>)getRecorderDelegate;
		[Export("getRecorderDelegate")]

		ZiggeoRecorderDelegate RecorderDelegate { get; }

		// -(id<ZiggeoSensorDelegate>)getSensorDelegate;
		[Export("getSensorDelegate")]

		ZiggeoSensorDelegate SensorDelegate { get; }

		// -(id<ZiggeoPlayerDelegate>)getPlayerDelegate;
		[Export("getPlayerDelegate")]

		ZiggeoPlayerDelegate PlayerDelegate { get; }

		// -(id<ZiggeoScreenRecorderDelegate>)getScreenRecorderDelegate;
		[Export("getScreenRecorderDelegate")]

		ZiggeoScreenRecorderDelegate ScreenRecorderDelegate { get; }

		// -(NSString *)getAppToken;
		[Export("getAppToken")]

		string AppToken { get; }

		// -(NSString *)getServerAuthToken;
		[Export("getServerAuthToken")]

		string ServerAuthToken { get; }

		// -(NSString *)getClientAuthToken;
		[Export("getClientAuthToken")]

		string ClientAuthToken { get; }

		// -(UIViewController *)getParentViewController;
		[Export("getParentViewController")]

		UIViewController ParentViewController { get; }

		// -(ZiggeoConfig *)config;
		[Export("config")]
		ZiggeoConfig Config { get; }

		// -(ZiggeoConnect *)connect;
		[Export("connect")]
		ZiggeoConnect Connect { get; }

		// -(ZiggeoVideos *)videos;
		[Export("videos")]

		ZiggeoVideos Videos { get; }

		// -(ZiggeoAudios *)audios;
		[Export("audios")]

		ZiggeoAudios Audios { get; }

		// -(ZiggeoImages *)images;
		[Export("images")]

		ZiggeoImages Images { get; }

		// -(FileSelectorConfig *)fileSelectorConfig;
		// -(void)setFileSelectorConfig:(FileSelectorConfig *)config;
		[Export("fileSelectorConfig")]

		FileSelectorConfig FileSelectorConfig { get; set; }

		// -(UploadingConfig *)uploadingConfig;
		// -(void)setUploadingConfig:(UploadingConfig *)config;
		[Export("uploadingConfig")]

		UploadingConfig UploadingConfig { get; set; }

		// -(PlayerConfig *)playerConfig;
		// -(void)setPlayerConfig:(PlayerConfig *)config;
		[Export("playerConfig")]

		PlayerConfig PlayerConfig { get; set; }

		// -(QrScannerConfig *)qrScannerConfig;
		// -(void)setQrScannerConfig:(QrScannerConfig *)config;
		[Export("qrScannerConfig")]

		QrScannerConfig QrScannerConfig { get; set; }

		// -(RecorderConfig *)recorderConfig;
		// -(void)setRecorderConfig:(RecorderConfig *)config;
		[Export("recorderConfig")]

		RecorderConfig RecorderConfig { get; set; }

		// -(void)sendReport:(NSArray *)array;
		[Export("sendReport:")]

		void SendReport(NSObject[] array);

		// -(void)sendEmailToSupport:(NSString *)subject messageBody:(NSString *)messageBody file:(FileInfoData *)file;
		[Export("sendEmailToSupport:messageBody:file:")]
		void SendEmailToSupport(string subject, string messageBody, FileInfoData file);

		// -(void)sendEmailToSupport;
		[Export("sendEmailToSupport")]
		void SendEmailToSupport();

		// -(void)log:(NSString *)message;
		[Export("log:")]
		void Log(string message);

		// -(void)logError:(NSString *)message;
		[Export("logError:")]
		void LogError(string message);

		// -(BOOL)isNetworkConnected;
		[Export("isNetworkConnected")]
		bool IsNetworkConnected();

		// -(BOOL)isWifiConnected;
		[Export("isWifiConnected")]
		bool IsWifiConnected();

		// -(void)record;
		[Export("record")]
		void Record();

		// -(void)startScreenRecorderWithAppGroup:(NSString *)appGroup preferredExtension:(NSString *)preferredExtension;
		[Export("startScreenRecorderWithAppGroup:preferredExtension:")]
		void StartScreenRecorderWithAppGroup(string appGroup, string preferredExtension);

		// -(void)trimVideo:(NSString *)videoUrl;
		[Export("trimVideo:")]
		void TrimVideo(string videoUrl);

		// -(void)startImageRecorder;
		[Export("startImageRecorder")]
		void StartImageRecorder();

		// -(void)startAudioRecorder;
		[Export("startAudioRecorder")]
		void StartAudioRecorder();

		// -(void)uploadFromPath:(NSString *)fileName data:(NSDictionary *)data;
		[Export("uploadFromPath:data:")]
		void UploadFromPath(string fileName, NSDictionary data);

		// -(void)uploadFromPath:(NSString *)fileName data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress confirmCallback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))confirmCallback;
		[Export("uploadFromPath:data:callback:progress:confirmCallback:")]
		void UploadFromPath(string fileName, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback, Action<int, int> progress, Action<NSDictionary, NSUrlResponse, NSError> confirmCallback);

		// -(void)startFileSelector;
		[Export("startFileSelector")]
		void StartFileSelector();

		// -(void)cancelUpload:(NSString *)path :(_Bool)delete_file;
		[Export("cancelUpload::")]
		void CancelUpload(string path, bool delete_file);

		// -(void)playVideo:(NSString *)token;
		[Export("playVideo:")]
		void PlayVideo(string token);

		// -(void)playVideos:(NSArray<NSString *> *)tokens;
		[Export("playVideos:")]
		void PlayVideos(string[] tokens);

		// -(void)playFromUri:(NSString *)url;
		[Export("playFromUri:")]
		void PlayFromUri(string url);

		// -(void)playFromUris:(NSArray<NSString *> *)urls;
		[Export("playFromUris:")]
		void PlayFromUris(string[] urls);

		// -(void)showImage:(NSString *)token;
		[Export("showImage:")]
		void ShowImage(string token);

		// -(void)showImages:(NSArray<NSString *> *)tokens;
		[Export("showImages:")]
		void ShowImages(string[] tokens);

		// -(void)showImageFromUri:(NSString *)url;
		[Export("showImageFromUri:")]
		void ShowImageFromUri(string url);

		// -(void)showImageFromUris:(NSArray<NSString *> *)urls;
		[Export("showImageFromUris:")]
		void ShowImageFromUris(string[] urls);

		// -(void)playAudio:(NSString *)token;
		[Export("playAudio:")]
		void PlayAudio(string token);

		// -(void)playAudios:(NSArray<NSString *> *)tokens;
		[Export("playAudios:")]
		void PlayAudios(string[] tokens);

		// -(void)playAudioFromUri:(NSString *)url;
		[Export("playAudioFromUri:")]
		void PlayAudioFromUri(string url);

		// -(void)playAudioFromUris:(NSArray<NSString *> *)urls;
		[Export("playAudioFromUris:")]
		void PlayAudioFromUris(string[] urls);

		// -(void)startAudioPlayer:(NSString *)token;
		[Export("startAudioPlayer:")]
		void StartAudioPlayer(string token);

		// -(void)startQrScanner;
		[Export("startQrScanner")]
		void StartQrScanner();
	}

	// @interface RecordingInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface RecordingInfo
	{
		// @property (nonatomic, strong) NSString * token;
		[Export("token", ArgumentSemantic.Strong)]
		string Token { get; set; }

		// @property (nonatomic) int fileType;
		[Export("fileType")]
		int FileType { get; set; }

		// @property (nonatomic) Boolean uploaded;
		[Export("uploaded")]
		byte Uploaded { get; set; }

		// @property (nonatomic) Boolean verified;
		[Export("verified")]
		byte Verified { get; set; }

		// @property (nonatomic) Boolean processed;
		[Export("processed")]
		byte Processed { get; set; }

		// @property (nonatomic) Boolean failed;
		[Export("failed")]
		byte Failed { get; set; }

		// @property (nonatomic, strong) UIImage * coverShot;
		[Export("coverShot", ArgumentSemantic.Strong)]
		UIImage CoverShot { get; set; }

		// @property (nonatomic, strong) NSDictionary * extraArgs;
		[Export("extraArgs", ArgumentSemantic.Strong)]
		NSDictionary ExtraArgs { get; set; }

		// @property (nonatomic, strong) NSMutableArray * urisForUploading;
		[Export("urisForUploading", ArgumentSemantic.Strong)]
		NSMutableArray UrisForUploading { get; set; }

		// @property (nonatomic) int uploadedParts;
		[Export("uploadedParts")]
		int UploadedParts { get; set; }

		// @property (nonatomic, strong) NSString * uploadId;
		[Export("uploadId", ArgumentSemantic.Strong)]
		string UploadId { get; set; }

		// @property (nonatomic, strong) NSString * streamToken;
		[Export("streamToken", ArgumentSemantic.Strong)]
		string StreamToken { get; set; }

		// -(id)initWithToken:(NSString *)token uploaded:(Boolean)uploaded verified:(Boolean)verified processed:(Boolean)processed failed:(Boolean)failed extraArgs:(NSDictionary *)extraArgs urisForUploading:(NSMutableArray *)urisForUploading uploadedParts:(int)uploadedParts uploadId:(NSString *)uploadId streamToken:(NSString *)streamToken;
		[Export("initWithToken:uploaded:verified:processed:failed:extraArgs:urisForUploading:uploadedParts:uploadId:streamToken:")]
		IntPtr Constructor(string token, byte uploaded, byte verified, byte processed, byte failed, NSDictionary extraArgs, NSMutableArray urisForUploading, int uploadedParts, string uploadId, string streamToken);

		// -(void)addExtraArgs:(NSDictionary *)extraArgs;
		[Export("addExtraArgs:")]
		void AddExtraArgs(NSDictionary extraArgs);
	}

	// @interface UploadingConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface UploadingConfig
	{
		// @property (nonatomic) long syncInterval;
		[Export("syncInterval")]
		nint SyncInterval { get; set; }

		// @property (nonatomic) _Bool shouldTurnOffUploader;
		[Export("shouldTurnOffUploader")]
		bool ShouldTurnOffUploader { get; set; }

		// @property (nonatomic) _Bool shouldUseWifiOnly;
		[Export("shouldUseWifiOnly")]
		bool ShouldUseWifiOnly { get; set; }

		// @property (nonatomic) _Bool shouldStartAsForeground;
		[Export("shouldStartAsForeground")]
		bool ShouldStartAsForeground { get; set; }

		// @property (nonatomic) int lostConnectionAction;
		[Export("lostConnectionAction")]
		int LostConnectionAction { get; set; }

		// @property (nonatomic, strong) NSDictionary * extraArgs;
		[Export("extraArgs", ArgumentSemantic.Strong)]
		NSDictionary ExtraArgs { get; set; }

		// -(void)addExtraArgs:(NSDictionary *)extraArgs;
		[Export("addExtraArgs:")]
		void AddExtraArgs(NSDictionary extraArgs);

		// -(NSString *)stringValueConfig;
		[Export("stringValueConfig")]

		string StringValueConfig { get; }
	}

	// @interface Video : ContentModel
	[BaseType(typeof(ContentModel))]
	interface Video
	{
		// @property (nonatomic) _Bool _volatile;
		[Export("_volatile")]
		bool _volatile { get; set; }

		// @property (nonatomic) int state;
		[Export("state")]
		int State { get; set; }

		// @property (nonatomic) _Bool onlyAudio;
		[Export("onlyAudio")]
		bool OnlyAudio { get; set; }

		// @property (nonatomic) double maxDuration;
		[Export("maxDuration")]
		double MaxDuration { get; set; }

		// @property (nonatomic) _Bool enforceDuration;
		[Export("enforceDuration")]
		bool EnforceDuration { get; set; }

		// @property (nonatomic, strong) NSString * videoSource;
		[Export("videoSource", ArgumentSemantic.Strong)]
		string VideoSource { get; set; }

		// @property (nonatomic, strong) NSArray * tags;
		[Export("tags", ArgumentSemantic.Strong)]

		NSObject[] Tags { get; set; }

		// @property (nonatomic, strong) NSObject * data;
		[Export("data", ArgumentSemantic.Strong)]
		NSObject Data { get; set; }

		// @property (nonatomic, strong) DeviceInfo * deviceInfo;
		[Export("deviceInfo", ArgumentSemantic.Strong)]
		DeviceInfo DeviceInfo { get; set; }

		// @property (nonatomic) long submissionDate;
		[Export("submissionDate")]
		nint SubmissionDate { get; set; }

		// @property (nonatomic, strong) NSObject * expirationDays;
		[Export("expirationDays", ArgumentSemantic.Strong)]
		NSObject ExpirationDays { get; set; }

		// @property (nonatomic) int resubmissionDate;
		[Export("resubmissionDate")]
		int ResubmissionDate { get; set; }

		// @property (nonatomic) int streamSubmissionDate;
		[Export("streamSubmissionDate")]
		int StreamSubmissionDate { get; set; }

		// @property (nonatomic) _Bool userLanguage;
		[Export("userLanguage")]
		bool UserLanguage { get; set; }

		// @property (nonatomic) _Bool deleteOldStreams;
		[Export("deleteOldStreams")]
		bool DeleteOldStreams { get; set; }

		// @property (nonatomic) _Bool autoCrop;
		[Export("autoCrop")]
		bool AutoCrop { get; set; }

		// @property (nonatomic) _Bool autoPad;
		[Export("autoPad")]
		bool AutoPad { get; set; }

		// @property (nonatomic) _Bool hd;
		[Export("hd")]
		bool Hd { get; set; }

		// @property (nonatomic, strong) NSObject * averageRating;
		[Export("averageRating", ArgumentSemantic.Strong)]
		NSObject AverageRating { get; set; }

		// @property (nonatomic) _Bool submitted;
		[Export("submitted")]
		bool Submitted { get; set; }

		// @property (nonatomic) _Bool approved;
		[Export("approved")]
		bool Approved { get; set; }

		// @property (nonatomic, strong) NSString * moderationReason;
		[Export("moderationReason", ArgumentSemantic.Strong)]
		string ModerationReason { get; set; }

		// @property (nonatomic, strong) NSObject * effectProfile;
		[Export("effectProfile", ArgumentSemantic.Strong)]
		NSObject EffectProfile { get; set; }

		// @property (nonatomic) double defaultImageSelector;
		[Export("defaultImageSelector")]
		double DefaultImageSelector { get; set; }

		// @property (nonatomic, strong) NSString * videoFileName;
		[Export("videoFileName", ArgumentSemantic.Strong)]
		string VideoFileName { get; set; }

		// @property (nonatomic, strong) NSString * type;
		[Export("type", ArgumentSemantic.Strong)]
		string Type { get; set; }

		// @property (nonatomic) int created;
		[Export("created")]
		int Created { get; set; }

		// @property (nonatomic) _Bool owned;
		[Export("owned")]
		bool Owned { get; set; }

		// @property (nonatomic, strong) NSString * videoProfile;
		[Export("videoProfile", ArgumentSemantic.Strong)]
		string VideoProfile { get; set; }

		// @property (nonatomic, strong) NSString * metaProfile;
		[Export("metaProfile", ArgumentSemantic.Strong)]
		string MetaProfile { get; set; }

		// @property (nonatomic, strong) NSString * metaProfileId;
		[Export("metaProfileId", ArgumentSemantic.Strong)]
		string MetaProfileId { get; set; }

		// @property (nonatomic, strong) NSArray * streams;
		[Export("streams", ArgumentSemantic.Strong)]

		NSObject[] Streams { get; set; }

		// @property (nonatomic, strong) StreamModel * originalStream;
		[Export("originalStream", ArgumentSemantic.Strong)]
		StreamModel OriginalStream { get; set; }

		// @property (nonatomic, strong) StreamModel * defaultStream;
		[Export("defaultStream", ArgumentSemantic.Strong)]
		StreamModel DefaultStream { get; set; }

		// @property (nonatomic, strong) NSString * embedImageUrl;
		[Export("embedImageUrl", ArgumentSemantic.Strong)]
		string EmbedImageUrl { get; set; }

		// @property (nonatomic, strong) NSString * embedVideoUrl;
		[Export("embedVideoUrl", ArgumentSemantic.Strong)]
		string EmbedVideoUrl { get; set; }

		// -(id)initWithJson:(NSDictionary *)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);

		// -(void)setInfo:(NSDictionary *)json;
		[Export("setInfo:")]
		void SetInfo(NSDictionary json);

		// -(void)clear;
		[Export("clear")]
		void Clear();

		// -(NSDictionary *)toDictionary;
		[Export("toDictionary")]

		NSDictionary ToDictionary { get; }

		// -(NSString *)toString;
		[Export("toString")]

		string ToString { get; }

		// -(_Bool)isVolatile;
		[Export("isVolatile")]

		bool IsVolatile { get; }

		// -(void)setVolatile:(_Bool)_volatile;
		[Export("setVolatile:")]
		void SetVolatile(bool _volatile);
	}

	// @interface ZiggeoAudios : NSObject
	[BaseType(typeof(NSObject))]
	interface ZiggeoAudios
	{
		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo;
		[Export("initWithZiggeoApplication:")]
		IntPtr Constructor(Ziggeo ziggeo);

		// -(NSUrlSessionTask *)index:(NSDictionary *)data callback:(void (^)(NSArray *, NSError *))callback;
		[Export("index:callback:")]
		NSUrlSessionTask Index(NSDictionary data, Action<NSArray, NSError> callback);

		// -(NSUrlSessionTask *)index:(NSDictionary *)data stringCallback:(void (^)(NSString *, NSUrlResponse *, NSError *))callback;
		[Export("index:stringCallback:")]
		NSUrlSessionTask Index(NSDictionary data, Action<NSString, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)create:(NSString *)file_path data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress confirmCallback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))confirmCallback;
		[Export("create:data:callback:progress:confirmCallback:")]
		NSUrlSessionTask Create(string file_path, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback, Action<int, int> progress, Action<NSDictionary, NSUrlResponse, NSError> confirmCallback);

		// -(NSUrlSessionTask *)get:(NSString *)token data:(NSDictionary *)data callback:(void (^)(Audio *, NSUrlResponse *, NSError *))callback;
		[Export("get:data:callback:")]
		NSUrlSessionTask Get(string token, NSDictionary data, Action<Audio, NSUrlResponse, NSError> callback);

		// -(void)download:(NSString *)token callback:(void (^)(NSString *))callback;
		[Export("download:callback:")]
		void Download(string token, Action<NSString> callback);

		// -(NSString *)getAudioUrl:(NSString *)token;
		[Export("getAudioUrl:")]
		string GetAudioUrl(string token);

		// -(NSUrlSessionTask *)destroy:(NSString *)token callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("destroy:callback:")]
		NSUrlSessionTask Destroy(string token, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)update:(NSString *)token data:(NSDictionary *)data callback:(void (^)(Audio *, NSUrlResponse *, NSError *))callback;
		[Export("update:data:callback:")]
		NSUrlSessionTask Update(string token, NSDictionary data, Action<Audio, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)update:(Audio *)model callback:(void (^)(Audio *, NSUrlResponse *, NSError *))callback;
		[Export("update:callback:")]
		NSUrlSessionTask Update(Audio model, Action<Audio, NSUrlResponse, NSError> callback);
	}

	// @interface ZiggeoConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface ZiggeoConfig
	{
		// @property (nonatomic, strong) NSString * server_api_url;
		[Export("server_api_url", ArgumentSemantic.Strong)]
		string Server_api_url { get; set; }

		// @property (nonatomic, strong) NSString * dev_server_api_url;
		[Export("dev_server_api_url", ArgumentSemantic.Strong)]
		string Dev_server_api_url { get; set; }

		// @property (nonatomic, strong) NSString * file_server_url;
		[Export("file_server_url", ArgumentSemantic.Strong)]
		string File_server_url { get; set; }

		// @property (nonatomic, strong) NSString * cdn_api_url;
		[Export("cdn_api_url", ArgumentSemantic.Strong)]
		string Cdn_api_url { get; set; }

		// @property (nonatomic, strong) NSString * wowza_url;
		[Export("wowza_url", ArgumentSemantic.Strong)]
		string Wowza_url { get; set; }

		// -(id)initWithToken:(NSString *)token;
		[Export("initWithToken:")]
		IntPtr Constructor(string token);
	}

	// @interface ZiggeoConnect : NSObject
	[BaseType(typeof(NSObject))]
	interface ZiggeoConnect
	{
		// @property (nonatomic) NSString * serverAuthToken;
		[Export("serverAuthToken")]
		string ServerAuthToken { get; set; }

		// @property (nonatomic) NSString * clientAuthToken;
		[Export("clientAuthToken")]
		string ClientAuthToken { get; set; }

		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo;
		[Export("initWithZiggeoApplication:")]
		IntPtr Constructor(Ziggeo ziggeo);

		// -(NSUrlSessionTask *)requestWithMethod:(NSString *)method path:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSData *, NSUrlResponse *, NSError *))callback;
		[Export("requestWithMethod:path:data:callback:")]
		NSUrlSessionTask RequestWithMethod(string method, string path, NSDictionary data, Action<NSData, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)backgroundUploadWithPath:(NSString *)path data:(NSDictionary *)data identifier:(NSString *)identifier file:(NSString *)file callback:(void (^)(NSData *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress;
		[Export("backgroundUploadWithPath:data:identifier:file:callback:progress:")]
		NSUrlSessionTask BackgroundUploadWithPath(string path, NSDictionary data, string identifier, string file, Action<NSData, NSUrlResponse, NSError> callback, Action<int, int> progress);

		// -(NSUrlSessionTask *)uploadFileWithPath:(NSString *)url parameters:(NSDictionary *)parameters identifier:(NSString *)identifier filePath:(NSString *)filePath fileName:(NSString *)fileName mimeType:(NSString *)mimeType fileExtension:(NSString *)fileExtension callback:(void (^)(NSData *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress;
		[Export("uploadFileWithPath:parameters:identifier:filePath:fileName:mimeType:fileExtension:callback:progress:")]
		NSUrlSessionTask UploadFileWithPath(string url, NSDictionary parameters, string identifier, string filePath, string fileName, string mimeType, string fileExtension, Action<NSData, NSUrlResponse, NSError> callback, Action<int, int> progress);

		// -(NSUrlSessionTask *)requestStringWithMethod:(NSString *)method path:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSString *, NSUrlResponse *, NSError *))callback;
		[Export("requestStringWithMethod:path:data:callback:")]
		NSUrlSessionTask RequestStringWithMethod(string method, string path, NSDictionary data, Action<NSString, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)requestJSONWithMethod:(NSString *)method path:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("requestJSONWithMethod:path:data:callback:")]
		NSUrlSessionTask RequestJSONWithMethod(string method, string path, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)requestJSONArrayWithMethod:(NSString *)method path:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSArray *, NSUrlResponse *, NSError *))callback;
		[Export("requestJSONArrayWithMethod:path:data:callback:")]
		NSUrlSessionTask RequestJSONArrayWithMethod(string method, string path, NSDictionary data, Action<NSArray, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)getWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSData *, NSUrlResponse *, NSError *))callback;
		[Export("getWithPath:data:callback:")]
		NSUrlSessionTask GetWithPath(string path, NSDictionary data, Action<NSData, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)getStringWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSString *, NSUrlResponse *, NSError *))callback;
		[Export("getStringWithPath:data:callback:")]
		NSUrlSessionTask GetStringWithPath(string path, NSDictionary data, Action<NSString, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)getJsonWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("getJsonWithPath:data:callback:")]
		NSUrlSessionTask GetJsonWithPath(string path, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)getJsonArrayWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSArray *, NSUrlResponse *, NSError *))callback;
		[Export("getJsonArrayWithPath:data:callback:")]
		NSUrlSessionTask GetJsonArrayWithPath(string path, NSDictionary data, Action<NSArray, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)postWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSData *, NSUrlResponse *, NSError *))callback;
		[Export("postWithPath:data:callback:")]
		NSUrlSessionTask PostWithPath(string path, NSDictionary data, Action<NSData, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)postRawDataWithPath:(NSString *)path data:(NSData *)data params:(NSDictionary *)params callback:(void (^)(NSData *, NSUrlResponse *, NSError *))callback;
		[Export("postRawDataWithPath:data:params:callback:")]
		NSUrlSessionTask PostRawDataWithPath(string path, NSData data, NSDictionary @params, Action<NSData, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)postJsonWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("postJsonWithPath:data:callback:")]
		NSUrlSessionTask PostJsonWithPath(string path, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)deleteWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSData *, NSUrlResponse *, NSError *))callback;
		[Export("deleteWithPath:data:callback:")]
		NSUrlSessionTask DeleteWithPath(string path, NSDictionary data, Action<NSData, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)deleteJsonWithPath:(NSString *)path data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("deleteJsonWithPath:data:callback:")]
		NSUrlSessionTask DeleteJsonWithPath(string path, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)addSessionData:(NSDictionary *)data path:(NSString *)path callback:(NSUrlSessionTask *(^)(NSDictionary *))callback;
		[Export("addSessionData:path:callback:")]
		NSUrlSessionTask AddSessionData(NSDictionary data, string path, Func<NSDictionary, NSUrlSessionTask> callback);

		// -(void)appWakeupSignalTaskComplete:(NSString *)sessionID;
		[Export("appWakeupSignalTaskComplete:")]
		void AppWakeupSignalTaskComplete(string sessionID);
	}

	// @interface ZiggeoImages : NSObject
	[BaseType(typeof(NSObject))]
	interface ZiggeoImages
	{
		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo;
		[Export("initWithZiggeoApplication:")]
		IntPtr Constructor(Ziggeo ziggeo);

		// -(NSUrlSessionTask *)index:(NSDictionary *)data callback:(void (^)(NSArray *, NSError *))callback;
		[Export("index:callback:")]
		NSUrlSessionTask Index(NSDictionary data, Action<NSArray, NSError> callback);

		// -(NSUrlSessionTask *)index:(NSDictionary *)data stringCallback:(void (^)(NSString *, NSUrlResponse *, NSError *))callback;
		[Export("index:stringCallback:")]
		NSUrlSessionTask Index(NSDictionary data, Action<NSString, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)create:(NSString *)file_path data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress confirmCallback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))confirmCallback;
		[Export("create:data:callback:progress:confirmCallback:")]
		NSUrlSessionTask Create(string file_path, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback, Action<int, int> progress, Action<NSDictionary, NSUrlResponse, NSError> confirmCallback);

		// -(NSUrlSessionTask *)get:(NSString *)token data:(NSDictionary *)data callback:(void (^)(Image *, NSUrlResponse *, NSError *))callback;
		[Export("get:data:callback:")]
		NSUrlSessionTask Get(string token, NSDictionary data, Action<Image, NSUrlResponse, NSError> callback);

		// -(void)download:(NSString *)token callback:(void (^)(NSString *))callback;
		[Export("download:callback:")]
		void Download(string token, Action<NSString> callback);

		// -(NSString *)getImageUrl:(NSString *)token;
		[Export("getImageUrl:")]
		string GetImageUrl(string token);

		// -(NSUrlSessionTask *)destroy:(NSString *)token callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("destroy:callback:")]
		NSUrlSessionTask Destroy(string token, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)update:(NSString *)token data:(NSDictionary *)data callback:(void (^)(Image *, NSUrlResponse *, NSError *))callback;
		[Export("update:data:callback:")]
		NSUrlSessionTask Update(string token, NSDictionary data, Action<Image, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)update:(Image *)model callback:(void (^)(Image *, NSUrlResponse *, NSError *))callback;
		[Export("update:callback:")]
		NSUrlSessionTask Update(Image model, Action<Image, NSUrlResponse, NSError> callback);
	}

	// @interface ZiggeoVideos : NSObject <NSFilePresenter>
	[BaseType(typeof(NSObject))]
	interface ZiggeoVideos : INSFilePresenter
	{
		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo;
		[Export("initWithZiggeoApplication:")]
		IntPtr Constructor(Ziggeo ziggeo);

		// -(NSUrlSessionTask *)index:(NSDictionary *)data callback:(void (^)(NSArray *, NSError *))callback;
		[Export("index:callback:")]
		NSUrlSessionTask Index(NSDictionary data, Action<NSArray, NSError> callback);

		// -(NSUrlSessionTask *)index:(NSDictionary *)data stringCallback:(void (^)(NSString *, NSUrlResponse *, NSError *))callback;
		[Export("index:stringCallback:")]
		NSUrlSessionTask Index(NSDictionary data, Action<NSString, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)create:(NSString *)file_path data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress confirmCallback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))confirmCallback;
		[Export("create:data:callback:progress:confirmCallback:")]
		NSUrlSessionTask Create(string file_path, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback, Action<int, int> progress, Action<NSDictionary, NSUrlResponse, NSError> confirmCallback);

		// -(NSUrlSessionTask *)get:(NSString *)token data:(NSDictionary *)data callback:(void (^)(Video *, NSUrlResponse *, NSError *))callback;
		[Export("get:data:callback:")]
		NSUrlSessionTask Get(string token, NSDictionary data, Action<Video, NSUrlResponse, NSError> callback);

		// -(void)download:(NSString *)token callback:(void (^)(NSString *))callback;
		[Export("download:callback:")]
		void Download(string token, Action<NSString> callback);

		// -(NSString *)getVideoUrl:(NSString *)token;
		[Export("getVideoUrl:")]
		string GetVideoUrl(string token);

		// -(NSString *)getImageUrl:(NSString *)token;
		[Export("getImageUrl:")]
		string GetImageUrl(string token);

		// -(NSUrlSessionTask *)attachVideoWithVideoToken:(NSString *)videoToken streamToken:(NSString *)streamToken data:(NSDictionary *)data file:(NSString *)fileName callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress;
		[Export("attachVideoWithVideoToken:streamToken:data:file:callback:progress:")]
		NSUrlSessionTask AttachVideoWithVideoToken(string videoToken, string streamToken, NSDictionary data, string fileName, Action<NSDictionary, NSUrlResponse, NSError> callback, Action<int, int> progress);

		// -(NSUrlSessionTask *)createVideoWithData:(NSDictionary *)data file:(NSString *)fileName cover:(UIImage *)cover callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress;
		[Export("createVideoWithData:file:cover:callback:progress:")]
		NSUrlSessionTask CreateVideoWithData(NSDictionary data, string fileName, UIImage cover, Action<NSDictionary, NSUrlResponse, NSError> callback, Action<int, int> progress);

		// -(NSUrlSessionTask *)rerecordVideoWithToken:(NSString *)videoToken file:(NSString *)fileName data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback progress:(void (^)(int, int))progress;
		[Export("rerecordVideoWithToken:file:data:callback:progress:")]
		NSUrlSessionTask RerecordVideoWithToken(string videoToken, string fileName, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback, Action<int, int> progress);

		// -(NSUrlSessionTask *)createEmptyVideoWithData:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("createEmptyVideoWithData:callback:")]
		NSUrlSessionTask CreateEmptyVideoWithData(NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)createLiveVideoWithData:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("createLiveVideoWithData:callback:")]
		NSUrlSessionTask CreateLiveVideoWithData(NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)recorderSubmitWithVideoToken:(NSString *)videoToken streamToken:(NSString *)streamToken data:(NSDictionary *)data callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("recorderSubmitWithVideoToken:streamToken:data:callback:")]
		NSUrlSessionTask RecorderSubmitWithVideoToken(string videoToken, string streamToken, NSDictionary data, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)destroy:(NSString *)token streamToken:(NSString *)streamToken callback:(void (^)(NSDictionary *, NSUrlResponse *, NSError *))callback;
		[Export("destroy:streamToken:callback:")]
		NSUrlSessionTask Destroy(string token, string streamToken, Action<NSDictionary, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)update:(NSString *)token data:(NSDictionary *)data callback:(void (^)(Video *, NSUrlResponse *, NSError *))callback;
		[Export("update:data:callback:")]
		NSUrlSessionTask Update(string token, NSDictionary data, Action<Video, NSUrlResponse, NSError> callback);

		// -(NSUrlSessionTask *)update:(Video *)model callback:(void (^)(Video *, NSUrlResponse *, NSError *))callback;
		[Export("update:callback:")]
		NSUrlSessionTask Update(Video model, Action<Video, NSUrlResponse, NSError> callback);

		// -(void)startScreenRecorderWithAppGroup:(NSString *)appGroup preferredExtension:(NSString * _Nonnull)preferredExtension;
		[Export("startScreenRecorderWithAppGroup:preferredExtension:")]
		void StartScreenRecorderWithAppGroup(string appGroup, string preferredExtension);

		// -(void)setAppGroup:(NSString *)groupID;
		[Export("setAppGroup:")]
		void SetAppGroup(string groupID);
	}

	// @protocol VideoPreviewDelegate
	[Protocol, Model(AutoGeneratedName = true)]
	interface VideoPreviewDelegate
	{
		// @required -(void)retake;
		[Abstract]
		[Export("retake")]
		void Retake();

		// @required -(void)uploadVideo:(NSURL *)fileURL;
		[Abstract]
		[Export("uploadVideo:")]
		void UploadVideo(NSUrl fileURL);
	}

	// @protocol VideoPreviewProtocol
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	interface VideoPreviewProtocol
	{
		// @required @property (nonatomic) NSURL * videoURL;
		[Abstract]
		[Export("videoURL", ArgumentSemantic.Assign)]
		NSUrl VideoURL { get; set; }

		// @required @property (nonatomic) AVLayerVideoGravity videoGravity;
		[Abstract]
		[Export("videoGravity")]
		string VideoGravity { get; set; }

		[Wrap("WeakPreviewDelegate"), Abstract]
		VideoPreviewDelegate PreviewDelegate { get; set; }

		// @required @property (nonatomic) id<VideoPreviewDelegate> previewDelegate;
		[Abstract]
		[NullAllowed, Export("previewDelegate", ArgumentSemantic.Assign)]
		NSObject WeakPreviewDelegate { get; set; }
	}

	// @interface ZiggeoRecorder : UIViewController
	[BaseType(typeof(UIViewController))]
	interface ZiggeoRecorder
	{
		// @property (nonatomic) _Bool showLightIndicator;
		[Export("showLightIndicator")]
		bool ShowLightIndicator { get; set; }

		// @property (nonatomic) _Bool showSoundIndicator;
		[Export("showSoundIndicator")]
		bool ShowSoundIndicator { get; set; }

		// @property (nonatomic) AVLayerVideoGravity videoGravity;
		[Export("videoGravity")]
		string VideoGravity { get; set; }

		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo;
		[Export("initWithZiggeoApplication:")]
		IntPtr Constructor(Ziggeo ziggeo);

		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo videoToken:(NSString *)videoToken;
		[Export("initWithZiggeoApplication:videoToken:")]
		IntPtr Constructor(Ziggeo ziggeo, string videoToken);

		// -(void)startRecordingToFile:(NSString *)outputFilePath;
		[Export("startRecordingToFile:")]
		void StartRecordingToFile(string outputFilePath);

		// -(void)stopRecording;
		[Export("stopRecording")]
		void StopRecording();

		// -(void)retake;
		[Export("retake")]
		void Retake();

		// -(void)pauseStreaming;
		[Export("pauseStreaming")]
		void PauseStreaming();

		// -(void)resumeStreaming;
		[Export("resumeStreaming")]
		void ResumeStreaming();

		// -(void)uploadVideo:(NSString *)filePath;
		[Export("uploadVideo:")]
		void UploadVideo(string filePath);
	}

	// @interface ZiggeoPlayer : AVQueuePlayer
	[BaseType(typeof(AVQueuePlayer))]
	interface ZiggeoPlayer
	{
		// @property (copy, nonatomic) void (^didFinishPlaying)(NSString *, NSError *);
		[Export("didFinishPlaying", ArgumentSemantic.Copy)]
		Action<NSString, NSError> DidFinishPlaying { get; set; }

		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo videoToken:(NSString *)token;
		[Export("initWithZiggeoApplication:videoToken:")]
		IntPtr Constructor(Ziggeo ziggeo, string token);

		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo videoToken:(NSString *)token videoUrl:(NSString *)url;
		[Export("initWithZiggeoApplication:videoToken:videoUrl:")]
		IntPtr Constructor(Ziggeo ziggeo, string token, string url);

		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo playerItems:(NSArray *)playerItems;
		[Export("initWithZiggeoApplication:playerItems:")]

		IntPtr Constructor(Ziggeo ziggeo, NSObject[] playerItems);

		// -(id)initWithZiggeoApplication:(Ziggeo *)ziggeo playerItem:(AVPlayerItem *)playerItem;
		[Export("initWithZiggeoApplication:playerItem:")]
		IntPtr Constructor(Ziggeo ziggeo, AVPlayerItem playerItem);

		// +(void)createPlayerWithAdditionalParams:(Ziggeo *)ziggeo videoToken:(NSString *)token params:(NSDictionary *)params callback:(void (^)(ZiggeoPlayer *))callback;
		[Static]
		[Export("createPlayerWithAdditionalParams:videoToken:params:callback:")]
		void CreatePlayerWithAdditionalParams(Ziggeo ziggeo, string token, NSDictionary @params, Action<ZiggeoPlayer> callback);

		// +(void)createPlayerWithAdditionalParams:(Ziggeo *)ziggeo videoToken:(NSString *)token videoUrl:(NSString *)url params:(NSDictionary *)params callback:(void (^)(ZiggeoPlayer *))callback;
		[Static]
		[Export("createPlayerWithAdditionalParams:videoToken:videoUrl:params:callback:")]
		void CreatePlayerWithAdditionalParams(Ziggeo ziggeo, string token, string url, NSDictionary @params, Action<ZiggeoPlayer> callback);

		// +(void)createPlayersWithAdditionalParams:(Ziggeo *)ziggeo videoTokens:(NSArray *)tokens params:(NSDictionary *)params callback:(void (^)(ZiggeoPlayer *))callback;
		[Static]
		[Export("createPlayersWithAdditionalParams:videoTokens:params:callback:")]

		void CreatePlayersWithAdditionalParams(Ziggeo ziggeo, NSObject[] tokens, NSDictionary @params, Action<ZiggeoPlayer> callback);

		// +(void)createPlayerWithServerAuthToken:(Ziggeo *)ziggeo videoToken:(NSString *)token authToken:(NSString *)authToken callback:(void (^)(ZiggeoPlayer *))callback;
		[Static]
		[Export("createPlayerWithServerAuthToken:videoToken:authToken:callback:")]
		void CreatePlayerWithServerAuthToken(Ziggeo ziggeo, string token, string authToken, Action<ZiggeoPlayer> callback);

		// +(void)createPlayerWithClientAuthToken:(Ziggeo *)ziggeo videoToken:(NSString *)token authToken:(NSString *)authToken callback:(void (^)(ZiggeoPlayer *))callback;
		[Static]
		[Export("createPlayerWithClientAuthToken:videoToken:authToken:callback:")]
		void CreatePlayerWithClientAuthToken(Ziggeo ziggeo, string token, string authToken, Action<ZiggeoPlayer> callback);

		// -(void)playWithAdsWithAdTagURL:(NSString *)adTagURL playerContainer:(UIView *)playerContainer rootViewController:(UIViewController *)rootViewController playerViewController:(AVPlayerViewController *)playerViewController;
		[Export("playWithAdsWithAdTagURL:playerContainer:rootViewController:playerViewController:")]
		void PlayWithAdsWithAdTagURL(string adTagURL, UIView playerContainer, UIViewController rootViewController, AVPlayerViewController playerViewController);
	}

	// @interface ZiggeoScreenRecorderSampleHandler : RPBroadcastSampleHandler
	[TV(10, 0), Mac(11, 0), iOS(10, 0)]
	[BaseType(typeof(RPBroadcastSampleHandler))]
	interface ZiggeoScreenRecorderSampleHandler
	{
		// -(NSString *)getApplicationGroup;
		[Export("getApplicationGroup")]

		string ApplicationGroup { get; }
	}
}