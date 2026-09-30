namespace klassbiblotek
{
    public class Utrustning
    {
        public int Id { get; }
        public string Namn { get; }
        public bool ArUtlanad { get; private set; }

        public Utrustning(int id, string namn)
        {
            Id = id;
            Namn = namn;
            ArUtlanad = false;
        }

        public bool Lana()
        {
            if (ArUtlanad)
            {
                return false;
            }

            ArUtlanad = true;
            return true;
        }

        public bool Aterlamna()
        {
            if (!ArUtlanad)
            {
                return false;
            }

            ArUtlanad = false;
            return true;
        }
    }
}