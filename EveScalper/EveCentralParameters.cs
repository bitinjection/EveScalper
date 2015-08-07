namespace EveScalper
{
    public class EveCentralParameters
    {
        public readonly int Id;
        public readonly int Hours;
        public readonly int System;

        public EveCentralParameters(int id, int hours, int system)
        {
            this.Id = id;
            this.Hours = hours;
            this.System = system;
        }
    }
}
