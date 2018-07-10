using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTracker.MusicNotes
{
    class KeyBoardListener
    {

        public Boolean bListening { get; set; }
        public int iSkip { get; set; }
        public string sVolume { get; set; }
        public int iOctave { get; set; }
        public String sInstrument { get; set; }
        // first row
        public Dictionary<char, string> BottomkeyMap = new Dictionary<char, string>
        {
        {'Z', "C-1"},{'S', "C#1"},{'X', "D-1"},{'D', "D#1"},{'C',"E-1"},{'V', "F-1"},{'G', "F#1"},{'B', "G-1"},{'H', "G#1"},{'N', "A-1"}, {'J', "A#1"}, {'M',"B-1"}, {'¼'/*<*/, "C-2"}, {'L',"C#2"},{'¾'/*>*/, "D-2"},{(char)186, "D#2"}, {'¿'/*?*/, "E-2"}
        };
        // second row
        public Dictionary<char, string> TopkeyMap = new Dictionary<char, string>
        {
        {'Q', "C-1"},{'2', "C#1"},{'W', "D-1"},{'3', "D#1"},{'E',"E-1"},{'R', "F-1"},{'5', "F#1"},{'T', "G-1"},{'6', "G#1"},{'Y', "A-1"}, {'7', "A#1"}, {'U',"B-1"}, {'I',"C-2"}, {'9',"C#2"}, {'O', "D-2"},{'0', "D#2"},{'P', "E-2"}, {'Û'/* { */, "F-2"},{(char)187, "F#2"}, {'Ý'/* } */, "G-2"}
        };
        public KeyBoardListener()
        {
            bListening = false;
            iSkip = 1;
            iOctave = 4;
            sVolume = "--";
            sInstrument = "01";
        }
        public string Listener(char cInOrigin)
        {
            char cIn = cInOrigin;

            string sReturn;
            if (this.TopkeyMap.ContainsKey(cIn))
            {
                this.TopkeyMap.TryGetValue(cIn, out sReturn);
                int iNum;
                char cInt = sReturn[2];
                int.TryParse(cInt.ToString(), out iNum);
                sReturn = "" + sReturn[0] + sReturn[1];
                sReturn += (this.iOctave + iNum).ToString();
                sReturn += sInstrument + sVolume;
                string sTest = "" + sReturn[0] + sReturn[1];
                if ((this.iOctave + iNum) <= 0 && (sTest != "A-" || sTest != "A#" || sTest != "B-")) return "......."; // if note is impossibly low
                if ((this.iOctave + iNum) > 7 && sTest != "C-") return ".......";  // if note is impossibly high

            }
            else if (this.BottomkeyMap.ContainsKey(cIn))
            {
                this.BottomkeyMap.TryGetValue(cIn, out sReturn);
                int iNum;
                char cInt = sReturn[2];
                int.TryParse(cInt.ToString(), out iNum);
                sReturn = "" + sReturn[0] + sReturn[1];
                sReturn += (this.iOctave + iNum - 1).ToString();
                sReturn += sInstrument + sVolume;
                string sTest = "" + sReturn[0] + sReturn[1];
                if ((this.iOctave + iNum - 1) <= 0 && sTest != "A-" && sTest != "A#" && sTest != "B-") return "......."; // if note is impossibly low
                if ((this.iOctave + iNum - 1) > 7 && sTest != "C-") return ".......";  // if note is impossibly high

            }
            else
                sReturn = ".......";

            return sReturn;
        }
    }
}
