package md53a34c844facec61e5150340088371e7a;


public class RegistrarFrequenciaActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("DIMO.Resources.controler.RegistrarFrequenciaActivity, DIMO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RegistrarFrequenciaActivity.class, __md_methods);
	}


	public RegistrarFrequenciaActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RegistrarFrequenciaActivity.class)
			mono.android.TypeManager.Activate ("DIMO.Resources.controler.RegistrarFrequenciaActivity, DIMO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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