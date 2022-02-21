
namespace VideoCutter
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.inputVideoFile = new System.Windows.Forms.OpenFileDialog();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.compressionCheck = new System.Windows.Forms.CheckBox();
            this.startH = new System.Windows.Forms.TextBox();
            this.startS = new System.Windows.Forms.TextBox();
            this.startLbl = new System.Windows.Forms.Label();
            this.outputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.startHLbl = new System.Windows.Forms.Label();
            this.startM = new System.Windows.Forms.TextBox();
            this.startMLbl = new System.Windows.Forms.Label();
            this.startSLbl = new System.Windows.Forms.Label();
            this.endLbl = new System.Windows.Forms.Label();
            this.endSLbl = new System.Windows.Forms.Label();
            this.endMLbl = new System.Windows.Forms.Label();
            this.endM = new System.Windows.Forms.TextBox();
            this.endHLbl = new System.Windows.Forms.Label();
            this.endS = new System.Windows.Forms.TextBox();
            this.endH = new System.Windows.Forms.TextBox();
            this.outputNameLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.bitrateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(12, 12);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFileBtn.TabIndex = 0;
            this.loadFileBtn.Text = "Load File...";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // inputVideoFile
            // 
            this.inputVideoFile.DefaultExt = "mp4";
            this.inputVideoFile.Filter = "Mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            this.inputVideoFile.RestoreDirectory = true;
            this.inputVideoFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openVideoFile_FileOk);
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(93, 16);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(87, 15);
            this.fileNameLbl.TabIndex = 1;
            this.fileNameLbl.Text = "PLACEHOLDER";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(12, 41);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 20);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "Save to...";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // compressionCheck
            // 
            this.compressionCheck.AutoSize = true;
            this.compressionCheck.Location = new System.Drawing.Point(120, 176);
            this.compressionCheck.Name = "compressionCheck";
            this.compressionCheck.Size = new System.Drawing.Size(96, 19);
            this.compressionCheck.TabIndex = 8;
            this.compressionCheck.Text = "Compression";
            this.compressionCheck.UseVisualStyleBackColor = true;
            // 
            // startH
            // 
            this.startH.Location = new System.Drawing.Point(12, 110);
            this.startH.Name = "startH";
            this.startH.Size = new System.Drawing.Size(45, 23);
            this.startH.TabIndex = 2;
            this.startH.Text = "00";
            // 
            // startS
            // 
            this.startS.Location = new System.Drawing.Point(114, 110);
            this.startS.Name = "startS";
            this.startS.Size = new System.Drawing.Size(45, 23);
            this.startS.TabIndex = 4;
            this.startS.Text = "00.00";
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startLbl.Location = new System.Drawing.Point(12, 64);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(45, 21);
            this.startLbl.TabIndex = 7;
            this.startLbl.Text = "Start:";
            // 
            // outputFileDialog
            // 
            this.outputFileDialog.DefaultExt = "mp4";
            this.outputFileDialog.Filter = "Mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            this.outputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // startHLbl
            // 
            this.startHLbl.AutoSize = true;
            this.startHLbl.Location = new System.Drawing.Point(12, 92);
            this.startHLbl.Name = "startHLbl";
            this.startHLbl.Size = new System.Drawing.Size(39, 15);
            this.startHLbl.TabIndex = 8;
            this.startHLbl.Text = "Hours";
            // 
            // startM
            // 
            this.startM.Location = new System.Drawing.Point(63, 110);
            this.startM.Name = "startM";
            this.startM.Size = new System.Drawing.Size(45, 23);
            this.startM.TabIndex = 3;
            this.startM.Text = "00";
            // 
            // startMLbl
            // 
            this.startMLbl.AutoSize = true;
            this.startMLbl.Location = new System.Drawing.Point(63, 92);
            this.startMLbl.Name = "startMLbl";
            this.startMLbl.Size = new System.Drawing.Size(50, 15);
            this.startMLbl.TabIndex = 10;
            this.startMLbl.Text = "Minutes";
            // 
            // startSLbl
            // 
            this.startSLbl.AutoSize = true;
            this.startSLbl.Location = new System.Drawing.Point(114, 92);
            this.startSLbl.Name = "startSLbl";
            this.startSLbl.Size = new System.Drawing.Size(51, 15);
            this.startSLbl.TabIndex = 11;
            this.startSLbl.Text = "Seconds";
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endLbl.Location = new System.Drawing.Point(193, 64);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(36, 21);
            this.endLbl.TabIndex = 12;
            this.endLbl.Text = "End";
            // 
            // endSLbl
            // 
            this.endSLbl.AutoSize = true;
            this.endSLbl.Location = new System.Drawing.Point(295, 92);
            this.endSLbl.Name = "endSLbl";
            this.endSLbl.Size = new System.Drawing.Size(51, 15);
            this.endSLbl.TabIndex = 18;
            this.endSLbl.Text = "Seconds";
            // 
            // endMLbl
            // 
            this.endMLbl.AutoSize = true;
            this.endMLbl.Location = new System.Drawing.Point(244, 92);
            this.endMLbl.Name = "endMLbl";
            this.endMLbl.Size = new System.Drawing.Size(50, 15);
            this.endMLbl.TabIndex = 17;
            this.endMLbl.Text = "Minutes";
            // 
            // endM
            // 
            this.endM.Location = new System.Drawing.Point(244, 110);
            this.endM.Name = "endM";
            this.endM.Size = new System.Drawing.Size(45, 23);
            this.endM.TabIndex = 6;
            this.endM.Text = "00";
            // 
            // endHLbl
            // 
            this.endHLbl.AutoSize = true;
            this.endHLbl.Location = new System.Drawing.Point(193, 92);
            this.endHLbl.Name = "endHLbl";
            this.endHLbl.Size = new System.Drawing.Size(39, 15);
            this.endHLbl.TabIndex = 15;
            this.endHLbl.Text = "Hours";
            // 
            // endS
            // 
            this.endS.Location = new System.Drawing.Point(295, 110);
            this.endS.Name = "endS";
            this.endS.Size = new System.Drawing.Size(45, 23);
            this.endS.TabIndex = 7;
            this.endS.Text = "00.00";
            // 
            // endH
            // 
            this.endH.Location = new System.Drawing.Point(193, 110);
            this.endH.Name = "endH";
            this.endH.Size = new System.Drawing.Size(45, 23);
            this.endH.TabIndex = 5;
            this.endH.Text = "00";
            // 
            // outputNameLbl
            // 
            this.outputNameLbl.AutoSize = true;
            this.outputNameLbl.Location = new System.Drawing.Point(93, 44);
            this.outputNameLbl.Name = "outputNameLbl";
            this.outputNameLbl.Size = new System.Drawing.Size(87, 15);
            this.outputNameLbl.TabIndex = 21;
            this.outputNameLbl.Text = "PLACEHOLDER";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(14, 203);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(328, 51);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(14, 257);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(26, 15);
            this.statusLbl.TabIndex = 24;
            this.statusLbl.Text = "Idle";
            // 
            // bitrateTxt
            // 
            this.bitrateTxt.Location = new System.Drawing.Point(14, 174);
            this.bitrateTxt.Name = "bitrateTxt";
            this.bitrateTxt.Size = new System.Drawing.Size(100, 23);
            this.bitrateTxt.TabIndex = 26;
            this.bitrateTxt.Text = "7.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Target Size (MB)";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitrateTxt);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.outputNameLbl);
            this.Controls.Add(this.endSLbl);
            this.Controls.Add(this.endMLbl);
            this.Controls.Add(this.endM);
            this.Controls.Add(this.endHLbl);
            this.Controls.Add(this.endS);
            this.Controls.Add(this.endH);
            this.Controls.Add(this.endLbl);
            this.Controls.Add(this.startSLbl);
            this.Controls.Add(this.startMLbl);
            this.Controls.Add(this.startM);
            this.Controls.Add(this.startHLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.startS);
            this.Controls.Add(this.startH);
            this.Controls.Add(this.compressionCheck);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.fileNameLbl);
            this.Controls.Add(this.loadFileBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Video Cutter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.OpenFileDialog inputVideoFile;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.CheckBox compressionCheck;
        private System.Windows.Forms.TextBox startH;
        private System.Windows.Forms.TextBox startS;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.SaveFileDialog outputFileDialog;
        private System.Windows.Forms.Label startHLbl;
        private System.Windows.Forms.TextBox startM;
        private System.Windows.Forms.Label startMLbl;
        private System.Windows.Forms.Label startSLbl;
        private System.Windows.Forms.Label endLbl;
        private System.Windows.Forms.Label endSLbl;
        private System.Windows.Forms.Label endMLbl;
        private System.Windows.Forms.TextBox endM;
        private System.Windows.Forms.Label endHLbl;
        private System.Windows.Forms.TextBox endS;
        private System.Windows.Forms.TextBox endH;
        private System.Windows.Forms.Label outputNameLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TextBox bitrateTxt;
        private System.Windows.Forms.Label label1;
    }
}

