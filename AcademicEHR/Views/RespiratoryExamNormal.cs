using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AcademicEHR.Views
{
    public class RespiratoryExamNormal: ContentPage
    {
        List<string> _findings = new List<string>(
            new string[] { "no complaints of breathing",
                "no chest tightness",
                "no pleuritic chest pains",
                "denies cough, sputum",
                "no stridor or audible wheeze",
                "to speak in full sentences",
                "maintaining own airway",
                "acyanotic",
                "trachea midline",
                " respiration even and unlabored",
                "AP diameter is not increased",
                "chest expansion equal",
                "denies point tenderness",
                "no crepitus",
                "Tactile fremitus symmetric",
                "resonant to percussion throughout",
                "Lungs clear to auscultation",
                "pulse oximetry at goal",
                "no oyxgen in use",
                "able to cough and deep breathe",
                "incentive spirometry in use",
                "peak flow at personal best",
            });

        public RespiratoryExamNormal()
        {
            this.Title = "Normal Findings";

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
                        Style = (Style)Application.Current.Resources["normalFinding"]
                    }, 1, i);
            }

            Label label = new Label { Text = "Normal Findings",
                FontSize = 30,
                Style = (Style)Application.Current.Resources["normalFinding"],
                FontAttributes = FontAttributes.Bold,
                Margin = 10
            };
            Button button = new Button { Text = "Next ", Style = (Style)Application.Current.Resources["buttonStyle"] };
            button.Clicked += async (sender, args)
                => await Navigation.PushAsync(new RespiratoryExamAbnormal());

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = { label, grid, button },
                    Margin = 20
                }
            };
        }
    }
}
