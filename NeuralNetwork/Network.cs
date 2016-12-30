using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public static class Network
    {

        static Random rnd = new Random();

        public static int HiddenLayerSize = 5;
        public static Node[] HiddenNodes;
        public static Node InputNode;
        public static Node OutputNode;

        public static float stepSize;

        static float[] trainInput;
        static float[] trainOutput;

        public static void createNetwork()
        {
            HiddenNodes = new Node[HiddenLayerSize];
            InputNode = new Node();
            OutputNode = new Node();

            for (int i = 0; i < HiddenNodes.Length; i++)
            {
                HiddenNodes[i] = new Node();
            }

            rndNodes();
            
        }

        static void rndNodes()
        {
            InputNode.BIAS = fRandom(0, 1, 3);

            for (int i = 0; i < HiddenNodes.Length; i++)
            {
                HiddenNodes[i].BIAS = fRandom(0, 1, 3);
                HiddenNodes[i].INPUT_WEIGHT = fRandom(0, 1, 3);
                HiddenNodes[i].OUTPUT_WEIGHT = fRandom(0, 1, 3);

            }

            OutputNode.BIAS = fRandom(0, 2, 3);
        }

        public static float runNetwork(float INPUT)
        {
            float OUTPUT = 0;

            OUTPUT = INPUT;
            OUTPUT = OUTPUT * InputNode.BIAS;
            InputNode.SCORE = OUTPUT;

            for (int i = 0; i < HiddenNodes.Length; i++)
            {
                HiddenNodes[i].SCORE = OUTPUT;

                HiddenNodes[i].SCORE = HiddenNodes[i].SCORE * HiddenNodes[i].INPUT_WEIGHT;
                HiddenNodes[i].SCORE = HiddenNodes[i].SCORE * HiddenNodes[i].OUTPUT_WEIGHT;
                HiddenNodes[i].SCORE = HiddenNodes[i].SCORE * HiddenNodes[i].BIAS;
            }

            OUTPUT = 0;
            for (int i = 0; i < HiddenNodes.Length; i++)
            {
                OUTPUT = OUTPUT + HiddenNodes[i].SCORE;
            }

            OutputNode.SCORE = OUTPUT * OutputNode.BIAS;

            return OutputNode.SCORE;
        }

        public static void trainNetwork()
        {
            float baseDist;
            float newDistminus;
            float newDistplus;

            for (int t = 0; t < trainInput.Length; t++)
            {
                float input = trainInput[t];
                float output = trainOutput[t];

                for (int iw = 0; iw < HiddenNodes.Length; iw++)
                {
                    baseDist = Math.Abs( output - runNetwork(input));
                    HiddenNodes[iw].INPUT_WEIGHT = HiddenNodes[iw].INPUT_WEIGHT - stepSize; // try minus step
                    newDistminus = Math.Abs(output - runNetwork(input));

                    HiddenNodes[iw].INPUT_WEIGHT = HiddenNodes[iw].INPUT_WEIGHT + (stepSize * 2); // reset and try plus step
                    newDistplus = Math.Abs(output - runNetwork(input));

                    if (baseDist < newDistminus && baseDist < newDistplus) {
                        HiddenNodes[iw].INPUT_WEIGHT = HiddenNodes[iw].INPUT_WEIGHT - stepSize; // reset
                    }
                    if (newDistminus < newDistplus)
                    {
                        HiddenNodes[iw].INPUT_WEIGHT = HiddenNodes[iw].INPUT_WEIGHT - (stepSize * 2); // reset and go minus step
                    }
                    else
                    {
                        // do nothing and stay plus
                    }

                    for (int ow = 0; ow < HiddenNodes.Length; ow++)
                    {
                        baseDist = Math.Abs(output - runNetwork(input));
                        HiddenNodes[iw].OUTPUT_WEIGHT = HiddenNodes[iw].OUTPUT_WEIGHT - stepSize; // try minus step
                        newDistminus = Math.Abs(output - runNetwork(input));

                        HiddenNodes[iw].OUTPUT_WEIGHT = HiddenNodes[iw].OUTPUT_WEIGHT + (stepSize * 2); // reset and try plus step
                        newDistplus = Math.Abs(output - runNetwork(input));

                        if (baseDist < newDistminus && baseDist < newDistplus)
                        {
                            HiddenNodes[iw].OUTPUT_WEIGHT = HiddenNodes[iw].OUTPUT_WEIGHT - stepSize; // reset
                        }
                        if (newDistminus < newDistplus)
                        {
                            HiddenNodes[iw].OUTPUT_WEIGHT = HiddenNodes[iw].OUTPUT_WEIGHT - (stepSize * 2); // reset and go minus step
                        }
                        else
                        {
                            // do nothing and stay plus
                        }


                        for (int b = 0; b < HiddenNodes.Length; b++)
                        {
                            baseDist = Math.Abs(output - runNetwork(input));
                            HiddenNodes[iw].BIAS = HiddenNodes[iw].BIAS - stepSize; // try minus step
                            newDistminus = Math.Abs(output - runNetwork(input));

                            HiddenNodes[iw].BIAS = HiddenNodes[iw].BIAS + (stepSize * 2); // reset and try plus step
                            newDistplus = Math.Abs(output - runNetwork(input));

                            if (baseDist < newDistminus && baseDist < newDistplus)
                            {
                                HiddenNodes[iw].BIAS = HiddenNodes[iw].BIAS - stepSize; // reset
                            }
                            if (newDistminus < newDistplus)
                            {
                                HiddenNodes[iw].BIAS = HiddenNodes[iw].BIAS - (stepSize * 2); // reset and go minus step
                            }
                            else
                            {
                                // do nothing and stay plus
                            }
                        }
                    }
                }

                baseDist = Math.Abs(output - runNetwork(input));
                InputNode.BIAS = InputNode.BIAS - stepSize; // try minus step
                newDistminus = Math.Abs(output - runNetwork(input));

                InputNode.BIAS = InputNode.BIAS + (stepSize * 2); // reset and try plus step
                newDistplus = Math.Abs(output - runNetwork(input));

                if (baseDist < newDistminus && baseDist < newDistplus)
                {
                    InputNode.BIAS = InputNode.BIAS - stepSize; // reset
                }
                if (newDistminus < newDistplus)
                {
                    InputNode.BIAS = InputNode.BIAS - (stepSize * 2); // reset and go minus step
                }
                else
                {
                    // do nothing and stay plus
                }

                baseDist = Math.Abs(output - runNetwork(input));
                OutputNode.BIAS = OutputNode.BIAS - stepSize; // try minus step
                newDistminus = Math.Abs(output - runNetwork(input));

                OutputNode.BIAS = OutputNode.BIAS + (stepSize * 2); // reset and try plus step
                newDistplus = Math.Abs(output - runNetwork(input));

                if (baseDist < newDistminus && baseDist < newDistplus)
                {
                    OutputNode.BIAS = OutputNode.BIAS - stepSize; // reset
                }
                if (newDistminus < newDistplus)
                {
                    OutputNode.BIAS = OutputNode.BIAS - (stepSize * 2); // reset and go minus step
                }
                else
                {
                    // do nothing and stay plus
                }


            }
        }

        public static float fRandom(int min, int max, int precise) {
            precise = Convert.ToInt32( Math.Pow(10, precise));
            float r = rnd.Next(min * precise, max * precise);
            return r / precise;
        }

        public static void getTrainData(String[] inputs, String[] outputs)
        {
            if (inputs.Length == outputs.Length)
            {
                trainInput = new float[inputs.Length];
                trainOutput = new float[outputs.Length];
                for (int i = 0; i < inputs.Length; i++)
                {
                    int n;
                    bool isNumeric = int.TryParse(inputs[i], out n);
                    if (isNumeric) { trainInput[i] = float.Parse(inputs[i]); }
                }
                for (int i = 0; i < outputs.Length; i++)
                {
                    int n;
                    bool isNumeric = int.TryParse(outputs[i], out n);
                    if (isNumeric) { trainOutput[i] = float.Parse(outputs[i]); }
                }
            }
            else {
                MessageBox.Show("Input and Output Length do not match!");
            }



        }



    }



    public class Node {
        public int NodeID;
        public float BIAS = 1,
                     INPUT_WEIGHT = 1,
                     OUTPUT_WEIGHT = 1,
                     SCORE;
    }
}
