using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ASEProject
{
    /// <summary>
    /// The form class where the main method is found
    /// <author>Mikey Frear</author>
    /// </summary>
    public partial class Form1 : Form
    {
        Bitmap OutputBitmap = new Bitmap(617, 545);
        Canvas myCanvas;
        Parser p;

        /// <summary>
        /// the constructor method, this initialises the objects and the canvass for the solution
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            myCanvas = new Canvas(Graphics.FromImage(OutputBitmap)); // passing the drawing surface to the drawing class
        }

        /// <summary>
        /// the graphic interface paint action, used for applying the canvas graphics to the bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }

        /// <summary>
        /// when the enter key is pressed it takes the text from the commandBox and passes the text to the parser.
        /// checks if run, load or save were entered then carries out the following commands. if not the data is passed through to the parser.
        /// the graphics are then refreshed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cmd = CommandBox.Text;
                Parser p = new Parser(myCanvas); // handling the parser class the canvas needed to draw on the screen
                
                cmd.ToLower().Trim(); // formatting the commandBox
                if (cmd.Equals("run")) // checking the command
                {
                    int num = Convert.ToInt32(txtRepitition.Text);
                    while (num != 0)
                    {
                        String[] cmds = CommandRchBox.Text.Split('\n');

                        for (int i = 0; i < cmds.Length; i++)
                        {
                            cmds[i].ToLower().Trim();

                            p.Read(cmds[i]);

                            CommandBox.Text = ""; // clears text box
                            Refresh();
                        }
                        num = num - 1;
                    }
                }
                else
                {
                    if (cmd.Equals("save")) // checks the command 
                    {
                        SaveFileDialog save = new SaveFileDialog(); // instansing a save file SaveFileDialog

                        save.Title = "Save File";
                        save.Filter = "Text File (*.txt | *.txt";

                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter write = new StreamWriter(File.Create(save.FileName));

                            write.Write(CommandRchBox.Text);

                            CommandBox.Text = ""; // clears text box
                            write.Dispose(); // disposes of the stream writer
                        }
                    }
                    else
                    {
                        if (cmd.Equals("open")) // checking command
                        {
                            OpenFileDialog open = new OpenFileDialog(); // instansing open file dialog
                            open.Title = "Load file";
                            open.Filter = "text File (*.txt | *.txt";

                            if (open.ShowDialog() == DialogResult.OK)
                            {
                                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                                CommandRchBox.Text = read.ReadToEnd();

                                CommandBox.Text = ""; //clears text box
                                read.Dispose(); // disposes of the stream reader
                            }
                        }
                        else
                        {
                            p.Read(cmd);
                            CommandBox.Text = ""; // clears text box
                            Refresh(); // updates the display to show the graphics
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
