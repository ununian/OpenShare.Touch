using Foundation;
using ObjCRuntime;
using UIKit;
using System;
namespace OpenShareTouch
{

	// @interface OSMessage : NSObject
	[BaseType(typeof(NSObject))]
	interface OSMessage
	{
		// @property NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @property NSString * desc;
		[Export("desc")]
		string Desc { get; set; }

		// @property NSString * link;
		[Export("link")]
		string Link { get; set; }

		// @property NSData * image;
		[Export("image", ArgumentSemantic.Assign)]
		NSData Image { get; set; }

		// @property NSData * thumbnail;
		[Export("thumbnail", ArgumentSemantic.Assign)]
		NSData Thumbnail { get; set; }

		// @property OSMultimediaType multimediaType;
		[Export("multimediaType", ArgumentSemantic.Assign)]
		OSMultimediaType MultimediaType { get; set; }

		// @property NSString * extInfo;
		[Export("extInfo")]
		string ExtInfo { get; set; }

		// @property NSString * mediaDataUrl;
		[Export("mediaDataUrl")]
		string MediaDataUrl { get; set; }

		// @property NSString * fileExt;
		[Export("fileExt")]
		string FileExt { get; set; }

		// -(BOOL)isEmpty:(NSArray *)emptyValueForKeys AndNotEmpty:(NSArray *)notEmptyValueForKeys;
		[Export("isEmpty:AndNotEmpty:")]
		//[Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
		bool IsEmpty(NSObject[] emptyValueForKeys, NSObject[] notEmptyValueForKeys);
	}

	// typedef void (^shareSuccess)(OSMessage *);
	delegate void shareSuccess(OSMessage arg0);

	// typedef void (^shareFail)(OSMessage *, NSError *);
	delegate void shareFail(OSMessage arg0, NSError arg1);

	// typedef void (^authSuccess)(NSDictionary *);
	delegate void authSuccess(NSDictionary arg0);

	// typedef void (^authFail)(NSDictionary *, NSError *);
	delegate void authFail(NSDictionary arg0, NSError arg1);

	// typedef void (^paySuccess)(NSDictionary *);
	delegate void paySuccess(NSDictionary arg0);

	// typedef void (^payFail)(NSDictionary *, NSError *);
	delegate void payFail(NSDictionary arg0, NSError arg1);

	// @interface OpenShare : NSObject
	[BaseType(typeof(NSObject))]
	interface OpenShare
	{
		// +(void)set:(NSString *)platform Keys:(NSDictionary *)key;
		[Static]
		[Export("set:Keys:")]
		void Set(string platform, NSDictionary key);

		// +(NSDictionary *)keyFor:(NSString *)platform;
		[Static]
		[Export("keyFor:")]
		NSDictionary KeyFor(string platform);

		// +(void)openURL:(NSString *)url;
		[Static]
		[Export("openURL:")]
		void OpenURL(string url);

		// +(BOOL)canOpen:(NSString *)url;
		[Static]
		[Export("canOpen:")]
		bool CanOpen(string url);

		// +(BOOL)handleOpenURL:(NSURL *)url;
		[Static]
		[Export("handleOpenURL:")]
		bool HandleOpenURL(NSUrl url);

		// +(shareSuccess)shareSuccessCallback;
		// +(void)setShareSuccessCallback:(shareSuccess)suc;
		[Static]
		[Export("shareSuccessCallback")]
		//[Verify(MethodToProperty)]
		shareSuccess ShareSuccessCallback { get; set; }

		// +(shareFail)shareFailCallback;
		// +(void)setShareFailCallback:(shareFail)fail;
		[Static]
		[Export("shareFailCallback")]
		//[Verify(MethodToProperty)]
		shareFail ShareFailCallback { get; set; }

		// +(NSURL *)returnedURL;
		[Static]
		[Export("returnedURL")]
		NSUrl ReturnedURL();

		// +(NSDictionary *)returnedData;
		[Static]
		[Export("returnedData")]
		NSDictionary ReturnedData();

		// +(void)setReturnedData:(NSDictionary *)retData;
		[Static]
		[Export("setReturnedData:")]
		void SetReturnedData(NSDictionary retData);

		// +(NSMutableDictionary *)parseUrl:(NSURL *)url;
		[Static]
		[Export("parseUrl:")]
		NSMutableDictionary ParseUrl(NSUrl url);

		// +(void)setMessage:(OSMessage *)msg;
		[Static]
		[Export("setMessage:")]
		void SetMessage(OSMessage msg);

		// +(OSMessage *)message;
		[Static]
		[Export("message")]
		OSMessage Message();

		// +(BOOL)beginShare:(NSString *)platform Message:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("beginShare:Message:Success:Fail:")]
		bool BeginShare(string platform, OSMessage msg, shareSuccess success, shareFail fail);

		// +(BOOL)beginAuth:(NSString *)platform Success:(authSuccess)success Fail:(authFail)fail;
		[Static]
		[Export("beginAuth:Success:Fail:")]
		bool BeginAuth(string platform, authSuccess success, authFail fail);

		// +(NSString *)base64Encode:(NSString *)input;
		[Static]
		[Export("base64Encode:")]
		string Base64Encode(string input);

		// +(NSString *)base64Decode:(NSString *)input;
		[Static]
		[Export("base64Decode:")]
		string Base64Decode(string input);

		// +(NSString *)CFBundleDisplayName;
		[Static]
		[Export("CFBundleDisplayName")]
		string CFBundleDisplayName();

		// +(NSString *)CFBundleIdentifier;
		[Static]
		[Export("CFBundleIdentifier")]
		string CFBundleIdentifier();

		// +(void)setGeneralPasteboard:(NSString *)key Value:(NSDictionary *)value encoding:(OSPboardEncoding)encoding;
		[Static]
		[Export("setGeneralPasteboard:Value:encoding:")]
		void SetGeneralPasteboard(string key, NSDictionary value, OSPboardEncoding encoding);

		// +(NSDictionary *)generalPasteboardData:(NSString *)key encoding:(OSPboardEncoding)encoding;
		[Static]
		[Export("generalPasteboardData:encoding:")]
		NSDictionary GeneralPasteboardData(string key, OSPboardEncoding encoding);

		// +(NSString *)base64AndUrlEncode:(NSString *)string;
		[Static]
		[Export("base64AndUrlEncode:")]
		string Base64AndUrlEncode(string @string);

		// +(NSString *)urlDecode:(NSString *)input;
		[Static]
		[Export("urlDecode:")]
		string UrlDecode(string input);

		// +(UIImage *)screenshot;
		[Static]
		[Export("screenshot")]
		UIImage Screenshot();

		// +(authSuccess)authSuccessCallback;
		[Static]
		[Export("authSuccessCallback")]
		authSuccess AuthSuccessCallback();

		// +(authFail)authFailCallback;
		[Static]
		[Export("authFailCallback")]
		authFail AuthFailCallback();

		// +(void)setPaySuccessCallback:(paySuccess)suc;
		[Static]
		[Export("setPaySuccessCallback:")]
		void SetPaySuccessCallback(paySuccess suc);

		// +(void)setPayFailCallback:(payFail)fail;
		[Static]
		[Export("setPayFailCallback:")]
		void SetPayFailCallback(payFail fail);

		// +(paySuccess)paySuccessCallback;
		[Static]
		[Export("paySuccessCallback")]
		paySuccess PaySuccessCallback();

		// +(payFail)payFailCallback;
		[Static]
		[Export("payFailCallback")]
		payFail PayFailCallback();
	}

	// @interface Alipay (OpenShare)
	[Category]
	[BaseType(typeof(OpenShare))]
	interface OpenShare_Alipay
	{
		// +(void)connectAlipay;
		[Static]
		[Export("connectAlipay")]
		void ConnectAlipay();

		// +(void)AliPay:(NSString *)link Success:(paySuccess)success Fail:(payFail)fail;
		[Static]
		[Export("AliPay:Success:Fail:")]
		void AliPay(string link, paySuccess success, payFail fail);
	}

	// @interface QQ (OpenShare)
	[Category]
	[BaseType(typeof(OpenShare))]
	interface OpenShare_QQ
	{
		// +(void)connectQQWithAppId:(NSString *)appId;
		[Static]
		[Export("connectQQWithAppId:")]
		void ConnectQQWithAppId(string appId);

		// +(BOOL)isQQInstalled;
		[Static]
		[Export("isQQInstalled")]
		//[Verify(MethodToProperty)]
		bool IsQQInstalled { get; }

		// +(void)shareToQQFriends:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToQQFriends:Success:Fail:")]
		void ShareToQQFriends(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)shareToQQZone:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToQQZone:Success:Fail:")]
		void ShareToQQZone(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)shareToQQFavorites:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToQQFavorites:Success:Fail:")]
		void ShareToQQFavorites(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)shareToQQDataline:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToQQDataline:Success:Fail:")]
		void ShareToQQDataline(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)QQAuth:(NSString *)scope Success:(authSuccess)success Fail:(authFail)fail;
		[Static]
		[Export("QQAuth:Success:Fail:")]
		void QQAuth(string scope, authSuccess success, authFail fail);

		// +(void)chatWithQQNumber:(NSString *)qqNumber;
		[Static]
		[Export("chatWithQQNumber:")]
		void ChatWithQQNumber(string qqNumber);

		// +(void)chatInQQGroup:(NSString *)groupNumber;
		[Static]
		[Export("chatInQQGroup:")]
		void ChatInQQGroup(string groupNumber);

		// +(BOOL)QQ_handleOpenURL;
		[Static]
		[Export("QQ_handleOpenURL")]
		//[Verify(MethodToProperty)]
		bool QQ_handleOpenURL { get; }
	}

	// @interface Renren (OpenShare)
	[Category]
	[BaseType(typeof(OpenShare))]
	interface OpenShare_Renren
	{
		// +(void)connectRenrenWithAppId:(NSString *)appId AndAppKey:(NSString *)appKey;
		[Static]
		[Export("connectRenrenWithAppId:AndAppKey:")]
		void ConnectRenrenWithAppId(string appId, string appKey);

		// +(BOOL)isRenrenInstalled;
		[Static]
		[Export("isRenrenInstalled")]
		//[Verify(MethodToProperty)]
		bool IsRenrenInstalled { get; }

		// +(void)shareToRenrenSession:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToRenrenSession:Success:Fail:")]
		void ShareToRenrenSession(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)shareToRenrenTimeline:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToRenrenTimeline:Success:Fail:")]
		void ShareToRenrenTimeline(OSMessage msg, shareSuccess success, shareFail fail);
	}

	// @interface Weibo (OpenShare)
	[Category]
	[BaseType(typeof(OpenShare))]
	interface OpenShare_Weibo
	{
		// +(void)connectWeiboWithAppKey:(NSString *)appKey;
		[Static]
		[Export("connectWeiboWithAppKey:")]
		void ConnectWeiboWithAppKey(string appKey);

		// +(BOOL)isWeiboInstalled;
		[Static]
		[Export("isWeiboInstalled")]
		//[Verify(MethodToProperty)]
		bool IsWeiboInstalled { get; }

		// +(void)shareToWeibo:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToWeibo:Success:Fail:")]
		void ShareToWeibo(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)WeiboAuth:(NSString *)scope redirectURI:(NSString *)redirectURI Success:(authSuccess)success Fail:(authFail)fail;
		[Static]
		[Export("WeiboAuth:redirectURI:Success:Fail:")]
		void WeiboAuth(string scope, string redirectURI, authSuccess success, authFail fail);
	}

	// @interface Weixin (OpenShare)
	[Category]
	[BaseType(typeof(OpenShare))]
	interface OpenShare_Weixin
	{
		// +(void)connectWeixinWithAppId:(NSString *)appId;
		[Static]
		[Export("connectWeixinWithAppId:")]
		void ConnectWeixinWithAppId(string appId);

		// +(BOOL)isWeixinInstalled;
		[Static]
		[Export("isWeixinInstalled")]
		//[Verify(MethodToProperty)]
		bool IsWeixinInstalled { get; }

		// +(void)shareToWeixinSession:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToWeixinSession:Success:Fail:")]
		void ShareToWeixinSession(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)shareToWeixinTimeline:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToWeixinTimeline:Success:Fail:")]
		void ShareToWeixinTimeline(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)shareToWeixinFavorite:(OSMessage *)msg Success:(shareSuccess)success Fail:(shareFail)fail;
		[Static]
		[Export("shareToWeixinFavorite:Success:Fail:")]
		void ShareToWeixinFavorite(OSMessage msg, shareSuccess success, shareFail fail);

		// +(void)WeixinAuth:(NSString *)scope Success:(authSuccess)success Fail:(authFail)fail;
		[Static]
		[Export("WeixinAuth:Success:Fail:")]
		void WeixinAuth(string scope, authSuccess success, authFail fail);

		// +(void)WeixinPay:(NSString *)link Success:(paySuccess)success Fail:(payFail)fail;
		[Static]
		[Export("WeixinPay:Success:Fail:")]
		void WeixinPay(string link, paySuccess success, payFail fail);
	}



}
