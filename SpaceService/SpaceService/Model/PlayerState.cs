﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceService.Model
{
    public class PlayerState
    {
        public Player Player { get; set; }
        public Vector Position { get; set; }
        public bool Finished { get; set; }
        public float Score { get; set; }
        public bool ResultRequested { get; set; }

        public PlayerState()
        {
            Position = new Vector();
            Finished = false;
            Score = float.MaxValue;
            ResultRequested = false;
        }
    }
}