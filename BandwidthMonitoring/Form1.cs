using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandwidthMonitoring
{
    public partial class Form1 : Form
    {

        public const double waktuUpdate = 1000;
        private NetworkInterface[] networkInterface;
        public Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeNetworkInterface();
            timerInitial();
        }

        private void timerInitial()
        {
            throw new NotImplementedException();
        }

        private void InitializeNetworkInterface()
        {
            networkInterface = NetworkInterface.GetAllNetworkInterfaces();

            for (int i = 0; i < networkInterface.Length; i++)
            {
                comboBoxDevices.Items.Add(networkInterface[i].Name);
            }
            comboBoxDevices.SelectedIndex = 0;

            

        }

        long lngBytesSend;
        long lngBytesReceived;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
