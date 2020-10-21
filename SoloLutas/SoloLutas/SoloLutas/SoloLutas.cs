using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robocode;


namespace sololutas //SOL = sun   ULT= R   IS= é
{
    class SoloLutas : Robot
    {
      
        public override void Run()
        {
            TurnLeft(Heading - 90);
            TurnGunRight(90);
            while (true)
            {
                Ahead(5000);
                TurnRight(90);
            }
        }
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            Fire(Rules.MAX_BULLET_POWER); // lembrar de ver todos os maximos que apareceram (velocidade...)
        }


    }
}