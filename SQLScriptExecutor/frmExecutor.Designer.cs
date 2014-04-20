namespace SQLScriptExecutor
{
    partial class frmExecutor
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
            this.lvFileViewer = new System.Windows.Forms.ListView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqlConnect = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.grpBoxOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.grpBoxFiles = new System.Windows.Forms.GroupBox();
            this.panelButtons.SuspendLayout();
            this.grpBoxOutput.SuspendLayout();
            this.grpBoxFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFileViewer
            // 
            this.lvFileViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFileViewer.GridLines = true;
            this.lvFileViewer.Location = new System.Drawing.Point(6, 19);
            this.lvFileViewer.Name = "lvFileViewer";
            this.lvFileViewer.Size = new System.Drawing.Size(298, 292);
            this.lvFileViewer.TabIndex = 0;
            this.lvFileViewer.UseCompatibleStateImageBehavior = false;
            this.lvFileViewer.View = System.Windows.Forms.View.List;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(7, 22);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(112, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSqlConnect
            // 
            this.btnSqlConnect.Location = new System.Drawing.Point(7, 291);
            this.btnSqlConnect.Name = "btnSqlConnect";
            this.btnSqlConnect.Size = new System.Drawing.Size(112, 23);
            this.btnSqlConnect.TabIndex = 3;
            this.btnSqlConnect.Text = "Connect to Server...";
            this.btnSqlConnect.UseVisualStyleBackColor = true;
            this.btnSqlConnect.Click += new System.EventHandler(this.btnSqlConnect_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSqlConnect);
            this.panelButtons.Controls.Add(this.btnExecute);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Location = new System.Drawing.Point(314, 1);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(122, 320);
            this.panelButtons.TabIndex = 4;
            // 
            // grpBoxOutput
            // 
            this.grpBoxOutput.Controls.Add(this.txtOutput);
            this.grpBoxOutput.Location = new System.Drawing.Point(2, 327);
            this.grpBoxOutput.Name = "grpBoxOutput";
            this.grpBoxOutput.Size = new System.Drawing.Size(434, 132);
            this.grpBoxOutput.TabIndex = 5;
            this.grpBoxOutput.TabStop = false;
            this.grpBoxOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(6, 19);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(422, 107);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // grpBoxFiles
            // 
            this.grpBoxFiles.Controls.Add(this.lvFileViewer);
            this.grpBoxFiles.Location = new System.Drawing.Point(2, 4);
            this.grpBoxFiles.Name = "grpBoxFiles";
            this.grpBoxFiles.Size = new System.Drawing.Size(310, 317);
            this.grpBoxFiles.TabIndex = 6;
            this.grpBoxFiles.TabStop = false;
            this.grpBoxFiles.Text = "Drag & Drop Files Here...";
            // 
            // frmExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 471);
            this.Controls.Add(this.grpBoxFiles);
            this.Controls.Add(this.grpBoxOutput);
            this.Controls.Add(this.panelButtons);
            this.Name = "frmExecutor";
            this.Text = "SQL Executor";
            this.Load += new System.EventHandler(this.frmExecutor_Load);
            this.panelButtons.ResumeLayout(false);
            this.grpBoxOutput.ResumeLayout(false);
            this.grpBoxFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFileViewer;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqlConnect;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox grpBoxOutput;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.GroupBox grpBoxFiles;
    }
}

