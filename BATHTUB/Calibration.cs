using System;
using System.Windows.Forms;
using BT2Support.UpgradeStubs;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace BathtubNet.Upgraded
{
    partial class frmCalibration : Form
    {
        private static frmCalibration m_vb6FormDefInstance;
        private static bool m_InitializingDefInstance;
        private bool isInitializingComponent;

        public frmCalibration()
        {
            bool mustCallFormLoad = false;
            if (m_vb6FormDefInstance == null)
            {
                if (m_InitializingDefInstance)
                {
                    m_vb6FormDefInstance = this;
                }
                else
                {
                    try
                    {
                        if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null &&
                            System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                        {
                            m_vb6FormDefInstance = this;
                        }
                    }
                    finally
                    {
                        mustCallFormLoad = true;
                    }
                }
            }

            isInitializingComponent = true;
            InitializeComponent();
            isInitializingComponent = false;
            ReLoadForm(false);

            if (mustCallFormLoad && m_vb6FormDefInstance != null)
            {
                m_vb6FormDefInstance.Form_Load();
            }
        }

        private void frmCalibration_Activated(object sender, EventArgs e)
        {
            if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != sender)
            {
                UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = sender;
            }
        }

        private void Form_Load()
        {
            int k;
            double i = Math.Max(0, Math.Min(2, Iop[7] - 1));
            OptOption[(int)i].Checked = true;

            lblDefinitions.Text = "Ready";
            txtCalib.Text = "";

            for (int j = 1; j <= 4; j++)
            {
                chkVariable[j - 1].CheckState = CheckState.Unchecked;
                chkVariable[j - 1].Enabled = false;
                k = 0;

                for (i = 1; i <= Nseg; i++)
                {
                    if (Cobs[(int)i, j] > 0) k++;
                }

                if (k > 0 && Iop[j] > 0) chkVariable[j - 1].Enabled = true;
            }

            if (chkVariable[1].Enabled) chkVariable[1].CheckState = CheckState.Checked;

            List1.Items.Clear();
            for (i = 1; i <= Nseg; i++)
            {
                List1.Items.Add(string.Format("{0:00} {1}", i, SegName[(int)i]));
            }
            ListBoxHelper.SetSelectedIndex(List1, 1);

            optMethod[0].Checked = true;
            List1.Enabled = !optMethod[0].Checked;
        }

        private int optM()
        {
            int result = 0;
            for (int i = 0; i <= 2; i++)
            {
                if (optMethod[i].Checked) result = i;
            }
            return result;
        }

        private void optMethod_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(optMethod, sender);
            if (((RadioButton)sender).Checked)
            {
                if (isInitializingComponent) return;
                List1.Enabled = index != 0;
            }
        }

        private void OptOption_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(OptOption, sender);
            if (((RadioButton)sender).Checked)
            {
                if (isInitializingComponent) return;
                Iop[7] = index + 1;
                Iop[8] = index + 1;
            }
        }

        private void Toolbar1_ButtonClick(object sender, EventArgs e)
        {
            ToolStripItem Button = (ToolStripItem)sender;

            switch (Button.Text)
            {
                case "Run":
                    switch (optM())
                    {
                        case 0:
                            GlobalCalib(2);
                            break;
                        case 1:
                            LocalCalib(1);
                            break;
                        case 2:
                            LocalCalib(0);
                            break;
                    }
                    FitUpdate();
                    break;

                case "Reset All":
                    txtCalib.Text = "";
                    for (int j = 1; j <= 4; j++)
                    {
                        Xk[j] = 1;
                        for (double i = 1; i <= Nseg; i++)
                        {
                            Cal[(int)i, j] = 1;
                        }
                    }
                    Model();
                    FitUpdate();
                    break;

                case "Reset":
                    txtCalib.Text = "";
                    for (int j = 1; j <= 4; j++)
                    {
                        if (chkVariable[j - 1].CheckState != CheckState.Unchecked)
                        {
                            if (optM() == 0)
                            {
                                Xk[j] = 1;
                            }
                            else
                            {
                                for (double i = 1; i <= Nseg; i++)
                                {
                                    if (ListBoxHelper.GetSelected(List1, (int)i - 1))
                                    {
                                        Cal[(int)i, j] = 1;
                                    }
                                }
                            }
                        }
                    }
                    Model();
                    FitUpdate();
                    break;

                case "List":
                    Model();
                    FitUpdate();
                    break;

                case "Help":
                    // Help functionality not upgraded
                    break;

                case "Quit":
                    Icalc = 0;
                    FormUpdate();
                    this.Close();
                    break;
            }
        }

        private void FitUpdate()
        {
            if (Icalc == 0) return;
            lblDefinitions.Text = "Listing Results...";
            List_Fits();
            ViewSheet("calibrations");
            lblDefinitions.Text = "Ready";
        }

        private void Form_Closed(object sender, EventArgs e)
        {
        }
    }
}
