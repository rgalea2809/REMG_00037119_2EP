using System;

namespace Hugo.databaseObjects
{
    public class UserOrder
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; }
        public int idAddress { get; set; }
        
        public UserOrder()
        {
            idOrder = 0;
            idProduct = 0;
            createDate = DateTime.Now;
            idAddress = 0;
        }
    }
}