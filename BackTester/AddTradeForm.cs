using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackTester
{
    public partial class AddTradeForm : Form
    {
        public double m_entryPrice;
        public double m_stopLossPrice;
        public double m_exitPrice;
        public Enums.Direction m_direction;
        public AddTradeForm()
        {
            InitializeComponent();
        }
    }
}
