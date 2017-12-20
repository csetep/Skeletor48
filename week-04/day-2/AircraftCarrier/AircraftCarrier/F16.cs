namespace AircraftCarrier
{
    class F16 : Aircraft
    {
        public F16() : base(8, 30)
        {
            Type = "F16";
        }

        public string GetAircraftType()
        {
            return Type;
        }
    }
}
