using System.Media;

namespace Timer.Entities
{
    class PlaySom
    {
        SoundPlayer player;
        string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "Som\\";

        public void IniciarMusica(string nomeMusica)
        {
            player = new SoundPlayer(path + nomeMusica + ".wav");
            player.Play();
        }

        public void PausarMusica()
        {
            player.Stop();
        }
    }
}
