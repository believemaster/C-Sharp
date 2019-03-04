using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            //HardCoded
            //    Animal lion = new Animal("Lion", 25, 2000, 3000.56m);   // "m" is used to make sure the compiler that this is a decimal value as by default it takes double value

            //    lblResult.Text = $"Animal Name: {lion.Name}\nAnimal Age: {lion.Age}\nAnimal Power: {lion.Power}\nAnimal Speed: {lion.Speed}";

            Animal lion = new Animal(txtBoxName.Text, int.Parse(txtBoxAge.Text), decimal.Parse(txtBoxPower.Text), decimal.Parse(txtBoxSpeed.Text));

            lblResult.Text = $"Animal Name: {lion.Name}\nAnimal Age: {lion.Age}\nAnimal Power: {lion.Power}\nAnimal Speed: {lion.Speed}";

            lion.IncreaseAge(4);    // if we assign -ve value eg. -2 it don't take as we applied condition in animal class

            lblIncreaseAge.Text = lion.Age + "" ;   //concatinate the int to string value easy trick to convert int to string

            lion.IncreasePower(5.6m);      //decimal cannot converted to int but int can be connverted to decimal

            lblIncreasePower.Text = lion.Power + "";

            lion.IncreaseSpeed(15);

            lblIncreaseSpeed.Text = lion.Speed + "";

            
        }
    }
}
