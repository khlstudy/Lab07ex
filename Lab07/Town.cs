using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Town
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public double YearIncome { get; set; }
        public double Square { get; set; }
        public bool HasPort { get; set; }
        public bool HasAirport { get; set; }

        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }

        public Town()
        {

        }

        public Town(string name, string country, string region, int population, double yearIncome, double square, bool hasPort, bool hasAirport)
        {
            Name = name; Country = country; Region = region;
            Population = population; YearIncome = yearIncome; Square = square; HasPort = hasPort; HasAirport = hasAirport;

        }
    }
}
