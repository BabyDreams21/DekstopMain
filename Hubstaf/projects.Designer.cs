namespace Hubstaf.Resources
{
    partial class projects
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
            this.name = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(4, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(186, 23);
            this.name.TabIndex = 1;
            this.name.Text = "name project";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(7, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 5);
            this.panel1.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(254, 16);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 3;
            this.id.Text = "id";
            // 
            // projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Name = "projects";
            this.Size = new System.Drawing.Size(320, 45);
            this.Load += new System.EventHandler(this.projects_Load);
            this.Click += new System.EventHandler(this.projects_Click);
            this.MouseEnter += new System.EventHandler(this.projects_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.projects_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label id;
    }
}
