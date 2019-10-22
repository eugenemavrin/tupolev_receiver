using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace Reciever
{
    public partial class Form1 : Form
    {
        private bool play_state = false;
        private int baudRate = 9600;
        private String PortName;
        private String debugText;
        private String musicLocation = "C:\\Users\\Евгений\\Desktop\\Kalimba.wav";
        private bool isPlaying = false;
        private System.Media.SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInitBluetooth_Click(object sender, EventArgs e)
        {
            try
            {
                baudRate = Int32.Parse(EditFrequency.Text);
                PortName = EditPort.Text;
            } catch (FormatException ex)
            {
                return;    
            }

            if (serialPort.IsOpen) serialPort.Close();

            serialPort.PortName = PortName;
            serialPort.BaudRate = baudRate;

            player = new System.Media.SoundPlayer();

            try
            {
                if (!serialPort.IsOpen) serialPort.Open();
                lblDebug.Text = "Соедениение по порту " + serialPort.PortName + " успешно установлено";
            } catch (Exception ex)
            {
                lblDebug.Text = ex.Message;
            }

            serialPort.DataReceived += new SerialDataReceivedEventHandler(BluetoothDataHandler);
        }

        private void BluetoothDataHandler(object sender, SerialDataReceivedEventArgs args)
        {
            SerialPort port = (SerialPort)sender;
            

            debugText = port.ReadLine();
            if (flagPlayStop.Checked)
            {
                if (debugText == "PLAY\r")
                {
                    Invoke(new EventHandler(StartPlayback));
                    play_state = true;
                    Invoke(new EventHandler(ChangeButtonName));
                }
                else if (debugText == "STOP\r")
                {
                    Invoke(new EventHandler(StopPlayback));
                    play_state = false;
                    Invoke(new EventHandler(ChangeButtonName));
                }
                //else 
            }
            else if (flagPlayUntilEnd.Checked)
            {
                if (debugText == "PLAY\r")
                {
                    Invoke(new EventHandler(StartPlayback));
                    play_state = true;
                    Invoke(new EventHandler(ChangeButtonName));
                    //else Invoke(new EventHandler(ChangeDebugLabel));
                }
            }
            else if (fladDoublePushing.Checked)
            {
                if (debugText == "PLAY\r")
                    if (play_state == false)
                    {
                        Invoke(new EventHandler(StartPlayback));
                        play_state = true;
                        Invoke(new EventHandler(ChangeButtonName));
                    }
                    else if (play_state == true)
                    {
                        Invoke(new EventHandler(StopPlayback));
                        play_state = false;
                        Invoke(new EventHandler(ChangeButtonName));
                    }
            }
        }
        private void ChangeButtonName(object sender, EventArgs e)
        {
            if (play_state == true)
            {
                PlayStop.Text = "Остановить";
            }
            else if (play_state == false)
            {
                PlayStop.Text = "Воспроизвести";
            }
        }

        private void ChangeDebugLabel(object sender, EventArgs e)
        {
            lblDebug.Text = debugText;
        }

        private void StopPlayback(object sender, EventArgs e)
        {
            player.Stop();
            isPlaying = false;
        }

        private void StartPlayback(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                //player.SoundLocation = "C:\\g.wav";
                player.SoundLocation = this.musicLocation;
                player.Play();
                isPlaying = true;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            dlgSelectTrack.ShowDialog();
        }

        private void dlgSelectTrack_FileOk(object sender, CancelEventArgs e)
        {
            edtFileName.Text = dlgSelectTrack.FileName;
            this.musicLocation = dlgSelectTrack.FileName;
        }

        private void PlayStop_Click(object sender, EventArgs e)
        {
            if (play_state == true)
            {
                Invoke(new EventHandler(StopPlayback));
                PlayStop.Text = "Воспроизвести";
                play_state = false;
            }
            else if (play_state == false)
            {
                Invoke(new EventHandler(StartPlayback));
                PlayStop.Text = "Остановить";
                play_state = true;
            }
        }
    }
}
