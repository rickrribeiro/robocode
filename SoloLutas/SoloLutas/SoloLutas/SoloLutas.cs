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
        int move = 11;
        bool isShooting = false;
        int victory = 2;
        public override void Run()
        {
            BodyColor = Color.Red; // Color.FromArgb(70, 77, 105);// 
            GunColor = Color.Blue;// Color.FromArgb(70, 77, 105); //
            RadarColor = Color.White;// Color.FromArgb(70, 77, 105);// 
            BulletColor = Color.FromArgb(70,77,105); //Color.Red; 

            //   BulletColor = Color.Red;



            int gunTurn = 3;
            int robotTurn = 3;

            while (true)
            {
                /*
                SetTurnRight(10000);
                Ahead(10000); */

                //for (int i = 0; i < 60; i++){
                //    TurnGunLeft(gunTurn);
                //}

                if (victory <= 0)
                {
                  //  victory = 2;
                  //  move++;
                }
                //   TurnGunLeftRadians(Math.PI*2);
                if (move == 1 || move == 4 || move == 7 || move == 10)
                {
                    move1();
                }
                else if (move == 2 || move == 5 || move == 8)
                {
                    move2();
                }
                else if (move == 3 || move == 6 || move == 9)
                {
                    move3();
                } else if (move == 11)
                {
                    move4();
                }
                


            }
        }

        public void move1()
        {
            MaxVelocity = Rules.MAX_VELOCITY;
            TurnRight(35);
            Ahead(150);
            for (int i = 0; i < 4; i++)
            {
                TurnGunLeftRadians(Math.PI / 2);
            }
        }

        public void move2()
        {
            MaxVelocity = 5;
            SetTurnRight(10000);
            Ahead(10000);
            for (int i = 0; i < 4; i++)
            {
                TurnGunLeftRadians(Math.PI / 2);
            }
        }

        public void move3()
        {
            Ahead(40);
            for (int i = 0; i < 4; i++)
            {
                TurnGunLeftRadians(Math.PI / 2);
            }
        }

        public void move4()
        {
            Ahead(140); //Go ahead 100 pixels
            TurnGunRight(360); //scan
            Back(100); //Go back 75 pixels
            TurnGunRight(360); //scan
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {



            Stop();

            Fire(Rules.MAX_BULLET_POWER); // lembrar de ver todos os maximos que apareceram (velocidade...)
                                          // Fire(2);
           

            Scan();
            Resume();
          

        }


        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            base.OnHitByBullet(evnt);
            //  TurnRight(15);
            //Ahead(40);

        }


        public override void OnHitWall(HitWallEvent evnt)
        {
            base.OnHitWall(evnt);
            if (move == 2)
            {
                TurnRight(90);
                Ahead(70);
            }
            else if (move == 1 || move == 3)
            {
                TurnRight(180);
                Ahead(70);
            }
           else if (move == 11)
            {
                double bearing = evnt.Bearing; //get the bearing of the wall
                TurnRight(-bearing); //This isn't accurate but release your robot.
                Ahead(100);
            }



        }

        public override void OnWin(WinEvent evnt)
        {
            base.OnWin(evnt);
            victory++;
        }

        public override void OnDeath(DeathEvent evnt)
        {
            base.OnDeath(evnt);
            victory--;
        }
    }


}