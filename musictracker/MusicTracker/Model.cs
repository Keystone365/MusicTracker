using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker
{
    class Model
    {
        private static byte[] myWaveData;
        // Sample rate (Or number of samples in one second)
        private const int SAMPLE_FREQUENCY = 44100; //Default from tutorial is 44100
        // 60 seconds or 1 minute of audio
        private static float AudioLengthInSeconds = 5;
        // Defines amplitude for tone generator
        private int AMPLITUDE_VALUE = 32760; //32760
        //Controls number of notes per minute
        public string[] arData { get; set; } 
        

        public int Amplitude
        {
            get { return AMPLITUDE_VALUE;  }
            set { AMPLITUDE_VALUE = value;  }
        }

        public byte[] WaveData
        {
            get { return myWaveData; }
            set { myWaveData = value; }
        }

        public int Frequency
        {
            get { return SAMPLE_FREQUENCY; }
        }
        
        public float Audio_Length_Sec //changed
        {
            get { return AudioLengthInSeconds; }
            set { AudioLengthInSeconds = value; }
        }

       
    }
}
