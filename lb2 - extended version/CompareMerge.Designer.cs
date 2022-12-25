
namespace lb2
{
    partial class CompareMerge
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.lbFirst = new System.Windows.Forms.ListBox();
            this.lbSecond = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(389, 382);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 56);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(42, 382);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(121, 56);
            this.btApply.TabIndex = 1;
            this.btApply.Text = "Застосувати";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // lbFirst
            // 
            this.lbFirst.FormattingEnabled = true;
            this.lbFirst.ItemHeight = 16;
            this.lbFirst.Location = new System.Drawing.Point(42, 51);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(213, 308);
            this.lbFirst.TabIndex = 2;
            // 
            // lbSecond
            // 
            this.lbSecond.FormattingEnabled = true;
            this.lbSecond.ItemHeight = 16;
            this.lbSecond.Location = new System.Drawing.Point(294, 51);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(216, 308);
            this.lbSecond.TabIndex = 3;
            // 
            // CompareMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.lbFirst);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btCancel);
            this.Name = "CompareMerge";
            this.Text = "CompareMerge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btApply;
        public System.Windows.Forms.ListBox lbFirst;
        public System.Windows.Forms.ListBox lbSecond;
    }
}