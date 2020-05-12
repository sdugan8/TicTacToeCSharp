namespace tictac
{
    partial class StartUp
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
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(477, 275);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(105, 41);
            this.Two.TabIndex = 5;
            this.Two.Text = "2 Player";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(219, 275);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(105, 41);
            this.One.TabIndex = 4;
            this.One.Text = "1 Player";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tic Tac Toe!!!";
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.label1);
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Label label1;
    }
}