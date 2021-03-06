﻿using System;

namespace BlazorAppFITSTIC.Data
{
    public class Student
    {
        public int Id { get; set; }
        public DateTime Inserimento { get; set; }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime Nascita { get; set; }
        public int AnnoIscrizione { get; set; }

        public Student() { }

        public Student(string nome, string cognome, DateTime nascita, int annoIscr)
        {
            Nome = nome;
            Cognome = cognome;
            Nascita = nascita;
            AnnoIscrizione = annoIscr;
            Inserimento = DateTime.Now;

            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentNullException("Nome");

            if (string.IsNullOrEmpty(Cognome))
                throw new ArgumentNullException("Cognome");

            if (AnnoIscrizione <= DateTime.Now.Year - 2)
                throw new ArgumentOutOfRangeException("AnnoIscrizione");
        }
    }
}
