using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch7house
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        Room dinningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        Location currentLocation;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor
                ("Living Room", "an antique carpet", "an oak door with a brass knob");
            dinningRoom = new Room
                ("Dinning Room", "crystal chandelier");
            kitchen = new RoomWithDoor(
                "Kitchen", "stainless steel appliances", "screen door");

            frontYard = new OutsideWithDoor("Front yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back yard", false, "screen door");
            garden = new Outside("Garden", true);

            livingRoom.Exits = new Location[] { dinningRoom };
            dinningRoom.Exits = new Location[] { kitchen, livingRoom };
            kitchen.Exits = new Location[] { dinningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { kitchen, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location location)
        {
            currentLocation = location;
            cbExits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                cbExits.Items.Add(currentLocation.Exits[i].Name);
            }
            cbExits.SelectedIndex = 0;

            txtDescription.Text = location.Description;

            if (currentLocation is IHasExteriorDoor)
            {
                btnGoThroughDoor.Visible = true;
            }
            else
            {
                btnGoThroughDoor.Visible = false;
            }
        }

        private void btnGoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cbExits.SelectedIndex]);
        }

        private void btnGoThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
