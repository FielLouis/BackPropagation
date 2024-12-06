using System;
using Backprop;

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int inputN = 4, outputN = 1;
        int[,] inputs;
        int min_epoch;
        int ctr_epoch = 0;
        public Form1()
        {
            InitializeComponent();
            inputs = new int[16, 5]
            {
                { 0, 0, 0, 0, 0},
                { 0, 0, 0, 1, 0},
                { 0, 0, 1, 0, 0},
                { 0, 0, 1, 1, 0},
                { 0, 1, 0, 0, 0},
                { 0, 1, 0, 1, 0},
                { 0, 1, 1, 0, 0},
                { 0, 1, 1, 1, 0},
                { 1, 0, 0, 0, 0},
                { 1, 0, 0, 1, 0},
                { 1, 0, 1, 0, 0},
                { 1, 0, 1, 1, 0},
                { 1, 1, 0, 0, 0},
                { 1, 1, 0, 1, 0},
                { 1, 1, 1, 0, 0},
                { 1, 1, 1, 1, 1}
            };

            min_epoch = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 100, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int epoch = 0; epoch < min_epoch; epoch++)
            {
                for (int i = 0; i < inputN * inputN; i++)
                {
                    for (int j = 0; j < inputN; j++)
                    {
                        nn.setInputs(j, inputs[i, j]);
                    }

                    nn.setDesiredOutput(0, inputs[i, inputN]);
                    nn.learn();
                }
            }

            ctr_epoch += min_epoch;
            label1.Text = "Total Epoch: " + (ctr_epoch);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                textBox5.Text = "Invalid inputs.";
                return;
            }

            // Set input values from the textboxes
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));

            // Run the network to predict the output
            nn.run();

            // Output the result
            textBox5.Text = nn.getOuputData(0).ToString();
        }
    }
}
