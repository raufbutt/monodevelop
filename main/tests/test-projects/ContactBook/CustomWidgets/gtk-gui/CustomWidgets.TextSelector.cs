
// This file has been generated by the GUI designer. Do not modify.
namespace CustomWidgets
{
	public partial class TextSelector
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action UnaOpci;

		private global::Gtk.Action UnaMs;

		private global::Gtk.Action IUnaAltre;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Entry entry;

		private global::Gtk.ComboBox combobox;

		private global::Gtk.MenuBar menubar1;

		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CustomWidgets.TextSelector
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UnaOpci = new global::Gtk.Action ("UnaOpci", global::Mono.Unix.Catalog.GetString ("Una opció"), null, null);
			this.UnaOpci.ShortLabel = "Una opció";
			w2.Add (this.UnaOpci, null);
			this.UnaMs = new global::Gtk.Action ("UnaMs", global::Mono.Unix.Catalog.GetString ("Una més"), null, null);
			this.UnaMs.ShortLabel = "Una més";
			w2.Add (this.UnaMs, null);
			this.IUnaAltre = new global::Gtk.Action ("IUnaAltre", global::Mono.Unix.Catalog.GetString ("I Una altre"), null, null);
			this.IUnaAltre.ShortLabel = "I Una altre";
			w2.Add (this.IUnaAltre, null);
			this.UIManager.InsertActionGroup (w2, 0);
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "CustomWidgets.TextSelector";
			// Container child CustomWidgets.TextSelector.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 3;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry = new global::Gtk.Entry ();
			this.entry.CanFocus = true;
			this.entry.Name = "entry";
			this.entry.Text = "fadabona";
			this.entry.IsEditable = true;
			this.entry.InvisibleChar = '●';
			this.hbox1.Add (this.entry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.combobox = global::Gtk.ComboBox.NewText ();
			this.combobox.Name = "combobox";
			this.hbox1.Add (this.combobox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.combobox]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='UnaOpci' action='UnaOpci'><menuitem name='UnaMs' action='UnaMs'/><menuitem name='IUnaAltre' action='IUnaAltre'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.hbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menubar1]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = "Texte";
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Show ();
			this.UnaMs.Activated += new global::System.EventHandler (this.OnUnaMsActivated);
			this.entry.Changed += new global::System.EventHandler (this.OnEntryChanged);
			this.combobox.Changed += new global::System.EventHandler (this.OnComboboxChanged);
		}
	}
}