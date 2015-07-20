using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tr.Com.Panaroma.Ngcrd.SecurityVerifyTool
{
    /// <summary>
    /// This form describes how to use SecurityVerifyTool library
    /// </summary>
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateVerifyKey_Click(object sender, EventArgs e)
        {
            string verificationKey;
            string fiscalCode;
            string fiscalNum;
            string serviceId;
            string dllDescription;

            int dllRetCode = SecurityVerifier.GenerateVerifyKey(
                txtInSModeId.Text, 
                txtInFiscalNum.Text, 
                txtInServiceId.Text,
                out verificationKey,
                out fiscalCode,
                out fiscalNum,
                out serviceId,
                out dllDescription);

            txtOutVerificationKey.Text = verificationKey;
            txtOutFiscalCode.Text = fiscalCode;
            txtOutFiscalNum.Text = fiscalNum;
            txtOutServiceId.Text = serviceId;
            txtOutDllMessage.Text = dllDescription;
            txtOutDllRetCode.Text = Convert.ToString(dllRetCode);
        }
    }
}
