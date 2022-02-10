
namespace WindowsFormsApp21
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
            this.buttonDock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDock
            // 
            this.buttonDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDock.Location = new System.Drawing.Point(0, 0);
            this.buttonDock.Name = "buttonDock";
            this.buttonDock.Size = new System.Drawing.Size(334, 221);
            this.buttonDock.TabIndex = 0;
            this.buttonDock.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 221);
            this.Controls.Add(this.buttonDock);
            this.MaximumSize = new System.Drawing.Size(350, 260);
            this.MinimumSize = new System.Drawing.Size(0, 260);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDock;
    }
}

