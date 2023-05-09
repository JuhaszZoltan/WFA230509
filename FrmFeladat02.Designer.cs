namespace WFA230509
{
    partial class FrmFeladat02
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelloWorld.Location = new System.Drawing.Point(12, 9);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(215, 46);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            // 
            // btnGomb
            // 
            this.btnGomb.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGomb.Location = new System.Drawing.Point(203, 199);
            this.btnGomb.Name = "btnGomb";
            this.btnGomb.Size = new System.Drawing.Size(576, 235);
            this.btnGomb.TabIndex = 1;
            this.btnGomb.Text = "Ez EgY gOmB";
            this.btnGomb.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 621);
            this.Controls.Add(this.btnGomb);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "FrmFeladat02";
            this.Text = "FrmFeladat02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHelloWorld;
        private Button btnGomb;
    }
}