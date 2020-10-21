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
                
                Ahead(150);
                for (int i = 0; i < 60; i++){
                    TurnGunLeft(gunTurn);
                }
                TurnRight(35);
                TurnGunLeft(35);
            }
        }
       
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
       

                Stop();     
                Fire(Rules.MAX_BULLET_POWER); // lembrar de ver todos os maximos que apareceram (velocidade...)
                Scan();
                Resume();
           
            
        }

        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            base.OnHitByBullet(evnt);
            Ahead(100);
            TurnRight(75);
            TurnGunLeft(75);
        }

        public override void OnHitWall(HitWallEvent evnt)
        {
            base.OnHitWall(evnt);
            TurnRight(75);
        }

     

    }
}