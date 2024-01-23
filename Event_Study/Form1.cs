using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Study
{
    public partial class Form1 : Form
    {
        Calculation cal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cal = new Calculation();



            cal.EndCalculation += Cal_EndCalculation;

            
        }

        private void Cal_EndCalculation(object sender, int result)
        {
            MessageBox.Show(result.ToString());
        }
        public void A(object sender, int result)
        { 
        
        }
        private void Cal_EndCalculation1(object sender, int result)
        {
            MessageBox.Show(result.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cal.Calc(1, 2);
            cal.Calc(2, 4);
        }
    }
}
