using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatenSpeichernUndLaden
{
    [Table("Personen")]
    class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public decimal Kontostand { get; set; }
    }
}
