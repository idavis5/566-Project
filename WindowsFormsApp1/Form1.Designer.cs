namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bShifts = new System.Windows.Forms.Button();
            this.bDrop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bShifts
            // 
            this.bShifts.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShifts.Location = new System.Drawing.Point(548, 48);
            this.bShifts.Name = "bShifts";
            this.bShifts.Size = new System.Drawing.Size(165, 131);
            this.bShifts.TabIndex = 0;
            this.bShifts.Text = "Open Shifts";
            this.bShifts.UseVisualStyleBackColor = true;
            this.bShifts.Click += new System.EventHandler(this.bShifts_Click);
            // 
            // bDrop
            // 
            this.bDrop.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDrop.Location = new System.Drawing.Point(548, 213);
            this.bDrop.Name = "bDrop";
            this.bDrop.Size = new System.Drawing.Size(165, 131);
            this.bDrop.TabIndex = 1;
            this.bDrop.Text = "Drop Shifts";
            this.bDrop.UseVisualStyleBackColor = true;
            this.bDrop.Click += new System.EventHandler(this.bDrop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDrop);
            this.Controls.Add(this.bShifts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bShifts;
        private System.Windows.Forms.Button bDrop;
    }
}

