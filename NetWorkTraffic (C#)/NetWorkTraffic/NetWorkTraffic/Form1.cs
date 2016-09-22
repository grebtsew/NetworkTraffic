using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Management;
using System.Diagnostics;


namespace NetWorkTraffic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadUnitData(); 
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void loadUnitData()
        {
            string hostName = Dns.GetHostName();
            HName.Text = hostName;
            OwnIP.Text = Dns.GetHostByName(hostName).AddressList[0].ToString();

            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            gIP.Text = externalip;


            if (CheckForInternetConnection())
            {
                connected.Text = "YES";
            } else
            {
                connected.Text = "NO";
                return;
            }

            var macAddr =
    (
        from nic in NetworkInterface.GetAllNetworkInterfaces()
        where nic.OperationalStatus == OperationalStatus.Up
        select nic.GetPhysicalAddress().ToString()
    ).FirstOrDefault();

            mac.Text = macAddr;


        

            StringBuilder sb = new StringBuilder();

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            sb.AppendLine(string.Format("Interface information for {0}.{1}     ",
                    computerProperties.HostName, computerProperties.DomainName));
            if (nics == null || nics.Length < 1)
            {
                sb.AppendLine("  No network interfaces found.");
                return;
            }

            sb.AppendLine(string.Format("  Number of interfaces .................... : {0}", nics.Length));
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                sb.AppendLine();
                sb.AppendLine(adapter.Description);
                sb.AppendLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                sb.AppendLine(string.Format("  Interface type .......................... : {0}", adapter.NetworkInterfaceType));
                sb.AppendLine(string.Format("  Physical Address ........................ : {0}",
                           adapter.GetPhysicalAddress().ToString()));
                sb.AppendLine(string.Format("  Operational status ...................... : {0}",
                    adapter.OperationalStatus));
                string versions = "";

                // Create a display string for the supported IP versions. 
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }
                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }
                sb.AppendLine(string.Format("  IP version .............................. : {0}", versions));
                sb.AppendLine(string.Format(properties.ToString()));

                // The following information is not useful for loopback adapters. 
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    continue;
                }
                sb.AppendLine(string.Format("  DNS suffix .............................. : {0}",
                    properties.DnsSuffix));

                string label;
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();
                    sb.AppendLine(string.Format("  MTU...................................... : {0}", ipv4.Mtu));
                    if (ipv4.UsesWins)
                    {

                        IPAddressCollection winsServers = properties.WinsServersAddresses;
                        if (winsServers.Count > 0)
                        {
                            label = "  WINS Servers ............................ :";
                            sb.AppendLine(string.Format(label, winsServers));
                        }
                    }
                }

                sb.AppendLine(string.Format("  DNS enabled ............................. : {0}",
                    properties.IsDnsEnabled));
                sb.AppendLine(string.Format("  Dynamically configured DNS .............. : {0}",
                    properties.IsDynamicDnsEnabled));
                sb.AppendLine(string.Format("  Receive Only ............................ : {0}",
                    adapter.IsReceiveOnly));
                sb.AppendLine(string.Format("  Multicast ............................... : {0}",
                    adapter.SupportsMulticast));

                sb.AppendLine("Speed Test : ");

                

                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface ni in interfaces)
                {
                    sb.AppendLine(string.Format("    Bytes Sent: {0}",
                        ni.GetIPv4Statistics().BytesSent));
                    sb.AppendLine(string.Format("    Bytes Received: {0}",
                        ni.GetIPv4Statistics().BytesReceived));
                }

            }

            // ipconfig/all
            sb.AppendLine("ipconfig/all");
            sb.AppendLine(runProcess("ipconfig", "/all"));
            // "new view"; // router
            sb.AppendLine("net view");
            sb.AppendLine(runProcess("net", "view"));
            //  "arp -a"; // local units
            sb.AppendLine("arp -a");
            sb.AppendLine(runProcess("arp", "-a"));
            //  "netstat –ano"; // all connections
            sb.AppendLine("netstat –ano");
            sb.AppendLine(runProcess("netstat", "-o"));
            //  "nslookup " + externalip.Replace("\n", ""); // all connections
            sb.AppendLine("nslookup " + externalip.Replace("\n", ""));
            sb.AppendLine(runProcess("nslookup", externalip.Replace("\n", "")));

            richTextBox1.Text = sb.ToString();

        }

        private string runProcess(string command, string param)
        {
            //  Create process
            Process pProcess = new Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = command; 
                                                      //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = param;

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();
            return strOutput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}
