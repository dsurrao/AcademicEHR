using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AcademicEHR.Views
{
    public class RespiratoryExamAbnormal : ContentPage
    {
        List<string> _findings = new List<string>(
            new string[] { "reports dyspnea with exertion",
                "reports dyspnea at rest",
                "c/o chest tightness",
                "c/o of pleuritic chest pain",
                "c/o cough",
                "cyanosis noted",
                "unable to speak in full sentences",
                "tachypnea noted",
                "bradypnea noted",
                "respirations shallow",
                "respirations deep",
                "nasal flaring noted",
                "retractions noted",
                "stridor/audible wheeze present",
                "cough noted",
                "sputum noted",
                "excessive oral secretions noted",
                "barrel chest noted",
                "Paradoxical chest movement noted",
                "unequal chest wall expansion",
                "point tenderness noted",
                "crepitus noted",
                "Tactile fremitus asymmetric or abnormal",
                "dullness to percussion",
                "hyperresonance to percussion",
                "adventitious breath sounds noted",
                "egophony noted",
                "friction rub noted",
                "pulse oximetry not at goal",
                "oxygen therapy in use",
                "receiving neutralizer therapy",
                "unable to C&DB",
                "unable to perform incentive spirometer",
                "Peak flow < 80% of personal best",
                "oral airway in use",
                "pharyngeal suctioning performed",
                "nasotracheal suctioning performed",
                "endotracheal suctioning performed",
                "Chest tube(s) insitu",
                "BIPAP in use",
                "ET/Trach tube in use",
                "mechanical ventilation in use"
            });

        public RespiratoryExamAbnormal()
        {
            this.Title = "Abnormal Findings";

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
                        Style = (Style)Application.Current.Resources["abnormalFinding"]
                    }, 1, i);
            }

            Label label = new Label
            {
                Text = "Abnormal Findings",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                Style = (Style)Application.Current.Resources["abnormalFinding"],
                Margin = 10
            };
            Button button = new Button { Text = "Next ", Style = (Style)Application.Current.Resources["buttonStyle"] };
            button.Clicked += async (sender, args)
                => await Navigation.PushAsync(new RespiratoryExamRRT());
            
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

