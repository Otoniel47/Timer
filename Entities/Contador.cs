using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer.Entities
{
    class Contador
    {
        public Form1 Relogio { get; set; }
        public Contador(Form1 form)
        {
            this.Relogio = form;
        }

        public void AcrecentarHora(int quantidade)
        {
            string tempoAtual = Relogio.relogio.Text;
            string hora = tempoAtual.Substring(0, 2);
            string minuto = tempoAtual.Substring(3, 2);
            string segundo = tempoAtual.Substring(6, 2);

            if (int.Parse(hora) < 60)
            {
                if (int.Parse(hora) + quantidade >= 60)
                {
                    hora = "60";
                    Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
                }
                else
                {
                    hora = (int.Parse(hora) + quantidade).ToString();
                    if (hora.Length < 2)
                        hora = "0" + hora;
                    Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
                }
            }
        }

        public void AcrecentarMinuto(int quantidade)
        {
            string tempoAtual = Relogio.relogio.Text;
            string hora = tempoAtual.Substring(0, 2);
            string minuto = tempoAtual.Substring(3, 2);
            string segundo = tempoAtual.Substring(6, 2);

            if (int.Parse(minuto) < 60)
            {
                if (int.Parse(minuto) + quantidade >= 60)
                {
                    hora = (int.Parse(hora) + 1).ToString();
                    minuto = (int.Parse(minuto) + quantidade - 60).ToString();
                    if (int.Parse(hora) >= 60)
                    {
                        hora = "60";
                        minuto = "59";
                    }
                    if (minuto.Length < 2)
                        minuto = "0" + minuto;
                    if (hora.Length < 2)
                        hora = "0" + hora;
                    Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
                }
                else
                {
                    minuto = (int.Parse(minuto) + quantidade).ToString();
                    if (minuto.Length < 2)
                        minuto = "0" + minuto;
                    Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
                }
            }
        }

        public void AcrecentarSegundo(int quantidade)
        {
            string tempoAtual = Relogio.relogio.Text;
            string hora = tempoAtual.Substring(0, 2);
            string minuto = tempoAtual.Substring(3, 2);
            string segundo = tempoAtual.Substring(6, 2);

            if (int.Parse(segundo) < 60)
            {
                if (int.Parse(segundo) + quantidade >= 60)
                {
                    minuto = (int.Parse(minuto) + 1).ToString();
                    segundo = (int.Parse(segundo) + quantidade - 60).ToString();
                    if (int.Parse(minuto) >= 60)
                    {
                        if (int.Parse(hora) < 60)
                        {
                            hora = (int.Parse(hora) + 1).ToString();
                            if (hora.Length < 2)
                                hora = "0" + hora;
                            minuto = "00";
                        }
                        else
                        {
                            minuto = "59";
                            segundo = "59";
                        }
                    }
                    if (segundo.Length < 2)
                        segundo = "0" + segundo;
                    if (minuto.Length < 2)
                        minuto = "0" + minuto;
                    Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
                }
                else
                {
                    segundo = (int.Parse(segundo) + quantidade).ToString();
                    if (segundo.Length < 2)
                        segundo = "0" + segundo;
                    Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
                }
            }
        }

        public void SubtraiHora(int quantidade)
        {
            string tempoAtual = Relogio.relogio.Text;
            string hora = tempoAtual.Substring(0, 2);
            string minuto = tempoAtual.Substring(3, 2);
            string segundo = tempoAtual.Substring(6, 2);

            if (int.Parse(hora) > 0)
            {
                hora = (int.Parse(hora) - quantidade).ToString();
                if (hora.Length < 2)
                    hora = "0" + hora;
                if (int.Parse(hora) < 0)
                    hora = "00";
                Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
            }
        }

        public void SubtraiMinuto(int quantidade)
        {
            string tempoAtual = Relogio.relogio.Text;
            string hora = tempoAtual.Substring(0, 2);
            string minuto = tempoAtual.Substring(3, 2);
            string segundo = tempoAtual.Substring(6, 2);

            if (int.Parse(minuto) > 0)
            {
                minuto = (int.Parse(minuto) - quantidade).ToString();
                if (minuto.Length < 2)
                    minuto = "0" + minuto;
                if (int.Parse(minuto) < 0)
                    minuto = "00";
                Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
            }
        }

        public void SubtraiSegundo(int quantidade)
        {
            string tempoAtual = Relogio.relogio.Text;
            string hora = tempoAtual.Substring(0, 2);
            string minuto = tempoAtual.Substring(3, 2);
            string segundo = tempoAtual.Substring(6, 2);

            if (int.Parse(segundo) > 0)
            {
                segundo = (int.Parse(segundo) - quantidade).ToString();
                if (segundo.Length < 2)
                    segundo = "0" + segundo;
                if (int.Parse(segundo) < 0)
                    segundo = "00";
                Relogio.relogio.Text = hora + ":" + minuto + ":" + segundo;
            }
        }
    }
}
