using System;
using System.Collections.Generic;
using System.Data;
using Hugo.databaseObjects;

namespace Hugo.DataAccessObjects
{
    public class apporderDAO
    {
        public static List<Orden> getOrders()
        {
            string query = "SELECT * FROM apporder";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            List<Orden> lista = new List<Orden>();
            foreach (DataRow fila in dt.Rows)
            {
                Orden o = new Orden();
                o.idOrder = Convert.ToInt16(fila[0].ToString());
                o.createDate = DateTime.Parse(fila[1].ToString());
                o.idProduct = Convert.ToInt16(fila[2].ToString());
                o.idAddress = Convert.ToInt16(fila[3].ToString());
                lista.Add(o);
            }
            return lista;
        }
    }
}