using System;
using ObjCRuntime;
namespace OpenShareTouch
{ 
	[Native]
	public enum OSMultimediaType : long
	{
		News,
		Audio,
		Video,
		App,
		File,
		Undefined
	}

	[Native]
	public enum OSPboardEncoding : long
	{
		KeyedArchiver,
		PropertyListSerialization
	} 
}
