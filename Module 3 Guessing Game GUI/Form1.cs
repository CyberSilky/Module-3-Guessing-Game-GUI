﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_3_Guessing_Game_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            //create a definite loop constant
            const int MAX_GUESSES = 10;

            //create varibales
            int system_guess;
            int user_guess;
            int counter = 1;
            bool gotIt = false;

            //create a random number
            Random random = new Random();
            system_guess = random.Next(1, 1001);

            //guessing loop
            while (counter <= MAX_GUESSES)
            {
                //ask the user to guess
                Write("Please enter a number between 1 and 1000: ");

                //retrieve the number from the user
                user_guess = int.Parse(ReadLine());

                //decide if the user guessed the correct number
                if (system_guess == user_guess)
                {
                    WriteLine($"The number is {user_guess} - you guessed it!");
                    gotIt = true;
                    break;
                }
                else if (system_guess < user_guess)
                {
                    WriteLine("Wrong answer! Go lower!");
                }
                else
                {
                    WriteLine("Wrong answer! Go higher!");
                }
                counter++;
            }

            if (gotIt == true)
            {
                WriteLine("You won! Great job! Bye!");
            }
            else
            {
                WriteLine($"Sorry you lost the number was {system_guess} - maybe next time - bye!!");
            }
        }
    }
}
