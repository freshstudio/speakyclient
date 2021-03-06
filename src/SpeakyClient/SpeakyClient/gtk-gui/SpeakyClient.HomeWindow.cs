
// This file has been generated by the GUI designer. Do not modify.
namespace SpeakyClient
{
	public partial class HomeWindow
	{
		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Image profilePicImg;

		private global::Gtk.Label nameLbl;

		private global::Gtk.Button googlePlayBtn;

		private global::Gtk.Button appStoreBtn;

		private global::Gtk.VBox vbox6;

		private global::Gtk.HBox hbox4;

		private global::Gtk.EventBox chatImgEvent;

		private global::Gtk.Image chatImg;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label chatNameLbl;

		private global::Gtk.Label additionalInfoLbl;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gtk.TextView chatView;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Entry msgEntry;

		private global::Gtk.Button msgSendBtn;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget SpeakyClient.HomeWindow
			this.Name = "SpeakyClient.HomeWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("HomeWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child SpeakyClient.HomeWindow.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.profilePicImg = new global::Gtk.Image();
			this.profilePicImg.Name = "profilePicImg";
			this.vbox1.Add(this.profilePicImg);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.profilePicImg]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.nameLbl = new global::Gtk.Label();
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Ypad = 50;
			this.nameLbl.LabelProp = global::Mono.Unix.Catalog.GetString("<username>");
			this.vbox1.Add(this.nameLbl);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.nameLbl]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.googlePlayBtn = new global::Gtk.Button();
			this.googlePlayBtn.CanFocus = true;
			this.googlePlayBtn.Name = "googlePlayBtn";
			this.googlePlayBtn.UseUnderline = true;
			this.googlePlayBtn.Label = global::Mono.Unix.Catalog.GetString("Google Play");
			this.vbox1.Add(this.googlePlayBtn);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.googlePlayBtn]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.appStoreBtn = new global::Gtk.Button();
			this.appStoreBtn.CanFocus = true;
			this.appStoreBtn.Name = "appStoreBtn";
			this.appStoreBtn.UseUnderline = true;
			this.appStoreBtn.Label = global::Mono.Unix.Catalog.GetString("AppStore");
			this.vbox1.Add(this.appStoreBtn);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.appStoreBtn]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			this.hbox2.Add(this.vbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.chatImgEvent = new global::Gtk.EventBox();
			this.chatImgEvent.Name = "chatImgEvent";
			// Container child chatImgEvent.Gtk.Container+ContainerChild
			this.chatImg = new global::Gtk.Image();
			this.chatImg.Name = "chatImg";
			this.chatImgEvent.Add(this.chatImg);
			this.hbox4.Add(this.chatImgEvent);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.chatImgEvent]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.chatNameLbl = new global::Gtk.Label();
			this.chatNameLbl.Name = "chatNameLbl";
			this.chatNameLbl.LabelProp = global::Mono.Unix.Catalog.GetString("<name>");
			this.chatNameLbl.UseUnderline = true;
			this.vbox2.Add(this.chatNameLbl);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.chatNameLbl]));
			w8.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.additionalInfoLbl = new global::Gtk.Label();
			this.additionalInfoLbl.Name = "additionalInfoLbl";
			this.additionalInfoLbl.LabelProp = global::Mono.Unix.Catalog.GetString("Last active: 1.01.1970");
			this.vbox2.Add(this.additionalInfoLbl);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.additionalInfoLbl]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.hbox4.Add(this.vbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox2]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox6.Add(this.hbox4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox4]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.chatView = new global::Gtk.TextView();
			this.chatView.CanFocus = true;
			this.chatView.Name = "chatView";
			this.GtkScrolledWindow1.Add(this.chatView);
			this.vbox6.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GtkScrolledWindow1]));
			w13.Position = 1;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.msgEntry = new global::Gtk.Entry();
			this.msgEntry.CanFocus = true;
			this.msgEntry.Name = "msgEntry";
			this.msgEntry.IsEditable = true;
			this.msgEntry.InvisibleChar = '•';
			this.hbox3.Add(this.msgEntry);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.msgEntry]));
			w14.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.msgSendBtn = new global::Gtk.Button();
			this.msgSendBtn.CanFocus = true;
			this.msgSendBtn.Name = "msgSendBtn";
			this.msgSendBtn.UseUnderline = true;
			this.msgSendBtn.Label = global::Mono.Unix.Catalog.GetString("Send message");
			this.hbox3.Add(this.msgSendBtn);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.msgSendBtn]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox6.Add(this.hbox3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox3]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.hbox2.Add(this.vbox6);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox6]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.Add(this.hbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 656;
			this.DefaultHeight = 308;
			this.Show();
			this.googlePlayBtn.Clicked += new global::System.EventHandler(this.OnGooglePlayBtnClicked);
			this.appStoreBtn.Clicked += new global::System.EventHandler(this.OnAppStoreBtnClicked);
		}
	}
}
