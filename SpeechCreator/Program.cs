using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SpeechCreator
{
    class Program
    {

        static SpeechSynthesizer speaker = new SpeechSynthesizer();

        static void Main(string[] args)
        {

            string say = args[0];
            string volume = args[1];

            speaker.Volume = Convert.ToInt32(volume);
            speaker.Speak(say);

        }

    }
}
