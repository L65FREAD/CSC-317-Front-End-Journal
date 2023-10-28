using System;
using Microsoft.Maui.Controls;

namespace MAUI_Journal_App.Pages
{
    public partial class JournalList : ContentPage
    {
        public JournalList()
        {
            InitializeComponent();

            lstJournalList.ItemsSource = App.journals;

            lstJournalList.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                
                lstJournalList.SelectedItem = null;
            }
        }
    }
}
