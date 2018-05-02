namespace Routes
{
    partial class Updatestop
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
            this.txtOldstopname = new System.Windows.Forms.TextBox();
            this.txtnewstopname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOldstopname
            // 
            this.txtOldstopname.Location = new System.Drawing.Point(158, 81);
            this.txtOldstopname.Name = "txtOldstopname";
            this.txtOldstopname.Size = new System.Drawing.Size(100, 20);
            this.txtOldstopname.TabIndex = 0;
            // 
            // txtnewstopname
            // 
            this.txtnewstopname.Location = new System.Drawing.Point(158, 178);
            this.txtnewstopname.Name = "txtnewstopname";
            this.txtnewstopname.Size = new System.Drawing.Size(100, 20);
            this.txtnewstopname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "old stopname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "new stopname";
            // 
            // cmdChange
            // 
            this.cmdChange.Location = new System.Drawing.Point(182, 272);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(75, 23);
            this.cmdChange.TabIndex = 4;
            this.cmdChange.Text = "Change";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // Updatestop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 319);
            this.Controls.Add(this.cmdChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnewstopname);
            this.Controls.Add(this.txtOldstopname);
            this.Name = "Updatestop";
            this.Text = "Updatestop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldstopname;
        private System.Windows.Forms.TextBox txtnewstopname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdChange;
    }
}