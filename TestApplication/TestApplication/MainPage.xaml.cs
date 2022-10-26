using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private string[] alpha = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
    "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
    "W", "X", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8",
"9", "0", " "};

        private string[] morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
    "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
    "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
    "-.--", "--..", ".----", "..---", "...--", "....-", ".....",
"-....", "--...", "---..", "----.", "-----", "|"};


        string currentMorse = "";
        string currentWord = "";


        //checks for the morse and convers to a letter
        //it then updates the morse code and and currentLetter into that
        void Button_Pressed(System.Object sender, System.EventArgs e)
        {
            var indexOfMorseList = morse.ToList().IndexOf(currentMorse);
            try {
                LabelForWord.Text += alpha[indexOfMorseList];
            }
            catch (Exception ex)
            {
                morseError.Text = "Incorrect Morse";
            }
            finally
            {
                currentMorse = "";
                LabelForMorse.Text = currentMorse;

            }
     
            
        }


        //enters a dot to the current morse
        void Dot_Pressed(System.Object sender, System.EventArgs e)
        {
            currentMorse += '.';
            LabelForMorse.Text = currentMorse;
            morseError.Text = "";
            
        }


        //enters a dash to the morse 
        void Dash_Pressed(System.Object sender, System.EventArgs e)
        {
            currentMorse += '-';
            LabelForMorse.Text = currentMorse;
            morseError.Text = "";
        }


     

        //clears out your current word
        void Clear_Word(System.Object sender, System.EventArgs e)
        {
            currentWord = "";
            LabelForWord.Text = currentWord;
        }

        //clears the current morse
        void Clear_Morse(System.Object sender, System.EventArgs e)
        {
            currentMorse = "";
            LabelForMorse.Text = currentMorse;
      
        }
        
    }
}

