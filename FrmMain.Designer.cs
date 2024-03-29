namespace TreeviewFileExplorer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Sui_Tlp_Main = new Sunny.UI.UITableLayoutPanel();
            this.Sui_Sb_Browse = new Sunny.UI.UISymbolButton();
            this.Sui_Tb_DirectoryPath = new Sunny.UI.UITextBox();
            this.Sui_Tb_Search = new Sunny.UI.UITextBox();
            this.Sui_TreeView = new Sunny.UI.UITreeView();
            this.Sui_Slbl_SelectedPath = new Sunny.UI.UISymbolLabel();
            this.Sui_Sb_Load = new Sunny.UI.UISymbolButton();
            this.Fbd_Browse = new System.Windows.Forms.FolderBrowserDialog();
            this.Sui_Tt = new Sunny.UI.UIToolTip(this.components);
            this.Sui_Tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sui_Tlp_Main
            // 
            this.Sui_Tlp_Main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.Sui_Tlp_Main.ColumnCount = 1;
            this.Sui_Tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Sui_Tlp_Main.Controls.Add(this.Sui_Sb_Browse, 0, 0);
            this.Sui_Tlp_Main.Controls.Add(this.Sui_Tb_DirectoryPath, 0, 1);
            this.Sui_Tlp_Main.Controls.Add(this.Sui_Tb_Search, 0, 3);
            this.Sui_Tlp_Main.Controls.Add(this.Sui_TreeView, 0, 4);
            this.Sui_Tlp_Main.Controls.Add(this.Sui_Slbl_SelectedPath, 0, 5);
            this.Sui_Tlp_Main.Controls.Add(this.Sui_Sb_Load, 0, 2);
            this.Sui_Tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sui_Tlp_Main.Location = new System.Drawing.Point(2, 36);
            this.Sui_Tlp_Main.Name = "Sui_Tlp_Main";
            this.Sui_Tlp_Main.Padding = new System.Windows.Forms.Padding(5);
            this.Sui_Tlp_Main.RowCount = 6;
            this.Sui_Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Sui_Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Sui_Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Sui_Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Sui_Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Sui_Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Sui_Tlp_Main.Size = new System.Drawing.Size(796, 762);
            this.Sui_Tlp_Main.TabIndex = 0;
            this.Sui_Tlp_Main.TagString = null;
            // 
            // Sui_Sb_Browse
            // 
            this.Sui_Sb_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sui_Sb_Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sui_Sb_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_Sb_Browse.Location = new System.Drawing.Point(10, 10);
            this.Sui_Sb_Browse.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sui_Sb_Browse.Name = "Sui_Sb_Browse";
            this.Sui_Sb_Browse.Size = new System.Drawing.Size(776, 34);
            this.Sui_Sb_Browse.Symbol = 61564;
            this.Sui_Sb_Browse.TabIndex = 0;
            this.Sui_Sb_Browse.Text = "Browse";
            this.Sui_Sb_Browse.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_Sb_Browse.Click += new System.EventHandler(this.Sui_Sb_Browse_Click);
            // 
            // Sui_Tb_DirectoryPath
            // 
            this.Sui_Tb_DirectoryPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sui_Tb_DirectoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sui_Tb_DirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_Tb_DirectoryPath.Location = new System.Drawing.Point(11, 54);
            this.Sui_Tb_DirectoryPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sui_Tb_DirectoryPath.MinimumSize = new System.Drawing.Size(1, 16);
            this.Sui_Tb_DirectoryPath.Name = "Sui_Tb_DirectoryPath";
            this.Sui_Tb_DirectoryPath.Padding = new System.Windows.Forms.Padding(5);
            this.Sui_Tb_DirectoryPath.ShowText = false;
            this.Sui_Tb_DirectoryPath.Size = new System.Drawing.Size(774, 30);
            this.Sui_Tb_DirectoryPath.TabIndex = 1;
            this.Sui_Tb_DirectoryPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sui_Tb_DirectoryPath.Watermark = "";
            // 
            // Sui_Tb_Search
            // 
            this.Sui_Tb_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sui_Tb_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sui_Tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_Tb_Search.Location = new System.Drawing.Point(11, 138);
            this.Sui_Tb_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sui_Tb_Search.MinimumSize = new System.Drawing.Size(1, 16);
            this.Sui_Tb_Search.Name = "Sui_Tb_Search";
            this.Sui_Tb_Search.Padding = new System.Windows.Forms.Padding(5);
            this.Sui_Tb_Search.ShowText = false;
            this.Sui_Tb_Search.Size = new System.Drawing.Size(774, 30);
            this.Sui_Tb_Search.TabIndex = 2;
            this.Sui_Tb_Search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sui_Tb_Search.Watermark = "SEARCH AND ENTER";
            this.Sui_Tb_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sui_Tb_Search_KeyUp);
            // 
            // Sui_TreeView
            // 
            this.Sui_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sui_TreeView.FillColor = System.Drawing.Color.White;
            this.Sui_TreeView.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.Sui_TreeView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_TreeView.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.Sui_TreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Sui_TreeView.Location = new System.Drawing.Point(11, 180);
            this.Sui_TreeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sui_TreeView.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sui_TreeView.Name = "Sui_TreeView";
            this.Sui_TreeView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Sui_TreeView.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.Sui_TreeView.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Sui_TreeView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Sui_TreeView.ScrollBarStyleInherited = false;
            this.Sui_TreeView.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Sui_TreeView.ShowLines = true;
            this.Sui_TreeView.ShowText = false;
            this.Sui_TreeView.Size = new System.Drawing.Size(774, 528);
            this.Sui_TreeView.Style = Sunny.UI.UIStyle.Custom;
            this.Sui_TreeView.TabIndex = 3;
            this.Sui_TreeView.Text = null;
            this.Sui_TreeView.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sui_TreeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sui_TreeView_MouseMove);
            this.Sui_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Sui_TreeView_NodeMouseClick);
            // 
            // Sui_Slbl_SelectedPath
            // 
            this.Sui_Slbl_SelectedPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sui_Slbl_SelectedPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_Slbl_SelectedPath.Location = new System.Drawing.Point(10, 718);
            this.Sui_Slbl_SelectedPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sui_Slbl_SelectedPath.Name = "Sui_Slbl_SelectedPath";
            this.Sui_Slbl_SelectedPath.Size = new System.Drawing.Size(776, 34);
            this.Sui_Slbl_SelectedPath.TabIndex = 4;
            this.Sui_Slbl_SelectedPath.Text = "-";
            this.Sui_Slbl_SelectedPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sui_Sb_Load
            // 
            this.Sui_Sb_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sui_Sb_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sui_Sb_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_Sb_Load.Location = new System.Drawing.Point(10, 94);
            this.Sui_Sb_Load.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sui_Sb_Load.Name = "Sui_Sb_Load";
            this.Sui_Sb_Load.Size = new System.Drawing.Size(776, 34);
            this.Sui_Sb_Load.Symbol = 61473;
            this.Sui_Sb_Load.TabIndex = 5;
            this.Sui_Sb_Load.Text = "Load";
            this.Sui_Sb_Load.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sui_Sb_Load.Click += new System.EventHandler(this.Sui_Sb_Load_Click);
            // 
            // Sui_Tt
            // 
            this.Sui_Tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Sui_Tt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sui_Tt.OwnerDraw = true;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.Sui_Tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2560, 1440);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ShowDragStretch = true;
            this.ShowFullScreen = true;
            this.ShowTitleIcon = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "TreeviewFileExplorer";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Sui_Tlp_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITableLayoutPanel Sui_Tlp_Main;
        private Sunny.UI.UISymbolButton Sui_Sb_Browse;
        private Sunny.UI.UITextBox Sui_Tb_DirectoryPath;
        private Sunny.UI.UITextBox Sui_Tb_Search;
        private Sunny.UI.UITreeView Sui_TreeView;
        private Sunny.UI.UISymbolLabel Sui_Slbl_SelectedPath;
        private System.Windows.Forms.FolderBrowserDialog Fbd_Browse;
        private Sunny.UI.UIToolTip Sui_Tt;
        private Sunny.UI.UISymbolButton Sui_Sb_Load;
    }
}

