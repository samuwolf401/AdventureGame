using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdventureGame
{
    public partial class adventureGame : Form
    {
        // Set up Random generator, and variable
        int page = 0;
        int randomValue;
        int wins = 0;
        int losses = 0;
        int score = 0;

        Random randGen = new Random();

        public adventureGame()
        {
            InitializeComponent();
        }

        private void AdventureGame_KeyDown(object sender, KeyEventArgs e)
        {
            headerLabel.Visible = false;
            //setting the page number
            if (e.KeyCode == Keys.M) //red button press
            {
                if (page == 0)
                {
                    page = 1;
                }
                else if (page == 1)
                {
                    page = 2;
                }
                else if (page == 2)
                {
                    page = 4;
                }
                else if (page == 3)
                {
                    page = 6;
                }
                else if (page == 4)
                {
                    //random
                    randomValue = randGen.Next(1,3);
                    if (randomValue == 1)
                    {
                        page = 1;
                    }
                    else
                    {
                        page = 36;
                    }
                }
                else if (page == 5)
                {
                    page = 8;
                }
                else if (page == 6)
                {
                    page = 12;
                }
                else if (page == 7)
                {
                    page = 13;
                }
                else if (page == 8)
                {
                    page = 9;
                }
                else if (page == 9)
                {
                    //random
                    randomValue = randGen.Next(1, 3);
                    if (randomValue == 1)
                    {
                        page = 10;
                    }
                    else
                    {
                        page = 11;
                    }
                }
                else if (page == 10)
                {
                    page = 0;
                }
                else if (page == 11)
                {
                    page = 0;
                }
                else if (page == 12)
                {
                    page = 0;
                }
                else if (page == 13)
                {
                    page = 24;
                }
                else if (page == 14)
                {
                    page = 15;
                }
                else if (page == 15)
                {
                    page = 7;
                }
                else if (page == 16)
                {
                    page = 0;
                }
                else if (page == 17)
                {
                    page = 18;
                }
                else if (page == 18)
                {
                    page = 0;
                }
                else if (page == 19)
                {
                    page = 20;
                }
                else if (page == 20)
                {
                    page = 22;
                }
                else if (page == 21)
                {
                    page = 34;
                }
                else if (page == 22)
                {
                    page = 0;
                }
                else if (page == 23)
                {
                    page = 0;
                }
                else if (page == 24)
                {
                    page = 25;
                }
                else if (page == 25)
                {
                    page = 29;
                }
                else if (page == 26)
                {
                    page = 27;
                }
                else if (page == 27)
                {
                    //random
                    randomValue = randGen.Next(1, 3);
                    if (randomValue == 1)
                    {
                        page = 30;
                    }
                    else
                    {
                        page = 31;
                    }
                }
                else if (page == 28)
                {
                    page = 0;
                }
                else if (page == 29)
                {
                    page = 32;
                }
                else if (page == 30)
                {
                    page = 0;
                }
                else if (page == 31)
                {
                    page = 0;
                }
                else if (page == 32)
                {
                    page = 0;
                }
                else if (page == 33)
                {
                    page = 0;
                }
                else if (page == 34)
                {
                    page = 0;
                }
                else if (page == 35)
                {
                    page = 0;
                }
                else if (page == 36)
                {
                    page = 0;
                }
                else if (page == 37)
                {
                    page = 0;
                }
            }
            else if (e.KeyCode == Keys.B) //blue button press
            {
                if (page == 0)
                {
                    //end program
                    outputLabel.Text = "Thank you for playing";
                    Refresh();
                    Thread.Sleep(1750);
                    Application.Exit();
                }
                else if (page == 1)
                {
                    page = 3;
                }
                else if (page == 2)
                {
                    page = 3;
                }
                else if (page == 3)
                {
                    page = 7;
                }
                else if (page == 4)
                {
                    //n/a
                }
                else if (page == 5)
                {
                    page = 6;
                }
                else if (page == 6)
                {
                    page = 13;
                }
                else if (page == 7)
                {
                    page = 15;
                }
                else if (page == 8)
                {
                    page = 7;
                }
                else if (page == 9)
                {
                    page = 35;
                }
                else if (page == 10)
                {
                // n/a
                }
                else if (page == 11)
                {
                // n/a
                }
                else if (page == 12)
                {
                    //n/a
                }
                else if (page == 13)
                {
                    page = 20;
                }
                else if (page == 14)
                {
                    page = 20;
                }
                else if (page == 15)
                {
                    //random
                    randomValue = randGen.Next(1, 4);
                    if (randomValue == 1)
                    {
                        page = 16;
                    }
                    else if (randomValue == 2)
                    {
                        page = 17;
                    }
                    else
                    {
                        page = 19;
                    }
                }
                else if (page == 16)
                {
                    //n/a
                }
                else if (page == 17)
                {
                    page = 19;
                }
                else if (page == 18)
                {
                    //n/a
                }
                else if (page == 19)
                {
                    page = 21;
                }
                else if (page == 20)
                {
                    page = 23;
                }
                else if (page == 21)
                {
                    page = 33;
                }
                else if (page == 22)
                {
                    //n/a
                }
                else if (page == 23)
                {
                    //n/a
                }
                else if (page == 24)
                {
                    page = 26;
                }
                else if (page == 25)
                {
                    page = 37;
                }
                else if (page == 26)
                {
                    page = 24;
                }
                else if (page == 27)
                {
                    page = 28;
                }
                else if (page == 28)
                {
                    //n/a
                }
                else if (page == 29)
                {
                    page = 9;
                }
                else if (page == 30)
                {
                    //n/a
                }
                else if (page == 31)
                {
                    //n/a
                }
                else if (page == 32)
                {
                    //n/a
                }
                else if (page == 33)
                {
                    //n/a
                }
                else if (page == 34)
                {
                    //n/a
                }
                else if (page == 35)
                {
                    //n/a
                }
                else if (page == 36)
                {
                    //n/a
                }
                else if (page == 37)
                {
                    //n/a
                }
            }
            else if (e.KeyCode == Keys.Space) //green button press
            {
                if (page == 0)
                {
                    page = randGen.Next(1,38);
                }
                else if (page == 2)
                {
                    page = 5;
                }
                else if (page == 7)
                {
                    page = 14;
                }
            }
            // going to the correct page
            switch (page)
            {
                case 0:
                    outputLabel.Text = $"Do You Want To Play again?";
                    redLabel.Text = $"Yes";
                    greenLabel.Text = $"Go to a random page";
                    blueLabel.Text = $"No";
                    imageBox.BackgroundImage = Properties.Resources.black;
                    break;
                case 1:
                    outputLabel.Text = $"You wake up in a dark room. You can feel the wall.\nDo you follow it to right or left?";
                    redLabel.Text = $"Right";
                    greenLabel.Text = $"";
                    blueLabel.Text = $"Left";
                    imageBox.BackgroundImage = Properties.Resources.black;
                    break;
                case 2:
                    outputLabel.Text = $"You find a light switch.\nThe room has a door, a vent, and a laundry shoot.\nWhere do you go?";
                    redLabel.Text = $"Through the Vent";
                    greenLabel.Text = $"Through the Door";
                    blueLabel.Text = $"Through the Laundry shoot";
                    imageBox.BackgroundImage = Properties.Resources.room;
                    break;
                case 3:
                    outputLabel.Text = $"You fall through a hole in the wall.\nYou find yourself in a pile of laundry.\nThere is a window and a elevator.\nWhere do you go?";
                    redLabel.Text = $"Take the Elevator";
                    blueLabel.Text = $"Go out the Window";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.laundry_room;
                    break;
                case 4:
                    outputLabel.Text = $"You get stuck in the vent, because this is not an action movie.";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.vent;
                    break;
                case 5:
                    outputLabel.Text = $"You find yourself in a hallway with a door going outside and an elevator going down.\nWhere do you go?";
                    redLabel.Text = $"Go Outside";
                    blueLabel.Text = $"Take the Elevator";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.hallway;
                    break;
                case 6:
                    outputLabel.Text = $"You find youself in a lab.\nPeople are coming in from the room next door. There is a window or a desk to hide behind.\nWhere do you go?";
                    redLabel.Text = $"Hide behind the Desk";
                    blueLabel.Text = $"Jump out the window";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.lab;
                    break;
                case 7:
                    outputLabel.Text = $"You are outside, there are three paths.\nWhich path do you take?";
                    redLabel.Text = $"The First Path";
                    blueLabel.Text = $"The Second Path";
                    greenLabel.Text = $"The Third Path";
                    imageBox.BackgroundImage = Properties.Resources.forest_path;
                    break;
                case 8:
                    outputLabel.Text = $"There is a truck with a key still in it, and a path thruogh the forest.\nWhere do you go?";
                    redLabel.Text = $"Take the Truck down the road.";
                    blueLabel.Text = $"Take the Forest Path";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.forest_path;
                    break;
                case 9:
                    outputLabel.Text = $"You take the road down to a security outpost. A guard asks for ID.\nWhat do you do?";
                    redLabel.Text = $"Say'I lost it'";
                    blueLabel.Text = $"Punch him in the face";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.booth;
                    break;
                case 10:
                    outputLabel.Text = $"He tells you to bring it next time.\nYou Escaped!!!";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.booth;
                    wins++;
                    break;
                case 11:
                    outputLabel.Text = $"He dosen't belive you. knocks you out.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.booth;
                    losses++;
                    break;
                case 12:
                    outputLabel.Text = $"The scientist find you and knock you out.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.lab;
                    losses++;
                    break;
                case 13:
                    outputLabel.Text = $"You find a lever on the forest path";
                    redLabel.Text = $"Pull the Lever";
                    blueLabel.Text = $"Follow the path";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.forest_path;
                    break;
                case 14:
                    outputLabel.Text = $"The pathe forks, one path goes uphill, one path goes downhill.\nWhere do you go?";
                    redLabel.Text = $"Go uphill";
                    blueLabel.Text = $"Go downhill";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.forest_path;
                    break;
                case 15:
                    outputLabel.Text = $"There is a cliff with a river a the bottom.";
                    redLabel.Text = $"Turn Back";
                    blueLabel.Text = $"Jump";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.river;
                    break;
                case 16:
                    outputLabel.Text = $"You jumped across the gap.\nYou find a fence with a hole in it.\nYou escaped!!!";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.fence;
                    wins++;
                    break;
                case 17:
                    outputLabel.Text = $"You grab the edge. A man offers his hand.";
                    redLabel.Text = $"Take his Hand";
                    blueLabel.Text = $"Let go and Fall";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.river;
                    break;
                case 18:
                    outputLabel.Text = $"The man pulls you up. Then he puts a tranqulizer needle in your neck.\nHe goes through you jugular vein, You bleed out.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.river;
                    losses++;
                    break;
                case 19:
                    outputLabel.Text = $"You land in a river and are taken down stream.\nYou wake up on a small beach in a lake. There is a canoe and a path";
                    redLabel.Text = $"Take the Path";
                    blueLabel.Text = $"Take the Canoe";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.lake;
                    break;
                case 20:
                    outputLabel.Text = $"There is a cave in the ground.";
                    redLabel.Text = $"Go in the Cave";
                    blueLabel.Text = $"Go around the Cave";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.cave;
                    break;
                case 21:
                    outputLabel.Text = $"You go down the lake and make it to a cabin and a small hut.";
                    redLabel.Text = $"Go in the Cabin";
                    blueLabel.Text = $"Go in the small Hut";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.lake;
                    break;
                case 22:
                    outputLabel.Text = $"A bear devours you.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.cave;
                    losses++;
                    break;
                case 23:
                    outputLabel.Text = $"You find a fence with missing barbed wire.\nYou climb it and get over the fence.\nYou escaped!!!";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.fence;
                    wins++;
                    break;
                case 24:
                    outputLabel.Text = $"There is a sewer system.";
                    redLabel.Text = $"Go Right";
                    blueLabel.Text = $"Go Left";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.sewer;
                    break;
                case 25:
                    outputLabel.Text = $"You follow to the left.\nThere is a ladder to go up.";
                    redLabel.Text = $"Go up the Ladder";
                    blueLabel.Text = $"Continue down the Tunnel";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.sewer_ladder;
                    break;
                case 26:
                    outputLabel.Text = $"You come to an area with  bars and rushing water.";
                    redLabel.Text = $"Slide through the Bars";
                    blueLabel.Text = $"Turn Back";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.sewer_opening;
                    break;
                case 27:
                    outputLabel.Text = $"You slide through the bars.\nSince it is wet you slip and start to fall.";
                    redLabel.Text = $"Grab the egde";
                    blueLabel.Text = $"Brace for impact";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.sewer_opening;
                    break;
                case 28:
                    outputLabel.Text = $"You made it safely down.\nYou escaped!!!";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.sewer_opening;
                    wins++;
                    break;
                case 29:
                    outputLabel.Text = $"There is a path and a road.";
                    redLabel.Text = $"Take the Path";
                    blueLabel.Text = $"Take the Road";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.forest_path;
                    break;
                case 30:
                    outputLabel.Text = $"You hit your head, and made it out.\nYou escaped!!!";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.sewer_opening;
                    wins++;
                    break;
                case 31:
                    outputLabel.Text = $"You grabed the edge and made it back up, but there is a gaurd waiting there.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.sewer_opening;
                    losses++;
                    break;
                case 32:
                    outputLabel.Text = $"You go down the path, a guard spots and shoots you.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.forest_path;
                    losses++;
                    break;
                case 33:
                    outputLabel.Text = $"An ancient evil posses your body and helps you escape.\nYou(and the evil force) Escaped!!!";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.little_forest_hut;
                    wins++;
                    break;
                case 34:
                    outputLabel.Text = $"The People in the cabin help you.\nThen they eat you.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.cabin;
                    losses++;
                    break;
                case 35:
                    outputLabel.Text = $"He didn't even flinch. He then shoots you.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.booth;
                    losses++;
                    break;
                case 36:
                    outputLabel.Text = $"You staved to death.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.vent;
                    losses++;
                    break;
                case 37:
                    outputLabel.Text = $"An Aligator eats you.\nYou lost...";
                    redLabel.Text = $"Continue";
                    blueLabel.Text = $"";
                    greenLabel.Text = $"";
                    imageBox.BackgroundImage = Properties.Resources.gator;
                    losses++;
                    break;
                default:
                    break;

            }
            #region //score calculator
            score = (wins - losses);
            winLabel.Text = $"{wins}";
            lossLabel.Text = $"{losses}";
            scoreLabel.Text = $"{score}";
            if (score >= 10)
            {
                outputLabel.Text = $"You are the champion you won with {wins} wins!";
                this.Text = "Champion!";
                Refresh();
                Thread.Sleep(1000);
            }
            else if (score <= -10)
            {
                outputLabel.Text = $"You are bad at this...\nYou are so bad I'm going to leave...";
                imageBox.BackgroundImage = Properties.Resources.black;
                Refresh();
                Thread.Sleep(2500);
                Application.Exit();
            }
            #endregion
        }
    }
}
