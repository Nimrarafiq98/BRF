namespace Routes
{
    partial class Addstop
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
            this.lblStopName = new System.Windows.Forms.Label();
            this.txtStopName = new System.Windows.Forms.TextBox();
            this.cmdAddStop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStopName
            // 
            this.lblStopName.AutoSize = true;
            this.lblStopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopName.ForeColor = System.Drawing.Color.Navy;
            this.lblStopName.Location = new System.Drawing.Point(32, 42);
            this.lblStopName.Name = "lblStopName";
            this.lblStopName.Size = new System.Drawing.Size(93, 20);
            this.lblStopName.TabIndex = 0;
            this.lblStopName.Text = "StopName";
            // 
            // txtStopName
            // 
            this.txtStopName.Location = new System.Drawing.Point(145, 32);
            this.txtStopName.Multiline = true;
            this.txtStopName.Name = "txtStopName";
            this.txtStopName.Size = new System.Drawing.Size(203, 41);
            this.txtStopName.TabIndex = 1;
            // 
            // cmdAddStop
            // 
            this.cmdAddStop.BackColor = System.Drawing.Color.White;
            this.cmdAddStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddStop.ForeColor = System.Drawing.Color.Maroon;
            this.cmdAddStop.Location = new System.Drawing.Point(273, 93);
            this.cmdAddStop.Name = "cmdAddStop";
            this.cmdAddStop.Size = new System.Drawing.Size(100, 33);
            this.cmdAddStop.TabIndex = 2;
            this.cmdAddStop.Text = "Add Stop";
            this.cmdAddStop.UseVisualStyleBackColor = false;
            this.cmdAddStop.Click += new System.EventHandler(this.cmdAddStop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Addstop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 333);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdAddStop);
            this.Controls.Add(this.txtStopName);
            this.Controls.Add(this.lblStopName);
            this.Name = "Addstop";
            this.Text = "Addstop";
            this.Load += new System.EventHandler(this.Addstop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStopName;
        private System.Windows.Forms.TextBox txtStopName;
        private System.Windows.Forms.Button cmdAddStop;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}