using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Sunny.UI;
using TreeviewFileExplorer.Properties;

namespace TreeviewFileExplorer
{
    public partial class FrmMain : UIForm
    {
        private static ImageList _allIcons;

        public FrmMain()
        {
            InitializeComponent();

            LanguageEnForUi();

            Sui_TreeView.ImageList = AllIcons;
            Sui_Tt.ShowAlways = true;
            Fbd_Browse.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        public static ImageList AllIcons
        {
            get
            {
                if (_allIcons == null)
                {
                    _allIcons = new ImageList();
                    _allIcons.Images.Add("root", Resources.icon_root);
                    _allIcons.Images.Add("directory", Resources.icon_directory);
                    _allIcons.Images.Add("folder", Resources.icon_folder);
                    _allIcons.Images.Add("exe", Resources.icon_exe);
                    _allIcons.Images.Add("msi", Resources.icon_msi);
                    _allIcons.Images.Add("zip", Resources.icon_zip);
                    _allIcons.Images.Add("pdf", Resources.icon_pdf);
                    _allIcons.Images.Add("java", Resources.icon_java);
                    _allIcons.Images.Add("video", Resources.icon_video);
                }

                return _allIcons;
            }
        }

        #region LoadAllNodes

        public void LoadDirectory(UITreeView tv, string dir)
        {
            var di = new DirectoryInfo(dir);
            var tds = tv.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.ImageKey = @"root";
            tds.SelectedImageKey = @"root";
            LoadFiles(dir, tds);
            LoadSubDirectories(dir, tds);
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            try
            {
                var subdirectoryEntries = Directory.GetDirectories(dir);

                if (subdirectoryEntries.Length != 0)
                {
                    foreach (var subdirectory in subdirectoryEntries)
                    {
                        var di = new DirectoryInfo(subdirectory);
                        var tds = td.Nodes.Add(di.Name);
                        tds.ImageKey = @"directory";
                        tds.SelectedImageKey = @"directory";
                        tds.Tag = di.FullName;
                        LoadFiles(subdirectory, tds);
                        LoadSubDirectories(subdirectory, tds);
                    }
                }
            }
            catch (UnauthorizedAccessException uae)
            {
                //
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            var files = Directory.GetFiles(dir, "*.*");
            foreach (var file in files)
            {
                var fi = new FileInfo(file);
                var tds = td.Nodes.Add(fi.Name);

                switch (fi.Extension)
                {
                    case @".exe":
                        tds.ImageKey = @"exe";
                        tds.SelectedImageKey = @"exe";
                        break;
                    case @".msi":
                        tds.ImageKey = @"msi";
                        tds.SelectedImageKey = @"msi";
                        break;
                    case @".pdf":
                        tds.ImageKey = @"pdf";
                        tds.SelectedImageKey = @"pdf";
                        break;
                    case @".jnlp":
                        tds.ImageKey = @"java";
                        tds.SelectedImageKey = @"java";
                        break;
                    case @".jar":
                        tds.ImageKey = @"java";
                        tds.SelectedImageKey = @"java";
                        break;
                    case @".mp4":
                        tds.ImageKey = @"video";
                        tds.SelectedImageKey = @"video";
                        break;
                    case @".7z":
                        tds.ImageKey = @"zip";
                        tds.SelectedImageKey = @"zip";
                        break;
                    case @".rar":
                        tds.ImageKey = @"zip";
                        tds.SelectedImageKey = @"zip";
                        break;
                    case @".zip":
                        tds.ImageKey = @"zip";
                        tds.SelectedImageKey = @"zip";
                        break;
                    default:
                        tds.ImageKey = @"folder";
                        tds.SelectedImageKey = @"folder";
                        break;
                }

                tds.Tag = fi.FullName;
            }
        }

        #endregion

        #region Helper

        private void LanguageEnForUi()
        {
            UILocalize.OK = @"OK";
            UILocalize.Cancel = @"Cancel";
        }

        private bool NodeFiltering(TreeNode dugum, string arananKelime)
        {
            var sonuc = false;

            if (dugum.Nodes.Count == 0)
            {
                if (dugum.Text.ToUpper().Contains(arananKelime.ToUpper()))
                    sonuc = true;
                else
                    dugum.Remove();
            }
            else
            {
                for (var i = dugum.Nodes.Count; i > 0; i--)
                    if (NodeFiltering(dugum.Nodes[i - 1], arananKelime))
                        sonuc = true;

                if (!sonuc)
                    dugum.Remove();
            }

            dugum.ExpandAll();
            return sonuc;
        }

        public static void SaveTree(UITreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Create))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(file, tree.Nodes.Cast<TreeNode>().ToList());
            }
        }

        public static void LoadTree(UITreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Open))
            {
                var bf = new BinaryFormatter();
                var obj = bf.Deserialize(file);

                var nodeList = (obj as IEnumerable<TreeNode> ?? Array.Empty<TreeNode>()).ToArray();
                tree.Nodes.AddRange(nodeList);
            }
        }

        private void ExpandToLevel(TreeNodeCollection nodes, int level)
        {
            if (level > 0)
                foreach (TreeNode node in nodes)
                {
                    node.Expand();
                    ExpandToLevel(node.Nodes, level - 1);
                }
        }

        #endregion

        #region Event

        private void Sui_TreeView_MouseMove(object sender, MouseEventArgs e)
        {
            var theNode = Sui_TreeView.GetNodeAt(e.X, e.Y);

            if (theNode != null && theNode.Tag != null)
            {
                if (theNode.Tag.ToString() != Sui_Tt.GetToolTip(Sui_TreeView))
                    Sui_Tt.SetToolTip(Sui_TreeView, theNode.Tag.ToString());
            }
            else
            {
                Sui_Tt.SetToolTip(Sui_TreeView, "");
            }
        }

        private void Sui_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Sui_Slbl_SelectedPath.Text = @"";
            var theNode = Sui_TreeView.GetNodeAt(e.X, e.Y);
            Sui_Slbl_SelectedPath.Text = theNode.Tag.ToString();
        }

        private void Sui_Tb_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Sui_Tb_Search.Text.Length == 0)
                {
                    if (File.Exists($@"{Application.StartupPath}\allnodes.bin"))
                    {
                        Sui_TreeView.Nodes.Clear();
                        LoadTree(Sui_TreeView, $@"{Application.StartupPath}\allnodes.bin");
                        ExpandToLevel(Sui_TreeView.Nodes, 1);
                        Sui_Slbl_SelectedPath.Text = @"-";
                    }
                }
                else
                {
                    if (Sui_TreeView.Nodes.Count > 0)
                    {
                        Sui_TreeView.BeginUpdate();
                        if (Sui_Tb_Search.Text.Length > 0)
                            for (var i = Sui_TreeView.Nodes.Count; i > 0; i--)
                                NodeFiltering(Sui_TreeView.Nodes[i - 1], Sui_Tb_Search.Text);
                        Sui_TreeView.EndUpdate();
                    }
                }
            }
        }

        private void Sui_Sb_Browse_Click(object sender, EventArgs e)
        {
            Fbd_Browse.SelectedPath = Sui_Tb_DirectoryPath.Text;
            var drResult = Fbd_Browse.ShowDialog();
            if (drResult == DialogResult.OK) Sui_Tb_DirectoryPath.Text = Fbd_Browse.SelectedPath;
        }

        private void Sui_Sb_Load_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Sui_Tb_DirectoryPath.Text))
            {
                if (Directory.Exists(Sui_Tb_DirectoryPath.Text))
                {
                    try
                    {
                        Sui_TreeView.Nodes.Clear();
                        LoadDirectory(Sui_TreeView, Sui_Tb_DirectoryPath.Text);
                        SaveTree(Sui_TreeView, $@"{Application.StartupPath}\allnodes.bin");
                        ExpandToLevel(Sui_TreeView.Nodes, 1);
                    }
                    catch (Exception exception)
                    {
                        UIMessageBox.Show(exception.ToString(), @"Error");
                    }
                }
                else
                {
                    UIMessageBox.Show(@"Directory Doesn't Exist", @"Info");
                }
            }
            else
            {
                UIMessageBox.Show(@"Directory Not Selected or Null", @"Info");
            }
        }

        #endregion
    }
}