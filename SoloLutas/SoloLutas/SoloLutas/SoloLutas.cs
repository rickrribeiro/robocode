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
            BodyColor = Color.Red;
            GunColor = Color.Blue;
            RadarColor = Color.White;
            //   BulletColor = Color.FromArgb(70,77,105);
            BulletColor = Color.Red;
            MaxVelocity = Rules.MAX_VELOCITY;


            int gunTurn = 3;
            int robotTurn = 3;

            while (true)
            {
                TurnRight(35);
                Ahead(150);
                //for (int i = 0; i < 60; i++){
                //    TurnGunLeft(gunTurn);
                //}
                TurnGunLeftRadians(Math.PI*2);
               
            
            }
        }
       
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