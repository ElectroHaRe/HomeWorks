using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerTypes
{
    public partial class TypeLimitsForm : Form
    {
        public TypeLimitsForm()
        {
            InitializeComponent();
        }

        private string LimitMessage(string minValue, string maxValue) {
            return "MinValue:" + minValue + " , MaxValue: " + maxValue;
        }

        private void byteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(Byte.MinValue.ToString(), Byte.MaxValue.ToString()));
        }

        private void sbyteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(SByte.MinValue.ToString(), SByte.MaxValue.ToString()));
        }

        private void shortButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(short.MinValue.ToString(), short.MaxValue.ToString()));
        }

        private void ushortButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(ushort.MinValue.ToString(), ushort.MaxValue.ToString()));
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(int.MinValue.ToString(), int.MaxValue.ToString()));
        }

        private void uintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(uint.MinValue.ToString(), uint.MaxValue.ToString()));
        }

        private void longButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(long.MinValue.ToString(), long.MaxValue.ToString()));
        }

        private void ulongButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LimitMessage(ulong.MinValue.ToString(), ulong.MaxValue.ToString()));
        }
    }
}
