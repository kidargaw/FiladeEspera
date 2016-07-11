using System.Speech.Synthesis;
namespace FiladeEspera
{
    public class Voice
    {

        public static void HelloVoice(string number)
        {

            //CultureInfo ci = new CultureInfo("pt-PT");
            //System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            //System.Threading.Thread.CurrentThread.CurrentUICulture = ci;




            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            //synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);  

            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10  



            synthesizer.SpeakAsync("client number " + number);


        }
    }
}
