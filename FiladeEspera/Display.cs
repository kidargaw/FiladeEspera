using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FiladeEspera
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        public static Queue<Client> listClient1 = new Queue<Client>();
        public static Queue<Client> listClient2 = new Queue<Client>();

        public static PQueue mQueue = new PQueue(listClient1);
        public static PQueue mQueue2 = new PQueue(listClient2);

        private int counter = 0;
        private int counter2 = 0;

        private void Display_Load(object sender, EventArgs e)
        {


        }

        private void buttonA_Click(object sender, EventArgs e)
        {

            counter++;
            var client = new Client
            {
                Num = counter,
                Data = DateTime.Now,
                Priority = 5,
                Type = "A"
            };
            try
            {
                ClientDAL.WriteXml(client);

                AddMultipleQueue(mQueue, counter, client, labelA1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //private void AddQueue(int counter)
        //{

        //    try
        //    {
        //        var client1 = new Client
        //        {
        //            Num = counter,
        //            Data = DateTime.Now,
        //            Priority = 5
        //        };

        //        mQueue.Add(client1);
        //        // labelA1.Text = client1.Num.ToString();
        //        labelA1.Text = client1.Num.ToString();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void AddMultipleQueue(PQueue pQueue, int counter, Client client, Label label)
        {

            try
            {
                pQueue.Add(client);
                label.Text = client.Num.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void buttonB_Click(object sender, EventArgs e)
        {
            counter2++;
            var client = new Client
            {
                Num = counter2,
                Data = DateTime.Now,
                Priority = 5,
                Type = "B"
            };

            try
            {
                ClientDAL.WriteXml(client);
                AddMultipleQueue(mQueue2, counter2, client, labelB1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
