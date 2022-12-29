namespace Hubstaf
{
    partial class Todo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltodo = new Guna.UI.WinForms.GunaLabel();
            this.lbltime = new Guna.UI.WinForms.GunaLabel();
            this.lblid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbltodo
            // 
            this.lbltodo.AutoSize = true;
            this.lbltodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbltodo.Location = new System.Drawing.Point(23, 30);
            this.lbltodo.Name = "lbltodo";
            this.lbltodo.Size = new System.Drawing.Size(68, 15);
            this.lbltodo.TabIndex = 0;
            this.lbltodo.Text = "gunaLabel1";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbltime.Location = new System.Drawing.Point(246, 30);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(68, 15);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "gunaLabel2";
            this.lbltime.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(712, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 5);
            this.panel2.TabIndex = 6;
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbltodo);
            this.Name = "Todo";
            this.Size = new System.Drawing.Size(750, 71);
            this.Load += new System.EventHandler(this.Todo_Load);
            this.Click += new System.EventHandler(this.Todo_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbltodo;
        private Guna.UI.WinForms.GunaLabel lbltime;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panel2;
    }
}
