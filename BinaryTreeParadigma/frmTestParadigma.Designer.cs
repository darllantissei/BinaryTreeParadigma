namespace BinaryTreeParadigma
{
    partial class frmTestParadigma
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
            this.txtResultBinaryTree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultBinaryTree
            // 
            this.txtResultBinaryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultBinaryTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBinaryTree.Location = new System.Drawing.Point(12, 12);
            this.txtResultBinaryTree.Multiline = true;
            this.txtResultBinaryTree.Name = "txtResultBinaryTree";
            this.txtResultBinaryTree.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultBinaryTree.Size = new System.Drawing.Size(558, 177);
            this.txtResultBinaryTree.TabIndex = 0;
            // 
            // frmTestParadigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 201);
            this.Controls.Add(this.txtResultBinaryTree);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestParadigma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processo seletivo Paradigma";
            this.Shown += new System.EventHandler(this.frmTestParadigma_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultBinaryTree;
    }
}

