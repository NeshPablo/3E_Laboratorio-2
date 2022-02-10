using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3E_Laboratorio_2
{
    public partial class Form1 : Form
    {
        List<string> pag = new List<string>();
     
        
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/?hl=es");
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button1_Click(object sender, EventArgs e)
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
           
            webBrowser1.Navigate("http://www.google.com/search?q=" + txt_combobox1.Text);
            webBrowser1.Navigate("http://www.google.com/search?q=" + txt_combobox1.Text);


        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void txt_combobox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
