using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace ReproAnimationWindowsBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Animate(lbl);
            Animate(box);
            Animate(grid);
            Animate(btn);
        }

        private void Animate(VisualElement element)
        {
            new Animation
            {
                { 0, 1, new (v => element.BackgroundColor = 
                new Color(element.BackgroundColor.Red, element.BackgroundColor.Green, 
                (float)v, element.BackgroundColor.Alpha),
                    element.BackgroundColor.Blue, 1) }
            }
            .Commit(element, "test", 16, 250, Easing.Linear, (d, b) => { });
        }
    }
}
