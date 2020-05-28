using System;

namespace Hugo.databaseObjects
{
    public class Orden
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; }
        public int idAddress { get; set; }
        
        public Orden()
        {
            idOrder = 0;
            idProduct = 0;
            createDate = DateTime.Now;
            idAddress = 0;
        }
    }
}