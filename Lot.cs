using System;

namespace XML_JSON_dz
{
    [Serializable]
    public class Lot
    {

        public int Id { get; set; }
        public string NameLot { get; set; }
        public string NameReception { get; set; }
        public int Sum { get; set; }
        public DateTime Time { get; set; }
        public Lot() { }
        public Lot(string nameL, string nameR, int sum, int id)
        {
            Id = id;
            Time = DateTime.Now;
            NameLot = nameL;
            NameReception = nameR;
            Sum = sum;
        }

    }
}
