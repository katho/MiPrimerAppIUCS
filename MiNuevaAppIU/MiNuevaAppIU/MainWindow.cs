using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton3Clicked (object sender, EventArgs e)
	{
		Console.WriteLine ("Botón!!!");
		MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent,
			MessageType.Info,
			ButtonsType.Ok, "HelloWorld!!!");
		md.Run ();
		md.Destroy();
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		Console.WriteLine ("Botón!!!");
		MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent,
			MessageType.Info,
			ButtonsType.Ok, "HelloWorld!!!");
		md.Run ();
		md.Destroy();
	}
}
