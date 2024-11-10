
namespace prjWin_tp1
{
    partial class frmUserMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMan));
            this.rTxtBoxUserMan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTxtBoxUserMan
            // 
            this.rTxtBoxUserMan.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtBoxUserMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxUserMan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rTxtBoxUserMan.Enabled = false;
            this.rTxtBoxUserMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBoxUserMan.Location = new System.Drawing.Point(15, 30);
            this.rTxtBoxUserMan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTxtBoxUserMan.Name = "rTxtBoxUserMan";
            this.rTxtBoxUserMan.ReadOnly = true;
            this.rTxtBoxUserMan.Size = new System.Drawing.Size(545, 574);
            this.rTxtBoxUserMan.TabIndex = 0;
            this.rTxtBoxUserMan.Text = resources.GetString("rTxtBoxUserMan.Text");
            this.rTxtBoxUserMan.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // frmUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(572, 628);
            this.Controls.Add(this.rTxtBoxUserMan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(590, 675);
            this.MinimumSize = new System.Drawing.Size(590, 675);
            this.Name = "frmUserMan";
            this.Text = "Manuelle d\'utilisation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtBoxUserMan;
    }
}