using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEProject
{
    /// <summary>
    /// the class used for parsing commands for the program.
    /// makes use of the canvas class within this solution 
    /// 
    /// </summary>
    class Parser
    {
        Canvas c;

        /// <summary>
        /// the class constructor 
        /// </summary>
        /// <param name="cIn"></param>
        public Parser(Canvas cIn)
        {
            this.c = cIn;
        }

        /// <summary>
        /// the class that reads the commands that are passed through.
        /// </summary>
        /// <param name="phrase"></param>
        /// <exception cref="InvalidOperationException">Exception is thrown with the switch statement if the value falls through</exception>
        public void Read(string phrase)
        {
            // phrase formatting and tidying
            phrase = phrase.Trim().ToLower();

            // splitting phrase into commands and parameteres
            String[] split = phrase.Split(' ');                     // assigning split values to an array
            String command = split[0];

            if (split.Length > 1) {
                String[] sParams = split[1].Split(',');             
                int[] intParameters = new int[sParams.Length];

                // for loop for parsing string array to int array
                for (int i = 0; i < sParams.Length; i++)
                {
                    int tmp;
                    if (int.TryParse(sParams[i], out tmp))          // parsing the string array to integer array. tmp = quick stirage integer
                        intParameters[i] = tmp;                     // passes tmp value to array position at i
                }

                // checking there are mulitple parts to the command 
                try
                {
                    switch (command)
                    {
                        case "rectangle":
                            if (intParameters.Length != 2)
                            {
                                System.Console.WriteLine("Invalid number of parameters");
                                MessageBox.Show("invalid Parameters", "Invalid Parameters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                c.DrawSquare(intParameters[0], intParameters[1]);
                            }
                            break;
                        case "circle":
                            if (intParameters.Length != 1)
                            {
                                MessageBox.Show("invalid Parameters", "Invalid Parameters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                c.DrawCircle(intParameters[0]);
                            }
                            
                            break;
                        case "triangle":
                            c.DrawTriangle(intParameters[0]);
                            break;
                        case "moveto":
                            if (intParameters.Length != 2)
                            {
                                System.Console.WriteLine("Invalid number of parameters");
                                MessageBox.Show("Invalid parameters", "Invalid parameters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                c.MoveTo(intParameters[0], intParameters[1]);
                            }

                            break;
                        case "colour":
                            c.Colour(sParams[0]);
                            break;
                        case "fill":
                            c.Fill(sParams[0]);
                            break;
                        case "drawto":
                            if (intParameters.Length != 2)
                            {
                                System.Console.WriteLine("Invalid number of parameters");
                                MessageBox.Show("Invalid parameters", "Invalid command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                c.DrawLine(intParameters[0], intParameters[1]);
                            }
                            break;
                        default:
                                throw new InvalidOperationException("Unknown item");

                    }
                }
                catch (InvalidOperationException e)
                {
                    System.Console.WriteLine("the following exception has occurred " + e.Message);
                    MessageBox.Show("Invalid command, shape", "Invalid command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    switch (command)
                    {
                        case "clear":
                            c.Clear();
                            break;
                        case "reset":
                            c.Reset();
                            break;
                        default:
                            throw new InvalidOperationException("Unknown item");
                    }
                }
                catch (InvalidOperationException e)
                {
                    System.Console.WriteLine("the following exception has occurred " + e.Message);
                    MessageBox.Show("Invalid command, shape", "Invalid command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // end of method
    } // end of class 
} // end of namespace
