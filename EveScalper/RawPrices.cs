namespace EveScalper
{
    class RawPrices
    {
        public readonly string Name;
        public readonly string Buy;
        public readonly string Sell;
        public readonly string Volume;

        public RawPrices(string name, string buy, string sell, string volume)
        {
            this.Name = name;
            this.Buy = buy;
            this.Sell = sell;
            this.Volume = volume;
        }

    }
}
