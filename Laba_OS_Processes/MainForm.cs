using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba_OS_Processes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool Checker = false;
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string TextFromFile;
                int NumberOfLines;
                string[] TextResourses = null;
                int[] Resourses = null;
                int[] ResourseCount = null;
                int[] Need = null;
                
                string[] Alphabet = new string[] { "A", "B", "C", "D", "E", "F", "H", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                string Filename = OpenFileDialog.FileName;
                try
                {
                    using (var streamReader = new StreamReader(Filename, Encoding.UTF8))
                    {
                        TextFromFile = streamReader.ReadToEnd(); 
                        YourFileTextbox.Text = TextFromFile + Environment.NewLine;
                        string ResoursesLine = File.ReadLines(Filename).Skip(0).First();
                        NumberOfLines = File.ReadAllLines(Filename).Length - 1;

                        TextResourses = ResoursesLine.Split(' ');
                        Resourses = new int[TextResourses.Length];
                        for (int i = 0; i != Resourses.Length; i++)
                        {
                            Resourses[i] = Convert.ToInt32(TextResourses[i]);
                        }
                        ResourseCount = new int[TextResourses.Length];
                        Need = new int[TextResourses.Length];
                        ResultTextbox.Text = "Available resourses" + Environment.NewLine;
                        for (int i = 1; i != NumberOfLines + 1; i++)
                        {
                            string Line = File.ReadLines(Filename).Skip(i).First();
                            string[] Process = Line.Split(' ');
                            for (int k = 1; k != TextResourses.Length + 1; k++)
                            {
                                ResourseCount[k - 1] = Convert.ToInt32(Process[k]);
                                Resourses[k - 1] -= ResourseCount[k - 1];
                            }
                        }
                        for (int i = 0; i != Resourses.Length; i++)
                        {
                            ResultTextbox.Text += Convert.ToString(Resourses[i]) + " ";
                        }
                        bool[] WasChecked = new bool[NumberOfLines];
                        for (int a = 0; a != NumberOfLines; a++)
                        {
                            WasChecked[a] = false;
                        }

                        for (int i = 1; i != NumberOfLines + 1; i++)
                        {
                            string Line = File.ReadLines(Filename).Skip(i).First();
                            string[] Process = Line.Split(' ');
                            for (int k = 1; k != TextResourses.Length + 1; k++)
                            {
                                ResourseCount[k - 1] = Convert.ToInt32(Process[k]);
                            }
                            for (int k = TextResourses.Length + 1; k != Process.Length; k++)
                            {
                                Need[k - TextResourses.Length - 1] = Convert.ToInt32(Process[k]);
                            }
                            int CheckLength = 0;
                            for (int a = 0; a != Resourses.Length; a++)
                            {
                                if ((Resourses[a] + ResourseCount[a] >= Need[a]) && WasChecked[i - 1] == false)
                                {
                                    CheckLength++;
                                }
                                if (CheckLength == Resourses.Length)
                                {
                                    ResultTextbox.Text += Environment.NewLine + "Started process " + Alphabet[i - 1] + ": " + Environment.NewLine;

                                    WasChecked[i - 1] = true;
                                    for (int j = 0; j != Resourses.Length; j++)
                                    {
                                        Resourses[j] += ResourseCount[j];
                                        ResultTextbox.Text += Convert.ToString(Resourses[j]) + " ";
                                    }

                                    for (int c = 0; c != NumberOfLines; c++)
                                    {
                                        if (WasChecked[c] == false)
                                            Checker = true;
                                    }
                                    if (Checker != false)
                                    {
                                        i = 0;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect data from file");
                }
            }
            else
            {
                MessageBox.Show("Unable to read file");
            }

            if (Checker != false)
            {
                ResultTextbox.Text += Environment.NewLine + "This system is stable ";
            }
            else
            {
                ResultTextbox.Text += Environment.NewLine + "Unstable system. Deadlock ";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
