using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_list_wfapp
{
    public partial class ITInfoUserControl : UserControl
    {
        public ITInfoUserControl()
        {
            InitializeComponent();
        }

        public ITInfoUserControl(string name, string cities, string count): this()
        {            
            comapanyNameL.Text = name;
            citiesL.Text = cities;
            emplCountL.Text = count;
        }
    }
}
