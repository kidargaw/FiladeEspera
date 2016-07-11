namespace FiladeEspera
{
    partial class FormClient
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
            this.labelC = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelA1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(6, 247);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(80, 76);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "C";
            // 
            // labelC1
            // 
            this.labelC1.AutoSize = true;
            this.labelC1.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(161, 247);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(243, 76);
            this.labelC1.TabIndex = 4;
            this.labelC1.Text = "00000";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(12, 129);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(74, 76);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B";
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB1.Location = new System.Drawing.Point(167, 129);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(243, 76);
            this.labelB1.TabIndex = 2;
            this.labelB1.Text = "00000";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(6, 27);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(81, 76);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A";
            // 
            // labelA1
            // 
            this.labelA1.AutoSize = true;
            this.labelA1.Font = new System.Drawing.Font("Lucida Fax", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA1.Location = new System.Drawing.Point(161, 27);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(243, 76);
            this.labelA1.TabIndex = 0;
            this.labelA1.Text = "00000";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.labelC);
            this.groupBox2.Controls.Add(this.labelC1);
            this.groupBox2.Controls.Add(this.labelB);
            this.groupBox2.Controls.Add(this.labelB1);
            this.groupBox2.Controls.Add(this.labelA);
            this.groupBox2.Controls.Add(this.labelA1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(651, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 399);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Painel Informativo";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(24, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(609, 395);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 442);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV - Monitor";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}