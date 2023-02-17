using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nationalEconomics
{
    public partial class USA : Form
    {
        bool flag;
        public USA(bool flag1)
        {
            flag = flag1;
            InitializeComponent();

            if (flag == true)
            {
                UStext.Text = "вы огорчили партию\n" +
                    "партия отнять у вас права\n" +
                    "миска риса и кошко жена\n" +
                    "ваши нологи повышены";
                USpictureBox.Load("../../pictures/amongass.gif");
            }
            else
            {
                UStext.Text = "молодчинка красавчик вот это православно\n" +
                    "партия выдать вам лада ларгус";
                USpictureBox.Load("../../pictures/pivasik.gif");
            }
            
        }

        private void USA_Load(object sender, EventArgs e)
        {

        }
    }
}
