using System;
using ObjCRuntime;

namespace MarqueeLabel.Xamarin.iOS
{
	[Native]
	public enum MarqueeType : long
	{
		LeftRight = 0,
		RightLeft,
		Continuous,
		ContinuousReverse
	}
}
