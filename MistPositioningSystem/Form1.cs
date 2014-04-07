using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MistPositioningSystem
{
    public partial class Form1 : Form
    {

        //this form controls the throttling of request to the server. 
        //if the server recieves signifcantly more messages than this application normally allows this IP will be blocked
        //if you decide to modify this code, don't send message to ahhhdragons faster than once every 10 seconds

        //limit to a single report of friend or enemy report every 10 seconds
        private AhhhDragonsReport _nextReport = null;

        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //used to grab the hotkeys for reporting enemy position
        private KeyboardHook _keyHook = new KeyboardHook();

        private Gw2Mem.MumbleLink _GW2 = new Gw2Mem.MumbleLink();
        public Form1()
        {
            InitializeComponent();


            _keyHook.RegisterHotKey(MistPositioningSystem.ModifierKeys.Control, Keys.F9); //playback mouse
            _keyHook.RegisterHotKey(MistPositioningSystem.ModifierKeys.Control, Keys.F10); //record mouse position
            _keyHook.RegisterHotKey(MistPositioningSystem.ModifierKeys.Control, Keys.F11); //clear mouse history
            _keyHook.KeyPressed += _keyHook_KeyPressed;
        }

        void _keyHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.F9:
                    _nextReport = BuildReport(AhhhDragonsReport.PlayerGroupAllegiance.Enemy, AhhhDragonsReport.PlayerGroupSize.Few);
                    Console.Beep(300,300);
                    break;
                case Keys.F10:
                    _nextReport = BuildReport(AhhhDragonsReport.PlayerGroupAllegiance.Enemy, AhhhDragonsReport.PlayerGroupSize.Many);
                    Console.Beep(300, 300);
                    break;
                case Keys.F11:
                    _nextReport = BuildReport(AhhhDragonsReport.PlayerGroupAllegiance.Enemy, AhhhDragonsReport.PlayerGroupSize.Zerg);
                    Console.Beep(300, 300);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // appending sound location
            //string fullPathToSound = Path.GetFullPath( @"beep.wav");
            //player.SoundLocation = fullPathToSound;
        }

        /// <summary>
        /// Saves the current report from the user to be sent to the server on regular 10s intervals
        /// </summary>
        /// <param name="allegiance"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        private AhhhDragonsReport BuildReport(AhhhDragonsReport.PlayerGroupAllegiance allegiance, MistPositioningSystem.AhhhDragonsReport.PlayerGroupSize amount)
        {
            var position = _GW2.Read();
            
            if (!string.IsNullOrWhiteSpace(position.name))
            {
                var identity = new JavaScriptSerializer().Deserialize<GW2Identity>(position.identity);
                var report = new AhhhDragonsReport
                {
                    MistsTrackingCode = txtMistsTrackingCode.Text,
                    Name = identity.Name,
                    Map = identity.Map_Id,
                    PosX = position.fAvatarPosition[0],
                    PosY = position.fAvatarPosition[1],
                    PosZ = position.fAvatarPosition[2],
                    GroupAllegiance = allegiance,
                    GroupSize = amount

                };
                return report;
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _nextReport = BuildReport(AhhhDragonsReport.PlayerGroupAllegiance.Enemy, MistPositioningSystem.AhhhDragonsReport.PlayerGroupSize.Few);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _nextReport = BuildReport(AhhhDragonsReport.PlayerGroupAllegiance.Enemy, MistPositioningSystem.AhhhDragonsReport.PlayerGroupSize.Many);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _nextReport = BuildReport(AhhhDragonsReport.PlayerGroupAllegiance.Enemy, MistPositioningSystem.AhhhDragonsReport.PlayerGroupSize.Zerg);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tmrAutoReport_Tick(object sender, EventArgs e)
        {
            if (_nextReport == null && chkSendMyPosition.Checked)
            {
                //build friendly report
                _nextReport = BuildReport(AhhhDragonsReport.PlayerGroupAllegiance.Friend, MistPositioningSystem.AhhhDragonsReport.PlayerGroupSize.Few);


            }

            if (_nextReport != null) 
            { 
                AhhhDragonsReporter.IssueReport(_nextReport);
                _nextReport = null;
            }



        }
    }
}
