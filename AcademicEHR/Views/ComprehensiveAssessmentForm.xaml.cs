using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AcademicEHR.Views
{
    public partial class ComprehensiveAssessmentForm : ContentPage
    {
        public ComprehensiveAssessmentForm()
        {
            InitializeComponent();
        }

        async void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (((ListView)sender).SelectedItem.Equals("Resp"))
            {
                await Navigation.PushAsync(new RespiratoryExamNormal());
            }
        }
    }
}
