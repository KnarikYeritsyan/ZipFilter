using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using EPPlus;
using  Excel = Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet;
using Spire.Xls;
using Microsoft.Office.Core;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            DragDropEffects effects = DragDropEffects.None;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
                textFolder.Text = path;

            }
            e.Effect = effects;

        }

        private void btnbrouse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbdun = new OpenFileDialog();
            //fbdun.Description = "Select your path";
            if (fbdun.ShowDialog() == DialogResult.OK)
                textFolder.Text = fbdun.FileName;
        }

        private void btnextractpdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFolder.Text))
            {
                MessageBox.Show("Please select your folder.");
                textFolder.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textpdf.Text))
            {
                MessageBox.Show("Please select your path.");
                textFolder.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(pdffoldername.Text))
            {
                MessageBox.Show("Please write a Folder name.");
                pdffoldername.Focus();
                return;
            }
            string source = textFolder.Text;
            string destination1 = textpdf.Text;
            string destination2 = pdffoldername.Text;

            string parent = Path.GetDirectoryName(source);
            string name = Path.GetFileName(source);
            //string foldername = Path.ChangeExtension(parent, null);
            DirectoryInfo di = Directory.CreateDirectory(parent + "\\" + "extracted");
            //string parentf = Path.GetDirectoryName(parent + "\\" + "extracted");
            string sdestination = destination1 + "\\" + destination2;
            ZipFile.ExtractToDirectory(source, parent + "\\" + "extracted");
            Directory.CreateDirectory(sdestination);

            foreach (var file in Directory.GetFiles(parent + "\\" + "extracted", "*.pdf"))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(sdestination, fileName);
                File.Copy(file, destFile);
                
            }

            di.Delete(true);
            MessageBox.Show("PDF Files extracted successfully");


        }

        private void btnextractcsv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFolder.Text))
            {
                MessageBox.Show("Please select your folder.");
                textFolder.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textcsv.Text))
            {
                MessageBox.Show("Please select your path.");
                textFolder.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(csvfoldername.Text))
            {
                MessageBox.Show("Please write a Folder name.");
                csvfoldername.Focus();
                return;
            }

            string source = textFolder.Text;
            string destination1 = textcsv.Text;
            string destination2 = csvfoldername.Text;

            string parent = Path.GetDirectoryName(source);
            string name = Path.GetFileName(source);
            //string foldername = Path.ChangeExtension(parent, null);
            DirectoryInfo di = Directory.CreateDirectory(parent + "\\" + "extracted");
            DirectoryInfo si = Directory.CreateDirectory(parent + "\\" + "csv");
            string sdestination = destination1 + "\\" + destination2;
            ZipFile.ExtractToDirectory(source, parent + "\\" + "extracted");
           

            Directory.CreateDirectory(sdestination);
            foreach (var file in Directory.GetFiles(parent + "\\" + "extracted", "*.csv"))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(source, parent + "\\" + "csv", fileName);
                File.Copy(file, destFile);

            }
            di.Delete(true);

            var date = DateTime.Now.Date.ToString("dd MM yyyy");
            string sourceFile = parent + "\\" + "csv";
            //string date = DateTime.Today.ToString();
            string destinationFile = sdestination + "\\" + date + ".csv";

            string[] filePaths = Directory.GetFiles(sourceFile);
            using (StreamWriter fileDest = new StreamWriter(destinationFile, true))
            {
                int i;
                int filenumber = Directory.GetFiles(sourceFile).Length;
                for (i = 0; i < filenumber; i++)
                {
                    string file = filePaths[i];

                    string[] lines = File.ReadAllLines(file);

                    if (i > 0)
                    {
                        lines = lines.ToArray();
                    }

                    foreach (string line in lines)
                    {
                        fileDest.WriteLine(line);
                    }
                }

                fileDest.Close();
            }

            si.Delete(true);
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            ExcelFile.Load(destinationFile).Save(sdestination + "\\" + date + ".xlsx");
            File.Delete(destinationFile);

            //MessageBox.Show(date);
            MessageBox.Show("CSV Files extracted successfully");


            /*string pathToHeader = @"C:\Users\Knarik\Desktop\trew\Sample-0001.csv";
            //string pathToNoHeader = @"C:\Users\Knarik\Desktop\trew\Sample-0002.csv";


            //string headerText = File.ReadAllText(pathToHeader);
            //string noHeaderText = File.ReadAllText(pathToNoHeader);

            //File.WriteAllText(@"C:\Users\Knarik\Desktop\iotswr\combined.csv", string.Concat(headerText, noHeaderText));*/
            /*var app = new Excel.Application();
            app.Visible = false;
            app.DisplayAlerts = false;
            var workbook = app.Workbooks.Add(Type.Missing);
            workbook.SaveAs(sdestination + "\\" + date + ".xlsx");
            workbook.Close();
            app.Quit();
            string destinationFilex = sdestination + "\\" + date + ".xlsx";*/

            /*string[] filePaths = Directory.GetFiles(sourceFile);
            using (StreamWriter fileDest = new StreamWriter(destinationFilex, true))
            {
                //fs
                int i;
                int filenumber = Directory.GetFiles(sourceFile).Length;
                for (i = 0; i < filenumber; i++)
                {
                    string file = filePaths[i];

                    string[] lines = File.ReadAllLines(file);

                    if (i > 0)
                    {
                        lines = lines.ToArray(); // Skip header row for all but first file
                    }

                    foreach (string line in lines)
                    {
                        fileDest.WriteLine(line);
                    }
                }

                fileDest.Close();
            }*/



            /*string[] filePaths =  Directory.GetFiles(@"C: \Users\Knarik\Desktop\FilePorc");
             StreamWriter fileDest = new StreamWriter(@"C:\Users\Knarik\Desktop\iotswr\combined.csv", true);

             int i;
            int filenumber = Directory.GetFiles(@"C: \Users\Knarik\Desktop\FilePorc").Length;
             for (i = 0; i < filenumber; i++)
             {
                 string file = filePaths[i];

                 string[] lines = File.ReadAllLines(file);

                if (i > 0)
                 {
                     lines = lines.Skip(1).ToArray(); // Skip header row for all but first file
                 }

            foreach (string line in lines)
            {
                fileDest.WriteLine(line);
            }
        }

        fileDest.Close();*/

            //string date = DateTime.Today.ToString();

        }
       

        private void brousepdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdun = new FolderBrowserDialog();
            //fbdun.Description = "Select your path";
            if (fbdun.ShowDialog() == DialogResult.OK)
                textpdf.Text = fbdun.SelectedPath;
        }

        private void brousescv_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdun = new FolderBrowserDialog();
            //fbdun.Description = "Select your path";
            if (fbdun.ShowDialog() == DialogResult.OK)
                textcsv.Text = fbdun.SelectedPath;
        }

        private void pdffoldername_TextChanged(object sender, EventArgs e)
        {

        }

        private void csvfoldername_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class srting
    {
    }
}
