using System;
namespace pawnshop
{
    public abstract class Pawnshop
    {
        public string title { get; set; }
        private string street;
        private string house;
        private string Balance;
        public string  Address { get { return $"{street} {house}"; }
            set { street = value.Split()[0]; house = value.Split()[1]; } }
        public void SetHouse(string house) => this.house = house;
        public void SerStreet(string street) => this.street = street;
        public abstract string GetInfo();

    }
}