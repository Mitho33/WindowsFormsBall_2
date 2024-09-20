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

namespace WindowsFormsBall_2
{
    public partial class FormBall : Form
    //In der Form werden 12 Panel erzeugt in von Panel1 -12 benannt , erhalten grauen Hintergrund ( weitere Formatierung siehe Abbildung)
    //ein Button wird erzeugt und in  Ball umbenannt und blauer Hintergrund (Eigenschaft)
    //der Button erhält noch das Ereignis keydown mit der Bezeichnung BallKey

    {

       int bewegung=5;//Variable für die Bewegung bzw. Schrittgröße
        int counter = 0;//Zähler für den Timer
      
 


        public FormBall()//Form1 wird erzeugt       
        {
            InitializeComponent();//Steuerelemente werden intialisiert
            Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
            Ball.Left = 100;

        }
        
      

        private void BallKey(object sender, KeyEventArgs keyEventArgs)//

        {
            timer1.Start();//Timer wird gestartet
         
            //if (keyEventArgs.KeyCode ==(Keys.ShiftKey | Keys.W))//schneller oben

            //  {
            //      Ball.Top -= bewegung2;
            //  }

            if (keyEventArgs.KeyCode == Keys.W)//W-Taste

            {
                Ball.Top -= bewegung;

            }

            if (keyEventArgs.KeyCode == Keys.ShiftKey)//Beschleunigung

            {
                bewegung=30;
            }

            if (keyEventArgs.KeyCode == Keys.S)//unten

            {
                Ball.Top += bewegung;
            }

            if (keyEventArgs.KeyCode == Keys.A)//Space=Leertaste

            {
                Ball.Left -= bewegung;
            }
            if (keyEventArgs.KeyCode == Keys.D)//Space=Leertaste

            {
                Ball.Left += bewegung;
            }

            if ((keyEventArgs.KeyCode == Keys.W) && (keyEventArgs.KeyCode == Keys.D))//DIAGONAL NACH rechts OBEN

            {
            }

            if ((keyEventArgs.KeyCode == Keys.S) && (keyEventArgs.KeyCode == Keys.D))//DIAGONAL NACH rechts unten

            {
                //keine Anweisungen nötig,da Anweisungen übernommen werden
            }


            if ((keyEventArgs.KeyCode == Keys.W) && (keyEventArgs.KeyCode == Keys.ShiftKey))//schneller NACH OBEN

            {
            }

            if ((keyEventArgs.KeyCode == Keys.ShiftKey) && (keyEventArgs.KeyCode == Keys.D))//rechts schnell

            {
            }

            //Kollision

            if (Ball.Bounds.IntersectsWith(Panel1.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }

            if (Ball.Bounds.IntersectsWith(Panel2.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }

            if (Ball.Bounds.IntersectsWith(Panel3.Bounds))
            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }

            if (Ball.Bounds.IntersectsWith(Panel4.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }


            if (Ball.Bounds.IntersectsWith(Panel5.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }

            if (Ball.Bounds.IntersectsWith(Panel6.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }


            if (Ball.Bounds.IntersectsWith(Panel7.Bounds))

            {
                timer1.Stop();
                //Message Box-Aufbau: Erst Text inkl. Variable, dann Name der Box und dann Button, getrennt jeweisl durch Komma
                MessageBox.Show("Ziel erreicht in "+ counter+" Sekunden", "Spielende",  MessageBoxButtons.OK);

                Close();
            }


            if (Ball.Bounds.IntersectsWith(Panel9.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }
            if (Ball.Bounds.IntersectsWith(Panel10.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }
            if (Ball.Bounds.IntersectsWith(Panel11.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }
            if (Ball.Bounds.IntersectsWith(Panel2.Bounds))

            {
                Ball.Top = 100;//Ausgangspostion des Balls, Nullpunkt links oben
                Ball.Left = 100;
            }

        }
        //Timer wird mit Toolbox unter der Form eingefügt und kann wie jedes Steuerelement bearbeitet werden
        //Methode für den Timer, addiert immer bei jedem Tick , über den Ereignishändler das Intervall auf eine Sekunde (1000) gestellt.
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }

      
    }

