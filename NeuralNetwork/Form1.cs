using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create network
            Network.HiddenLayerSize = Convert.ToInt32(textHiddenLayers.Text);
            Network.createNetwork();
            Network.stepSize = Convert.ToSingle( stepSizeText.Text );

            testButton.Enabled = true;
            trainButton.Enabled = true;
            textBox3.Enabled = true;
            labelNetSize.Text = "/ " + textHiddenLayers.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            float f = Network.fRandom(0, 2, 3);
            MessageBox.Show(f.ToString());
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            float output = Network.runNetwork( Convert.ToSingle(textBox2.Text) );
            outputLabel.Text = Math.Round(output, 2).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(textBox3.Text, out n);

            if (isNumeric) {
                int number = Convert.ToInt32( textBox3.Text );
                if (number <= Network.HiddenLayerSize && number != 0)
                {
                    Node selected = Network.HiddenNodes[number - 1];
                    richTextBox1.Text = getNodeInfo(selected);
                }
                else if (number == 0)
                {
                    Node selected = Network.InputNode;
                    richTextBox1.Text = getNodeInfo(selected);
                }
                else if (number == Network.HiddenLayerSize + 1)
                {
                    Node selected = Network.OutputNode;
                    richTextBox1.Text = getNodeInfo(selected);
                }
                else { richTextBox1.Text = ""; }
            }
        }

        private string getNodeInfo(Node node) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Bias: " + node.BIAS.ToString());
            sb.AppendLine("Input Weight: " + node.INPUT_WEIGHT.ToString());
            sb.AppendLine("Output Weight: " + node.OUTPUT_WEIGHT.ToString());
            sb.AppendLine("Output: " + node.SCORE.ToString());
            return sb.ToString();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {

            //Network.trainSize = TrainTextInput.Lines.Count();
            //if(TrainTextOutput.Lines.Count() > Network.trainSize) { Network.trainSize = TrainTextOutput.Lines.Count(); }

            Network.getTrainData(TrainTextInput.Lines,
                                 TrainTextOutput.Lines
                                );
            Network.trainNetwork();
        }
    }
}
