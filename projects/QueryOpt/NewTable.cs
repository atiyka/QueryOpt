using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryOpt
{
    public partial class NewTable : Form
    {
        private Form1 parent;

        public string Text1 { get; private set; }

        public NewTable(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void NewItem_Load(object sender, EventArgs e)
        {

        }

        private void B_ok_Click(object sender, EventArgs e)
        {
            this.parent.newItemResult = TB_name.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
