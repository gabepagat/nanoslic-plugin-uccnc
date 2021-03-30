using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Plugins
{

    public partial class PluginForm : Form
    {
        private Plugininterface.Entry UC;
        UCCNCplugin Pluginmain;
        bool mustclose = false;
        string PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UCCNC", "Geometric_codes");

        public PluginForm(UCCNCplugin Pluginmain)
        {
            this.UC = Pluginmain.UC;
            this.Pluginmain = Pluginmain;
            InitializeComponent();
        }

        private void PluginForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            // set variable values
            this.x1 = 0; this.y1 = 0;
            this.x2 = 0; this.y2 = 0;

            // Add onClick for Generate button
            this.button1.Click += (s, ea) => this.Button1_Click(sender, ea, new SprayParameters(x1, y1, x2, y2, this.comboBox3.SelectedItem, this.comboBox2.SelectedItem, this.comboBox1.SelectedItem, this.comboBox4.SelectedItem));
            
            // Default values for ComboBoxes
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 0;
        }

        private void jogXplusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(147);
        }

        private void jogXplusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(229);
        }

        private void jogXminusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(148);
        }

        private void jogXminusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(230);
        }

        private void jogYplusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(149);
        }

        private void jogYplusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(231);
        }

        private void jogYminusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(150);
        }

        private void jogYminusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(232);
        }

        private void jogZplusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(151);
        }

        private void jogZplusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(233);
        }

        private void jogZminusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(152);
        }

        private void jogZminusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(234);
        }

        private void jogAplusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(153);
        }

        private void jogAplusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(235);
        }

        private void jogAminusbutton_MouseDown(object sender, MouseEventArgs e)
        {
            UC.Callbutton(154);
        }

        private void jogAminusbutton_MouseUp(object sender, MouseEventArgs e)
        {
            UC.Callbutton(236);
        }

        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Do not close the form when the red X button is pressed
            //But start a Thread which will stop the Loop call from the UCCNC
            //to prevent the form closing while there is a GUI update in the Loop event
            if (!mustclose)
            {
                e.Cancel = true;
                Thread closethr = new Thread(new ThreadStart(Closeform));
                closethr.Start();
            }
            else
            {
                //Form is closing here...
            }
        }

        public void Closeform()
        {
            //Stop the Loop event to update the GUI
            Pluginmain.loopstop = true;
            //Wait until the loop exited
            while (Pluginmain.loopworking)
            {
                Thread.Sleep(10);
            }
            //Set the mustclose variable to true and call the .Close() function to close the Form
            mustclose = true;
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e, SprayParameters parameters)
        {
            List<Plugininterface.Datatypes.Layerdatastruct> Ldata = UC.Getlayerslist(true);
            WriteGCode(parameters);
        }

        private void WriteGCode(SprayParameters parameters)
        {
            try
            {
                // File headers
                String g_code = "%\nG40 G49 G64 P0.03 M6 T1\nG17\nM7\nM8\n";

                // Create directory for g_code if it does not exist
                if (!Directory.Exists(PATH))
                {
                    DirectoryInfo di = Directory.CreateDirectory(PATH);
                }

                // Loop variables
                double currentX = parameters.x2, currentY = parameters.y2, spacingDelta;
                int verticalPasses = (int) Math.Ceiling((parameters.x2 - parameters.x1) / parameters.passSpacing);
                int horizontalPasses = (int) Math.Ceiling((parameters.y2 - parameters.y1) / parameters.passSpacing);

                // Go to start and turn on sprayer
                g_code += String.Format("G0X{0:F}G0Y{1:F}S{2:F1}\nM3\n", currentX, currentY, parameters.spraySpeed);

                // for loop generate g_code
                for (int i = 0; i < parameters.numCoats; i++)
                {

                    g_code += "( HORIZONTAL PASSES )\n";

                    spacingDelta = currentY >= parameters.y2 ? -parameters.passSpacing : parameters.passSpacing;
                    for (int j = 0; j <= horizontalPasses; j++) // <= beacuse we want to spray across the last pass row
                    {
                        currentX = currentX >= parameters.x2 ? parameters.x1 : parameters.x2;
                        g_code += String.Format("G1X{0:F}F{1:F1}\n", currentX, parameters.spraySpeed);

                        if (j != horizontalPasses)
                        {
                            currentY += spacingDelta;
                            g_code += String.Format("G0Y{0:F}\n", currentY);
                        }
                    }

                    g_code += "( VERTICAL PASSES )\n";

                    spacingDelta = currentX >= parameters.x2 ? -parameters.passSpacing : parameters.passSpacing;
                    for (int k = 0; k <= verticalPasses; k++) // <= beacuse we want to spray across the last pass row
                    {
                        currentY = currentY >= parameters.y2 ? parameters.y1 : parameters.y2;
                        g_code += String.Format("G1Y{0:F}F{1:F1}\n", currentY, parameters.spraySpeed);

                        if (k != verticalPasses)
                        {
                            currentX += spacingDelta;
                            g_code += String.Format("G0X{0:F}\n", currentX);
                        }
                    }

                }

                // Concat ending lines
                g_code += "M9\nM2\n%\n";

                // Write to file
                String g_code_path = Path.Combine(PATH, "nanoslic_gcode.txt");
                File.WriteAllText(g_code_path, g_code);

                // Display message if overspray amount is corrected
                if (parameters.correctionMessage.Length > 0)
                {
                    MessageBox.Show(parameters.correctionMessage, "Overspray Correction");
                }

                MessageBox.Show("Output g-code to " + Path.GetFullPath(g_code_path), "Finished generating g-code");
                UC.Callbutton(124);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get fields and update variables
            this.x1 = UC.Getfielddouble(true, 226);
            this.y1 = UC.Getfielddouble(true, 227);

            // update label
            this.label6.Text = String.Format("Bottom Left: ({0:F}, {1:F})", x1, y1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // get fields and update variables
            this.x2 = UC.Getfielddouble(true, 226);
            this.y2 = UC.Getfielddouble(true, 227);

            // update label
            this.label7.Text = String.Format("Top Right: ({0:F}, {1:F})", x2, y2);
        }
    }
}
