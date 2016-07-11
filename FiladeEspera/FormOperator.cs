using System;
using System.Windows.Forms;

namespace FiladeEspera
{



    public partial class FormOperator : Form
    {
        public FormOperator()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            RemoveQueue();
        }

        private void FormOperator_Load(object sender, EventArgs e)
        {

        }



        private void RemoveQueue()
        {

            labelA1.Text = Display.mQueue.Next().ToString();

            FormClient fc = (FormClient)Application.OpenForms["FormClient"];
            if (fc != null)
            {
                fc.SetCounter();
            }

            Display.mQueue.Remove();

            labelTotalA.Text = Display.mQueue.Total().ToString();

            PlaySound.OnePing();

            Voice.HelloVoice(labelA1.Text);
        }

        private void RemoveQueueB()
        {

            labelB1.Text = Display.mQueue2.Next().ToString();

            FormClient fc = (FormClient)Application.OpenForms["FormClient"];
            if (fc != null)
            {
                fc.SetCounterB();
            }

            Display.mQueue2.Remove();

            labelTotalB.Text = Display.mQueue2.Total().ToString();

            PlaySound.OnePing();

            Voice.HelloVoice(labelB1.Text);
        }



        private void buttonB_Click(object sender, EventArgs e)
        {
            RemoveQueueB();
        }
    }
}
