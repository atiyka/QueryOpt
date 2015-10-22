namespace QueryOpt
{
    partial class NewItem
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
            this.L_name = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.B_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_name
            // 
            this.L_name.AutoSize = true;
            this.L_name.Location = new System.Drawing.Point(12, 20);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(38, 13);
            this.L_name.TabIndex = 0;
            this.L_name.Text = "Name:";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(56, 17);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(100, 20);
            this.TB_name.TabIndex = 1;
            // 
            // B_ok
            // 
            this.B_ok.Location = new System.Drawing.Point(162, 15);
            this.B_ok.Name = "B_ok";
            this.B_ok.Size = new System.Drawing.Size(30, 23);
            this.B_ok.TabIndex = 2;
            this.B_ok.Text = "OK";
            this.B_ok.UseVisualStyleBackColor = true;
            this.B_ok.Click += new System.EventHandler(this.B_ok_Click);
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 62);
            this.Controls.Add(this.B_ok);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.L_name);
            this.Name = "NewItem";
            this.Text = "NewItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_name;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Button B_ok;
    }
}