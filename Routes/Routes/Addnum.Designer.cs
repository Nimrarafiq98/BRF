namespace Routes
{
    partial class Addnum
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
            this.cmdAddnum = new System.Windows.Forms.Button();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.lblRouteNumber = new System.Windows.Forms.Label();
            this.lblBusNumber = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lnkstop = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAddnum
            // 
            this.cmdAddnum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdAddnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddnum.ForeColor = System.Drawing.Color.Maroon;
            this.cmdAddnum.Location = new System.Drawing.Point(366, 51);
            this.cmdAddnum.Name = "cmdAddnum";
            this.cmdAddnum.Size = new System.Drawing.Size(104, 38);
            this.cmdAddnum.TabIndex = 16;
            this.cmdAddnum.Text = "Add";
            this.cmdAddnum.UseVisualStyleBackColor = false;
            this.cmdAddnum.Click += new System.EventHandler(this.cmdAddnum_Click);
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(159, 108);
            this.txtRouteNumber.Multiline = true;
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(120, 34);
            this.txtRouteNumber.TabIndex = 15;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(159, 38);
            this.txtBusNumber.Multiline = true;
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(120, 33);
            this.txtBusNumber.TabIndex = 14;
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblRouteNumber.Location = new System.Drawing.Point(6, 108);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(120, 20);
            this.lblRouteNumber.TabIndex = 13;
            this.lblRouteNumber.Text = "RouteNumber";
            // 
            // lblBusNumber
            // 
            this.lblBusNumber.AutoSize = true;
            this.lblBusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblBusNumber.Location = new System.Drawing.Point(10, 38);
            this.lblBusNumber.Name = "lblBusNumber";
            this.lblBusNumber.Size = new System.Drawing.Size(102, 20);
            this.lblBusNumber.TabIndex = 12;
            this.lblBusNumber.Text = "BusNumber";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lnkstop});
            this.dataGridView1.Location = new System.Drawing.Point(39, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lnkstop
            // 
            this.lnkstop.HeaderText = "stops";
            this.lnkstop.Name = "lnkstop";
            this.lnkstop.Text = "add stops";
            this.lnkstop.UseColumnTextForLinkValue = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(370, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Update Route";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdAddnum);
            this.Controls.Add(this.txtRouteNumber);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.lblRouteNumber);
            this.Controls.Add(this.lblBusNumber);
            this.Name = "Addnum";
            this.Text = "Addnum";
            this.Load += new System.EventHandler(this.Addnum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAddnum;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label lblRouteNumber;
        private System.Windows.Forms.Label lblBusNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn lnkstop;
        private System.Windows.Forms.Button button1;
    }
}