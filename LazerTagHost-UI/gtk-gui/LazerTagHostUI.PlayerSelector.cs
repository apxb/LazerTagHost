// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LazerTagHostUI {
    
    
    public partial class PlayerSelector {
        
        private Gtk.Table tablePlayerSelector;
        
        private Gtk.Label labelColumn1;
        
        private Gtk.Label labelColumn2;
        
        private Gtk.Label labelColumn3;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LazerTagHostUI.PlayerSelector
            Stetic.BinContainer.Attach(this);
            this.Name = "LazerTagHostUI.PlayerSelector";
            // Container child LazerTagHostUI.PlayerSelector.Gtk.Container+ContainerChild
            this.tablePlayerSelector = new Gtk.Table(((uint)(9)), ((uint)(3)), true);
            this.tablePlayerSelector.WidthRequest = 600;
            this.tablePlayerSelector.HeightRequest = 600;
            this.tablePlayerSelector.Name = "tablePlayerSelector";
            this.tablePlayerSelector.RowSpacing = ((uint)(6));
            this.tablePlayerSelector.ColumnSpacing = ((uint)(6));
            this.tablePlayerSelector.BorderWidth = ((uint)(6));
            // Container child tablePlayerSelector.Gtk.Table+TableChild
            this.labelColumn1 = new Gtk.Label();
            this.labelColumn1.Name = "labelColumn1";
            this.labelColumn1.LabelProp = Mono.Unix.Catalog.GetString("label1");
            this.tablePlayerSelector.Add(this.labelColumn1);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.tablePlayerSelector[this.labelColumn1]));
            w1.XOptions = ((Gtk.AttachOptions)(4));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tablePlayerSelector.Gtk.Table+TableChild
            this.labelColumn2 = new Gtk.Label();
            this.labelColumn2.Name = "labelColumn2";
            this.labelColumn2.LabelProp = Mono.Unix.Catalog.GetString("label2");
            this.tablePlayerSelector.Add(this.labelColumn2);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.tablePlayerSelector[this.labelColumn2]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tablePlayerSelector.Gtk.Table+TableChild
            this.labelColumn3 = new Gtk.Label();
            this.labelColumn3.Name = "labelColumn3";
            this.labelColumn3.LabelProp = Mono.Unix.Catalog.GetString("label3");
            this.tablePlayerSelector.Add(this.labelColumn3);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.tablePlayerSelector[this.labelColumn3]));
            w3.LeftAttach = ((uint)(2));
            w3.RightAttach = ((uint)(3));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            this.Add(this.tablePlayerSelector);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
