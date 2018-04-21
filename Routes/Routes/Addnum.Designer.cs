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
            this.lnkAddStops = new System.Windows.Forms.LinkLabel();
            this.cmdAddnum = new System.Windows.Forms.Button();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.lblRouteNumber = new System.Windows.Forms.Label();
            this.lblBusNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkAddStops
            // 
            this.lnkAddStops.AutoSize = true;
            this.lnkAddStops.Location = new System.Drawing.Point(32, 182);
            this.lnkAddStops.Name = "lnkAddStops";
            this.lnkAddStops.Size = new System.Drawing.Size(53, 13);
            this.lnkAddStops.TabIndex = 11;
            this.lnkAddStops.TabStop = true;
            this.lnkAddStops.Text = "AddStops";
            // 
            // cmdAddnum
            // 
            this.cmdAddnum.Location = new System.Drawing.Point(153, 182);
            this.cmdAddnum.Name = "cmdAddnum";
            this.cmdAddnum.Size = new System.Drawing.Size(75, 23);
            this.cmdAddnum.TabIndex = 10;
            this.cmdAddnum.Text = "Add";
            this.cmdAddnum.UseVisualStyleBackColor = true;
            this.cmdAddnum.Click += new System.EventHandler(this.cmdAddnum_Click);
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(153, 108);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRouteNumber.TabIndex = 9;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(153, 56);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBusNumber.TabIndex = 8;
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Location = new System.Drawing.Point(52, 108);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(73, 13);
            this.lblRouteNumber.TabIndex = 7;
            this.lblRouteNumber.Text = "RouteNumber";
            // 
            // lblBusNumber
            // 
            this.lblBusNumber.AutoSize = true;
            this.lblBusNumber.Location = new System.Drawing.Point(49, 56);
            this.lblBusNumber.Name = "lblBusNumber";
            this.lblBusNumber.Size = new System.Drawing.Size(62, 13);
            this.lblBusNumber.TabIndex = 6;
            this.lblBusNumber.Text = "BusNumber";
            // 
            // Addnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lnkAddStops);
            this.Controls.Add(this.cmdAddnum);
            this.Controls.Add(this.txtRouteNumber);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.lblRouteNumber);
            this.Controls.Add(this.lblBusNumber);
            this.Name = "Addnum";
            this.Text = "Addnum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkAddStops;
        private System.Windows.Forms.Button cmdAddnum;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label lblRouteNumber;
        private System.Windows.Forms.Label lblBusNumber;
    }
}