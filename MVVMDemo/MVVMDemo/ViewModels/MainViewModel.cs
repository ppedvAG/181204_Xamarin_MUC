using MVVMDemo.Helpers;
using MVVMDemo.Models;
using MVVMDemo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            GetPersonenCommand = new Command(GetPersonen);

            // Controllfreak-Antipattern
            service = new PersonenService();
        }

        private readonly PersonenService service;
        private void GetPersonen(object commandParameter)
        {
            Personenliste = service.GetPersonen();
        }
        public Command GetPersonenCommand { get; set; }

        // Fody-Weaver
        private List<Person> personenListe;
        public List<Person> Personenliste
        {
            get => personenListe;
            set => SetValue(ref personenListe, value);
        }
    }
}
