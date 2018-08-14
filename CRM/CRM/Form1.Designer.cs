namespace CRM
{
    partial class FormCRM
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelectOldModule = new System.Windows.Forms.Button();
            this.textBoxOldModule = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // buttonSelectOldModule
            // 
            this.buttonSelectOldModule.Location = new System.Drawing.Point(12, 24);
            this.buttonSelectOldModule.Name = "buttonSelectOldModule";
            this.buttonSelectOldModule.Size = new System.Drawing.Size(326, 23);
            this.buttonSelectOldModule.TabIndex = 1;
            this.buttonSelectOldModule.Text = "コピー元モジュール選択";
            this.buttonSelectOldModule.UseVisualStyleBackColor = true;
            this.buttonSelectOldModule.Click += new System.EventHandler(this.buttonSelectOldModule_Click);
            // 
            // textBoxOldModule
            // 
            this.textBoxOldModule.Location = new System.Drawing.Point(14, 56);
            this.textBoxOldModule.Multiline = true;
            this.textBoxOldModule.Name = "textBoxOldModule";
            this.textBoxOldModule.Size = new System.Drawing.Size(324, 109);
            this.textBoxOldModule.TabIndex = 2;
            // 
            // FormCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.textBoxOldModule);
            this.Controls.Add(this.buttonSelectOldModule);
            this.Controls.Add(this.label1);
            this.Name = "FormCRM";
            this.Text = "リリースモジュール作成ツール";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSelectOldModule;
        private System.Windows.Forms.TextBox textBoxOldModule;
    }
}

