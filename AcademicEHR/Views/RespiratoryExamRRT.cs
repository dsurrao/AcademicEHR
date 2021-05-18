using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AcademicEHR.Views
{
    public class RespiratoryExamRRT : ContentPage
    {
        List<string> _findings = new List<string>(
            new string[] {
                "Respiratory rate < 8-10 or > 28-30",
                "Unable to maintain airway",
                "Trachea deviated",
                "Pulse oximetry < 90% (<88% in CO2 retaining pt)",
                "Hypoxemia persists despite upward oxygen titration"
            });

        public RespiratoryExamRRT()
        {
            this.Title = "RRT Criteria";

            Grid grid = new Grid
            {
                ColumnDefinitions =
            {
                new ColumnDefinition{ Width =
                    new GridLength(0.05, GridUnitType.Star) },
                new ColumnDefinition{ Width =
                    new GridLength(0.95, GridUnitType.Star) },
            }
            };

            for (var i = 0; i < _findings.Count; i++)
            {
                grid.Children.Add(new CheckBox(), 0, i);
                grid.Children.Add(
                    new Label
                    {
                        Text = _findings[i],
                        Style = (Style)Application.Current.Resources["rrtCriteria"]
                    }, 1, i);
            }

            Label label = new Label
            {
                Text = "RRT Criteria",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                Style = (Style)Application.Current.Resources["rrtCriteria"],
                Margin = 10
            };
            Button button = new Button { Text = "Next ", Style = (Style)Application.Current.Resources["buttonStyle"] };
            button.Clicked += async (sender, args)
                => await Navigation.PushAsync(new FocusedAssessment());
            Label note = new Label { Text = "If you select one of the RRT criteria. Activate RRT and prepare your SBAR using the SBAR/RRT form",
                Style = (Style)Application.Current.Resources["rrtCriteria"],
            };

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = { label, grid, note, button },
                    Margin = 20
                }
            };
        }
    }
}

