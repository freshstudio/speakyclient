
// This file has been generated by the GUI designer. Do not modify.
namespace SpeakyClient
{
	public partial class LoginWindow
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Table table1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry passwordEntry;

		private global::Gtk.Entry usernameEntry;

		private global::Gtk.Button logInBtn;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget SpeakyClient.LoginWindow
			this.Name = "SpeakyClient.LoginWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Log In with ");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child SpeakyClient.LoginWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Username");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Password");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.passwordEntry = new global::Gtk.Entry();
			this.passwordEntry.CanFocus = true;
			this.passwordEntry.Name = "passwordEntry";
			this.passwordEntry.IsEditable = true;
			this.passwordEntry.Visibility = false;
			this.passwordEntry.InvisibleChar = '•';
			this.table1.Add(this.passwordEntry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.passwordEntry]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.usernameEntry = new global::Gtk.Entry();
			this.usernameEntry.CanFocus = true;
			this.usernameEntry.Name = "usernameEntry";
			this.usernameEntry.IsEditable = true;
			this.usernameEntry.InvisibleChar = '•';
			this.table1.Add(this.usernameEntry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.usernameEntry]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.logInBtn = new global::Gtk.Button();
			this.logInBtn.CanFocus = true;
			this.logInBtn.Name = "logInBtn";
			this.logInBtn.UseUnderline = true;
			this.logInBtn.Label = global::Mono.Unix.Catalog.GetString("Log in");
			this.vbox2.Add(this.logInBtn);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.logInBtn]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 105;
			this.Show();
			this.logInBtn.Clicked += new global::System.EventHandler(this.OnLogInBtnClicked);
		}
	}
}
