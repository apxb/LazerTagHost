
// This file has been generated by the GUI designer. Do not modify.
namespace LazerTagHostUI
{
	public partial class PlayerSelectionScreen
	{
		private global::Gtk.HPaned hpaned1;

		private global::Gtk.VBox vboxPanel;

		private global::Gtk.Label labelTitle;

		private global::LazerTagHostUI.PlayerSelector playerselector;

		private global::Gtk.VBox vboxPlayerControls;

		private global::Gtk.Button buttonDropPlayer;

		private global::Gtk.ComboBoxEntry comboboxentryRenamePlayer;

		private global::Gtk.Button buttonLateJoin;

		private global::Gtk.ToggleButton togglebuttonRelativeScores;

		private global::Gtk.HBox hboxBaseControls;

		private global::Gtk.Button buttonNext;

		private global::Gtk.Button buttonPause;

		private global::Gtk.Button buttonAbortHost;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LazerTagHostUI.PlayerSelectionScreen
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LazerTagHostUI.PlayerSelectionScreen";
			// Container child LazerTagHostUI.PlayerSelectionScreen.Gtk.Container+ContainerChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 500;
			this.hpaned1.BorderWidth = ((uint)(6));
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vboxPanel = new global::Gtk.VBox ();
			this.vboxPanel.Name = "vboxPanel";
			this.vboxPanel.Spacing = 6;
			// Container child vboxPanel.Gtk.Box+BoxChild
			this.labelTitle = new global::Gtk.Label ();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("Step Description Here");
			this.vboxPanel.Add (this.labelTitle);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vboxPanel[this.labelTitle]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vboxPanel.Gtk.Box+BoxChild
			this.playerselector = new global::LazerTagHostUI.PlayerSelector ();
			this.playerselector.Events = ((global::Gdk.EventMask)(256));
			this.playerselector.Name = "playerselector";
			this.vboxPanel.Add (this.playerselector);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxPanel[this.playerselector]));
			w2.Position = 1;
			this.hpaned1.Add (this.vboxPanel);
			global::Gtk.Paned.PanedChild w3 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.vboxPanel]));
			w3.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vboxPlayerControls = new global::Gtk.VBox ();
			this.vboxPlayerControls.WidthRequest = 150;
			this.vboxPlayerControls.Name = "vboxPlayerControls";
			this.vboxPlayerControls.Spacing = 6;
			// Container child vboxPlayerControls.Gtk.Box+BoxChild
			this.buttonDropPlayer = new global::Gtk.Button ();
			this.buttonDropPlayer.CanFocus = true;
			this.buttonDropPlayer.Name = "buttonDropPlayer";
			this.buttonDropPlayer.UseUnderline = true;
			// Container child buttonDropPlayer.Gtk.Container+ContainerChild
			global::Gtk.Alignment w4 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w5 = new global::Gtk.HBox ();
			w5.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			w5.Add (w6);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w8 = new global::Gtk.Label ();
			w8.LabelProp = global::Mono.Unix.Catalog.GetString ("Drop Player");
			w8.UseUnderline = true;
			w5.Add (w8);
			w4.Add (w5);
			this.buttonDropPlayer.Add (w4);
			this.vboxPlayerControls.Add (this.buttonDropPlayer);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxPlayerControls[this.buttonDropPlayer]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vboxPlayerControls.Gtk.Box+BoxChild
			this.comboboxentryRenamePlayer = global::Gtk.ComboBoxEntry.NewText ();
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Charlie"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Cougar"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Goose"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Iceman"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Jester"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Maverick"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Merlin"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Slider"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Viper"));
			this.comboboxentryRenamePlayer.AppendText (global::Mono.Unix.Catalog.GetString ("Wolfman"));
			this.comboboxentryRenamePlayer.Name = "comboboxentryRenamePlayer";
			this.vboxPlayerControls.Add (this.comboboxentryRenamePlayer);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxPlayerControls[this.comboboxentryRenamePlayer]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vboxPlayerControls.Gtk.Box+BoxChild
			this.buttonLateJoin = new global::Gtk.Button ();
			this.buttonLateJoin.CanFocus = true;
			this.buttonLateJoin.Name = "buttonLateJoin";
			this.buttonLateJoin.UseUnderline = true;
			// Container child buttonLateJoin.Gtk.Container+ContainerChild
			global::Gtk.Alignment w14 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w15 = new global::Gtk.HBox ();
			w15.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w16 = new global::Gtk.Image ();
			w16.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w15.Add (w16);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w18 = new global::Gtk.Label ();
			w18.LabelProp = global::Mono.Unix.Catalog.GetString ("Late Join");
			w18.UseUnderline = true;
			w15.Add (w18);
			w14.Add (w15);
			this.buttonLateJoin.Add (w14);
			this.vboxPlayerControls.Add (this.buttonLateJoin);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vboxPlayerControls[this.buttonLateJoin]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vboxPlayerControls.Gtk.Box+BoxChild
			this.togglebuttonRelativeScores = new global::Gtk.ToggleButton ();
			this.togglebuttonRelativeScores.CanFocus = true;
			this.togglebuttonRelativeScores.Name = "togglebuttonRelativeScores";
			this.togglebuttonRelativeScores.UseUnderline = true;
			// Container child togglebuttonRelativeScores.Gtk.Container+ContainerChild
			global::Gtk.Alignment w23 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w24 = new global::Gtk.HBox ();
			w24.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w25 = new global::Gtk.Image ();
			w25.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_calendar-view-month", global::Gtk.IconSize.Menu);
			w24.Add (w25);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w27 = new global::Gtk.Label ();
			w27.LabelProp = global::Mono.Unix.Catalog.GetString ("Show Relative Scores");
			w27.UseUnderline = true;
			w24.Add (w27);
			w23.Add (w24);
			this.togglebuttonRelativeScores.Add (w23);
			this.vboxPlayerControls.Add (this.togglebuttonRelativeScores);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vboxPlayerControls[this.togglebuttonRelativeScores]));
			w31.Position = 3;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vboxPlayerControls.Gtk.Box+BoxChild
			this.hboxBaseControls = new global::Gtk.HBox ();
			this.hboxBaseControls.Name = "hboxBaseControls";
			this.hboxBaseControls.Spacing = 6;
			// Container child hboxBaseControls.Gtk.Box+BoxChild
			this.buttonNext = new global::Gtk.Button ();
			this.buttonNext.CanFocus = true;
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.UseUnderline = true;
			// Container child buttonNext.Gtk.Container+ContainerChild
			global::Gtk.Alignment w32 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w33 = new global::Gtk.HBox ();
			w33.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w34 = new global::Gtk.Image ();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w33.Add (w34);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w36 = new global::Gtk.Label ();
			w36.LabelProp = global::Mono.Unix.Catalog.GetString ("_Next");
			w36.UseUnderline = true;
			w33.Add (w36);
			w32.Add (w33);
			this.buttonNext.Add (w32);
			this.hboxBaseControls.Add (this.buttonNext);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hboxBaseControls[this.buttonNext]));
			w40.PackType = ((global::Gtk.PackType)(1));
			w40.Position = 2;
			w40.Expand = false;
			w40.Fill = false;
			// Container child hboxBaseControls.Gtk.Box+BoxChild
			this.buttonPause = new global::Gtk.Button ();
			this.buttonPause.CanFocus = true;
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.UseUnderline = true;
			// Container child buttonPause.Gtk.Container+ContainerChild
			global::Gtk.Alignment w41 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w42 = new global::Gtk.HBox ();
			w42.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w43 = new global::Gtk.Image ();
			w43.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_appointment-reminder", global::Gtk.IconSize.Menu);
			w42.Add (w43);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w45 = new global::Gtk.Label ();
			w45.LabelProp = global::Mono.Unix.Catalog.GetString ("_Pause");
			w45.UseUnderline = true;
			w42.Add (w45);
			w41.Add (w42);
			this.buttonPause.Add (w41);
			this.hboxBaseControls.Add (this.buttonPause);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hboxBaseControls[this.buttonPause]));
			w49.PackType = ((global::Gtk.PackType)(1));
			w49.Position = 3;
			w49.Expand = false;
			w49.Fill = false;
			// Container child hboxBaseControls.Gtk.Box+BoxChild
			this.buttonAbortHost = new global::Gtk.Button ();
			this.buttonAbortHost.CanFocus = true;
			this.buttonAbortHost.Name = "buttonAbortHost";
			this.buttonAbortHost.UseUnderline = true;
			// Container child buttonAbortHost.Gtk.Container+ContainerChild
			global::Gtk.Alignment w50 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w51 = new global::Gtk.HBox ();
			w51.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w52 = new global::Gtk.Image ();
			w52.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w51.Add (w52);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w54 = new global::Gtk.Label ();
			w54.LabelProp = global::Mono.Unix.Catalog.GetString ("_Abort Host");
			w54.UseUnderline = true;
			w51.Add (w54);
			w50.Add (w51);
			this.buttonAbortHost.Add (w50);
			this.hboxBaseControls.Add (this.buttonAbortHost);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.hboxBaseControls[this.buttonAbortHost]));
			w58.PackType = ((global::Gtk.PackType)(1));
			w58.Position = 4;
			w58.Expand = false;
			w58.Fill = false;
			this.vboxPlayerControls.Add (this.hboxBaseControls);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vboxPlayerControls[this.hboxBaseControls]));
			w59.PackType = ((global::Gtk.PackType)(1));
			w59.Position = 5;
			w59.Expand = false;
			w59.Fill = false;
			this.hpaned1.Add (this.vboxPlayerControls);
			global::Gtk.Paned.PanedChild w60 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.vboxPlayerControls]));
			w60.Resize = false;
			w60.Shrink = false;
			this.Add (this.hpaned1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.togglebuttonRelativeScores.Toggled += new global::System.EventHandler (this.RelativeScoresToggled);
		}
	}
}
