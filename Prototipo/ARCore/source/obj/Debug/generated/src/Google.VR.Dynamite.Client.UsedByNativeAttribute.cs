using System;

namespace Google.VR.Dynamite.Client {

	[global::Android.Runtime.Annotation ("com.google.vr.dynamite.client.UsedByNative")]
	public partial class UsedByNativeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
