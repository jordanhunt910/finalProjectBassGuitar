using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    /* Bass Guitar
     * WinForms App
     * This application allows the user to play a bass guitar with the keyboard or mouse
     * Jordan Hunt
     * Date Created 20 November 2019
     * Date Revised 8 December 2019
     */
    public partial class Form1 : Form
    {
        public bool KeyPreview { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        int noteLength = 200
           ;

        #region EString
        private void EStringOpen()
        {
            Console.Beep(41, noteLength);
        }
        private void EStringFirstFret()
        {
            Console.Beep(44, noteLength);
        }
        private void EStringSecondFret()
        {
            Console.Beep(46, noteLength);
        }
        private void EStringThirdFret()
        {
            Console.Beep(49, noteLength);
        }
        private void EStringFourthFret()
        {
            Console.Beep(52, noteLength);
        }
        #endregion
        #region AString
        private void AStringOpen()
        {
            Console.Beep(55, noteLength);
        }
        private void AStringFirstFret()
        {
            Console.Beep(58, noteLength);
        }
        private void AStringSecondFret()
        {
            Console.Beep(62, noteLength);
        }
        private void AStringThirdFret()
        {
            Console.Beep(65, noteLength);
        }
        private void AStringFourthFret()
        {
            Console.Beep(69, noteLength);
        }
        #endregion
        #region DString
        private void DStringOpen()
        {
            Console.Beep(73, noteLength);
        }
        private void DStringFirstFret()
        {
            Console.Beep(78, noteLength);
        }
        private void DStringSecondFret()
        {
            Console.Beep(82, noteLength);
        }
        private void DStringThirdFret()
        {
            Console.Beep(87, noteLength);
        }
        private void DStringFourthFret()
        {
            Console.Beep(93, noteLength);
        }
        #endregion
        #region GString
        private void GStringOpen()
        {
            Console.Beep(98, noteLength);
        }
        private void GStringFirstFret()
        {
            Console.Beep(104, noteLength);
        }
        private void GStringSecondFret()
        {
            Console.Beep(110, noteLength);
        }
        private void GStringThirdFret()
        {
            Console.Beep(117, noteLength);
        }
        private void GStringFourthFret()
        {
            Console.Beep(124, noteLength);
            
        }
        private void GStringFifthFret()
        {
            Console.Beep(131, noteLength);
        }
        #endregion
        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button34_Click(object sender, EventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {

        }
        #region EString

        private void EStringOpen_Click(object sender, EventArgs e)
        {
            EStringOpen();
            
        }
        private void EStringFirstFret_Click(object sender, EventArgs e)
        {
            EStringFirstFret();
        }
        private void EStringSecondFret_Click(object sender, EventArgs e)
        {
            EStringSecondFret();
        }
        private void EStringThirdFret_Click(object sender, EventArgs e)
        {
            EStringThirdFret();
        }
        private void EStringFourthFret_Click(object sender, EventArgs e)
        {
            EStringFourthFret();
        }
        private void EStringFifthFret_Click(object sender, EventArgs e)
        {
            AStringOpen();
        }
        #endregion
        #region AString
        private void AStringOpen_Click(object sender, EventArgs e)
        {
            AStringOpen();
        }
        private void AStringFirstFret_Click(object sender, EventArgs e)
        {
            AStringFirstFret();
        }
        private void AStringSecondFret_Click(object sender, EventArgs e)
        {
            AStringSecondFret();
        }
        private void AStringThirdFret_Click(object sender, EventArgs e)
        {
            AStringThirdFret();
        }
        private void AStringFourthFret_Click(object sender, EventArgs e)
        {
            AStringFourthFret();
        }
        private void AStringFifthFret_Click(object sender, EventArgs e)
        {
            DStringOpen();
        }
        #endregion

        #region dString
        private void DStringOpen_Click(object sender, EventArgs e)
        {
            DStringOpen();
        }
        private void DStringFirstFret_Click(object sender, EventArgs e)
        {
            DStringFirstFret();
        }
        private void DStringSecondFret_Click(object sender, EventArgs e)
        {
            DStringSecondFret();
        }
        private void DStringThirdFret_Click(object sender, EventArgs e)
        {
            DStringThirdFret();
        }
        private void DStringFourthFret_Click(object sender, EventArgs e)
        {
            DStringFourthFret();
        }
        private void DStringFifthFret_Click(object sender, EventArgs e)
        {
            GStringOpen();
        }
        #endregion
        #region gString
        private void GStringOpen_Click(object sender, EventArgs e)
        {
            GStringOpen();
        }
        private void GStringFirstFret_Click(object sender, EventArgs e)
        {
            GStringFirstFret();
        }
        private void GStringSecondFret_Click(object sender, EventArgs e)
        {
            GStringSecondFret();
        }
        private void GStringThirdFret_Click(object sender, EventArgs e)
        {
            GStringThirdFret();
        }
        private void GStringFourthFret_Click(object sender, EventArgs e)
        {
            GStringFourthFret();
        }
        private void GStringFifthFret_Click(object sender, EventArgs e)
        {
            GStringFifthFret();
        }
        #endregion

        private void EStringOpen_KeyPress(object sender, KeyEventArgs e)
        {
            
        }
        private void EStringOpen_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void EStringOpen_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void keyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    DStringOpen();
                    break;
                case Keys.Up:
                    GStringOpen();
                    break;
                case Keys.Right:
                    AStringOpen();
                    break;
                case Keys.Down:
                    EStringOpen();
                    break;
                case Keys.D1:
                    GStringFirstFret();
                    break;
                case Keys.D2:
                    GStringSecondFret();
                    break;
                case Keys.D3:
                    GStringThirdFret();
                    break;
                case Keys.D4:
                    GStringFourthFret();
                    break;
                case Keys.D5:
                    GStringFifthFret();
                    break;
                case Keys.Q:
                    DStringFirstFret();
                    break;
                case Keys.W:
                    DStringSecondFret();
                    break;
                case Keys.E:
                    DStringThirdFret();
                    break;
                case Keys.R:
                    DStringFourthFret();
                    break;
                case Keys.T:
                    GStringOpen();
                    break;
                case Keys.A:
                    AStringFirstFret();
                    break;
                case Keys.S:
                    AStringSecondFret();
                    break;
                case Keys.D:
                    AStringThirdFret();
                    break;
                case Keys.F:
                    AStringFourthFret();
                    break;
                case Keys.G:
                    DStringOpen();
                    break;
                case Keys.Z:
                    EStringFirstFret();
                    break;
                case Keys.X:
                    EStringSecondFret();
                    break;
                case Keys.C:
                    EStringThirdFret();
                    break;
                case Keys.V:
                    EStringFourthFret();
                    break;
                case Keys.B:
                    AStringOpen();
                    break;
                default:
                    break;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        static void TextBox26_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox25_TextChanged(object sender, EventArgs e)
        {
        }
    }
    }

