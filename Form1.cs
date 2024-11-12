using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06_P02_First_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double OilChangeCharges, LubeCharges, RadiatorFlushCharges, TransmissionFlushCharges, InspectionCharges, MufflerCharges, TireRotationCharges, PartsCharges, LaborCharges, TaxCharges, TotalCharges, ServiceAndLaborCharges;

            // This is a method that checks the checkbox for oil change and returns the charges to the user.

            if (OilChangeCheckBox.Checked)
            {
                OilChangeCharges = 50.00;
            }
            else
            {
                OilChangeCharges = 0.00;
            }

            //—Returns the charges for an oil change, if selected.

            // This is a method that checks the checkbox for lube job and returns the charges to the user.
            if (LubeJobCheckBox.Checked)
            {
                LubeCharges = 40.00;
            }
            else
            {
                LubeCharges = 0.00;
            }

            //—Returns the charges for a lube job, if selected.


            // This is a method that checks the checkbox for radiator flush and returns the charges to the user.
            if (RadiatorFlushCheckBox.Checked)
            {
                RadiatorFlushCharges = 100.00;
            }
            else
            {
                RadiatorFlushCharges = 0.00;
            }

            //—Returns the charges for a radiator flush, if selected.


            // This is a method that checks the checkbox for transmission flush and returns the charges to the user.
            if (TransmissionFlushCheckBox.Checked)
            {
                TransmissionFlushCharges = 120.00;
            }
            else
            {
                TransmissionFlushCharges = 0.00;
            }

            //—Returns the charges for a transmission flush, if selected.


            // This is a method that checks the checkbox for inspection and returns the charges to the user.
            if (InspectionCheckBox.Checked)
            {
                InspectionCharges = 35.00;
            }
            else
            {
                InspectionCharges = 0.00;
            }

            //—Returns the charges for an inspection, if selected.


            // This is  a method that checks the checkbox for muffler replacement and returns the charges to the user.
            if (ReplaceMufflerCheckBox.Checked)
            {
                MufflerCharges = 150.00;
            }
            else
            {
                MufflerCharges = 0.00;
            }

            //—Returns the charges for a muffler replacement, if selected.


            // This is a method that checks the checkbox for tire rotation and returns the charges to the user.
            if (TireRotationCheckBox.Checked)
            {
                TireRotationCharges = 25.00;
            }
            else
            {
                TireRotationCharges = 0.00;
            }

            //—Returns the charges for a tire rotation, if selected.


            // This is a method that calculates the charges for parts and returns them to the user.
            double.TryParse(PartsTextBox.Text, out PartsCharges);

            PartsOutputTextBox.Text = PartsCharges.ToString("c");


            //—Returns the charges for parts, if applicable.


            // This is a method that calculates the labor charges and returns them to the user.
            double.TryParse(LaborTextBox.Text, out LaborCharges);
            LaborCharges = LaborCharges * 75.00;
            // Multiply the labor hours by $75.00 per hour


            //—Returns the charges for labor, if applicable.



            //This is a method that calculates the taxes on parts and returns them to the user.
            TaxCharges = PartsCharges * 0.09;
            TaxOutputTextBox.Text = TaxCharges.ToString("c");



            //The minimum combined 2024 sales tax rate for Kansas City, Missouri is 8.99%.
            //This is the total of state, county, and city sales tax rates. 
            //—Returns the taxes on parts, if applicable.


            //This is a method that calculates the total charges for services and labor aswell as the total charges and return them to the user.
            ServiceAndLaborCharges = OilChangeCharges + LubeCharges + RadiatorFlushCharges + TransmissionFlushCharges + InspectionCharges + MufflerCharges + TireRotationCharges + LaborCharges;
            ServiceLaborOutputTextBox.Text = ServiceAndLaborCharges.ToString("c");
            // —Returns the total charges for services and labor.

            TotalCharges = OilChangeCharges + LubeCharges + RadiatorFlushCharges + TransmissionFlushCharges + InspectionCharges + MufflerCharges + TireRotationCharges + PartsCharges + LaborCharges + TaxCharges;
            TotalOutputTextBox.Text = TotalCharges.ToString("c");
            //—Returns the total charges
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            PartsTextBox.Text = string.Empty;
            LaborTextBox.Text = string.Empty;
            PartsOutputTextBox.Text = string.Empty;
            TaxOutputTextBox.Text = string.Empty;
            ServiceLaborOutputTextBox.Text = string.Empty;
            TotalOutputTextBox.Text = string.Empty;

            // Uncheck all checkboxes
            OilChangeCheckBox.Checked = false;
            LubeJobCheckBox.Checked = false;
            RadiatorFlushCheckBox.Checked = false;
            TransmissionFlushCheckBox.Checked = false;
            InspectionCheckBox.Checked = false;
            ReplaceMufflerCheckBox.Checked = false;
            TireRotationCheckBox.Checked = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}