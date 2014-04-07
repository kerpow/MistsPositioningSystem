using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MistPositioningSystem
{
    class AhhhDragonsReport
    {
        
        public enum PlayerGroupSize{
            Few,
            Many,
            Zerg,
        }
        
        public enum PlayerGroupAllegiance{
            Friend,
            Enemy,
        }

        public string MistsTrackingCode {get;set;}
        public string Name {get;set;}
        public int Map {get;set;}
        public float PosX {get;set;}
        public float PosY {get;set;}
        public float PosZ {get;set;}
        public PlayerGroupAllegiance GroupAllegiance {get;set;}
        public PlayerGroupSize GroupSize {get;set;}



    }
}
