using System;
using System.Windows.Forms;


public delegate void AposExecutarCalculo();

namespace FiladeEspera
{



    public partial class FormClient : Form
    {


        public AposExecutarCalculo meuDelegate;

        public FormClient()
        {
            InitializeComponent();
        }


        private void FormClient_Load(object sender, EventArgs e)
        {
            //string filePath = AppDomain.CurrentDomain.BaseDirectory + "\video.html";

            //webBrowser1.AllowWebBrowserDrop = false;
            //webBrowser1.Url = new Uri(filePath);
            //@"D:\video\video.html"
        }

        public static string SetNumber(string text)
        {
            return text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            labelA1.Text = Display.mQueue.Next().ToString();
        }

        public void SetCounter()
        {
            labelA1.Text = Display.mQueue.Next().ToString();
        }

        public void SetCounterB()
        {
            labelB1.Text = Display.mQueue2.Next().ToString();
        }






    }
}
