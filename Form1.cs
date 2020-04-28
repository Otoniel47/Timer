using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Timer.Entities;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDiminuirUmHora_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiHora(1);
        }

        private void BtnAcrecentarDezHora_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarHora(10);
        }

        private void BtnAcrecentarCincoHora_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarHora(5);
        }

        private void Button7btnAcrecentarUmHora_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarHora(1);
        }

        private void BtnAcrecentarDezMinuto_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarMinuto(10);
        }

        private void BtnZerar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            relogio.Text = "00:00:00";
        }

        private void BtnAcrecentarCincoMinuto_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarMinuto(5);
        }

        private void Button7btnAcrecentarUmMinuto_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarMinuto(1);
        }

        private void BtnAcrecentarDezSegundos_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarSegundo(10);
        }

        private void BtnAcrecentarCincoSegundos_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarSegundo(5);
        }

        private void BtnAcrecentarUmSegundo_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.AcrecentarSegundo(1);
        }

        private void BtnDiminuirCincoHora_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiHora(5);
        }

        private void BtnDiminuirDezHora_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiHora(10);
        }

        private void BtnDiminuirUmMinuto_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiMinuto(1);
        }

        private void BtnDiminuirCincoMinuto_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiMinuto(5);
        }

        private void BtnDiminuirDezMinuto_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiMinuto(10);
        }

        private void BtnDiminuirUmSegundo_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiSegundo(1);
        }

        private void BtnDiminuirCincoSegundo_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiSegundo(5);
        }

        private void BtnDiminuirDezSegundo_Click(object sender, EventArgs e)
        {
            Contador contador = new Contador(this);
            contador.SubtraiSegundo(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Point MovendoCursor;
        Point MovendoFrom;
        bool Movendo;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Movendo = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Movendo = true;
            MovendoCursor = Cursor.Position;
            MovendoFrom = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Movendo == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(MovendoCursor));
                this.Location = Point.Add(MovendoFrom, new Size(dif));
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string musica = string.Empty;
            if (comboBox1.SelectedItem != null)
                musica = comboBox1.SelectedItem.ToString();
 
            ContagemTimer contagemTimer = new ContagemTimer(this, musica);
            contagemTimer.TimerAtivo();
        }

        PlaySom playSom = new PlaySom();
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            playSom.IniciarMusica(comboBox1.SelectedItem.ToString());
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                playSom.PausarMusica();
            }
            catch { }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
