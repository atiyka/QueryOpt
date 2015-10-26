using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace QueryOpt
{
    public partial class Form1 : Form
    {
        ContextMenu cMenu = new ContextMenu();
        public string newItemResult = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument dom = new XmlDocument();
                dom.Load("Catalog.xml");

                // initialize the TreeView control
                tree.Nodes.Clear();
                TreeNode tNode = new TreeNode(dom.DocumentElement.Name);
                tNode.Name = "database";
                tree.Nodes.Add(tNode);
                
                // populate the TreeView with the DOM nodes.
                AddNode(dom.DocumentElement, tNode);
                tree.ExpandAll();
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            nodeList = inXmlNode.ChildNodes;
            for (i = 0; i <= nodeList.Count - 1; i++)
            {
                xNode = nodeList[i];
                if (xNode.GetType() == typeof(XmlElement))
                {
                    XmlAttributeCollection attrList = xNode.Attributes;
                    if (attrList.Count == 0 || xNode.Name.StartsWith("Index"))
                        // if there is no attribute, then go deeper
                        AddNode(xNode, inTreeNode);
                    else
                    {
                        // suppose that the first attribute is the name of the column
                        XmlAttribute firstAttr = attrList[0];
                        tNode = new TreeNode(firstAttr.Value);
                        if (xNode.Name.Equals("DataBase"))
                            tNode.Name = "table";
                        else if (xNode.Name.Equals("Table"))
                        {
                            tNode.Name = "attribute";
                            tNode.Tag = xNode;
                            //tNode.Text = tNode.Text.ToString();
                        }
                        //else if (xNode.Name.Equals("Attribute"))
                        //    tNode.Name = "Attribute";

                        inTreeNode.Nodes.Add(tNode);
                        AddNode(xNode, tNode);
                    }
                }
            }
        }

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string val = e.Node.Name;
                if (val.Length != 0)
                {
                    MenuItem menu = new MenuItem("New " + val);
                    menu.Click += (sender2, e2) => menuItem_Click(sender, e);
                    cMenu.MenuItems.Clear();
                    cMenu.MenuItems.Add(menu);
                    cMenu.Show(tree, e.Location);
                }
            }
        }

        private void menuItem_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            var name = e.Node.Text;
            var type = e.Node.Name;

            // uj attributum hozzadasa
            if (e.Node.Name.Equals("attribute"))
            {
                LV_attr.Clear();
                LV_attr.Show();
                
                LV_attr.Columns.Add("First");
                LV_attr.Columns[0].Width = 0;

                
                B_newAttr.Show();
                XmlNode xml = (XmlNode)e.Node.Tag;
                xml = xml.ChildNodes[0];
                

                for (int i = 0; i < xml.ChildNodes.Count; i++)
                {
                    var item = xml.ChildNodes[i];
                    if (item.Name.Equals("Attribute"))
                    {
                        for (int j = 0; j < item.Attributes.Count; j++)
                            LV_attr.Columns.Add(item.Attributes[j].Name);
                        break;
                    }
                }

                for (int i = 0; i < xml.ChildNodes.Count; i++)
                {
                    var item = xml.ChildNodes[i];
                    if (item.Name.Equals("Attribute"))
                    {
                        ListViewItem lv = new ListViewItem();
                        for (int j = 0; j < item.Attributes.Count; j++)
                            lv.SubItems.Add(item.Attributes[j].Value);
                        LV_attr.Items.Add(lv);
                    }
                }
            }
            // uj tabla
            else if (e.Node.Name.Equals("table"))
            {
                XmlNode xml = (XmlNode)e.Node.Tag;
                string tableName = e.Node.Text;

                NewItem newTbl = new NewItem(this);
                var result = newTbl.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(newItemResult);

                    XmlDocument doc = new XmlDocument();
                    doc.Load("Catalog.xml");
                 
                    XmlNode tables = doc.SelectSingleNode("//Tables");
                    XmlNode table = doc.SelectSingleNode("//Table");

                    XmlElement newTable = doc.CreateElement("Table");
                    newTable.SetAttribute("tableName", newItemResult);
                    newTable.SetAttribute("fileName", newItemResult + ".bin");
                    newTable.SetAttribute("rowLength", "53");

                    newTable.IsEmpty = false; // with closing tag

                    tables.InsertBefore(newTable, table);

                    doc.Save("Catalog.xml");
                }
            }
            else if (e.Node.Name.Equals("database"))
            {
                 XmlNode xml = (XmlNode)e.Node.Tag;
                string tableName = e.Node.Text;
                
                NewItem newDb = new NewItem(this);
                var result = newDb.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show(newItemResult);

                    XmlDocument doc = new XmlDocument();
                    doc.Load("Catalog.xml");


                    XmlNode databases = doc.SelectSingleNode("//Databases");
                    XmlNode database = doc.SelectSingleNode("//Database");

                    XmlElement newDatabase = doc.CreateElement("Database");
                    newDatabase.SetAttribute("dataBaseName", newItemResult);

                    newDatabase.IsEmpty = false; // with closing tag

                    databases.InsertBefore(newDatabase, database);

                    doc.Save("Catalog.xml");
                }
            
            }
            
        }

        private void B_newAttr_Click(object sender, EventArgs e)
        {
            NewAttribute newAttr = new NewAttribute();
            newAttr.Show();
        }



    }
}
