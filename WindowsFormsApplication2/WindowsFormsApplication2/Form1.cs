using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//                                      Disclaimer

 
//Den mou aresei katholou etc opws to exw kanei.
//Einai leitourgiko kai logika kanei auto pou zhtate alla den maresei.
//Mexri th kuriakh an exw xrono kai empneush tha prospathhsw na to kanw kalutero(programmatistika)
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {//edw kanoume thn class 
        public class RNJesus
        {//edw ftiaxnoume method pou epistrefei to tuxaio noumero.to 1000 einai apla ena orio.
            Random rnd =new Random();
            public int RNG()

            {return rnd.Next(0,1000);}
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//ftiaxnoume to object kai 2 pinakes
            RNJesus a = new RNJesus();
            int[] sum = new int[5];
            int[] RNG = new int[5];
            //ftiaxnoume ta 5 random numera kai ta vazoume se pinaka
            RNG[0]= a.RNG();
            RNG[1] = a.RNG();
            RNG[2] = a.RNG();
            RNG[3] = a.RNG();
            RNG[4] = a.RNG();
            //vazoume ta athroismata se allo pinaka
            sum[0] = RNG[0];
            sum[1] = RNG[0] + RNG[1];
            sum[2] = RNG[0] + RNG[1] + RNG[2];
            sum[3] = RNG[0] + RNG[1] + RNG[2] + RNG[3];
            sum[4] = RNG[0] + RNG[1] + RNG[2] + RNG[3] + RNG[4];
           
            //thetoume tis times sta lables apo prin kai meta apla ta emfanizoume
            label1.Text = Convert.ToString(RNG[0]);
            label2.Text = Convert.ToString(RNG[1]);
            label3.Text = Convert.ToString(RNG[2]);
            label4.Text = Convert.ToString(RNG[3]);
            label5.Text = Convert.ToString(RNG[4]);
            label6.Text = Convert.ToString(sum[0]);
            label7.Text = Convert.ToString(sum[1]);
            label8.Text = Convert.ToString(sum[2]);
            label9.Text = Convert.ToString(sum[3]);
            label10.Text = Convert.ToString(sum[4]);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {   //otan kanoume diplo click elegxoume pio label einai energo ekeinh th stigmh 
            //gia na emfanisoume to antistoixo athroisma
            //kai stamatame to epomeno timer
            if ((label1.Visible) == true)
                 {
                timer2.Stop();
                label6.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
                
            }
            else if ((label2.Visible) == true)
                 {
                timer3.Stop();
                label7.Visible = true;
                button2.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
            }
            else if ((label3.Visible) == true)
                 {
                timer4.Stop();
                label8.Visible = true;
                button3.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
            }
            else if ((label4.Visible) == true)
                {
                timer5.Stop();
                label9.Visible = true;
                button4.Visible = true;
                button6.Visible = true;
                button7.Visible = false;
            }
            else if ((label5.Visible) == true)
                 {
                label10.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                 }
        }
         
        //to kathe timer perimenei 5 sec.Meta ksekinaei to epomeno timer kai emfanizei to current label
        //kai stamataei to current timer
        private void timer1_Tick(object sender, EventArgs e)
        {  
            timer1.Interval = 5000;
            timer2.Start();
            label1.Visible = true;
            timer1.Stop();
        }
        //sta epomena apla kruvei to prohgoumeno label gia na doulepsei to parapanw IF
        private void timer2_Tick(object sender, EventArgs e)
        { 
            timer2.Interval = 5000;
            label2.Visible = true;
            label1.Visible = false;
            timer3.Start();
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 5000;
            timer4.Start();
            label3.Visible = true;
            label2.Visible = false;
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer5.Start();
            label4.Visible = true;
            label3.Visible = false;
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        { 
            timer5.Interval = 5000;
           label5.Visible = true;
            label4.Visible = false;
            timer5.Stop();
            //edw stamataei to teleuteo programma kai emfanizei to teliko athroisma
            label10.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {//edw ksekinaei h alusida.Mporousa na to kanw k alliws alla protimhsa auto
            timer1.Start();
            button1.Visible = false;
            button7.Visible = true;
        }
        //edw ftiaxnw koumpi gia na emfanizei ta prohgoumena noumera gia epalhtheush
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }
    }
}
