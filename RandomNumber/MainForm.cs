﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TestSimpleRNG;
using System.IO;

namespace RandomNumber
{
    public partial class RandomGenerator : Form
    {
        public RandomGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(generateNormalRandom));
            MessageBox.Show("Starting calculation. Please wait until next notification.");
            oThread.Start();
            oThread.Join();
            MessageBox.Show("Calculation Finished");
        }

        private void PoissonButton_Click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(generatePoissonRandom));
            MessageBox.Show("Starting calculation. Please wait until next notification.");
            oThread.Start();
            oThread.Join();
            MessageBox.Show("Calculation Finished");
        }

        public void generateNormalRandom()
        {
            double mean, deviasi;
            StreamWriter writer = new StreamWriter("result.csv");
            try
            {
                
                mean = double.Parse(meanTextBox.Text);
                deviasi = double.Parse(deviasiTextBox.Text);
                for(int i = 0; i < int.Parse(jumlahTextBox.Text); i++)
                {
                    writer.WriteLine(SimpleRNG.GetNormal(mean, deviasi) + ",");
                }
            }
            catch(System.FormatException)
            {
                for (int i = 0; i < int.Parse(jumlahTextBox.Text); i++)
                {
                    writer.WriteLine(SimpleRNG.GetNormal() + ",");
                }
            }
            writer.Close();
        }
        public void generatePoissonRandom()
        {
            StreamWriter writer = new StreamWriter("result.csv");
            double lambda = (double.Parse(lambdaTextBox.Text));
            for (int i = 0; i < int.Parse(jumlahTextBox.Text); i++)
            {
                writer.WriteLine(SimpleRNG.GetPoisson(lambda));
            }
            writer.Close();
        }
    }
}
