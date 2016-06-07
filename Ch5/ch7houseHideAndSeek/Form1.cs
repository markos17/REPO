using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch7houseHideAndSeek
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;
        Opponent opponent;

        int Moves;


        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet",
            "inside the closet", "an oak door with a brass handle");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier",
            "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances",
            "in the cabinet", "a screen door");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog",
            "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet",
            "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed",
            "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed",
            "under the bed");
            frontYard = new OutsideWithDoor("Front Yard", false, "a heavy-looking oak door");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation_(Location location)
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

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            cbExits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                cbExits.Items.Add(currentLocation.Exits[i].Name);
            cbExits.SelectedIndex = 0;
            txtDescription.Text = currentLocation.Description + "\r\n(move #" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                btnCheck.Text = "Check " + hidingPlace.HidingPlaceName;
                btnCheck.Visible = true;
            }
            else
                btnCheck.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                btnGoThroughDoor.Visible = true;
            else
                btnGoThroughDoor.Visible = false;
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                txtDescription.Text = "You found your opponent in " + Moves
                + " moves! He was hiding " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            btnHide.Visible = true;
            btnGoHere.Visible = false;
            btnCheck.Visible = false;
            btnGoThroughDoor.Visible = false;
            cbExits.Visible = false;
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnHide.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                txtDescription.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            txtDescription.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            btnGoHere.Visible = true;
            cbExits.Visible = true;
            MoveToANewLocation(livingRoom);
        }


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGoHere = new System.Windows.Forms.Button();
            this.btnGoThroughDoor = new System.Windows.Forms.Button();
            this.cbExits = new System.Windows.Forms.ComboBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 12);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(407, 171);
            this.txtDescription.TabIndex = 0;
            // 
            // btnGoHere
            // 
            this.btnGoHere.Location = new System.Drawing.Point(12, 189);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(99, 23);
            this.btnGoHere.TabIndex = 1;
            this.btnGoHere.Text = "Go here:";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Visible = false;
            this.btnGoHere.Click += new System.EventHandler(this.btnGoHere_Click);
            // 
            // btnGoThroughDoor
            // 
            this.btnGoThroughDoor.Location = new System.Drawing.Point(12, 218);
            this.btnGoThroughDoor.Name = "btnGoThroughDoor";
            this.btnGoThroughDoor.Size = new System.Drawing.Size(406, 23);
            this.btnGoThroughDoor.TabIndex = 2;
            this.btnGoThroughDoor.Text = "Go through the door";
            this.btnGoThroughDoor.UseVisualStyleBackColor = true;
            this.btnGoThroughDoor.Visible = false;
            this.btnGoThroughDoor.Click += new System.EventHandler(this.btnGoThroughDoor_Click);
            // 
            // cbExits
            // 
            this.cbExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExits.FormattingEnabled = true;
            this.cbExits.Location = new System.Drawing.Point(133, 191);
            this.cbExits.Name = "cbExits";
            this.cbExits.Size = new System.Drawing.Size(285, 21);
            this.cbExits.TabIndex = 3;
            this.cbExits.Visible = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(12, 278);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(406, 23);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide!";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 248);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(406, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 313);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.cbExits);
            this.Controls.Add(this.btnGoThroughDoor);
            this.Controls.Add(this.btnGoHere);
            this.Controls.Add(this.txtDescription);
            this.Name = "Form1";
            this.Text = "Explore the House!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGoHere;
        private System.Windows.Forms.Button btnGoThroughDoor;
        private System.Windows.Forms.ComboBox cbExits;
        private Button btnHide;
        private Button btnCheck;


    }
}
