
namespace SistemaMonitoramento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.pictureBox_WebCam = new System.Windows.Forms.PictureBox();
            this.btn_TirarFoto = new System.Windows.Forms.Button();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox_WebCam2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox_WebCam3 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btn_Parar2 = new System.Windows.Forms.Button();
            this.btn_TirarFoto2 = new System.Windows.Forms.Button();
            this.btn_Iniciar2 = new System.Windows.Forms.Button();
            this.btn_Parar3 = new System.Windows.Forms.Button();
            this.btn_TirarFoto3 = new System.Windows.Forms.Button();
            this.btn_Iniciar3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebCam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebCam3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.Location = new System.Drawing.Point(14, 395);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(136, 32);
            this.btn_Iniciar.TabIndex = 0;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // pictureBox_WebCam
            // 
            this.pictureBox_WebCam.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox_WebCam.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_WebCam.Image")));
            this.pictureBox_WebCam.Location = new System.Drawing.Point(13, 80);
            this.pictureBox_WebCam.Name = "pictureBox_WebCam";
            this.pictureBox_WebCam.Size = new System.Drawing.Size(302, 279);
            this.pictureBox_WebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_WebCam.TabIndex = 1;
            this.pictureBox_WebCam.TabStop = false;
            // 
            // btn_TirarFoto
            // 
            this.btn_TirarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TirarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TirarFoto.Location = new System.Drawing.Point(96, 433);
            this.btn_TirarFoto.Name = "btn_TirarFoto";
            this.btn_TirarFoto.Size = new System.Drawing.Size(136, 32);
            this.btn_TirarFoto.TabIndex = 2;
            this.btn_TirarFoto.Text = "Tirar Foto";
            this.btn_TirarFoto.UseVisualStyleBackColor = true;
            this.btn_TirarFoto.Click += new System.EventHandler(this.btn_TirarFoto_Click);
            // 
            // btn_Parar
            // 
            this.btn_Parar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Parar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Parar.Location = new System.Drawing.Point(179, 395);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(136, 32);
            this.btn_Parar.TabIndex = 3;
            this.btn_Parar.Text = "Parar";
            this.btn_Parar.UseVisualStyleBackColor = true;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "imagem.jpg";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // pictureBox_WebCam2
            // 
            this.pictureBox_WebCam2.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox_WebCam2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_WebCam2.Image")));
            this.pictureBox_WebCam2.Location = new System.Drawing.Point(321, 80);
            this.pictureBox_WebCam2.Name = "pictureBox_WebCam2";
            this.pictureBox_WebCam2.Size = new System.Drawing.Size(302, 279);
            this.pictureBox_WebCam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_WebCam2.TabIndex = 5;
            this.pictureBox_WebCam2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(321, 365);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(301, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // pictureBox_WebCam3
            // 
            this.pictureBox_WebCam3.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox_WebCam3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_WebCam3.Image")));
            this.pictureBox_WebCam3.Location = new System.Drawing.Point(628, 80);
            this.pictureBox_WebCam3.Name = "pictureBox_WebCam3";
            this.pictureBox_WebCam3.Size = new System.Drawing.Size(302, 279);
            this.pictureBox_WebCam3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_WebCam3.TabIndex = 7;
            this.pictureBox_WebCam3.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(629, 365);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(301, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // btn_Parar2
            // 
            this.btn_Parar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Parar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Parar2.Location = new System.Drawing.Point(486, 395);
            this.btn_Parar2.Name = "btn_Parar2";
            this.btn_Parar2.Size = new System.Drawing.Size(136, 32);
            this.btn_Parar2.TabIndex = 11;
            this.btn_Parar2.Text = "Parar";
            this.btn_Parar2.UseVisualStyleBackColor = true;
            this.btn_Parar2.Click += new System.EventHandler(this.btn_Parar2_Click);
            // 
            // btn_TirarFoto2
            // 
            this.btn_TirarFoto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TirarFoto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TirarFoto2.Location = new System.Drawing.Point(407, 433);
            this.btn_TirarFoto2.Name = "btn_TirarFoto2";
            this.btn_TirarFoto2.Size = new System.Drawing.Size(136, 32);
            this.btn_TirarFoto2.TabIndex = 10;
            this.btn_TirarFoto2.Text = "Tirar Foto";
            this.btn_TirarFoto2.UseVisualStyleBackColor = true;
            this.btn_TirarFoto2.Click += new System.EventHandler(this.btn_TirarFoto2_Click);
            // 
            // btn_Iniciar2
            // 
            this.btn_Iniciar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Iniciar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar2.Location = new System.Drawing.Point(321, 395);
            this.btn_Iniciar2.Name = "btn_Iniciar2";
            this.btn_Iniciar2.Size = new System.Drawing.Size(136, 32);
            this.btn_Iniciar2.TabIndex = 9;
            this.btn_Iniciar2.Text = "Iniciar";
            this.btn_Iniciar2.UseVisualStyleBackColor = true;
            this.btn_Iniciar2.Click += new System.EventHandler(this.btn_Iniciar2_Click);
            // 
            // btn_Parar3
            // 
            this.btn_Parar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Parar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Parar3.Location = new System.Drawing.Point(794, 395);
            this.btn_Parar3.Name = "btn_Parar3";
            this.btn_Parar3.Size = new System.Drawing.Size(136, 32);
            this.btn_Parar3.TabIndex = 14;
            this.btn_Parar3.Text = "Parar";
            this.btn_Parar3.UseVisualStyleBackColor = true;
            this.btn_Parar3.Click += new System.EventHandler(this.btn_Parar3_Click);
            // 
            // btn_TirarFoto3
            // 
            this.btn_TirarFoto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TirarFoto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TirarFoto3.Location = new System.Drawing.Point(713, 433);
            this.btn_TirarFoto3.Name = "btn_TirarFoto3";
            this.btn_TirarFoto3.Size = new System.Drawing.Size(136, 32);
            this.btn_TirarFoto3.TabIndex = 13;
            this.btn_TirarFoto3.Text = "Tirar Foto";
            this.btn_TirarFoto3.UseVisualStyleBackColor = true;
            this.btn_TirarFoto3.Click += new System.EventHandler(this.btn_TirarFoto3_Click);
            // 
            // btn_Iniciar3
            // 
            this.btn_Iniciar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Iniciar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar3.Location = new System.Drawing.Point(629, 395);
            this.btn_Iniciar3.Name = "btn_Iniciar3";
            this.btn_Iniciar3.Size = new System.Drawing.Size(136, 32);
            this.btn_Iniciar3.TabIndex = 12;
            this.btn_Iniciar3.Text = "Iniciar";
            this.btn_Iniciar3.UseVisualStyleBackColor = true;
            this.btn_Iniciar3.Click += new System.EventHandler(this.btn_Iniciar3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sistema de monitoramento simples";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(794, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "Encerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Status:";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(72, 533);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(138, 17);
            this.lb_status.TabIndex = 18;
            this.lb_status.Text = "Cameras Desligadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(946, 563);
            this.ControlBox = false;
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Parar3);
            this.Controls.Add(this.btn_TirarFoto3);
            this.Controls.Add(this.btn_Iniciar3);
            this.Controls.Add(this.btn_Parar2);
            this.Controls.Add(this.btn_TirarFoto2);
            this.Controls.Add(this.btn_Iniciar2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.pictureBox_WebCam3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox_WebCam2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.btn_TirarFoto);
            this.Controls.Add(this.pictureBox_WebCam);
            this.Controls.Add(this.btn_Iniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(964, 610);
            this.MinimumSize = new System.Drawing.Size(964, 610);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sistema Monitoramento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebCam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebCam3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.PictureBox pictureBox_WebCam;
        private System.Windows.Forms.Button btn_TirarFoto;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox_WebCam2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox_WebCam3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btn_Parar2;
        private System.Windows.Forms.Button btn_TirarFoto2;
        private System.Windows.Forms.Button btn_Iniciar2;
        private System.Windows.Forms.Button btn_Parar3;
        private System.Windows.Forms.Button btn_TirarFoto3;
        private System.Windows.Forms.Button btn_Iniciar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_status;
    }
}

