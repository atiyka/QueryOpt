namespace QueryOpt
{
    partial class NewAttribute
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
            this.B_save = new System.Windows.Forms.Button();
            this.CB_ref = new System.Windows.Forms.ComboBox();
            this.CB_primary = new System.Windows.Forms.CheckBox();
            this.CB_null = new System.Windows.Forms.CheckBox();
            this.CB_type = new System.Windows.Forms.ComboBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.L_ref = new System.Windows.Forms.Label();
            this.L_primary = new System.Windows.Forms.Label();
            this.L_null = new System.Windows.Forms.Label();
            this.L_type = new System.Windows.Forms.Label();
            this.L_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_save
            // 
            this.B_save.AccessibleRole = System.Windows.Forms.AccessibleRole.HelpBalloon;
            this.B_save.Location = new System.Drawing.Point(80, 204);
            this.B_save.Name = "B_save";
            this.B_save.Size = new System.Drawing.Size(75, 23);
            this.B_save.TabIndex = 21;
            this.B_save.Text = "Save";
            this.B_save.UseVisualStyleBackColor = true;
            // 
            // CB_ref
            // 
            this.CB_ref.FormattingEnabled = true;
            this.CB_ref.Location = new System.Drawing.Point(80, 157);
            this.CB_ref.Name = "CB_ref";
            this.CB_ref.Size = new System.Drawing.Size(109, 21);
            this.CB_ref.TabIndex = 20;
            // 
            // CB_primary
            // 
            this.CB_primary.AutoSize = true;
            this.CB_primary.Location = new System.Drawing.Point(80, 132);
            this.CB_primary.Name = "CB_primary";
            this.CB_primary.Size = new System.Drawing.Size(15, 14);
            this.CB_primary.TabIndex = 19;
            this.CB_primary.UseVisualStyleBackColor = true;
            // 
            // CB_null
            // 
            this.CB_null.AutoSize = true;
            this.CB_null.Location = new System.Drawing.Point(80, 104);
            this.CB_null.Name = "CB_null";
            this.CB_null.Size = new System.Drawing.Size(15, 14);
            this.CB_null.TabIndex = 18;
            this.CB_null.UseVisualStyleBackColor = true;
            // 
            // CB_type
            // 
            this.CB_type.FormattingEnabled = true;
            this.CB_type.Items.AddRange(new object[] {
            "int",
            "varchar"});
            this.CB_type.Location = new System.Drawing.Point(80, 69);
            this.CB_type.Name = "CB_type";
            this.CB_type.Size = new System.Drawing.Size(109, 21);
            this.CB_type.TabIndex = 17;
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(80, 35);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(109, 20);
            this.TB_name.TabIndex = 16;
            // 
            // L_ref
            // 
            this.L_ref.AutoSize = true;
            this.L_ref.Location = new System.Drawing.Point(9, 160);
            this.L_ref.Name = "L_ref";
            this.L_ref.Size = new System.Drawing.Size(65, 13);
            this.L_ref.TabIndex = 15;
            this.L_ref.Text = "References:";
            // 
            // L_primary
            // 
            this.L_primary.AutoSize = true;
            this.L_primary.Location = new System.Drawing.Point(30, 132);
            this.L_primary.Name = "L_primary";
            this.L_primary.Size = new System.Drawing.Size(44, 13);
            this.L_primary.TabIndex = 14;
            this.L_primary.Text = "Primary:";
            // 
            // L_null
            // 
            this.L_null.AutoSize = true;
            this.L_null.Location = new System.Drawing.Point(36, 104);
            this.L_null.Name = "L_null";
            this.L_null.Size = new System.Drawing.Size(38, 13);
            this.L_null.TabIndex = 13;
            this.L_null.Text = "NULL:";
            // 
            // L_type
            // 
            this.L_type.AutoSize = true;
            this.L_type.Location = new System.Drawing.Point(40, 72);
            this.L_type.Name = "L_type";
            this.L_type.Size = new System.Drawing.Size(34, 13);
            this.L_type.TabIndex = 12;
            this.L_type.Text = "Type:";
            // 
            // L_name
            // 
            this.L_name.AutoSize = true;
            this.L_name.Location = new System.Drawing.Point(36, 38);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(38, 13);
            this.L_name.TabIndex = 11;
            this.L_name.Text = "Name:";
            // 
            // NewA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.B_save);
            this.Controls.Add(this.CB_ref);
            this.Controls.Add(this.CB_primary);
            this.Controls.Add(this.CB_null);
            this.Controls.Add(this.CB_type);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.L_ref);
            this.Controls.Add(this.L_primary);
            this.Controls.Add(this.L_null);
            this.Controls.Add(this.L_type);
            this.Controls.Add(this.L_name);
            this.Name = "NewA";
            this.Text = "NewA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_save;
        private System.Windows.Forms.ComboBox CB_ref;
        private System.Windows.Forms.CheckBox CB_primary;
        private System.Windows.Forms.CheckBox CB_null;
        private System.Windows.Forms.ComboBox CB_type;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label L_ref;
        private System.Windows.Forms.Label L_primary;
        private System.Windows.Forms.Label L_null;
        private System.Windows.Forms.Label L_type;
        private System.Windows.Forms.Label L_name;
    }
}