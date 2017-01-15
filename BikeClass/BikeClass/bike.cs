using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeClass
{
    class bike
    {
        //Member variables for the bike
        private int cadence;
        private int gear;
        private int speed;

        //Properties of the bike class
        public int Cadence
        {
            get
            {
                return cadence;
            }
            set
            {
                cadence = value;
            }
        }

        public int Gear
        {
            get
            {
                return gear;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        //Methods that will perform the actions
        public void SetGears(int gr)
        {
            gear = gr;
        }

        public void ApplyBrakes(int amt)
        {
            speed -= amt;
        }

        public void IncreaseSpeed(int amnt)
        {
            speed += amnt;
        }

    }
}
