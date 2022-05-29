namespace Video_Cutter
{
    partial class VidoCutter
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
            this.load_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.video_fps = new System.Windows.Forms.TextBox();
            this.start_time = new System.Windows.Forms.TextBox();
            this.end_time = new System.Windows.Forms.TextBox();
            this.change_fps = new System.Windows.Forms.CheckBox();
            this.load_file = new System.Windows.Forms.OpenFileDialog();
            this.save_file = new System.Windows.Forms.SaveFileDialog();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.outputNameLbl = new System.Windows.Forms.Label();
            this.start_lbl = new System.Windows.Forms.Label();
            this.end_lbl = new System.Windows.Forms.Label();
            this.time_box = new System.Windows.Forms.GroupBox();
            this.file_box = new System.Windows.Forms.GroupBox();
            this.setting_box = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.audio_size = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.video_height = new System.Windows.Forms.TextBox();
            this.video_width = new System.Windows.Forms.TextBox();
            this.video_size = new System.Windows.Forms.TextBox();
            this.no_audio = new System.Windows.Forms.CheckBox();
            this.audio_checked = new System.Windows.Forms.CheckBox();
            this.res_checkbox = new System.Windows.Forms.CheckBox();
            this.compress_checked = new System.Windows.Forms.CheckBox();
            this.time_box.SuspendLayout();
            this.file_box.SuspendLayout();
            this.setting_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_btn
            // 
            this.load_btn.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Location = new System.Drawing.Point(11, 35);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 0;
            this.load_btn.Text = "Load File...";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(11, 64);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Save To...";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Enabled = false;
            this.start_btn.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(12, 237);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(113, 44);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // video_fps
            // 
            this.video_fps.Enabled = false;
            this.video_fps.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_fps.Location = new System.Drawing.Point(12, 87);
            this.video_fps.Name = "video_fps";
            this.video_fps.Size = new System.Drawing.Size(100, 26);
            this.video_fps.TabIndex = 6;
            // 
            // start_time
            // 
            this.start_time.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_time.Location = new System.Drawing.Point(17, 71);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(204, 26);
            this.start_time.TabIndex = 1;
            this.start_time.Text = "00:00:00";
            // 
            // end_time
            // 
            this.end_time.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time.Location = new System.Drawing.Point(243, 71);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(204, 26);
            this.end_time.TabIndex = 2;
            this.end_time.Text = "00:00:00";
            // 
            // change_fps
            // 
            this.change_fps.AutoSize = true;
            this.change_fps.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_fps.Location = new System.Drawing.Point(118, 89);
            this.change_fps.Name = "change_fps";
            this.change_fps.Size = new System.Drawing.Size(188, 23);
            this.change_fps.TabIndex = 7;
            this.change_fps.Text = "Change framerate";
            this.change_fps.UseVisualStyleBackColor = true;
            this.change_fps.CheckedChanged += new System.EventHandler(this.change_fps_CheckedChanged);
            // 
            // load_file
            // 
            this.load_file.FileOk += new System.ComponentModel.CancelEventHandler(this.load_file_FileOk);
            // 
            // save_file
            // 
            this.save_file.FileOk += new System.ComponentModel.CancelEventHandler(this.save_file_FileOk);
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLbl.Location = new System.Drawing.Point(93, 40);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(95, 15);
            this.fileNameLbl.TabIndex = 7;
            this.fileNameLbl.Text = "fileNameLbl";
            // 
            // outputNameLbl
            // 
            this.outputNameLbl.AutoSize = true;
            this.outputNameLbl.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputNameLbl.Location = new System.Drawing.Point(93, 68);
            this.outputNameLbl.Name = "outputNameLbl";
            this.outputNameLbl.Size = new System.Drawing.Size(111, 15);
            this.outputNameLbl.TabIndex = 8;
            this.outputNameLbl.Text = "outputNameLbl";
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbl.Location = new System.Drawing.Point(239, 46);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(49, 19);
            this.start_lbl.TabIndex = 9;
            this.start_lbl.Text = "End:";
            // 
            // end_lbl
            // 
            this.end_lbl.AutoSize = true;
            this.end_lbl.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_lbl.Location = new System.Drawing.Point(17, 46);
            this.end_lbl.Name = "end_lbl";
            this.end_lbl.Size = new System.Drawing.Size(69, 19);
            this.end_lbl.TabIndex = 10;
            this.end_lbl.Text = "Start:";
            // 
            // time_box
            // 
            this.time_box.Controls.Add(this.start_time);
            this.time_box.Controls.Add(this.end_time);
            this.time_box.Controls.Add(this.end_lbl);
            this.time_box.Controls.Add(this.start_lbl);
            this.time_box.Enabled = false;
            this.time_box.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_box.Location = new System.Drawing.Point(12, 117);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(460, 114);
            this.time_box.TabIndex = 11;
            this.time_box.TabStop = false;
            this.time_box.Text = "Time";
            // 
            // file_box
            // 
            this.file_box.Controls.Add(this.load_btn);
            this.file_box.Controls.Add(this.save_btn);
            this.file_box.Controls.Add(this.outputNameLbl);
            this.file_box.Controls.Add(this.fileNameLbl);
            this.file_box.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_box.Location = new System.Drawing.Point(12, 12);
            this.file_box.Name = "file_box";
            this.file_box.Size = new System.Drawing.Size(460, 99);
            this.file_box.TabIndex = 12;
            this.file_box.TabStop = false;
            this.file_box.Text = "File";
            // 
            // setting_box
            // 
            this.setting_box.Controls.Add(this.label4);
            this.setting_box.Controls.Add(this.audio_size);
            this.setting_box.Controls.Add(this.label3);
            this.setting_box.Controls.Add(this.label2);
            this.setting_box.Controls.Add(this.label1);
            this.setting_box.Controls.Add(this.video_height);
            this.setting_box.Controls.Add(this.video_width);
            this.setting_box.Controls.Add(this.video_size);
            this.setting_box.Controls.Add(this.video_fps);
            this.setting_box.Controls.Add(this.no_audio);
            this.setting_box.Controls.Add(this.audio_checked);
            this.setting_box.Controls.Add(this.res_checkbox);
            this.setting_box.Controls.Add(this.compress_checked);
            this.setting_box.Controls.Add(this.change_fps);
            this.setting_box.Enabled = false;
            this.setting_box.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_box.Location = new System.Drawing.Point(478, 14);
            this.setting_box.Name = "setting_box";
            this.setting_box.Size = new System.Drawing.Size(450, 267);
            this.setting_box.TabIndex = 13;
            this.setting_box.TabStop = false;
            this.setting_box.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Video size (MB):";
            // 
            // audio_size
            // 
            this.audio_size.Enabled = false;
            this.audio_size.FormattingEnabled = true;
            this.audio_size.Items.AddRange(new object[] {
            "128k",
            "86k",
            "64k",
            "32k",
            "16k",
            "8k",
            "4k",
            "2k",
            "10"});
            this.audio_size.Location = new System.Drawing.Point(12, 190);
            this.audio_size.Name = "audio_size";
            this.audio_size.Size = new System.Drawing.Size(121, 27);
            this.audio_size.TabIndex = 10;
            this.audio_size.Text = "Select...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // video_height
            // 
            this.video_height.Enabled = false;
            this.video_height.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_height.Location = new System.Drawing.Point(136, 55);
            this.video_height.Name = "video_height";
            this.video_height.Size = new System.Drawing.Size(100, 26);
            this.video_height.TabIndex = 4;
            // 
            // video_width
            // 
            this.video_width.Enabled = false;
            this.video_width.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_width.Location = new System.Drawing.Point(12, 55);
            this.video_width.Name = "video_width";
            this.video_width.Size = new System.Drawing.Size(100, 26);
            this.video_width.TabIndex = 3;
            // 
            // video_size
            // 
            this.video_size.Enabled = false;
            this.video_size.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_size.Location = new System.Drawing.Point(12, 159);
            this.video_size.Name = "video_size";
            this.video_size.Size = new System.Drawing.Size(100, 26);
            this.video_size.TabIndex = 8;
            // 
            // no_audio
            // 
            this.no_audio.AutoSize = true;
            this.no_audio.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_audio.Location = new System.Drawing.Point(12, 223);
            this.no_audio.Name = "no_audio";
            this.no_audio.Size = new System.Drawing.Size(108, 23);
            this.no_audio.TabIndex = 12;
            this.no_audio.Text = "No audio";
            this.no_audio.UseVisualStyleBackColor = true;
            this.no_audio.CheckedChanged += new System.EventHandler(this.no_audio_CheckedChanged);
            // 
            // audio_checked
            // 
            this.audio_checked.AutoSize = true;
            this.audio_checked.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audio_checked.Location = new System.Drawing.Point(139, 192);
            this.audio_checked.Name = "audio_checked";
            this.audio_checked.Size = new System.Drawing.Size(168, 23);
            this.audio_checked.TabIndex = 11;
            this.audio_checked.Text = "Compress audio";
            this.audio_checked.UseVisualStyleBackColor = true;
            this.audio_checked.CheckedChanged += new System.EventHandler(this.audio_checked_CheckedChanged);
            // 
            // res_checkbox
            // 
            this.res_checkbox.AutoSize = true;
            this.res_checkbox.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_checkbox.Location = new System.Drawing.Point(242, 57);
            this.res_checkbox.Name = "res_checkbox";
            this.res_checkbox.Size = new System.Drawing.Size(198, 23);
            this.res_checkbox.TabIndex = 5;
            this.res_checkbox.Text = "Change resolution";
            this.res_checkbox.UseVisualStyleBackColor = true;
            this.res_checkbox.CheckedChanged += new System.EventHandler(this.res_checkbox_CheckedChanged);
            // 
            // compress_checked
            // 
            this.compress_checked.AutoSize = true;
            this.compress_checked.Font = new System.Drawing.Font("DejaVu Sans Mono for Powerline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compress_checked.Location = new System.Drawing.Point(118, 161);
            this.compress_checked.Name = "compress_checked";
            this.compress_checked.Size = new System.Drawing.Size(168, 23);
            this.compress_checked.TabIndex = 9;
            this.compress_checked.Text = "Compress video";
            this.compress_checked.UseVisualStyleBackColor = true;
            this.compress_checked.CheckedChanged += new System.EventHandler(this.compress_checked_CheckedChanged);
            // 
            // VidoCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 293);
            this.Controls.Add(this.setting_box);
            this.Controls.Add(this.file_box);
            this.Controls.Add(this.time_box);
            this.Controls.Add(this.start_btn);
            this.Name = "VidoCutter";
            this.Text = "Video Cutter";
            this.time_box.ResumeLayout(false);
            this.time_box.PerformLayout();
            this.file_box.ResumeLayout(false);
            this.file_box.PerformLayout();
            this.setting_box.ResumeLayout(false);
            this.setting_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox video_fps;
        private System.Windows.Forms.TextBox start_time;
        private System.Windows.Forms.TextBox end_time;
        private System.Windows.Forms.CheckBox change_fps;
        private System.Windows.Forms.OpenFileDialog load_file;
        private System.Windows.Forms.SaveFileDialog save_file;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Label outputNameLbl;
        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Label end_lbl;
        private System.Windows.Forms.GroupBox time_box;
        private System.Windows.Forms.GroupBox file_box;
        private System.Windows.Forms.GroupBox setting_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox audio_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox video_height;
        private System.Windows.Forms.TextBox video_width;
        private System.Windows.Forms.TextBox video_size;
        private System.Windows.Forms.CheckBox no_audio;
        private System.Windows.Forms.CheckBox audio_checked;
        private System.Windows.Forms.CheckBox res_checkbox;
        private System.Windows.Forms.CheckBox compress_checked;
    }
}

