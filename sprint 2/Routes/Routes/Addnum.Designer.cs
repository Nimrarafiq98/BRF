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
            this.lnkAddStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddStops.LinkColor = System.Drawing.Color.Maroon;
            this.lnkAddStops.Location = new System.Drawing.Point(47, 206);
            this.lnkAddStops.Name = "lnkAddStops";
            this.lnkAddStops.Size = new System.Drawing.Size(100, 24);
            this.lnkAddStops.TabIndex = 11;
            this.lnkAddStops.TabStop = true;
            this.lnkAddStops.Text = "AddStops";
            this.lnkAddStops.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddStops_LinkClicked);
            // 
            // cmdAddnum
            // 
            this.cmdAddnum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdAddnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddnum.ForeColor = System.Drawing.Color.Maroon;
            this.cmdAddnum.Location = new System.Drawing.Point(196, 200);
            this.cmdAddnum.Name = "cmdAddnum";
            this.cmdAddnum.Size = new System.Drawing.Size(104, 38);
            this.cmdAddnum.TabIndex = 10;
            this.cmdAddnum.Text = "Add";
            this.cmdAddnum.UseVisualStyleBackColor = false;
            this.cmdAddnum.Click += new System.EventHandler(this.cmdAddnum_Click);
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(180, 124);
            this.txtRouteNumber.Multiline = true;
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(120, 34);
            this.txtRouteNumber.TabIndex = 9;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(180, 54);
            this.txtBusNumber.Multiline = true;
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(120, 33);
            this.txtBusNumber.TabIndex = 8;
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblRouteNumber.Location = new System.Drawing.Point(27, 124);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(120, 20);
            this.lblRouteNumber.TabIndex = 7;
            this.lblRouteNumber.Text = "RouteNumber";
            // 
            // lblBusNumber
            // 
            this.lblBusNumber.AutoSize = true;
            this.lblBusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblBusNumber.Location = new System.Drawing.Point(31, 54);
            this.lblBusNumber.Name = "lblBusNumber";
            this.lblBusNumber.Size = new System.Drawing.Size(102, 20);
            this.lblBusNumber.TabIndex = 6;
            this.lblBusNumber.Text = "BusNumber";
            // 
            // Addnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 306);
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