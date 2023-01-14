using System.Diagnostics;
using System.IO;
using System.Text;
//using static System.Net.Mime.MediaTypeNames;

namespace Goku_Words
{
    public partial class Form1 : Form
    {
        string path = @"Python\";

        private static int lineCount = 0;
        private static StringBuilder output = new StringBuilder();

        Image endImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            DoStuff();
        }

        async void DoStuff()
        {
            lineCount = 0;
            output = new StringBuilder();

            if (endResultImage.Image != null)
            {
                var existingFile = endResultImage.Image;
                endResultImage.Image = null;
                existingFile?.Dispose();
            }
            if (endImage != null)
            {
                var existingFile = endImage;
                endImage = null;
                existingFile?.Dispose();
            }

                charBox.Text.Replace(" ", "+");
            prefixBox.Text.Replace(" ", "+");

            await File.WriteAllTextAsync(path + "words.txt", charBox.Text + ":" + prefixBox.Text + ":" + topBox.Text + ":" + bottomBox.Text + ":");

            //using StreamWriter file = new(path + "words.txt", append: false);
            //await file.WriteLineAsync(charBox.Text + ":" + prefixBox.Text + ":" + topBox.Text + ":" + bottomBox.Text);

            await Task.Delay(100);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "cmd.exe";
            startInfo.WorkingDirectory = path;
            startInfo.Arguments = "/C py main.py";
            process.StartInfo = startInfo;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    //consoleLabel.Text += "\n[" + lineCount + "]: " + e.Data;
                    output.Append("\n[" + lineCount + "] " + e.Data);
                }
            });
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();

            consoleLabel.Text = output.ToString();

            process.WaitForExit();
            process.Close();

            await Task.Delay(100);

            endImage = Image.FromFile(path + "done.png");

            endResultImage.Image = endImage;


            Clipboard.SetDataObject(endImage);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if(endImage != null)
            {
                Clipboard.SetDataObject(endImage);
            }
        }
    }
}