using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Clicker
{
    public partial class Clicker : Form
    {
        //Initialize Variables
        long perClick, num, upgradeCost, upgradeAutoCost, currentAuto, currentAuto2, currentAuto2Cost, currentAuto1;
        long auto3Cost, auto3Current;
        public Clicker()
        {
            //Set each variables with label's text
            InitializeComponent();
            perClick = long.Parse(perClickLabel.Text);
            num = long.Parse(numClickLabel.Text);
            upgradeCost = long.Parse(upgradeClickLabel.Text);
            upgradeAutoCost = long.Parse(upgradeCostAuto.Text);
            currentAuto = long.Parse(currentAutoClick.Text);
            currentAuto2 = long.Parse(autoClick2Current.Text);
            currentAuto2Cost = long.Parse(autoClick2Cost.Text);
            auto3Cost = long.Parse(Auto3Cost.Text);
            auto3Current = long.Parse(Auto3Current.Text);
            currentAuto1 = 0;
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            //dummyButton is for preventing user from clicking by just holding enter key.
            dummyButton.Focus();
            //When clicked Number of Clicks raise by perClick value.
            num += perClick;
            numClickLabel.Text = num.ToString();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            /*Upgrading the value by checking if you have enough clicks.
             *This is done by decrement of number of clicks by the cost.
             *Updating the cost of upgrade.
             *Updating the value by a fixed number.
             *Updating all text labels.
            */
            if (num >= upgradeCost)
            {
                num -= upgradeCost;
                numClickLabel.Text = num.ToString();
                upgradeCost += (long)(upgradeCost*0.2);
                upgradeClickLabel.Text = upgradeCost.ToString();
                perClick += 1;
                perClickLabel.Text = perClick.ToString();
            }
        }

        private void autoClickButton_Click(object sender, EventArgs e)
        {
            //See upgradeButton_Click comment.
            if (num >= upgradeAutoCost)
            {
                num -= upgradeAutoCost;
                numClickLabel.Text = num.ToString();
                upgradeAutoCost += (upgradeAutoCost/2);
                upgradeCostAuto.Text = upgradeAutoCost.ToString();
                currentAuto += 1;
                currentAutoClick.Text = (currentAuto1+=1).ToString();
            }
        }

        private void clickerTimer_Tick(object sender, EventArgs e)
        {
            /*The Timer is set on an interval of 100ms. 
             *Every 100ms, the number of clicks increment by the currentAuto value
             *The Label is then updated
            */
            num += currentAuto;
            numClickLabel.Text = num.ToString();
        }

        private void autoClickButton2_Click(object sender, EventArgs e)
        {
            //See upgradeButton_Click comment.
            if (num >= currentAuto2Cost)
            {
                num -= currentAuto2Cost;
                numClickLabel.Text = num.ToString();
                currentAuto2Cost += (currentAuto2Cost/2);
                autoClick2Cost.Text = currentAuto2Cost.ToString();
                currentAuto += 100;
                autoClick2Current.Text = (currentAuto2 += 100).ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /*The save is written using most basic TextWriter
             *It saves the value into a text file named status.txt line by line
             *Note: This is very insecure since you can modify the text file easily 
            */
            TextWriter tw = new StreamWriter("status.txt");

            tw.WriteLine(perClick);
            tw.WriteLine(num);
            tw.WriteLine(upgradeCost);
            tw.WriteLine(upgradeAutoCost);
            tw.WriteLine(currentAuto);
            tw.WriteLine(currentAuto2);
            tw.WriteLine(currentAuto2Cost);
            tw.WriteLine(currentAuto1);
            tw.WriteLine(auto3Cost);
            tw.WriteLine(auto3Current);

            tw.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            /*The load button loads the status.txt using TextReader
             *It loads the value line by line and updates them into the variables.
            */
            TextReader tr = new StreamReader("status.txt");

            perClick = long.Parse(tr.ReadLine());
            num = long.Parse(tr.ReadLine());
            upgradeCost = long.Parse(tr.ReadLine());
            upgradeAutoCost = long.Parse(tr.ReadLine());
            currentAuto = long.Parse(tr.ReadLine());
            currentAuto2 = long.Parse(tr.ReadLine());
            currentAuto2Cost = long.Parse(tr.ReadLine());
            currentAuto1 = long.Parse(tr.ReadLine());
            auto3Cost = long.Parse(tr.ReadLine());
            auto3Current = long.Parse(tr.ReadLine());

            numClickLabel.Text = num.ToString();
            upgradeClickLabel.Text = upgradeCost.ToString();
            perClickLabel.Text = perClick.ToString();
            upgradeCostAuto.Text = upgradeAutoCost.ToString();
            currentAutoClick.Text = currentAuto1.ToString();
            autoClick2Cost.Text = currentAuto2Cost.ToString();
            autoClick2Current.Text = currentAuto2.ToString();
            Auto3Cost.Text = auto3Cost.ToString();
            Auto3Current.Text = auto3Current.ToString();

            tr.Close();
        }

        private void Auto3Button_Click(object sender, EventArgs e)
        {
            //See upgradeButton_Click comment.
            if (num >= auto3Cost)
            {
                num -= auto3Cost;
                numClickLabel.Text = num.ToString();
                auto3Cost += (auto3Cost / 2);
                Auto3Cost.Text = auto3Cost.ToString();
                currentAuto += 10000;
                Auto3Current.Text = (auto3Current += 10000).ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            /* Reset button sets each of the value to its default
             * then it updates the labels.
            */
            perClick = 1;
            num = 0;
            upgradeCost = 20;
            upgradeAutoCost = 100;
            currentAuto = 0;
            currentAuto2 = 0;
            currentAuto2Cost = 10000;
            currentAuto1 = 0;
            auto3Cost = 10000000;
            auto3Current = 0;

            numClickLabel.Text = 0.ToString();
            upgradeClickLabel.Text = 20.ToString();
            perClickLabel.Text = 1.ToString();
            upgradeCostAuto.Text = 100.ToString();
            currentAutoClick.Text = 0.ToString();
            autoClick2Cost.Text = 10000.ToString();
            autoClick2Current.Text = 0.ToString();
            Auto3Cost.Text = 10000000.ToString();
            Auto3Current.Text = 0.ToString();
        }

        
    }
}
