using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleIntrest
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();            

        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            float Intreast, TAmnt, year, IAmnt,total;
            Intreast = Convert.ToInt32(Intrest.Text);
            IAmnt = Convert.ToInt32(Amount.Text);
            year = Convert.ToInt32(Year.Text);
          
            TAmnt = (Intreast * IAmnt * year) /100;
            IAmount.Text = "₹" + Convert.ToString(TAmnt);
            total = TAmnt + IAmnt;
            TOTAL.Text = "₹" + Convert.ToString(total);
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            Intrest.Text = "";
            Amount.Text = "";
            Year.Text = "";
            IAmount.Text = "";
            TOTAL.Text = "";
        }
    }
}
