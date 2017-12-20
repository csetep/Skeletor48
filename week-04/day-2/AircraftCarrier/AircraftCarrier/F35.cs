namespace AircraftCarrier
{
    class F35 : Aircraft
    {
        public F35() : base(12, 50)
        {
            Type = "F35";
        }

        public string GetAircraftType()
        {
            return Type;
        }
    }
}
