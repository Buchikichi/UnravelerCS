namespace UnravelerCS
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UnravelButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.PreviewPictureBox = new UnravelerCS.Behavior.CustomPictureBox();
            this.PageTrackBar = new System.Windows.Forms.TrackBar();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // UnravelButton
            // 
            this.UnravelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UnravelButton.BackColor = System.Drawing.Color.MistyRose;
            this.UnravelButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UnravelButton.Location = new System.Drawing.Point(566, 504);
            this.UnravelButton.Name = "UnravelButton";
            this.UnravelButton.Size = new System.Drawing.Size(100, 32);
            this.UnravelButton.TabIndex = 1;
            this.UnravelButton.Text = "Unravel";
            this.UnravelButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(672, 504);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 32);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // FileListBox
            // 
            this.FileListBox.AllowDrop = true;
            this.FileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.ItemHeight = 21;
            this.FileListBox.Location = new System.Drawing.Point(12, 12);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.ScrollAlwaysVisible = true;
            this.FileListBox.Size = new System.Drawing.Size(250, 508);
            this.FileListBox.TabIndex = 2;
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            this.FileListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileListBox_DragDrop);
            this.FileListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileListBox_DragEnter);
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPictureBox.Location = new System.Drawing.Point(268, 12);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(504, 486);
            this.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewPictureBox.TabIndex = 3;
            this.PreviewPictureBox.TabStop = false;
            // 
            // PageTrackBar
            // 
            this.PageTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageTrackBar.AutoSize = false;
            this.PageTrackBar.Location = new System.Drawing.Point(269, 505);
            this.PageTrackBar.Name = "PageTrackBar";
            this.PageTrackBar.Size = new System.Drawing.Size(291, 31);
            this.PageTrackBar.TabIndex = 4;
            this.PageTrackBar.TabStop = false;
            this.PageTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.PageTrackBar.Scroll += new System.EventHandler(this.PageTrackBar_Scroll);
            // 
            // MainForm
            // 
            this.AcceptButton = this.UnravelButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PreviewPictureBox);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UnravelButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PageTrackBar);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button UnravelButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox FileListBox;
        private Behavior.CustomPictureBox PreviewPictureBox;
        private System.Windows.Forms.TrackBar PageTrackBar;
    }
}

