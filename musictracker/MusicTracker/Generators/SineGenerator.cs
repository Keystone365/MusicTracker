using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker.Generators
{
    class SineGenerator
    {
        //Model myModel = new Model();

        private readonly double _frequency;
        private readonly UInt32 _sampleRate;
        private readonly UInt16 _secondsInLength;
        private short[] _dataBuffer;
        private float AMPLITUDE_VALUE; //32760
        private string _sBPM = "120";

        public short[] Data { get { return _dataBuffer; } }

        /*public SineGenerator(double frequency,
            UInt32 sampleRate, UInt16 secondsInLength, string sBPM)
        {
            _frequency = frequency;
            _sampleRate = sampleRate;
            _secondsInLength = secondsInLength;
            AMPLITUDE_VALUE = myModel.Amplitude;
            _sBPM = sBPM;
            GenerateData();
        }*/

        //Overloaded constructor for amplitude
        public SineGenerator(double frequency,
    UInt32 sampleRate, UInt16 secondsInLength, int myAmplitude, string sBPM)
        {
            _frequency = frequency;
            _sampleRate = sampleRate;
            _secondsInLength = secondsInLength;
            AMPLITUDE_VALUE = myAmplitude;
            _sBPM = sBPM;
            GenerateData();
        }

        private void GenerateData()
        {
            string f = _sBPM;
            uint bufferSize = ((_sampleRate * (_secondsInLength)) * 60) / Convert.ToUInt32(f);
            _dataBuffer = new short[bufferSize];

            float amplitude = AMPLITUDE_VALUE;

            double timePeriod = (Math.PI * 2 * _frequency) /
                (_sampleRate);

            for (uint index = 0; index < bufferSize - 1; index++)
            {
                _dataBuffer[index] = Convert.ToInt16(amplitude *
                    Math.Sin(timePeriod * index));
            }
        }
    }
}
