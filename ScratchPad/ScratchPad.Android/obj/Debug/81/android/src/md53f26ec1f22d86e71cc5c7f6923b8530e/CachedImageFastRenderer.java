package md53f26ec1f22d86e71cc5c7f6923b8530e;


public class CachedImageFastRenderer
	extends md53f26ec1f22d86e71cc5c7f6923b8530e.CachedImageView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("FFImageLoading.Forms.Droid.CachedImageFastRenderer, FFImageLoading.Forms.Droid", CachedImageFastRenderer.class, __md_methods);
	}


	public CachedImageFastRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CachedImageFastRenderer.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Forms.Droid.CachedImageFastRenderer, FFImageLoading.Forms.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public CachedImageFastRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CachedImageFastRenderer.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Forms.Droid.CachedImageFastRenderer, FFImageLoading.Forms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CachedImageFastRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CachedImageFastRenderer.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Forms.Droid.CachedImageFastRenderer, FFImageLoading.Forms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CachedImageFastRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == CachedImageFastRenderer.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Forms.Droid.CachedImageFastRenderer, FFImageLoading.Forms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
