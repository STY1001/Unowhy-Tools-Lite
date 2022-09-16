using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Unowhy_Tools_Lite
{
    public partial class Main : Form
    {
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 35, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 38, new[] { 1 }, 4);
        }

        string GetLine(string text, int lineNo)
        {
            string[] lines = text.Replace("\r", "").Split('\n');
            return lines.Length >= lineNo ? lines[lineNo - 1] : null;
        }

        public Main()
        {
            Process p = new Process();
            p.StartInfo.FileName = "wmic";
            p.StartInfo.Arguments = "bios get smbiosbiosversion";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            
            string enestr = p.StandardOutput.ReadToEnd();
            string enestr2 = GetLine(enestr, 2);

            Process p2 = new Process();
            p2.StartInfo.FileName = "wmic";
            p2.StartInfo.Arguments = "bios get smbiosbiosversion";
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p2.Start();

            string ifpstr = p.StandardOutput.ReadToEnd();
            string ifpstr2 = GetLine(ifpstr, 2);

            InitializeComponent();

            

            bios.Text = enestr2;

            if (ifpstr2.Contains("IFP2"))
            {
                if (bios.Text.Contains("_ENE"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene2022.ToString();
                    pass.Text = passstr;
                }
            }
            else
            {
                if (bios.Text.Contains("ENE_"))
                {
                    if (bios.Text.Contains("ENE_1"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene1.ToString();
                        pass.Text = passstr;
                    }

                    if (bios.Text.Contains("ENE_2"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene2.ToString();
                        pass.Text = passstr;
                    }

                    if (bios.Text.Contains("ENE_3"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene3.ToString();
                        pass.Text = passstr;
                    }

                    if (bios.Text.Contains("ENE_4"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene4.ToString();
                        pass.Text = passstr;
                    }

                    if (bios.Text.Contains("ENE_5"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene5.ToString();
                        pass.Text = passstr;
                    }

                    if (bios.Text.Contains("ENE_6"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene6.ToString();
                        pass.Text = passstr;
                    }

                    if (bios.Text.Contains("ENE_7"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene7.ToString();
                        pass.Text = passstr;
                    }
                }
                else
                {
                    if (bios.Text.Contains("timing"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene.ToString();
                        pass.Text = passstr;
                    }

                    if (bios.Text.Contains("_ENE"))
                    {
                        string passstr = Unowhy_Tools_Lite.Properties.Resources.ene.ToString();
                        pass.Text = passstr;
                    }
                }

                if (bios.Text.Contains("STY1001"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene2.ToString();
                    pass.Text = passstr;
                }

                if (pass.Text == "PASS")
                {
                    pass.Text = "Only for Y13 / Seulement pour le Y13";
                }
            }
        }

        private void sty_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sty1001.wordpress.com/");
        }

        private void git_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/STY1001/Unowhy-Tools-Lite");
        }

        private void gitu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/STY1001/Unowhy-Tools-Lite/releases/latest");
        }

        private void manual_Click(object sender, EventArgs e)
        {
            var m = new Manual();
            m.ShowDialog();
        }
    }
}
