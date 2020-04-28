namespace Timer.Entities
{
    class ContagemTimer
    {
        PlaySom playSom = new PlaySom();

        public Form1 Relogio { get; set; }
        public string Musica { get; set; }
        public ContagemTimer(Form1 form)
        {
            this.Relogio = form;
        }

        public ContagemTimer(Form1 form,string musica)
        {
            this.Relogio = form;
            this.Musica = musica;
        }

        public void TimerAtivo()
        {
            string tempoAtual = Relogio.relogio.Text;
            string hora = tempoAtual.Substring(0, 2);
            string minuto = tempoAtual.Substring(3, 2);
            string segundo = tempoAtual.Substring(6, 2);

            if (int.Parse(segundo) > 0 || int.Parse(minuto) > 0 || int.Parse(hora) > 0)
            {
                segundo = (int.Parse(segundo) - 1).ToString();
                if (int.Parse(segundo) <= 0)
                {
                    if (int.Parse(minuto) >= 1)
                    {
                        segundo = "59";
                        minuto = (int.Parse(minuto) - 1).ToString();
                    }
                }
                if (int.Parse(minuto) == 0 && int.Parse(hora) > 0)
                {
                    hora = (int.Parse(hora) - 1).ToString();
                    minuto = "59";
                    segundo = "59";
                }
                if (hora.Length < 2)
                    hora = "0" + hora;
                if (minuto.Length < 2)
                    minuto = "0" + minuto;
                if (segundo.Length < 2)
                    segundo = "0" + segundo;
                Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
            }
            if (Relogio.relogio.Text == "00:00:00")
            {
                Relogio.timer1.Enabled = false;
                if(Musica != string.Empty)
                playSom.IniciarMusica(Musica);
            }
        }

    }
}
