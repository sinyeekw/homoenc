using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Research.SEAL;

namespace homoenc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            EncryptionParameters parms = new EncryptionParameters(SchemeType.CKKS);

        }
    }
}
