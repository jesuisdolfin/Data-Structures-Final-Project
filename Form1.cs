using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresFinalGUI
{
    public partial class Form1 : Form
    {

        LinkedList<Player> pool = new LinkedList<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Generates Second Team
        private void button1_Click(object sender, EventArgs e)
        {
            Player[] final = makeSecondTeam();

            textBox9.Text = final[0].name;
            textBox10.Text = final[1].name;
            textBox11.Text = final[2].name;
            textBox12.Text = final[3].name;
            textBox13.Text = final[4].name;
        }

        // Generates First Team
        private void button2_Click(object sender, EventArgs e)
        {
            Player[] final = makeFirstTeam();

            textBox5.Text = final[0].name;
            textBox3.Text = final[1].name;
            textBox4.Text = final[2].name;
            textBox2.Text = final[3].name;
            textBox1.Text = final[4].name;
        }

        // Enters player data into a Linked List and displays entered data on GUI
        private void button3_Click(object sender, EventArgs e)
        {

            string newName = textBox6.Text;
            if (newName.Contains('1') || newName.Contains('2') || newName.Contains('1') || newName.Contains('3') ||
                newName.Contains('4') || newName.Contains('5') || newName.Contains('6') || newName.Contains('7') ||
                newName.Contains('8') || newName.Contains('9'))
            {
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                throw new IllegalNameException();
            }
            string newPosition = textBox7.Text;
            if (newPosition.Length > 1)
            {
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                throw new IllegalPositionException();
            }
            string rating = textBox8.Text;
            for (int i = 0; i < rating.Length; i++)
            {
                if (rating[i] >= 'a' && rating[i] <= 'z' || rating[i] >= 'A' && rating[i] <= 'Z')
                {
                    throw new IllegalRatingException();
                }
            }
            int newRating = int.Parse(textBox8.Text);




            Player newPlayer = new Player(newName, newPosition, newRating);
            label16.Text += "Name: " + newPlayer.name + ", Position: " + newPlayer.position + ", Rating: " + newPlayer.rating + "\n";

            insert(newPlayer);
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            
        }

        // Inserts player data into Linked List
        private void insert(Player newPlayer)
        {
            pool.AddLast(newPlayer);
        }

        // Determine which players make up the second team
        public Player[] makeSecondTeam()
        {

            // Temporary linked lists to make separating positions easier
            LinkedList<Player> centers = new LinkedList<Player>();
            LinkedList<Player> forwards = new LinkedList<Player>();
            LinkedList<Player> guards = new LinkedList<Player>();

            foreach (Player element in pool)
            {
                if (element.position == "C")
                {
                    centers.AddLast(element);
                }
                else if (element.position == "F")
                {
                    forwards.AddLast(element);
                }
                else
                {
                    guards.AddLast(element);
                }
            }

            Player[] centersArray = new Player[centers.Count];
            for (int i = 0; i <= centers.Count + 1; ++i)
            {
                if (i == centers.Count)
                {
                    centersArray[i] = centers.Last.Value;
                }
                else
                {
                    centersArray[i] = centers.First.Value;
                    centers.RemoveFirst();
                }
            }
            Player[] forwardsArray = new Player[forwards.Count];
            for (int i = 0; i <= forwards.Count + 1; ++i)
            {
                if (i == forwards.Count)
                {
                    forwardsArray[i] = forwards.Last.Value;
                }
                else
                {
                    forwardsArray[i] = forwards.First.Value;
                    forwards.RemoveFirst();
                }
            }
            Player[] guardsArray = new Player[guards.Count];
            for (int i = 0; i <= guards.Count + 1; ++i)
            {
                if (i == guards.Count)
                {
                    guardsArray[i] = guards.Last.Value;
                }
                else
                {
                    guardsArray[i] = guards.First.Value;
                    guards.RemoveFirst();
                }
            }
            insertionSort(centersArray);
            insertionSort(forwardsArray);
            insertionSort(guardsArray);

            // Build final team
            Player[] final = new Player[5];

            final[0] = centersArray[centersArray.Length - 2];
            final[1] = forwardsArray[forwardsArray.Length - 3];
            final[2] = forwardsArray[forwardsArray.Length - 4];
            final[3] = guardsArray[guardsArray.Length - 3];
            final[4] = guardsArray[guardsArray.Length - 4];

            return final;
        }

        // Determine which players make up the first team
        public Player[] makeFirstTeam()
        {

            // Temporary linked lists to make separating positions easier
            LinkedList<Player> centers = new LinkedList<Player>();
            LinkedList<Player> forwards = new LinkedList<Player>();
            LinkedList<Player> guards = new LinkedList<Player>();

            foreach (Player element in pool)
            {
                if (element.position == "C")
                {
                    centers.AddLast(element);
                }
                else if (element.position == "F")
                {
                    forwards.AddLast(element);
                }
                else
                {
                    guards.AddLast(element);
                }
            }

            Player[] centersArray = new Player[centers.Count];
            for (int i = 0; i <= centers.Count + 1; ++i)
            {
                if (i == centers.Count)
                {
                    centersArray[i] = centers.Last.Value;
                }
                else
                {
                    centersArray[i] = centers.First.Value;
                    centers.RemoveFirst();
                }
            }
            Player[] forwardsArray = new Player[forwards.Count];
            for (int i = 0; i <= forwards.Count + 1; ++i)
            {
                if (i == forwards.Count)
                {
                    forwardsArray[i] = forwards.Last.Value;
                }
                else
                {
                    forwardsArray[i] = forwards.First.Value;
                    forwards.RemoveFirst();
                }
            }
            Player[] guardsArray = new Player[guards.Count];
            for (int i = 0; i <= guards.Count + 1; ++i)
            {
                if (i == guards.Count)
                {
                    guardsArray[i] = guards.Last.Value;
                }
                else
                {
                    guardsArray[i] = guards.First.Value;
                    guards.RemoveFirst();
                }
            }
            insertionSort(centersArray);
            insertionSort(forwardsArray);
            insertionSort(guardsArray);

            // Build final team
            Player[] final = new Player[5];

            final[0] = centersArray[centersArray.Length - 1];
            final[1] = forwardsArray[forwardsArray.Length - 1];
            final[2] = forwardsArray[forwardsArray.Length - 2];
            final[3] = guardsArray[guardsArray.Length - 1];
            final[4] = guardsArray[guardsArray.Length - 2];

            return final;
        }

        // Sorting method to organize players by rating
        public static void insertionSort(Player[] pool)
        {
            for (int i = 1; i < pool.Length; i++)
            {
                Player val = pool[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.rating < pool[j].rating)
                    {
                        pool[j + 1] = pool[j];
                        j--;
                        pool[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
        }

        // Printing method used for testing
        public string print(Player[] team)
        {
            string teamString = "Team: \n";
            foreach (Player element in team)
            {
                teamString += element.name + ", " + element.position + ", " + element.rating + "\n";
            }
            return teamString;
        }
    }
}
