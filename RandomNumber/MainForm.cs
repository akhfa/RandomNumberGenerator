using System;
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
            MessageBox.Show("Calculation Finished. See result in result.csv");
        }

        private void PoissonButton_Click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(generatePoissonRandom));
            MessageBox.Show("Starting calculation. Please wait until next notification.");
            oThread.Start();
            oThread.Join();
            MessageBox.Show("Calculation Finished. See result in result.csv");
        }

        private void logNormButton_Click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(generateLogNormalRandom));
            MessageBox.Show("Starting calculation. Please wait until next notification.");
            oThread.Start();
            oThread.Join();
            MessageBox.Show("Calculation Finished. See result in result.csv");
        }

        private void EksButton_Click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(generateEksRandom));
            MessageBox.Show("Starting calculation. Please wait until next notification.");
            oThread.Start();
            oThread.Join();
            MessageBox.Show("Calculation Finished. See result in result.csv");
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

        public void generateLogNormalRandom()
        {
            StreamWriter writer = new StreamWriter("result.csv");
            double sigma = (double.Parse(sigmaTextBox.Text));
            double mu = (double.Parse(muTextBox.Text));
            for (int i = 0; i < int.Parse(jumlahTextBox.Text); i++)
            {
                writer.WriteLine(SimpleRNG.GetLogNormal(mu,sigma));
            }
            writer.Close();
        }

        public void generateEksRandom()
        {
            StreamWriter writer = new StreamWriter("result.csv");
            try
            {
                double mean = (double.Parse(meanEksTextBox.Text));
                for (int i = 0; i < int.Parse(jumlahTextBox.Text); i++)
                {
                    writer.WriteLine(SimpleRNG.GetExponential(mean));
                }
            }catch(System.FormatException)
            {
                for (int i = 0; i < int.Parse(jumlahTextBox.Text); i++)
                {
                    writer.WriteLine(SimpleRNG.GetExponential());
                }
            }
            
            writer.Close();
        }
    }
}
