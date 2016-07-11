namespace FiladeEspera
{
    partial class FormOperator
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
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelA1 = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.labelTotalA = new System.Windows.Forms.Label();
            this.labelTotalB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.ForeColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(74, 196);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(151, 56);
            this.buttonB.TabIndex = 15;
            this.buttonB.Text = "B - NEXT";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(74, 93);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(151, 56);
            this.buttonA.TabIndex = 14;
            this.buttonA.Text = "A - NEXT";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Number";
            // 
            // labelA1
            // 
            this.labelA1.AutoSize = true;
            this.labelA1.Font = new System.Drawing.Font("Lucida Fax", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA1.Location = new System.Drawing.Point(286, 93);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(100, 32);
            this.labelA1.TabIndex = 19;
            this.labelA1.Text = "00000";
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Font = new System.Drawing.Font("Lucida Fax", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB1.Location = new System.Drawing.Point(286, 196);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(100, 32);
            this.labelB1.TabIndex = 25;
            this.labelB1.Text = "00000";
            // 
            // labelTotalA
            // 
            this.labelTotalA.AutoSize = true;
            this.labelTotalA.Font = new System.Drawing.Font("Lucida Fax", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalA.Location = new System.Drawing.Point(443, 93);
            this.labelTotalA.Name = "labelTotalA";
            this.labelTotalA.Size = new System.Drawing.Size(100, 32);
            this.labelTotalA.TabIndex = 26;
            this.labelTotalA.Text = "00000";
            // 
            // labelTotalB
            // 
            this.labelTotalB.AutoSize = true;
            this.labelTotalB.Font = new System.Drawing.Font("Lucida Fax", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalB.Location = new System.Drawing.Point(454, 196);
            this.labelTotalB.Name = "labelTotalB";
            this.labelTotalB.Size = new System.Drawing.Size(100, 32);
            this.labelTotalB.TabIndex = 27;
            this.labelTotalB.Text = "00000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total";
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalB);
            this.Controls.Add(this.labelTotalA);
            this.Controls.Add(this.labelB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelA1);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Name = "FormOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Operator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormOperator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Label labelTotalA;
        private System.Windows.Forms.Label labelTotalB;
        private System.Windows.Forms.Label label4;
    }
}