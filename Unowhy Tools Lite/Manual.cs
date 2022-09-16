using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unowhy_Tools_Lite
{
    public partial class Manual : Form
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

        public Manual()
        {
            InitializeComponent();

            string passstr = Unowhy_Tools_Lite.Properties.Resources.ene.ToString();
            pass.Text = passstr;
        }

        private void ene_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ene.Text.Contains("ENE_"))
            {
                if (ene.Text.Contains("ENE_1"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene1.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE_2"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene2.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE_3"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene3.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE_4"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene4.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE_5"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene5.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE_6"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene6.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE_7"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene7.ToString();
                    pass.Text = passstr;
                }
            }
            else
            {
                if (ene.Text.Contains("timing"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE (2019/2020)"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene.ToString();
                    pass.Text = passstr;
                }

                if (ene.Text.Contains("ENE (2022)"))
                {
                    string passstr = Unowhy_Tools_Lite.Properties.Resources.ene2022.ToString();
                    pass.Text = passstr;
                }
            }
        }
    }
}
