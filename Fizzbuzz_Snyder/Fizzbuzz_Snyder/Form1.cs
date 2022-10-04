using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fizzbuzz_Snyder
{
    public partial class Form1 : Form
    {
        //Variables
        int Count = 1;                                                      //The number that is being counted
        string OutputPlaceholder = "";                                      //An output placeholder string, it get's built up as more divisors are added
        List<FizzBuzzDivisor> Divisors = new List<FizzBuzzDivisor>();       //This list of divisors such as "Fizz" and "Buzz"

        public Form1()
        {
            //Divisors
            FizzBuzzDivisor Fizz = new FizzBuzzDivisor("Fizz", 3); Divisors.Add(Fizz);      //Fizz, gets added for numbers divisible by 3
            FizzBuzzDivisor Buzz = new FizzBuzzDivisor("Buzz", 5); Divisors.Add(Buzz);      //Buzz, gets added for numbers divisible by 5
            FizzBuzzDivisor Binn = new FizzBuzzDivisor("Binn", 150); Divisors.Add(Binn);    //Binn, my own divisor for numbers divisibile by 150, added to
                                                                                            //show the scalability of this implementation

            InitializeComponent();
        }

        public void NextNum() 
        {
            //Calculates what the next number/phrase should be
            foreach (FizzBuzzDivisor Divisor in Divisors)
            {
                if (IsDivisible(Count, Divisor.Divisor)) OutputPlaceholder += Divisor.Name;
            }

            if (OutputPlaceholder == "") OutputPlaceholder += Count;

            //Sending Output
            rtb_Output.Text += OutputPlaceholder + System.Environment.NewLine;

            //Reseting and advancing variables
            Count++;
            OutputPlaceholder = "";
        }

        //Checks to see if Num1 is divisible by Num2
        public bool IsDivisible(int Num1, int Num2) 
        {
            if ((Num1 % Num2) == 0) return true;
            return false;
        }

        //The next button
        private void btn_Next_Click(object sender, EventArgs e) 
        {
            NextNum();  
        }

        //Same as the next button, but advances by 100
        private void btn_Next100_Click(object sender, EventArgs e) 
        {
            for (int i = 0; i < 100; i++)
            {
                NextNum();
            }
        }

        //Resets the game
        private void btn_Reset_Click(object sender, EventArgs e) 
        {
            Count = 1;
            rtb_Output.Clear();
        }

        //Auto scrolls the output text box to the bottom
        private void rtb_Output_TextChanged(object sender, EventArgs e) 
        {
            rtb_Output.SelectionStart = rtb_Output.Text.Length;
            rtb_Output.ScrollToCaret();
        }

        //Hyper link for more information on what Fizz buzz is
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            Process.Start("https://en.wikipedia.org/wiki/Fizz_buzz");
        }
    }

    //The divisor class, has a name and divisor for each FizzBuzzDivisor
    public class FizzBuzzDivisor {  
        public string Name;
        public int Divisor;

        public FizzBuzzDivisor(string input_Name, int input_Divisor)
        {
            Name = input_Name;
            Divisor = input_Divisor;
        }
    }
}
