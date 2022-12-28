namespace Hubstaf
{
    partial class todos
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
            this.todo = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // todo
            // 
            this.todo.AutoSize = true;
            this.todo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todo.Location = new System.Drawing.Point(67, 10);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(37, 17);
            this.todo.TabIndex = 0;
            this.todo.Text = "todo";
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tanggal.Location = new System.Drawing.Point(182, 11);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(47, 15);
            this.tanggal.TabIndex = 1;
            this.tanggal.Text = "tanggal";
            // 
            // todos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.todo);
            this.Name = "todos";
            this.Size = new System.Drawing.Size(756, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todo;
        private System.Windows.Forms.Label tanggal;
    }
}
