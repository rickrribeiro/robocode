using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robocode;


namespace sololutas //SOL = sun   ULT= R   IS= é
{
    class SoloLutas : AdvancedRobot
    {
      
        public override void Run()
        {
            
            while (true)
            {
           //     Fire(Rules.MAX_BULLET_POWER);
           for(int i = 0; i < 2; i++)
                {
                    Ahead(150);
                    TurnGunRight(30);
                }
               
                 TurnRight(35);


            }
        }
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            Fire(Rules.MAX_BULLET_POWER); // lembrar de ver todos os maximos que apareceram (velocidade...)
        }


    }
}