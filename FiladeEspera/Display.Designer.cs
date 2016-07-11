namespace FiladeEspera
{
    partial class Display
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
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.labelA1 = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(11, 244);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(295, 56);
            this.buttonA.TabIndex = 15;
            this.buttonA.Text = "A - Withdrawals";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.ForeColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(384, 244);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(295, 56);
            this.buttonB.TabIndex = 16;
            this.buttonB.Text = "B - Deposits";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // labelA1
            // 
            this.labelA1.AutoSize = true;
            this.labelA1.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA1.Location = new System.Drawing.Point(38, 118);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(243, 76);
            this.labelA1.TabIndex = 17;
            this.labelA1.Text = "00000";
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB1.Location = new System.Drawing.Point(410, 133);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(243, 76);
            this.labelB1.TabIndex = 18;
            this.labelB1.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ticket Line Machine  Simulator";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelB1);
            this.Controls.Add(this.labelA1);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Name = "Display";
            this.Text = "Simulator - Ticket Machine  ";
            this.Load += new System.EventHandler(this.Display_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Label label1;
    }
}