using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MySample
{
    internal class Trip
    {
        public string Hotel { get; set; }
        public string Flight { get; set; }
        public string Car { get; set; }

        public override string ToString()
        {
            return $"Hotel: {Hotel}, Flight: {Flight}, Car: {Car}";
        }

        public class Builder
        {
            private Trip trip = new Trip();

            public Builder SetHotel(string hotel)
            {
                trip.Hotel = hotel;
                return this;
            }

            public Builder SetFlight(string flight)
            {
                trip.Flight = flight;
                return this;
            }

            public Builder SetCar(string car)
            {
                trip.Car = car;
                return this;
            }

            public Trip Build()
            {
                return trip;
            }
        }
    }
}
