using System.Media;

namespace FiladeEspera
{
    public class PlaySound
    {

        public static void OnePing()
        {
            SystemSounds.Beep.Play();
            SystemSounds.Beep.Play();
        }

        public static void TwoPing()
        {
            SystemSounds.Exclamation.Play();
        }
    }
}
