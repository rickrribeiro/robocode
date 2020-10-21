using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Robocode;


namespace sololutas //SOL = sun   ULT= R   IS= é
{
    class SoloLutas : AdvancedRobot
    {
        bool isShooting = false;
        public override void Run()
        {
            BodyColor = Color.FromArgb(70, 77, 105);// Color.Red;
            GunColor = Color.FromArgb(70, 77, 105); //Color.Blue;
            RadarColor = Color.FromArgb(70, 77, 105);// Color.White;
              BulletColor = Color.FromArgb(70,77,105);
            SetAllColors(Color.FromArgb(70, 77, 105));
         //   BulletColor = Color.Red;
            MaxVelocity = Rules.MAX_VELOCITY;
            

            int gunTurn = 3;
            int robotTurn = 3;

            while (true)
            {
                SetTurnRight(10000);
                //TurnRight(35);
                Ahead(10000);
                //for (int i = 0; i < 60; i++){
                //    TurnGunLeft(gunTurn);
                //}
                for(int i = 0; i < 4; i++)
                {
                    TurnGunLeftRadians(Math.PI / 2);
                }
             //   TurnGunLeftRadians(Math.PI*2);
               
            
            }
        }
        int count = 0;
        public override void OnScannedRobot(ScannedRobotEvent e)
        {

           
                Stop();
                Fire(Rules.MAX_BULLET_POWER); // lembrar de ver todos os maximos que apareceram (velocidade...)
                Scan();
                Resume();
          
               
        }
        
        /*
        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            base.OnHitByBullet(evnt);
            TurnRight(75);
            Ahead(100);
            TurnGunLeftRadians(Math.PI * 2);
        }
        */

        public override void OnHitWall(HitWallEvent evnt)
        {
            base.OnHitWall(evnt);
            TurnRight(75);
        }
        


        }
}