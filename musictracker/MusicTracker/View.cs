using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicTracker;
using System.Media;
using System.IO;


namespace MusicTracker
{
    public partial class View : Form
    {
        private Control myControl = new Control();
        public int iPanelValueControlPointer = 1;


        public View()
        {
            InitializeComponent();

            BackColor = Color.WhiteSmoke;
            // dataGridView1.BackgroundColor = BackColor;

            foreach (Panel x in flowLayoutPanel1.Controls)
            {
                x.BackColor = Color.WhiteSmoke;
            }

            flowLayoutPanel1.BackColor = BackColor;

        }



        private void m_bar_Amplitude_Scroll(object sender, EventArgs e)
        {
            myControl.setVolume(m_bar_Amplitude.Value);
            m_lbl_StatusLabel.Text = myControl.iVolume.ToString();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
                return;
            myControl.musicKeyListener.iOctave = 8 - (comboBox2.SelectedIndex + 1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex == -1)
            return;
            myControl.musicKeyListener.iSkip = comboBox3.SelectedIndex + 1; // skipping interval
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1)
                return;
            switch (comboBox4.SelectedIndex) // swith for instrument
            {
                case 0:
                    myControl.musicKeyListener.sInstrument = "01";
                    break;
                case 1:
                    myControl.musicKeyListener.sInstrument = "02";
                    break;
                case 2:
                    myControl.musicKeyListener.sInstrument = "03";
                    break;
                case 3:
                    myControl.musicKeyListener.sInstrument = "04";
                    break;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //

            if (comboBox1.SelectedIndex == -1)
                return;

            string sTemp = (comboBox1.SelectedItem.ToString());

            int numberOfPanelsNeeded = ConvertToNumber(sTemp) * (int)(Convert.ToInt32(myControl.sBPM) / 60);
            //if (numberOfPanelsNeeded == 0) numberOfPanelsNeeded = 1;

            //elements of panel
            Label l;
            TextBox t;
            TextBox j;
            Panel b;
            Button k;

            int numberOfPanels = 0;

            //gets number of text boxes
            foreach (Panel c in flowLayoutPanel1.Controls) numberOfPanels++;
            int seconds;

            seconds = 0;

            //Determines the number of boxes should be created or deleted
            if (numberOfPanelsNeeded > numberOfPanels)
            {
                seconds = numberOfPanels;
                for (int i = 0; i < numberOfPanelsNeeded - numberOfPanels; ++i)
                {

                    //Initilizes textobes
                    l = new Label();
                    t = new TextBox();
                    j = new TextBox();
                    b = new Panel();
                    k = new Button();

                    // BorderStyle ResizeRedraw = new BorderStyle();
                    // b.BorderStyle = ResizeRedraw;

                    //determines size and color of panel
                    b.Size = new System.Drawing.Size(500, 40);
                    b.MouseClick += flowLayoutPanel1_MouseClick;
                    //b.BackColor = Color.LightBlue;

                    //creates label for panal
                    l.Size = new System.Drawing.Size(55, 25);
                    l.Text = "";
                    l.Location = new Point(10, 10);
                    l.Name = "Label";
                    l.Validating += flowLayoutPanel1_Validating;
                    l.MouseClick += flowLayoutPanel1_MouseClick;
                    b.Controls.Add(l);

                    //makes first text box
                    t.Text = "-------";
                    t.Location = new Point(65, 10);
                    t.Name = "FirstTextBox";
                    t.Validating += flowLayoutPanel1_Validating;
                    t.PreviewKeyDown += flowLayoutPanel1_PreviewKeyDown;
                    t.MouseClick += flowLayoutPanel1_MouseClick;
                    b.Controls.Add(t);

                    //makes second text box
                    j.Text = "-------";
                    j.Location = new Point(170, 10);
                    j.Name = "SecondTextBox";
                    j.Validating += flowLayoutPanel1_Validating;
                    j.PreviewKeyDown += flowLayoutPanel1_PreviewKeyDown;
                    j.MouseClick += flowLayoutPanel1_MouseClick;
                    b.Controls.Add(j);

                    //Define button
                    k.Size = new System.Drawing.Size(65, 25);
                    k.Text = "PLAY";
                    k.BackColor = Color.Gray;
                    k.Location = new Point(300, 8);
                    k.MouseClick += flowLayoutPanel1_MouseClick;
                    k.Click += button_Click; //defines function for use in playing sound //defines function for use in playing sound

                    b.Controls.Add(k);

                    //Puts panel into flowlayoutpanel
                    flowLayoutPanel1.Controls.Add(b);
                }
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < numberOfPanelsNeeded; ++i)
                {

                    //Initilizes textobes
                    l = new Label();
                    t = new TextBox();
                    j = new TextBox();
                    b = new Panel();
                    k = new Button();

                    // BorderStyle ResizeRedraw = new BorderStyle();
                    // b.BorderStyle = ResizeRedraw;

                    //determines size and color of panel
                    b.Size = new System.Drawing.Size(500, 40);
                    b.MouseClick += flowLayoutPanel1_MouseClick;
                    //b.BackColor = Color.LightBlue;

                    //creates label for panal
                    l.Size = new System.Drawing.Size(55, 25);
                    l.Text = "";
                    l.Location = new Point(10, 10);
                    l.Name = "Label";
                    l.Validating += flowLayoutPanel1_Validating;
                    l.MouseClick += flowLayoutPanel1_MouseClick;
                    b.Controls.Add(l);

                    //makes first text box
                    t.Text = "-------";
                    t.Location = new Point(65, 10);
                    t.Name = "FirstTextBox";
                    t.Validating += flowLayoutPanel1_Validating;
                    t.PreviewKeyDown += flowLayoutPanel1_PreviewKeyDown;
                    t.MouseClick += flowLayoutPanel1_MouseClick;
                    b.Controls.Add(t);

                    //makes second text box
                    j.Text = "-------";
                    j.Location = new Point(170, 10);
                    j.Name = "SecondTextBox";
                    j.Validating += flowLayoutPanel1_Validating;
                    j.PreviewKeyDown += flowLayoutPanel1_PreviewKeyDown;
                    j.MouseClick += flowLayoutPanel1_MouseClick;
                    b.Controls.Add(j);

                    //Define button
                    k.Size = new System.Drawing.Size(65, 25);
                    k.Text = "PLAY";
                    k.BackColor = Color.Gray;
                    k.Location = new Point(300, 8);
                    k.MouseClick += flowLayoutPanel1_MouseClick;
                    k.Click += button_Click; //defines function for use in playing sound


                    b.Controls.Add(k);

                    //Attempt to fix click function
                    b.TabIndex = i;

                    //Puts panel into flowlayoutpanel
                    flowLayoutPanel1.Controls.Add(b);
                }
            }

            int s = 0;
            int ib = 0;
            foreach (Panel c in flowLayoutPanel1.Controls)
            {
                foreach (Label lb in c.Controls.OfType<Label>())
                {
                    string PanelName = (s + 1).ToString();
                    PanelName += " Sec";
                    if ((ib % (Convert.ToInt32(myControl.sBPM) / 60)) == 0)
                    {
                        lb.Text = PanelName;
                        s++;

                    }

                }
                ib++;

            }


        }

        protected void button_Click(object sender, EventArgs e)
        {
            //Default values
            float fGen1 = 300;
            float fGen2 = 300;
            String InstrumentVar1 = "01";
            String InstrumentVar2 = "01";
            String Volume1 = myControl.iVolume.ToString();
            String Volume2 = myControl.iVolume.ToString();

            var button = (Button)sender;
            var panel = button.Parent;

            string sTem;
            string FirstPart;

            foreach (TextBox x in panel.Controls.OfType<TextBox>())
            {

                if (x.Name == "FirstTextBox")
                {
                    //check if empty text box
                    if (x.Text == "-------")
                    {
                        sTem = myControl.sPreviousNote1;
                    }
                    else if (x.Text == "0")
                    {
                        sTem = "A-30100";
                        myControl.sPreviousNote1 = sTem;
                    }
                    else
                    {
                        sTem = x.Text.ToString().ToUpper();
                        myControl.sPreviousNote1 = sTem;
                    }

                    FirstPart = sTem.Substring(0, 3);
                    InstrumentVar1 = sTem.Substring(3, 2);
                    Volume1 = sTem.Substring(5, 2);
                    fGen1 = (float)MusicNotes.NoteMaker.notes[FirstPart];



                }
                else if (x.Name == "SecondTextBox")
                {
                    if (x.Text == "-------")
                    {
                        sTem = sTem = myControl.sPreviousNote2;
                    }
                    else if (x.Text == "0")
                    {
                        sTem = "A-30100";
                        myControl.sPreviousNote2 = sTem;
                    }
                    else
                    {
                        sTem = x.Text.ToString().ToUpper();
                        myControl.sPreviousNote2 = sTem;
                    }

                    FirstPart = sTem.Substring(0, 3);
                    InstrumentVar2 = sTem.Substring(3, 2);
                    Volume2 = sTem.Substring(5, 2);
                    fGen2 = (float)MusicNotes.NoteMaker.notes[FirstPart];

                }

            }//textbox

            //create tone
            myControl.ToneGenerator(fGen1, fGen2, InstrumentVar1, InstrumentVar2, Volume1, Volume2);
        }

        public int ConvertToNumber(string sTemp)
        {
            switch (sTemp)
            {
                case "1 Second":
                    return 1;

                case "10 Seconds":
                    return 10;

                case "30 Second":
                    return 30;
                case "1 Minute":
                    return 60;
                case "5 Minute":
                    return 300;
                case "10 Minute":
                    return 600;
                default: return 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTemp = "";

            float fGen1 = 300;
            float fGen2 = 300;
            String InstrumentVar1 = "01";
            String InstrumentVar2 = "01";
            String Volume1 = myControl.iVolume.ToString();
            String Volume2 = myControl.iVolume.ToString();

            //Cycle through each panel
            foreach (Panel c in flowLayoutPanel1.Controls)
            {
                //Cycle through each textbox
                foreach (TextBox x in c.Controls.OfType<TextBox>())
                {
                    string sTem;
                    string FirstPart;

                    if (x.Name == "FirstTextBox")
                    {
                        //check if empty text box
                        if (x.Text == "-------")
                        {
                            sTem = myControl.sPreviousNote1;
                        }
                        else if (x.Text == "0")
                        {
                            sTem = "A-30100";
                            myControl.sPreviousNote1 = sTem;
                        }
                        else
                        {
                            sTem = x.Text.ToString().ToUpper();
                            myControl.sPreviousNote1 = sTem;
                        }
                        FirstPart = sTem.Substring(0, 3);
                        InstrumentVar1 = sTem.Substring(3, 2);
                        Volume1 = sTem.Substring(5, 2);
                        fGen1 = (float)MusicNotes.NoteMaker.notes[FirstPart];

                        sTemp += x.Text;
                        sTemp += " ";

                    }
                    else if (x.Name == "SecondTextBox")
                    {
                        if (x.Text == "-------")
                        {
                            sTem = myControl.sPreviousNote2;
                        }
                        else if (x.Text == "0")
                        {
                            sTem = "A-30100";
                            myControl.sPreviousNote2 = sTem;
                        }
                        else
                        {
                            sTem = x.Text.ToString().ToUpper();
                            myControl.sPreviousNote2 = sTem;
                        }
                        FirstPart = sTem.Substring(0, 3);
                        InstrumentVar2 = sTem.Substring(3, 2);
                        Volume2 = sTem.Substring(5, 2);
                        fGen2 = (float)MusicNotes.NoteMaker.notes[FirstPart];

                    }

                }//textbox

                //create tone
                myControl.ToneGenerator(fGen1, fGen2, InstrumentVar1, InstrumentVar2, Volume1, Volume2);

            }//panel

        }//method

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Validates every textbox in panel
        private void flowLayoutPanel1_Validating(object sender, CancelEventArgs e)
        {
            foreach (Panel c in flowLayoutPanel1.Controls)
            {
                foreach (TextBox x in c.Controls.OfType<TextBox>())
                {
                    string sNote, sInstrument, sEffect;

                    if (x.Text != "0")
                    {
                        CorrectInput(x.Text.ToUpper(), out sNote, out sInstrument, out sEffect);
                        x.Text = sNote + sInstrument + sEffect;
                    }
                }
            }
        }


        private void CorrectInput(String s, out String note, out String instrument, out String effect)
        {
            char[] NoteValues = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            note = "---";
            instrument = "--";
            effect = "--";
            if('0' == s[0])
            {
                note = "000";
                return;
            }
            s.ToUpper(); // convert for ease of use
            if (s.Length < 7) s = s + ".......";

            String[] splitString = { s.Substring(0, 3), s.Substring(3, 2), s.Substring(5, 2) };
            //test variable
            int iTest;
            // note test
            if (NoteValues.Contains(splitString[0][0]) // first letter note
                && (splitString[0][1] == '-' || splitString[0][1] == '#') // sharp or not
                && int.TryParse(splitString[0][2].ToString(), out iTest)) // 
            {
                note = splitString[0];
            }
            //instrument test
            if (int.TryParse(splitString[1][0].ToString(), out iTest) && int.TryParse(splitString[1][1].ToString(), out iTest))
            {
                instrument = splitString[1];

            }
            //effect test
            if (int.TryParse(splitString[2][0].ToString(), out iTest) && int.TryParse(splitString[2][1].ToString(), out iTest))
            {
                effect = splitString[2];
            }
        }

        private void projectGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string iMessage = "";
            iMessage += "Music Tracker\nCopyright 2015\n";
            iMessage += "Description:\n\n";
            iMessage += "   This project, Project Songbird, began as a final project for CSCI 220 Programing Languages. The";
            iMessage += "goal of the project was to create a music tracker, similiar to MilkyTracker, that";
            iMessage += "would be able to create songs from user input. The group was comprised of Andrew ";
            iMessage += "Christianson, Mathew Christianson, and Bjorn Mathisen. This software is the ";
            iMessage += "final product of that project.";

            MessageBox.Show(this,
                            iMessage,
                            "About SongBird",
                            MessageBoxButtons.OK);
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string iMessage = "";
            iMessage += "   For help in case of errors or recommendation of software use, please contact one of our members. ";
            iMessage += "We can be contacted through email or phone number. Below is our contact information:\n\n";
            iMessage += "Andrew Christianson\n";
            iMessage += "Email: andy.christianson@principia.edu\n";
            iMessage += "Phone: (951)-973-8395";

            MessageBox.Show(this,
                            iMessage,
                            "Help",
                            MessageBoxButtons.OK);
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string iMessage = "";
            iMessage += "   The current program works like a normal music tracker. Musical notes can be entered into the textboxes ";
            iMessage += "to product the currect tones. C-4, D-5, F#3 all work as correct inputs and create sine waves of the correct quality. ";
            iMessage += "Other effects besides basic notes can be added in this manner: \n\n";
            iMessage += "Note   Instrument   Volume\n";
            iMessage += "   \\            |            / \n";
            iMessage += "     C-4     01      32 \n";
            iMessage += "                 |         \n";
            iMessage += "           C-40132       \n\n";
            iMessage += "Textboxes and buttons and be easily navigated quickly by pressiing the tab key. Add time to your song by selecting";
            iMessage += " a timeframe from one second to 15 minutes.";

            MessageBox.Show(this,
                iMessage,
                "Help",
                MessageBoxButtons.OK);
        }

        /*
         * private void m_btn_GenerateWav_Click
         * Description: Uses to create the wav file from the sound inputs
         * Pre: At least something selected for time
         * Post: Wav file exported
         */
        private void m_btn_GenerateWav_Click(object sender, EventArgs e)
        {
            myControl.FileGenerated = true;
            label2.Text = "Status: Wav file ready for export";


            string sTemp = "";

            float fGen1 = 300;
            float fGen2 = 300;
            String InstrumentVar1 = "01";
            String InstrumentVar2 = "01";
            String Volume1 = myControl.iVolume.ToString();
            String Volume2 = myControl.iVolume.ToString();

            //For concatonation
            List<string> Source = new List<string>();
            int i = 0;
            //m_lbl_StatusLabel.Text = "Working";

            //Cycle through each panel
            foreach (Panel c in flowLayoutPanel1.Controls)
            {

                //For concatenation

                //Cycle through each textbox
                foreach (TextBox x in c.Controls.OfType<TextBox>())
                {
                    string sTem;
                    string FirstPart;

                    if (x.Name == "FirstTextBox")
                    {
                        //check if empty text box
                        if (x.Text == "-------")
                        {
                            sTem = myControl.sPreviousNote1;
                        }
                        else if (x.Text == "0")
                        {
                            sTem = "A-30100";
                            myControl.sPreviousNote1 = sTem;
                        }
                        else
                        {
                            sTem = x.Text.ToString().ToUpper();
                            myControl.sPreviousNote1 = sTem;
                        }
                        FirstPart = sTem.Substring(0, 3);
                        InstrumentVar1 = sTem.Substring(3, 2);
                        Volume1 = sTem.Substring(5, 2);
                        fGen1 = (float)MusicNotes.NoteMaker.notes[FirstPart];

                        sTemp += x.Text;
                        sTemp += " ";

                    }
                    else if (x.Name == "SecondTextBox")
                    {
                        if (x.Text == "-------")
                        {
                            sTem = myControl.sPreviousNote2;
                        }
                        else if (x.Text == "0")
                        {
                            sTem = "A-30100";
                            myControl.sPreviousNote2 = sTem;
                        }
                        else
                        {
                            sTem = x.Text.ToString().ToUpper();
                            myControl.sPreviousNote2 = sTem;
                        }
                        FirstPart = sTem.Substring(0, 3);
                        InstrumentVar2 = sTem.Substring(3, 2);
                        Volume2 = sTem.Substring(5, 2);
                        fGen2 = (float)MusicNotes.NoteMaker.notes[FirstPart];

                    }

                }//textbox

                //create tone
                //myControl.ToneGenerator(fGen1, fGen2, InstrumentVar1, InstrumentVar2, Volume2, Volume2);
                myControl.ToneGeneratorCreateWav(fGen1, fGen2, InstrumentVar1, InstrumentVar2, Volume1, Volume2, i);

                Source.Add("WavFiles/Test.wav" + i.ToString());
                i++;

            }//panel


            myControl.Concatenate("Output.wav", Source);
            m_lbl_StatusLabel.Text = "Done";

            SoundPlayer simpleSound = new SoundPlayer("Output.wav");
            simpleSound.PlaySync();
            simpleSound.Dispose();

            Array.ForEach(Directory.GetFiles("WavFiles"), File.Delete);


            m_lbl_StatusLabel.Text = "Ready...";


        }

        private void exportToWaveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            /*SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();*/

            if (myControl.FileGenerated == false)
            {
                string iMessage = "Warning: Please create the wav file by selecting a time and pressing the generate wav file button ";
                iMessage += " before trying to export.";

                MessageBox.Show(this,
                                iMessage,
                                "Warning: No file Created",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                myControl.CreateDialog();


            }
        }

        public void m_txt_BPMText_Validating(object sender, EventArgs e)
        {
            int iNumber = 120;
            bool BPars = Int32.TryParse(m_txt_BPMText.Text.ToString(), out iNumber);

            if (BPars && iNumber < 900 && iNumber >= 60)
            {
                myControl.setBPM(m_txt_BPMText.Text);
            }
            else
            {
                string iMessage = "Please enter a integer value between 60 and 900 for beats per minute";

                MessageBox.Show(this,
                iMessage,
                "Warning: No file Created",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                m_txt_BPMText.Text = myControl.getBPM();
                return;
            }

        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
               Function:	defaultToolStripMenuItem_Click_1
               Pre:		default gray color scheme
               Post:		
           ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
            // dataGridView1.BackgroundColor = BackColor;

            foreach (Panel x in flowLayoutPanel1.Controls)
            {
                x.BackColor = Color.WhiteSmoke;
            }

            flowLayoutPanel1.BackColor = BackColor;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
            //dataGridView1.BackgroundColor = BackColor;

            foreach (Panel x in flowLayoutPanel1.Controls)
            {
                x.BackColor = Color.Gray;
            }

            flowLayoutPanel1.BackColor = BackColor;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;

            //dataGridView1.BackgroundColor = BackColor;

            foreach (Panel x in flowLayoutPanel1.Controls)
            {
                x.BackColor = Color.White;
            }

            flowLayoutPanel1.BackColor = BackColor;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightCyan;
            //dataGridView1.BackgroundColor = BackColor;

            foreach (Panel x in flowLayoutPanel1.Controls)
            {
                x.BackColor = Color.LightCyan;
            }

            flowLayoutPanel1.BackColor = BackColor;
        }

        public void TextFileCreation()
        {
            View myView = new View();

            List<string> newList = new List<string>();
            //newList.Add("Happy"); test

            TextWriter tw = new StreamWriter("data.txt");
            //writes imporant info to file
            tw.WriteLine(myControl.iVolume); // amplitude
            tw.WriteLine(myControl.getBPM()); // beats per minute
            tw.WriteLine(comboBox1.SelectedItem.ToString());


            foreach (Panel c in flowLayoutPanel1.Controls)
            {
                foreach (TextBox x in c.Controls.OfType<TextBox>())
                {
                    newList.Add(x.Text);
                }
            }

            //writes list to file
            foreach (string x in newList)
            {
                tw.WriteLine(x);
                //tw.Write(newList[0]);
            }

            // close the stream
            tw.Close();
            tw.Dispose();

        }

        private void but_generate_file_Click(object sender, EventArgs e)
        {
            TextFileCreation();
        }


        private void but_load_file_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Title = "Open Title";
            //openFile.Filter = "Text Files (txt)|*.txt)| All Files (*.*)|*.*";

            //if(openFile.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader read = new StreamReader(File.OpenRead(openFileDialog.FileName));

            //    int iV = (Int32.Parse(read.ReadLine()));

            //    m_bar_Amplitude.Value = iV;
            //    m_lbl_StatusLabel.Text = iV.ToString();
            //    myControl.iVolume = iV;

            //    m_txt_BPMText.Text = (read.ReadLine());
            //    comboBox1.Text = read.ReadLine();

            //    int iNumberOfPanels = 0;
            //    int iVar = 0;
            //    foreach (Panel c in flowLayoutPanel1.Controls) iNumberOfPanels++;
            //    for (int i = 0; i < iNumberOfPanels / 2; i++)
            //    {
            //        foreach (TextBox c in flowLayoutPanel1.Controls[iVar].Controls.OfType<TextBox>())
            //        {
            //            c.Text = read.ReadLine();
            //        }
            //        iVar++;
            //    }
            //    read.Dispose();
            //}

            //

            List<string> sa = new List<string>();
            myControl.LoadTextDialog(sa);

            //List<string> theFile = myControl.LoadTextDialog();

            int iV = (Int32.Parse(sa[0]));




            m_bar_Amplitude.Value = iV;
            m_lbl_StatusLabel.Text = iV.ToString();
            myControl.iVolume = iV;

            m_txt_BPMText.Text = sa[1];
            comboBox1.Text = sa[2];

            int iNumberOfPanels = 0;
            int iVar = 0;
            int x = 3;

            foreach (Panel c in flowLayoutPanel1.Controls) iNumberOfPanels++;
            for (int i = 0; i < iNumberOfPanels; )
            {
                foreach (TextBox c in flowLayoutPanel1.Controls[iVar].Controls.OfType<TextBox>())
                {
                    c.Text = sa[x];
                    x++;
                }
                iVar++; i++;
            }

            //for (int i = 0; i < iNumberOfPanels / 2; i++)
            //{
            //    foreach (TextBox c in flowLayoutPanel1.Controls[iVar].Controls.OfType<TextBox>())
            //    {
            //        c.Text = read.ReadLine();
            //    }
            //    iVar++;
            //}
            //read.Dispose();


            //StreamReader tr = new StreamReader(File.OpenRead(FileName));
            //////
            //int iV = (Int32.Parse(tr.ReadLine()));
            //m_bar_Amplitude.Value = iV;
            //m_lbl_StatusLabel.Text = iV.ToString();
            //myControl.iVolume = iV;
            //m_txt_BPMText.Text = (tr.ReadLine());
            //comboBox1.Text = tr.ReadLine();

            //int iNumberOfPanels = 0;
            //int iVar = 0;

            //foreach (Panel c in flowLayoutPanel1.Controls) iNumberOfPanels++;
            //for (int i = 0; i < iNumberOfPanels; i++)
            //{
            //    foreach (TextBox c in flowLayoutPanel1.Controls[iVar].Controls.OfType<TextBox>())
            //    {
            //        c.Text = tr.ReadLine();
            //    }
            //    iVar++;
            //}

            //tr.Dispose();
        }

        private void flowLayoutPanel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Boolean bFound = false;
            
            //Cycle through each panel
            foreach (Panel c in flowLayoutPanel1.Controls)
            {
                //Cycle through each textbox
                foreach (TextBox x in c.Controls.OfType<TextBox>())
                {
                    x.ReadOnly = false; // sets all to readable
                    if (!x.Focused) x.BackColor = Color.Lavender;
                    if (x.Focused && !bFound)
                    {
                        bFound = true; // means textbox is found; 
                        if (e.KeyData == Keys.Space && myControl.musicKeyListener.bListening == false)
                        {
                            myControl.musicKeyListener.bListening = true;
                            x.BackColor = Color.PaleVioletRed;
                            x.Focus();
                            

                        }
                        else  if (e.KeyData == Keys.Space && myControl.musicKeyListener.bListening == true)
                        {
                            myControl.musicKeyListener.bListening = false;
                            x.BackColor = Color.Lavender;
                            x.Focus();
                            x.SelectAll();
                        }
                        else if (myControl.musicKeyListener.bListening)
                        {
                            x.ReadOnly = true;
                            string sResult = myControl.musicKeyListener.Listener((char)e.KeyValue);
                            x.Text = sResult;

                            int index = flowLayoutPanel1.Controls.IndexOf(c) + myControl.musicKeyListener.iSkip;

                            if (index < flowLayoutPanel1.Controls.Count)
                            {
                                Panel p = (Panel)flowLayoutPanel1.Controls[index];
                                foreach (TextBox tex in p.Controls.OfType<TextBox>())
                                {
                                    switch (x.Name)
                                    {
                                        // for second collumn
                                        case "SecondTextBox":
                                            if (tex.Name == "SecondTextBox")
                                            {
                                                x.BackColor = Color.Lavender;
                                                tex.Focus();
                                                tex.BackColor = Color.PaleVioletRed;
                                            }
                                            break;
                                        default:    // for first collumn
                                            if (tex.Name == "FirstTextBox")
                                            {
                                                x.BackColor = Color.Lavender;
                                                tex.Focus();
                                                tex.BackColor = Color.PaleVioletRed;
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                        else
                            x.ReadOnly = false;
                    }
                }
            }
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            myControl.musicKeyListener.bListening = false;
            foreach (Panel p in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                foreach (TextBox t in p.Controls.OfType<TextBox>())
                {
                     t.BackColor = Color.Lavender;
                }
            }
        }
    }

}
