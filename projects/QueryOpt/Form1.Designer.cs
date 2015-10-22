namespace QueryOpt
{
    partial class Form1
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
            this.tree = new System.Windows.Forms.TreeView();
            this.B_newAttr = new System.Windows.Forms.Button();
            this.LV_attr = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(12, 12);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(201, 421);
            this.tree.TabIndex = 0;
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            // 
            // B_newAttr
            // 
            this.B_newAttr.Location = new System.Drawing.Point(219, 210);
            this.B_newAttr.Name = "B_newAttr";
            this.B_newAttr.Size = new System.Drawing.Size(89, 23);
            this.B_newAttr.TabIndex = 2;
            this.B_newAttr.Text = "New attribute";
            this.B_newAttr.UseVisualStyleBackColor = true;
            this.B_newAttr.Visible = false;
            this.B_newAttr.Click += new System.EventHandler(this.B_newAttr_Click);
            // 
            // LV_attr
            // 
            this.LV_attr.Location = new System.Drawing.Point(219, 12);
            this.LV_attr.Name = "LV_attr";
            this.LV_attr.Size = new System.Drawing.Size(467, 192);
            this.LV_attr.TabIndex = 3;
            this.LV_attr.UseCompatibleStateImageBehavior = false;
            this.LV_attr.View = System.Windows.Forms.View.Details;
            this.LV_attr.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 445);
            this.Controls.Add(this.LV_attr);
            this.Controls.Add(this.B_newAttr);
            this.Controls.Add(this.tree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Button B_newAttr;
        private System.Windows.Forms.ListView LV_attr;
    }
}

