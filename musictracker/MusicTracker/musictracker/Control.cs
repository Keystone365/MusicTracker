using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace MusicTracker
{
    class Control
    {
        Model myModel = new Model(); // creates the model object type

        static Audio myAudio = new Audio();
        private static byte[] myWaveData;
        // Sample rate (Or number of samples in one second)
        private const int SAMPLE_FREQUENCY = 44100; //Default from tutorial is 44100
        // 60 seconds or 1 minute of audio
        private const int AUDIO_LENGTH_IN_SECONDS = 5;
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
        }

        static void ToneGenerator()
        {
            List<Byte> tempBytes = new List<byte>();

            Generators.WaveHeader header = new Generators.WaveHeader();
            Generators.FormatChunk format = new Generators.FormatChunk();
            Generators.DataChunk data = new Generators.DataChunk();

            // Create 1 second of tone at 697Hz
            Generators.SineGenerator leftData = new Generators.SineGenerator(627.0f,
                SAMPLE_FREQUENCY, AUDIO_LENGTH_IN_SECONDS);
            // Create 1 second of tone at 1209Hz
            Generators.SineGenerator rightData = new Generators.SineGenerator(1209.0f,
                SAMPLE_FREQUENCY, AUDIO_LENGTH_IN_SECONDS);

            data.AddSampleData(leftData.Data, rightData.Data);

            header.FileLength += format.Length() + data.Length();

            tempBytes.AddRange(header.GetBytes());
            tempBytes.AddRange(format.GetBytes());
            tempBytes.AddRange(data.GetBytes());

            myWaveData = tempBytes.ToArray();

            myAudio.Play(myWaveData, AudioPlayMode.WaitToComplete);
        }
    }
}
