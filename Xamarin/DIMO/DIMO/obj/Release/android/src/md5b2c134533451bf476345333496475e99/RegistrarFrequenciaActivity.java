package md5b2c134533451bf476345333496475e99;


public class RegistrarFrequenciaActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.wdullaer.materialdatetimepicker.date.DatePickerDialog.OnDateSetListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onDateSet:(Lcom/wdullaer/materialdatetimepicker/date/DatePickerDialog;III)V:GetOnDateSet_Lcom_wdullaer_materialdatetimepicker_date_DatePickerDialog_IIIHandler:Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog/IOnDateSetListenerInvoker, Xamarin.Bindings.MaterialDateTimePicker\n" +
			"";
		mono.android.Runtime.register ("DIMO.Resources.activity.RegistrarFrequenciaActivity, DIMO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RegistrarFrequenciaActivity.class, __md_methods);
	}


	public RegistrarFrequenciaActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RegistrarFrequenciaActivity.class)
			mono.android.TypeManager.Activate ("DIMO.Resources.activity.RegistrarFrequenciaActivity, DIMO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onDateSet (com.wdullaer.materialdatetimepicker.date.DatePickerDialog p0, int p1, int p2, int p3)
	{
		n_onDateSet (p0, p1, p2, p3);
	}

	private native void n_onDateSet (com.wdullaer.materialdatetimepicker.date.DatePickerDialog p0, int p1, int p2, int p3);

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
