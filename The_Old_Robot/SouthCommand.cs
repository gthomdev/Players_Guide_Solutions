﻿using System;
using System.Collections.Generic;
using System.Text;

namespace The_Old_Robot
{
    class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y--;
            }
        }
    }
}
