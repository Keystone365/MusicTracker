using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker.Generators
{
    class PulseGenerator
    {
         private readonly double _frequency;
        private readonly UInt32 _sampleRate;
        private readonly UInt16 _secondsInLength;
        private short[] _dataBuffer;

        public short[] Data { get { return _dataBuffer; } }

        public PulseGenerator(double frequency,
            UInt32 sampleRate, UInt16 secondsInLength)
        {
            _frequency = frequency;
            _sampleRate = sampleRate;
            _secondsInLength = secondsInLength;
            GenerateData();
        }

        private void GenerateData()
        {
            uint bufferSize = _sampleRate * _secondsInLength;
            _dataBuffer = new short[bufferSize];

            int amplitude = 32760;

            double timePeriod = (Math.PI * 3 * _frequency) /
                (_sampleRate);


            for (uint index = 0; index < bufferSize - 1; index++)
            {
                //try to break into thirds
                if(index % 5 == 0)
                {
                    _dataBuffer[index] = Convert.ToInt16(amplitude *
                    Math.Sign(Math.Sin(timePeriod * index)));
                }
                else
                {
                    _dataBuffer[index] = 0;
                }
                
            }
        }
    }
}
