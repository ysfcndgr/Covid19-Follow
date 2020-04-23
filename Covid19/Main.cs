using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Covid19
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
  


        private void btnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Main_Load(object sender, EventArgs e)

        {


            btnOff.FlatStyle = FlatStyle.Flat;

            btnOff.BackColor = Color.Transparent;

            btnOff.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnOff.FlatAppearance.MouseOverBackColor = Color.Transparent;
          

            location.Items.AddRange(Results.comboBoxValue().ToArray());



        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void borderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;

        }

        private void borderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void borderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }


        private void location_SelectedValueChanged(object sender, EventArgs e)
        {
           
            List<CoronaInfo> coronaresult = JsonConvert.DeserializeObject<List<CoronaInfo>>(Results.CountryCase().ToString());
            foreach (var item in coronaresult)
            {
          
                if (item.Country.ToString() == location.Text)
                {
                    
                    result1.Text = item.NewConfirmed.ToString();
                    result2.Text = item.TotalConfirmed.ToString();
                    result3.Text = item.NewDeaths.ToString();
                    result4.Text = item.TotalDeaths.ToString();
                    result5.Text = item.NewRecovered.ToString();
                    result6.Text = item.TotalRecovered.ToString();
                    break;
                }

            }

        }
    }
}
