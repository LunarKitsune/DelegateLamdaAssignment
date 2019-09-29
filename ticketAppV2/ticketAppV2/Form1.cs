/*
 * TO DO:
 *  FIX this formatting for delegate result
 * 
 *  +lamda true/false needs to be fixed so results come out the way it needs to
 *  +Fine not being calculated correctly in some methods
 *  +Need to get validate ID button working. Possibly not working over not assigning
 *  the result to the rich text box text. 
 */ 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketAppV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //professor Basillico says: only you can prevent code smells and spaggetti. 
        Officer Basillico = new Officer();
        bool inputError = false;

        private void BtnInterfaceCalc_Click(object sender, EventArgs e)
        {
            ValidateInput();

            if (!inputError)
            {
                rtbFineOutput.Text = Basillico.fineMessage();
            }

        }

        private void BtnDelegateCalc_Click(object sender, EventArgs e)
        {
            ValidateInput();

            if (!inputError)
            {
                rtbFineOutput.Text = Basillico.DelegateResult();
            }

        }

        private void BtnLamdaBool_Click(object sender, EventArgs e)
        {
            ValidateInput();

            if (!inputError)
            {
                rtbFineOutput.Text = Basillico.LamdaBoolResult();
            }
        }

        private void BtnLamdaCalc_Click(object sender, EventArgs e)
        {
            ValidateInput();

            if(!inputError)
            {
                rtbFineOutput.Text = Basillico.LamdaResult();
            }
        }

        private void btnValidateID_Click(object sender, EventArgs e)
        {
            string result = Basillico.validateID(txtIDInput.Text);
        }

        private void ValidateInput()
        {
            try
            {
                Basillico.DetectedSpeed = double.Parse(txtSpeedInput.Text);
                Basillico.EnforedSpeed = double.Parse(txtFastLimitInput.Text);
                
                inputError = false;
            }
            catch
            {
                MessageBox.Show("Input Error", "Input");
                inputError = true;
            }
        }

    }
}
