using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AcademicEHR.Views
{
    public partial class FocusedAssessment : ContentPage
    {
        public FocusedAssessment()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
