using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMDemo.Services
{
    class PersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Image="https://picsum.photos/100/100/?image=11",Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Image="https://picsum.photos/100/100/?image=22",Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Image="https://picsum.photos/100/100/?image=33",Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300},
                new Person{Image="https://picsum.photos/100/100/?image=44",Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-4400},
                new Person{Image="https://picsum.photos/100/100/?image=55",Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=55555500},
                new Person{Image="https://picsum.photos/100/100/?image=66",Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=666600},
                new Person{Image="https://picsum.photos/100/100/?image=77",Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=-77700},
                new Person{Image="https://picsum.photos/100/100/?image=88",Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=88800},
                new Person{Image="https://picsum.photos/100/100/?image=99",Vorname="Axel",Nachname="Schweiß",Alter=90,Kontostand=99900},
                new Person{Image="https://picsum.photos/100/100/?image=100",Vorname="Marian",Nachname="Kron",Alter=100,Kontostand=-100}
            };
        }
    }
}
