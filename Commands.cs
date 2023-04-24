using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEProject
{
    /// <summary>
    /// the class used for handling the commands for drawing shapes
    /// </summary>
    class Commands
    {
        Canvas c;

        /// <summary>
        /// the constructor thst is parsed the canvas to be handled by the drawing methods
        /// </summary>
        /// <param name="cIn"></param>
        public Commands(Canvas cIn)
        {
            this.c = cIn;
        }

        /// <summary>
        /// the parse method is used for processing and handling the input form the user and processing it so that the correct values are passed through and in the correct format
        /// </summary>
        /// <param name="phrase"></param>
        /// <exception cref="ArgumentException"> this is thrown by the shape factory class if the string being passed does not match any of the values</exception>
        /// <exception cref="InvalidOperationException">this is thrown by the witch statment if the value doesnt match any of the cases</exception>
        /// <exception cref="IndexOutOfRangeException"> this is thrown if the indexing for the parameters is incorrect</exception>
        public void Parse(String phrase)
        {
            if (phrase.Contains('='))
            {
                String[] split = phrase.Split('=');
                String variable = split[0];
                int param = int.Parse(split[1]);
            }
            else
            {
                String[] s = phrase.Split(' ');
                String command = s[0];

                if (s.Length > 1)
                {
                    String[] parameters = s[1].Split(',');
                    int[] intParameters = new int[parameters.Length];

                    try
                    {
                        switch (command)
                        {
                            case ("rectangle"):
                                c.DrawSquare(intParameters[0], intParameters[1]);
                                break;
                            case ("circle"):
                                c.DrawCircle(intParameters[0]);
                                Console.WriteLine("circle drawn");
                                break;
                            case("triangle"):
                                c.DrawTriangle(intParameters[0]);
                                break;
                            case ("line"):
                                c.DrawLine(intParameters[0], intParameters[1]);
                                break;
                            case ("move"):
                                c.MoveTo(intParameters[0], intParameters[1]);
                                break;
                            case ("colour"):
                                c.Colour(intParameters[0].ToString());
                                break;
                            case ("fill"):
                                c.Fill(intParameters[0].ToString());
                                break;
                            default:
                                throw new InvalidOperationException("unknown command");
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("invalid shape: " + e);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else if (s.Length == 1)
                {
                    switch (command)
                    {
                        case ("clear"):
                            c.Clear();
                            break;
                        case ("reset"):
                            c.Reset();
                            break;
                    }
                }
            }
        }
    }
}
