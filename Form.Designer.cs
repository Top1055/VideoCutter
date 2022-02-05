
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
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.openVideoFile = new System.Windows.Forms.OpenFileDialog();
            this.fileName = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.compressionCheck = new System.Windows.Forms.CheckBox();
            this.startH = new System.Windows.Forms.TextBox();
            this.startS = new System.Windows.Forms.TextBox();
            this.startLbl = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // openVideoFile
            // 
            this.openVideoFile.DefaultExt = "mp4";
            this.openVideoFile.FileName = "openVideoFile";
            this.openVideoFile.RestoreDirectory = true;
            this.openVideoFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openVideoFile_FileOk);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(93, 16);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(87, 15);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "PLACEHOLDER";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(7, 165);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(334, 41);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "Save to...";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // compressionCheck
            // 
            this.compressionCheck.AutoSize = true;
            this.compressionCheck.Location = new System.Drawing.Point(12, 140);
            this.compressionCheck.Name = "compressionCheck";
            this.compressionCheck.Size = new System.Drawing.Size(96, 19);
            this.compressionCheck.TabIndex = 4;
            this.compressionCheck.Text = "Compression";
            this.compressionCheck.UseVisualStyleBackColor = true;
            // 
            // startH
            // 
            this.startH.Location = new System.Drawing.Point(7, 96);
            this.startH.Name = "startH";
            this.startH.Size = new System.Drawing.Size(45, 23);
            this.startH.TabIndex = 5;
            this.startH.Text = "00";
            // 
            // startS
            // 
            this.startS.Location = new System.Drawing.Point(109, 96);
            this.startS.Name = "startS";
            this.startS.Size = new System.Drawing.Size(45, 23);
            this.startS.TabIndex = 6;
            this.startS.Text = "00.00";
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startLbl.Location = new System.Drawing.Point(7, 50);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(45, 21);
            this.startLbl.TabIndex = 7;
            this.startLbl.Text = "Start:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "mp4";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // startHLbl
            // 
            this.startHLbl.AutoSize = true;
            this.startHLbl.Location = new System.Drawing.Point(7, 78);
            this.startHLbl.Name = "startHLbl";
            this.startHLbl.Size = new System.Drawing.Size(39, 15);
            this.startHLbl.TabIndex = 8;
            this.startHLbl.Text = "Hours";
            // 
            // startM
            // 
            this.startM.Location = new System.Drawing.Point(58, 96);
            this.startM.Name = "startM";
            this.startM.Size = new System.Drawing.Size(45, 23);
            this.startM.TabIndex = 9;
            this.startM.Text = "00";
            // 
            // startMLbl
            // 
            this.startMLbl.AutoSize = true;
            this.startMLbl.Location = new System.Drawing.Point(58, 78);
            this.startMLbl.Name = "startMLbl";
            this.startMLbl.Size = new System.Drawing.Size(50, 15);
            this.startMLbl.TabIndex = 10;
            this.startMLbl.Text = "Minutes";
            // 
            // startSLbl
            // 
            this.startSLbl.AutoSize = true;
            this.startSLbl.Location = new System.Drawing.Point(109, 78);
            this.startSLbl.Name = "startSLbl";
            this.startSLbl.Size = new System.Drawing.Size(51, 15);
            this.startSLbl.TabIndex = 11;
            this.startSLbl.Text = "Seconds";
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endLbl.Location = new System.Drawing.Point(188, 50);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(36, 21);
            this.endLbl.TabIndex = 12;
            this.endLbl.Text = "End";
            // 
            // endSLbl
            // 
            this.endSLbl.AutoSize = true;
            this.endSLbl.Location = new System.Drawing.Point(290, 78);
            this.endSLbl.Name = "endSLbl";
            this.endSLbl.Size = new System.Drawing.Size(51, 15);
            this.endSLbl.TabIndex = 18;
            this.endSLbl.Text = "Seconds";
            // 
            // endMLbl
            // 
            this.endMLbl.AutoSize = true;
            this.endMLbl.Location = new System.Drawing.Point(239, 78);
            this.endMLbl.Name = "endMLbl";
            this.endMLbl.Size = new System.Drawing.Size(50, 15);
            this.endMLbl.TabIndex = 17;
            this.endMLbl.Text = "Minutes";
            // 
            // endM
            // 
            this.endM.Location = new System.Drawing.Point(239, 96);
            this.endM.Name = "endM";
            this.endM.Size = new System.Drawing.Size(45, 23);
            this.endM.TabIndex = 16;
            this.endM.Text = "00";
            // 
            // endHLbl
            // 
            this.endHLbl.AutoSize = true;
            this.endHLbl.Location = new System.Drawing.Point(188, 78);
            this.endHLbl.Name = "endHLbl";
            this.endHLbl.Size = new System.Drawing.Size(39, 15);
            this.endHLbl.TabIndex = 15;
            this.endHLbl.Text = "Hours";
            // 
            // endS
            // 
            this.endS.Location = new System.Drawing.Point(290, 96);
            this.endS.Name = "endS";
            this.endS.Size = new System.Drawing.Size(45, 23);
            this.endS.TabIndex = 14;
            this.endS.Text = "00.00";
            // 
            // endH
            // 
            this.endH.Location = new System.Drawing.Point(188, 96);
            this.endH.Name = "endH";
            this.endH.Size = new System.Drawing.Size(45, 23);
            this.endH.TabIndex = 13;
            this.endH.Text = "00";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "bitrate";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.loadFileBtn);
            this.Name = "Form";
            this.Text = "Video Cutter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.OpenFileDialog openVideoFile;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.CheckBox compressionCheck;
        private System.Windows.Forms.TextBox startH;
        private System.Windows.Forms.TextBox startS;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

