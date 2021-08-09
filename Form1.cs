using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading;

namespace SistemaMonitoramento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection dispositivo;
        private VideoCaptureDevice imagem;
        private VideoCaptureDevice imagem2;
        private VideoCaptureDevice imagem3;

        private void Form1_Load(object sender, EventArgs e)
        {
            dispositivo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo capturar in dispositivo)
            {
                comboBox1.Items.Add(capturar.Name);
                comboBox2.Items.Add(capturar.Name);
                comboBox3.Items.Add(capturar.Name);
            }
            btn_Parar.Enabled = false;
            btn_Parar2.Enabled = false;
            btn_Parar3.Enabled = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 2;
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            imagem = new VideoCaptureDevice(dispositivo[comboBox1.SelectedIndex].MonikerString);
            imagem.NewFrame += new NewFrameEventHandler(camera);
            imagem.Start();
            lb_status.ForeColor = Color.Green;
            lb_status.Text = $"Camera 1 ligada";
            comboBox1.Enabled = false;
            btn_Parar.Enabled = true;
            btn_Iniciar.Enabled = false;
            button1.Enabled = false;
            btn_Iniciar.Text = "Gravando";
        }

        void camera(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_WebCam.Image = bit;

        }

        private void btn_TirarFoto_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"d:\picture";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox_WebCam.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            if (imagem.IsRunning)
            {
                imagem.Stop();
                lb_status.ForeColor = Color.Red;
                lb_status.Text = "Cameras Desligadas";
                comboBox1.Enabled = true;
                imagem = default;
                btn_Parar.Enabled = false;
                btn_Iniciar.Enabled = true;
                button1.Enabled = true;
                btn_Iniciar.Text = "Iniciar";
            }
        }

        private void btn_Iniciar2_Click(object sender, EventArgs e)
        {
            imagem2 = new VideoCaptureDevice(dispositivo[comboBox2.SelectedIndex].MonikerString);
            imagem2.NewFrame += new NewFrameEventHandler(camera2);
            imagem2.Start();
            lb_status.ForeColor = Color.Green;
            lb_status.Text = $"Camera 2 ligada";
            comboBox2.Enabled = false;
            btn_Parar2.Enabled = true;
            btn_Iniciar2.Enabled = false;
            button1.Enabled = false;
            btn_Iniciar2.Text = "Gravando";
        }

        void camera2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_WebCam2.Image = bit;

        }

        private void btn_TirarFoto2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"d:\picture";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox_WebCam2.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btn_Parar2_Click(object sender, EventArgs e)
        {
            if (imagem2.IsRunning)
            {
                imagem2.Stop();
                lb_status.ForeColor = Color.Red;
                lb_status.Text = "Cameras Desligadas";
                comboBox2.Enabled = true;
                imagem2 = default;
                btn_Parar2.Enabled = false;
                btn_Iniciar2.Enabled = true;
                button1.Enabled = true;
                btn_Iniciar2.Text = "Iniciar";
            }
        }

        private void btn_Iniciar3_Click(object sender, EventArgs e)
        {
            imagem3 = new VideoCaptureDevice(dispositivo[comboBox3.SelectedIndex].MonikerString);
            imagem3.NewFrame += new NewFrameEventHandler(camera3);
            imagem3.Start();
            lb_status.ForeColor = Color.Green;
            lb_status.Text = $"Camera 3 ligada";
            comboBox3.Enabled = false;
            btn_Parar3.Enabled = true;
            btn_Iniciar3.Enabled = false;
            button1.Enabled = false;
            btn_Iniciar3.Text = "Gravando";
        }

        void camera3(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_WebCam3.Image = bit;

        }

        private void btn_TirarFoto3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"d:\picture";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox_WebCam3.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btn_Parar3_Click(object sender, EventArgs e)
        {
            if (imagem3.IsRunning)
            {
                imagem3.Stop();
                lb_status.ForeColor = Color.Red;
                lb_status.Text = "Cameras Desligadas";
                comboBox3.Enabled = true;
                imagem3 = default;
                btn_Parar3.Enabled = false;
                btn_Iniciar3.Enabled = true;
                button1.Enabled = true;
                btn_Iniciar3.Text = "Iniciar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
