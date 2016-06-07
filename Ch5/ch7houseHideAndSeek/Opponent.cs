﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7houseHideAndSeek
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            this.myLocation = startingLocation;
            this.random = new Random();
        }

        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if(myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor locationWithDoor =
                        myLocation as IHasExteriorDoor;
                    if (random.Next(2) == 1)
                        myLocation = locationWithDoor.DoorLocation;

                }

                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }

        public bool Check(Location locationWhereHide){
            if (this.myLocation == locationWhereHide)
                return true;
            else
                return false;
            }
    }
}
