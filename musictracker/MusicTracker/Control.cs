/*########################################################################################
Program Model for View.cs associated with RSC

Author:				Bjorn Mathisen, Andy Christianson, Matt Christianson 
Course:				CSCI 220 Programming Languages
Date Completed:		11/20/2015


DESCRIPTION: 

########################################################################################*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using MusicTracker.Generators;
using MusicTracker.MusicNotes;
using System.Threading;
using System.Linq;

namespace MusicTracker
{

    class Control
    {
        

        static Audio myAudio = new Audio();
        private Model myModel = new Model(); // creates the model object type
        public KeyBoardListener musicKeyListener = new KeyBoardListener();// translates edit mode commands
        //Used to make sure file is generated before you can use the export function
        public bool FileGenerated = false;
        //Controls the global variables
        public int iVolume = 0;
        public string sBPM = "120";
        public string sPreviousNote1 = "A-30100";
        public string sPreviousNote2 = "A-30100";
        


        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
           Function:	
           Pre:		    contructor
           Post:		
       ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        static void Main() //launches form information style
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
            // Application.set .SetApartmentState(ApartmentState.STA);

            
        }

        
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
           Function:	
           Pre:		    
           Post:		
       ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public void ToneGenerator(float Gen1, float Gen2, string Generator1, string Generator2, string amp1, string amp2)
        {

            List<Byte> tempBytes = new List<byte>();

            //test to define length of sound
            myModel.Audio_Length_Sec = 1;

            //For amplitude/volume of note
            int Amplit1 = iVolume;
            int Amplit2 = iVolume;
            const int VOLUME_MULT = 1600;


            //Creates wave, format, and data chunks
            Generators.WaveHeader header = new Generators.WaveHeader();
            Generators.FormatChunk format = new Generators.FormatChunk();
            Generators.DataChunk data = new Generators.DataChunk();
            //Sine and square waves
            Generators.SineGenerator leftData1;
            Generators.SquareGenerator leftData2;
            Generators.SineGenerator rightData1;
            Generators.SquareGenerator rightData2;

            //Try to parse amplitude, set to new variables
            //Try to parse amplitude, set to new variables
            if (Int32.TryParse(amp1, out Amplit1)) Amplit1 = Amplit1 / 10;
            else Amplit1 = iVolume;
            if (Int32.TryParse(amp2, out Amplit2)) Amplit2 = Amplit2/10;
            else Amplit2 = iVolume;



            //Test for sawtooth generator
            Generators.PulseGenerator ExtraData = new Generators.PulseGenerator(Gen2,  //12098.0f
    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec);


            if (Generator1 == "01" && Generator2 == "01")
            {
                leftData1 = new Generators.SineGenerator(Gen1,  //627.0f
                    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                rightData1 = new Generators.SineGenerator(Gen2,  //627.0f
                 (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

                //Add the data
                data.AddSampleData(leftData1.Data, rightData1.Data);


            }
            else if (Generator1 == "01" && Generator2 == "02" || Generator1 == "01" && Generator2 == "--")
            {
                //Create Sine wave
                leftData1 = new Generators.SineGenerator(Gen1,  //627.0f
                (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                //Create square wave
                rightData2 = new Generators.SquareGenerator(Gen2,  //627.0f
                     (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

                //Add the data
                data.AddSampleData(leftData1.Data, rightData2.Data);


            }
            else if (Generator1 == "02" && Generator2 == "01" || Generator1 == "--" && Generator2 == "01")
            {
                //Create Square wave
                leftData2 = new Generators.SquareGenerator(Gen1,  //627.0f
                (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                //Create Sine wave
                rightData1 = new Generators.SineGenerator(Gen1,  //627.0f
                     (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

                //Add the data
                data.AddSampleData(leftData2.Data, rightData1.Data);

            }
            else if (Generator1 == "02" && Generator2 == "02" || Generator1 == "--" && Generator2 == "--")
            {
                leftData2 = new Generators.SquareGenerator(Gen1,  //627.0f
                    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                //Create square wave
                rightData2 = new Generators.SquareGenerator(Gen1,  //627.0f
                     (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

                //Add the data
                data.AddSampleData(leftData2.Data, rightData2.Data);
            }
            else
            {
                leftData1 = new Generators.SineGenerator(Gen1,  //627.0f
    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                rightData1 = new Generators.SineGenerator(Gen2,  //627.0f
                 (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

                //Add the data
                data.AddSampleData(leftData1.Data, rightData1.Data);
            }

            //Sets header length
            header.FileLength += format.Length() + data.Length();

            //Adds header, format, and data chunks to list
            tempBytes.AddRange(header.GetBytes());
            tempBytes.AddRange(format.GetBytes());
            tempBytes.AddRange(data.GetBytes());

            //Sets list to WaveData array
            myModel.WaveData = tempBytes.ToArray();

           /* //Defines new filestream to write Wave to file. Overwrites file if not created, or creates new file
            //By default it goes into the same folder as exe. If using debug it is the debug folder
            //in bin.
            FileStream f = new FileStream("Test.wav", FileMode.Create);
            BinaryWriter wr = new BinaryWriter(f);

            //Writes to new file
            wr.Write(myModel.WaveData);

            File.WriteAllBytes("Sound.wav", myModel.WaveData);*/

            //Plays bytes like WAVE file
            myAudio.Play(myModel.WaveData, AudioPlayMode.WaitToComplete);

           // myModel.Amplitude = 3200;
        }

        //Used for creating wav file for Generation
        public void ToneGeneratorCreateWav(float Gen1, float Gen2, string Generator1, string Generator2,
            string amp1, string amp2, int i)
        {

            List<Byte> tempBytes = new List<byte>();

            //test to define length of sound
            myModel.Audio_Length_Sec = 1;

            //For amplitude/volume of note
            int Amplit1 = iVolume;
            int Amplit2 = iVolume;
            const int VOLUME_MULT = 1600;


            //Creates wave, format, and data chunks
            Generators.WaveHeader header = new Generators.WaveHeader();
            Generators.FormatChunk format = new Generators.FormatChunk();
            Generators.DataChunk data = new Generators.DataChunk();
            //Sine and square waves
            Generators.SineGenerator leftData1;
            Generators.SquareGenerator leftData2;
            Generators.SineGenerator rightData1;
            Generators.SquareGenerator rightData2;

            //Try to parse amplitude, set to new variables
            //Try to parse amplitude, set to new variables
            if (Int32.TryParse(amp1, out Amplit1)) Amplit1 = Amplit1 / 10;
            else Amplit1 = iVolume;
            if (Int32.TryParse(amp2, out Amplit2)) Amplit2 = Amplit2 / 10;
            else Amplit2 = iVolume;

               
            //Test for sawtooth generator
            Generators.PulseGenerator ExtraData = new Generators.PulseGenerator(Gen2,  //12098.0f
    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec);


            if (Generator1 == "01" && Generator2 == "01")
            {
                leftData1 = new Generators.SineGenerator(Gen1,  //627.0f
                    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                rightData1 = new Generators.SineGenerator(Gen2,  //627.0f
                 (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

            //Add the data
                data.AddSampleData(leftData1.Data, rightData1.Data);


            }
            else if (Generator1 == "01" && Generator2 == "02" || Generator1 == "01" && Generator2 == "--")
            {
            //Create Sine wave
            leftData1 = new Generators.SineGenerator(Gen1,  //627.0f
            (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);
            
            //Create square wave
            rightData2 = new Generators.SquareGenerator(Gen2,  //627.0f
                 (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

            //Add the data
                data.AddSampleData(leftData1.Data, rightData2.Data);
            

            }
            else if (Generator1 == "02" && Generator2 == "01" || Generator1 == "--" && Generator2 == "01")
            {
                           //Create Sine wave
            leftData2 = new Generators.SquareGenerator(Gen1,  //627.0f
            (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);
            
            //Create square wave
            rightData1 = new Generators.SineGenerator(Gen1,  //627.0f
                 (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

            //Add the data
                data.AddSampleData(leftData2.Data, rightData1.Data);

            }
            else if (Generator1 == "02" && Generator2 == "02" || Generator1 == "--" && Generator2 == "--")
            {
                leftData2 = new Generators.SquareGenerator(Gen1,  //627.0f
                    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                //Create square wave
                rightData2 = new Generators.SquareGenerator(Gen1,  //627.0f
                     (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

                //Add the data
                data.AddSampleData(leftData2.Data, rightData2.Data);
            }
            else
            {
                leftData2 = new Generators.SquareGenerator(Gen1,  //627.0f
    (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit1 * VOLUME_MULT, sBPM);

                rightData2 = new Generators.SquareGenerator(Gen2,  //627.0f
                 (uint)myModel.Frequency, (ushort)myModel.Audio_Length_Sec, Amplit2 * VOLUME_MULT, sBPM);

                //Add the data
                data.AddSampleData(leftData2.Data, rightData2.Data);
            }
            

            //Sets header length
            header.FileLength += format.Length() + data.Length();

            //Adds header, format, and data chunks to list
            tempBytes.AddRange(header.GetBytes());
            tempBytes.AddRange(format.GetBytes());
            tempBytes.AddRange(data.GetBytes());

            //Sets list to WaveData array
            myModel.WaveData = tempBytes.ToArray();

             //Defines new filestream to write Wave to file. Overwrites file if not created, or creates new file
             //By default it goes into the same folder as exe. If using debug it is the debug folder
             //in bin.
             FileStream f = new FileStream("WavFiles/Test.wav" + i.ToString(), FileMode.Create);
             BinaryWriter wr = new BinaryWriter(f);

             //Writes to new file
            wr.Write(myModel.WaveData);

            f.Dispose();
            wr.Dispose();

             //File.WriteAllBytes("Sound.wav", myModel.WaveData);

            //Plays bytes like WAVE file
            //myAudio.Play(myModel.WaveData, AudioPlayMode.WaitToComplete);

            // myModel.Amplitude = 3200;
        }


        public void Concatenate(string outputFile, IEnumerable<string> sourceFiles)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;

            try
            {
                foreach (string sourceFile in sourceFiles)
                {
                    using (WaveFileReader reader = new WaveFileReader(sourceFile))
                    {
                        if (waveFileWriter == null)
                        {
                            // first time in create new Writer
                            waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                        }
                        else
                        {
                            if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
                            {
                                throw new InvalidOperationException("Can't concatenate WAV Files that don't share the same format");
                            }
                        }

                        int read;
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            waveFileWriter.WriteData(buffer, 0, read);
                        }
                    }
                }
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }

        } //Concatenate

        public void CreateDialog()
        {
            //String paths
            

            string sFileName;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "wav (*.wav)|*.wav|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save Wav File";
            saveFileDialog1.CheckFileExists = false;
            var thread = new Thread(new ParameterizedThreadStart(param => { 

                if(saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                else
                {
                    sFileName = saveFileDialog1.FileName;
                    File.Copy("Output.wav", sFileName, true);

                }

            }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
        }

        public void setVolume(int i)
        {
            iVolume = i;
        }


        //Set and get for Beats per minute
        public void setBPM(string i)
        {
            sBPM = i;
        }

        public string getBPM()
        {
            return sBPM;
        }

        public string loadFileDialog()
        {
            string s = "";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "wav (*.wav)|*.wav|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save Wav File";
            saveFileDialog1.CheckFileExists = false;
            var thread = new Thread(new ParameterizedThreadStart(param => {

                if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                else
                {
                    s = saveFileDialog1.FileName;
                }

            }));

            return s;
        }


        public void LoadTextDialog(List<string> lines)
        {
            //String paths


            string sFileName = "data.txt";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Save Wav File";
            openFileDialog1.CheckFileExists = false;
            var thread = new Thread(new ParameterizedThreadStart(param => {

                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                else
                {
                    sFileName = openFileDialog1.FileName;
                    //File.OpenRead(sFileName);

                    try
                    {

                    }
                    catch(Exception ex)
                    {
                        using (StreamReader sr = new StreamReader(sFileName))
                        {
                            // Read the stream to a string, and write the string to the console.
                            
                            while (sr.Peek() >= 0)
                                lines.Add(sr.ReadLine());
                        }
                    }

                }

            }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            string filePath = sFileName;

            
            


            //List<string> fileLines = new List<string>();

            //try
            //{
            //    using (var reader = new StreamReader(sFileName))
            //    {
            //        string line;
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            fileLines.Add(line);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}


            //return fileLines;

        }

        
    }
}
