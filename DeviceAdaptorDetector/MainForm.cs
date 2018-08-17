using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceAdaptorDetector
{
    public partial class MainForm : Form
    {

        private NetworkInterface[] nicArr;

        public MainForm()
        {
            InitializeComponent();
            InitializeNetworkInterface();
        }

        private void InitializeNetworkInterface()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();

            for (int i = 0; i < nicArr.Length; i++)
            {
                comboBoxDevice.Items.Add(nicArr[i].Name);
            }
            comboBoxDevice.SelectedIndex = 0;
        }

        public void networkProc()
        {
            NetworkInterface nic = nicArr[comboBoxDevice.SelectedIndex];

            IPGlobalProperties globalProperties = IPGlobalProperties.GetIPGlobalProperties();

            ArrayList info = new ArrayList();

            info.Add("Interfafce Information for:" + globalProperties.NodeType
                + globalProperties.DomainName);
            info.Add("NetBIOS node type: " + globalProperties.NodeType);
            info.Add("===============================================");
            info.Add("Name: " + nic.Name);
            info.Add("Description: " + nic.Description);
            info.Add("Network Interface Type: " + nic.NetworkInterfaceType);
            info.Add("Physical Address: " + nic.GetPhysicalAddress().ToString());
            info.Add("Adapter ID: " + nic.Id);
            info.Add("Receive Only: " + nic.IsReceiveOnly);
            info.Add("Status: " + nic.OperationalStatus.ToString());
            info.Add("Speed: " + nic.Speed.ToString());

            IPInterfaceProperties properties = nic.GetIPProperties();
            info.Add("Properties: ");

            info.Add("|DNS Addresses");
            foreach (IPAddressInformation uniCast in properties.UnicastAddresses)
                info.Add("->:" + uniCast.Address.ToString());

            info.Add("|AnyCast Addresses");
            foreach (IPAddressInformation anyCast in properties.AnycastAddresses)
                info.Add("->:" + anyCast.Address.ToString());

            info.Add("|Support multi-cast: " +nic.SupportsMulticast);

            info.Add("|Multicast Addresses: ");
            foreach (IPAddressInformation multiCast in properties.MulticastAddresses)
                info.Add("->: " + multiCast.Address.ToString());

            info.Add("|Gateway Address");
            foreach (GatewayIPAddressInformation gateway in properties.GatewayAddresses)
                info.Add("->:" + gateway.Address.ToString());

            if (nic.Supports(NetworkInterfaceComponent.IPv4) == true)
            {
                IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();
                info.Add("+IPV4 Properties");
                if (ipv4 != null)
                {
                    info.Add("  |Interface Index : " + ipv4.Index.ToString());
                    info.Add("  |Automatic Private Addressing Active : " + ipv4.IsAutomaticPrivateAddressingActive.ToString());
                    info.Add("  |Automatic Private Addressing Enabled : " + ipv4.IsAutomaticPrivateAddressingEnabled.ToString());
                    info.Add("  |DHCP Enabled : " + ipv4.IsDhcpEnabled.ToString());
                    info.Add("  |Forwadding Enabled: " + ipv4.IsForwardingEnabled.ToString());
                    info.Add("  |MTU Size : " + ipv4.Mtu.ToString());
                    info.Add("  |\\Uses Wins : " + ipv4.UsesWins.ToString());
                }
                else
                {
                    info.Add("|Device has no IPV4 properties");
                }
            }
            else
            {
                info.Add(" |+IPv4 is not implemented: ");
            }


            if (nic.Supports(NetworkInterfaceComponent.IPv6) == true)
            {
                IPv6InterfaceProperties ipv6 = properties.GetIPv6Properties();
                info.Add(" +IPV6 Properties");

                if (ipv6 != null)
                {
                    info.Add("  +IPV6 Properties : ");
                    info.Add("  |Interface Index : " + ipv6.Index.ToString());
                    info.Add("  \\MTU Size : " + ipv6.Mtu.ToString());
                }
                else
                {
                    info.Add(" |Device has no IPV6 properties");
                }
            }

            else
            {
                info.Add(" +IPv6 is not Implemented");
            }

            foreach (string a in info)
            {
                listBoxDetail.Items.Add(a);
            }

        }

        private void ButtonGet_Click(object sender, EventArgs e)
        {
            listBoxDetail.Items.Clear();
            networkProc();
        }
    }
}
