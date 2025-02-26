﻿namespace Aircompany.Planes // удалил лишнюю директирву using
{
    public class PassengerPlane : Plane
    {
        private int _passengersCapacity;

        // переписал конструктор в стрелочный
        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity) => _passengersCapacity = passengersCapacity; 

        public int PassengersCapacity => _passengersCapacity;

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null && base.Equals(obj) && _passengersCapacity == plane._passengersCapacity; // return в одну строку
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + _passengersCapacity.GetHashCode();
            return hashCode;
        }

        public override string ToString() => $"Passenger {base.ToString()}, passengersCapacity = {_passengersCapacity}"; // переписал в виде стрелочной функции
    }
}
