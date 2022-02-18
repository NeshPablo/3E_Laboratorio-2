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

namespace _3E_Laboratorio_2
{
    
    public partial class Form1 : Form
    {
        List<string> pag = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "Uri.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > 0) {
                string texto = reader.ReadLine();
                txt_combobox1.Items.Add(texto);
            }
            
            reader.Close();

        }
        private void Guardar(string F_name,string txt){
            FileStream stream = new FileStream(F_name, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(txt);
            
            writer.Close();

        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void button1_Enter(object sender, EventArgs e)
        {
            
            string uri = "";
          
            
            if (txt_combobox1.Text != null)
                uri = txt_combobox1.Text;
            else if (txt_combobox1.SelectedItem != null)
                uri = txt_combobox1.SelectedItem.ToString();
            if (!uri.Contains("."))
                uri = "https://www.google.com/search?q=" + uri;
            if (!uri.Contains("https://"))
                uri = "https://" + uri;
            webBrowser1.Navigate(new Uri(uri));
            Guardar("Uri.txt", uri);
        }
    }
}
