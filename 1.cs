﻿using System;

namespace definiowanie struktur
{
    public struct Student
    {
        public string Imię;
        public string Nazwisko;
        public int NumerAlbumu;
        public string Kierunek;
        public int RokNauki;
        public List<string> ListaPrzedmiotów;
        public double Średnia;
    }
    public struct Przedmiot
    {
        public string NazwaPrzedmiotu;
        public string Prowadzący;
        public int LiczbaGodzin;
        public List<string> ListaStudentów;
    }
    public struct Nauczyciel_Akademicki
    {
        public string Imię;
        public string Nazwisko;
        public string Tytuł_Naukowy;
        public string Stopień_Naukowy;
        public List<string> ListaPrzedmiotów;
        public string Katedra;
    }
}