using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Interfaces;

namespace HostApplication
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      if (cboAssemblyName.Items.Count > 0)
      {
        cboAssemblyName.SelectedIndex = 0;
      }

      if (cboClassName.Items.Count > 0)
      {
        cboClassName.SelectedIndex = 0;
      }
    }

    private void cmdExecute_Click(object sender, EventArgs e)
    {
      try
      {
        using (AppDomainProxy pAppDomainProxy = new AppDomainProxy())
        {
          ISampleInterface pI = pAppDomainProxy.CreateInstance(cboAssemblyName.Text, cboClassName.Text);

          if (pI != null)
          {
            txtOutput.Text = pI.GetValue(txtParameter.Text);
            MessageBox.Show("Now is the time to look both AppDomain before it gets deleted!");
          }
          else
          {
            throw new ApplicationException("Could not load assembly " + cboAssemblyName.Text);
          }
        }
      }
      catch (Exception pException)
      {
        MessageBox.Show(pException.Message);
      }
    }
  }
}
