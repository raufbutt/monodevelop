
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Database.Designer
{
	public partial class ForeignKeyConstraintEditorWidget
	{
		private global::Gtk.HPaned hpaned;

		private global::Gtk.VBox vbox3;

		private global::Gtk.ScrolledWindow windowPK;

		private global::Gtk.TreeView listFK;

		private global::Gtk.HButtonBox hbuttonbox;

		private global::Gtk.Button buttonAdd;

		private global::Gtk.Button buttonRemove;

		private global::Gtk.VBox vboxColumns;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment2;

		private global::MonoDevelop.Database.Components.SelectColumnWidget columnSelecter;

		private global::Gtk.Label GtkLabel2;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment3;

		private global::MonoDevelop.Database.Components.SelectColumnWidget referenceColumnSelecter;

		private global::Gtk.Label GtkLabel3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Database.Designer.ForeignKeyConstraintEditorWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Database.Designer.ForeignKeyConstraintEditorWidget";
			// Container child MonoDevelop.Database.Designer.ForeignKeyConstraintEditorWidget.Gtk.Container+ContainerChild
			this.hpaned = new global::Gtk.HPaned ();
			this.hpaned.CanFocus = true;
			this.hpaned.Name = "hpaned";
			this.hpaned.Position = 293;
			// Container child hpaned.Gtk.Paned+PanedChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.windowPK = new global::Gtk.ScrolledWindow ();
			this.windowPK.CanFocus = true;
			this.windowPK.Name = "windowPK";
			this.windowPK.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child windowPK.Gtk.Container+ContainerChild
			this.listFK = new global::Gtk.TreeView ();
			this.listFK.CanFocus = true;
			this.listFK.Name = "listFK";
			this.windowPK.Add (this.listFK);
			this.vbox3.Add (this.windowPK);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.windowPK]));
			w2.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbuttonbox = new global::Gtk.HButtonBox ();
			this.hbuttonbox.Name = "hbuttonbox";
			this.hbuttonbox.Spacing = 6;
			this.hbuttonbox.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child hbuttonbox.Gtk.ButtonBox+ButtonBoxChild
			this.buttonAdd = new global::Gtk.Button ();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseStock = true;
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = "gtk-add";
			this.hbuttonbox.Add (this.buttonAdd);
			global::Gtk.ButtonBox.ButtonBoxChild w3 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox[this.buttonAdd]));
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbuttonbox.Gtk.ButtonBox+ButtonBoxChild
			this.buttonRemove = new global::Gtk.Button ();
			this.buttonRemove.Sensitive = false;
			this.buttonRemove.CanFocus = true;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.UseStock = true;
			this.buttonRemove.UseUnderline = true;
			this.buttonRemove.Label = "gtk-remove";
			this.hbuttonbox.Add (this.buttonRemove);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox[this.buttonRemove]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox3.Add (this.hbuttonbox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbuttonbox]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.hpaned.Add (this.vbox3);
			global::Gtk.Paned.PanedChild w6 = ((global::Gtk.Paned.PanedChild)(this.hpaned[this.vbox3]));
			w6.Resize = false;
			// Container child hpaned.Gtk.Paned+PanedChild
			this.vboxColumns = new global::Gtk.VBox ();
			this.vboxColumns.Name = "vboxColumns";
			this.vboxColumns.Spacing = 6;
			// Container child vboxColumns.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.columnSelecter = new global::MonoDevelop.Database.Components.SelectColumnWidget ();
			this.columnSelecter.Sensitive = false;
			this.columnSelecter.CanFocus = true;
			this.columnSelecter.Name = "columnSelecter";
			this.columnSelecter.ShadowType = ((global::Gtk.ShadowType)(1));
			this.columnSelecter.SingleCheck = false;
			this.GtkAlignment2.Add (this.columnSelecter);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("Columns");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vboxColumns.Add (this.frame1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vboxColumns[this.frame1]));
			w9.Position = 0;
			// Container child vboxColumns.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.referenceColumnSelecter = new global::MonoDevelop.Database.Components.SelectColumnWidget ();
			this.referenceColumnSelecter.Sensitive = false;
			this.referenceColumnSelecter.CanFocus = true;
			this.referenceColumnSelecter.Name = "referenceColumnSelecter";
			this.referenceColumnSelecter.ShadowType = ((global::Gtk.ShadowType)(1));
			this.referenceColumnSelecter.SingleCheck = false;
			this.GtkAlignment3.Add (this.referenceColumnSelecter);
			this.frame2.Add (this.GtkAlignment3);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("Reference Columns");
			this.GtkLabel3.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel3;
			this.vboxColumns.Add (this.frame2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxColumns[this.frame2]));
			w12.Position = 1;
			this.hpaned.Add (this.vboxColumns);
			this.Add (this.hpaned);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.buttonAdd.Clicked += new global::System.EventHandler (this.AddClicked);
			this.buttonRemove.Clicked += new global::System.EventHandler (this.RemoveClicked);
		}
	}
}
