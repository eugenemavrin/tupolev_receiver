namespace Reciever
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnInitBluetooth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditFrequency = new System.Windows.Forms.TextBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dlgSelectTrack = new System.Windows.Forms.OpenFileDialog();
            this.edtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.panelPlayControl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.fladDoublePushing = new System.Windows.Forms.RadioButton();
            this.flagPlayStop = new System.Windows.Forms.RadioButton();
            this.flagPlayUntilEnd = new System.Windows.Forms.RadioButton();
            this.PlayStop = new System.Windows.Forms.Button();
            this.panelPlayControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInitBluetooth
            // 
            this.BtnInitBluetooth.Location = new System.Drawing.Point(230, 6);
            this.BtnInitBluetooth.Name = "BtnInitBluetooth";
            this.BtnInitBluetooth.Size = new System.Drawing.Size(158, 48);
            this.BtnInitBluetooth.TabIndex = 0;
            this.BtnInitBluetooth.Text = "Инициализировать прием";
            this.BtnInitBluetooth.UseVisualStyleBackColor = true;
            this.BtnInitBluetooth.Click += new System.EventHandler(this.BtnInitBluetooth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя порта";
            // 
            // EditPort
            // 
            this.EditPort.Location = new System.Drawing.Point(88, 6);
            this.EditPort.Name = "EditPort";
            this.EditPort.Size = new System.Drawing.Size(123, 20);
            this.EditPort.TabIndex = 2;
            this.EditPort.Text = "COM4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Частота";
            // 
            // EditFrequency
            // 
            this.EditFrequency.Location = new System.Drawing.Point(88, 34);
            this.EditFrequency.Name = "EditFrequency";
            this.EditFrequency.Size = new System.Drawing.Size(123, 20);
            this.EditFrequency.TabIndex = 2;
            this.EditFrequency.Text = "9600";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(26, 72);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(0, 13);
            this.lblDebug.TabIndex = 3;
            // 
            // dlgSelectTrack
            // 
            this.dlgSelectTrack.Filter = "Music Files (*.MP3;*.WAV)|*.*";
            this.dlgSelectTrack.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSelectTrack_FileOk);
            // 
            // edtFileName
            // 
            this.edtFileName.Location = new System.Drawing.Point(57, 131);
            this.edtFileName.Name = "edtFileName";
            this.edtFileName.Size = new System.Drawing.Size(256, 20);
            this.edtFileName.TabIndex = 4;
            this.edtFileName.Text = "C:\\Users\\Евгений\\Desktop\\Kalimba.wav";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Файл:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(319, 128);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(69, 23);
            this.btnChooseFile.TabIndex = 6;
            this.btnChooseFile.Text = "Выбор";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // panelPlayControl
            // 
            this.panelPlayControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayControl.Controls.Add(this.label4);
            this.panelPlayControl.Controls.Add(this.fladDoublePushing);
            this.panelPlayControl.Controls.Add(this.flagPlayStop);
            this.panelPlayControl.Controls.Add(this.flagPlayUntilEnd);
            this.panelPlayControl.Location = new System.Drawing.Point(15, 173);
            this.panelPlayControl.Name = "panelPlayControl";
            this.panelPlayControl.Size = new System.Drawing.Size(373, 141);
            this.panelPlayControl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Режимы работы:";
            // 
            // fladDoublePushing
            // 
            this.fladDoublePushing.AutoSize = true;
            this.fladDoublePushing.Checked = true;
            this.fladDoublePushing.Location = new System.Drawing.Point(26, 46);
            this.fladDoublePushing.Name = "fladDoublePushing";
            this.fladDoublePushing.Size = new System.Drawing.Size(325, 17);
            this.fladDoublePushing.TabIndex = 2;
            this.fladDoublePushing.TabStop = true;
            this.fladDoublePushing.Text = "Управление воспроизведением файла по нажатию кнопки";
            this.fladDoublePushing.UseVisualStyleBackColor = true;
            // 
            // flagPlayStop
            // 
            this.flagPlayStop.AutoSize = true;
            this.flagPlayStop.Location = new System.Drawing.Point(26, 92);
            this.flagPlayStop.Name = "flagPlayStop";
            this.flagPlayStop.Size = new System.Drawing.Size(265, 17);
            this.flagPlayStop.TabIndex = 1;
            this.flagPlayStop.Text = "Воспроизведение файла по удержанию кнопки";
            this.flagPlayStop.UseVisualStyleBackColor = true;
            // 
            // flagPlayUntilEnd
            // 
            this.flagPlayUntilEnd.AutoSize = true;
            this.flagPlayUntilEnd.Location = new System.Drawing.Point(26, 69);
            this.flagPlayUntilEnd.Name = "flagPlayUntilEnd";
            this.flagPlayUntilEnd.Size = new System.Drawing.Size(183, 17);
            this.flagPlayUntilEnd.TabIndex = 0;
            this.flagPlayUntilEnd.Text = "Проигрывание файла до конца";
            this.flagPlayUntilEnd.UseVisualStyleBackColor = true;
            // 
            // PlayStop
            // 
            this.PlayStop.Location = new System.Drawing.Point(110, 320);
            this.PlayStop.Name = "PlayStop";
            this.PlayStop.Size = new System.Drawing.Size(158, 48);
            this.PlayStop.TabIndex = 8;
            this.PlayStop.Text = "Управление воспроизведением";
            this.PlayStop.UseVisualStyleBackColor = true;
            this.PlayStop.Click += new System.EventHandler(this.PlayStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 466);
            this.Controls.Add(this.PlayStop);
            this.Controls.Add(this.panelPlayControl);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtFileName);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.EditFrequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnInitBluetooth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Remote Music Player (Mavrin-Tupolev)";
            this.panelPlayControl.ResumeLayout(false);
            this.panelPlayControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInitBluetooth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditFrequency;
        private System.Windows.Forms.Label lblDebug;
        private System.IO.Ports.SerialPort serialPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog dlgSelectTrack;
        private System.Windows.Forms.TextBox edtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Panel panelPlayControl;
        private System.Windows.Forms.RadioButton flagPlayStop;
        private System.Windows.Forms.RadioButton flagPlayUntilEnd;
        private System.Windows.Forms.RadioButton fladDoublePushing;
        private System.Windows.Forms.Button PlayStop;
        private System.Windows.Forms.Label label4;
    }
}

