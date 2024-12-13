using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ0412
{
    internal class Firma
    {
        public List<Employee> Employees;
        public Firma(string? nameFirma, string? profile, DateOnly date, string? nameDirector, int countEmployees, string? address)
        {
            NameFirma = nameFirma;
            ProfileBussines = profile;
            Date = date;
            NameDirector = nameDirector;
            CountEmployees = countEmployees;
            WhatCity = address;

            Employees = [];
        }

        public string? NameFirma { get; set; }
        public string? ProfileBussines { get; set; }
        public DateOnly Date {  get; set; }
        public string? NameDirector { get; set; }
        public int CountEmployees { get; set; }
        public string? WhatCity { get; set; }

        public override string ToString()
        {
            return $"NameFirma: {NameFirma} | ProfileBussines: {ProfileBussines} | NameDirector: {NameDirector} | City: {WhatCity} | CountEmployees {CountEmployees} | DateRelease: {Date}";
        }
    }
}
