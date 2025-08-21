namespace _02_Laboratory_Exercise_Queueing_Nicolas
{
    partial class QueueingForm
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
            this.btnCashier = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnCashierWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.Location = new System.Drawing.Point(98, 71);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(185, 138);
            this.btnCashier.TabIndex = 0;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(409, 84);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(240, 32);
            this.lblQueue.TabIndex = 1;
            this.lblQueue.Text = "Position in Queue";
            this.lblQueue.Click += new System.EventHandler(this.lblQueue_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(430, 163);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(192, 46);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "P - 10007";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btnCashierWindow
            // 
            this.btnCashierWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCashierWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierWindow.ForeColor = System.Drawing.Color.Red;
            this.btnCashierWindow.Location = new System.Drawing.Point(98, 231);
            this.btnCashierWindow.Name = "btnCashierWindow";
            this.btnCashierWindow.Size = new System.Drawing.Size(187, 25);
            this.btnCashierWindow.TabIndex = 3;
            this.btnCashierWindow.Text = "Click to get a number";
            this.btnCashierWindow.UseVisualStyleBackColor = false;
            this.btnCashierWindow.Click += new System.EventHandler(this.btnCashierWindow_Click);
            // 
            // QueueingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCashierWindow);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.btnCashier);
            this.Name = "QueueingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCashierWindow;
    }
}

