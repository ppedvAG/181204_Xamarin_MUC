using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private bool selectedFlag;
        private ObservableCollection<Person> currentData;

        private void Button_Clicked(object sender, EventArgs e)
        {
            //listViewDaten.ItemsSource = new string[] { "Apfel","Birne","Banane","Orange" };
            currentData = new ObservableCollection<Person>
            {
                new Person{Image="https://picsum.photos/100/100/?image=1",Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Image="https://picsum.photos/100/100/?image=2",Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Image="https://picsum.photos/100/100/?image=3",Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300},
                new Person{Image="https://picsum.photos/100/100/?image=4",Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-4400},
                new Person{Image="https://picsum.photos/100/100/?image=5",Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=55555500},
                new Person{Image="https://picsum.photos/100/100/?image=6",Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=666600},
                new Person{Image="https://picsum.photos/100/100/?image=7",Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=-77700},
                new Person{Image="https://picsum.photos/100/100/?image=8",Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=88800},
                new Person{Image="https://picsum.photos/100/100/?image=9",Vorname="Axel",Nachname="Schweiß",Alter=90,Kontostand=99900},
                new Person{Image="https://picsum.photos/100/100/?image=10",Vorname="Marian",Nachname="Kron",Alter=100,Kontostand=-100}
            };
            listViewDaten.ItemsSource = currentData;
        }


        private void ListViewDaten_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Liste", "Selected", "Ok");
            selectedFlag = true;
        }

        private void ListViewDaten_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (selectedFlag)
            {
                selectedFlag = false;
                return;
            }
            DisplayAlert(((Person)e.Item).Vorname, "Tapped", "Ok");
        }

        private void ListViewDaten_Refreshing(object sender, EventArgs e)
        {
            currentData = new ObservableCollection<Person>
            {
                new Person{Image="https://picsum.photos/100/100/?image=1",Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Image="https://picsum.photos/100/100/?image=2",Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Image="https://picsum.photos/100/100/?image=3",Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300},
                new Person{Image="https://picsum.photos/100/100/?image=4",Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-4400},
                new Person{Image="https://picsum.photos/100/100/?image=5",Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=55555500},
                new Person{Image="https://picsum.photos/100/100/?image=6",Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=666600},
                new Person{Image="https://picsum.photos/100/100/?image=7",Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=-77700},
                new Person{Image="https://picsum.photos/100/100/?image=8",Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=88800},
                new Person{Image="https://picsum.photos/100/100/?image=9",Vorname="Axel",Nachname="Schweiß",Alter=90,Kontostand=99900},
                new Person{Image="https://picsum.photos/100/100/?image=10",Vorname="Marian",Nachname="Kron",Alter=100,Kontostand=-100}
            };
            listViewDaten.ItemsSource = currentData;
            // Variante 1)
            // listViewDaten.IsRefreshing = false;

            // Variante 2)
            listViewDaten.EndRefresh();
        }

        private void SearchBarSuchtext_TextChanged(object sender, TextChangedEventArgs e)
        {
            listViewDaten.ItemsSource = currentData.Where(x => x.Vorname.StartsWith(searchBarSuchtext.Text));
        }

        private void MenuItemInfo_Clicked(object sender, EventArgs e)
        {
            Person selected = listViewDaten.SelectedItem as Person;
            DisplayAlert($"{selected.Vorname} {selected.Nachname}",
                         $"Alter:{selected.Alter}, Kontostand: {selected.Kontostand}", "OK");
        }

        private void MenuItemLöschen_Clicked(object sender, EventArgs e)
        {
            Person selected = (sender as MenuItem).CommandParameter as Person;
            currentData.Remove(selected);


        }
    }
}
