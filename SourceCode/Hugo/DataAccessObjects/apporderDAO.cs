using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Hugo.CustomExceptions;
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
        public static List<Orden> getUserOrdersIDS(Usuario u)
        {
            try
            {
                string Q = "SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                    "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                    $"AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {u.idUser};";
           

                DataTable dt = dbHelper.ExecuteQuery(query: Q);
                List<Orden> lista = new List<Orden>();
                foreach (DataRow fila in dt.Rows)
                {
                    Orden o = new Orden();
                    o.idOrder = Convert.ToInt16(fila[0].ToString());
                    lista.Add(o);
                }
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }
        public static DataTable getUserOrdersdt(Usuario u)
        {
        
            string Q = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                        $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                        $"WHERE ao.idProduct = pr.idProduct " +
                        $"AND ao.idAddress = ad.idAddress " +
                        $"AND ad.idUser = au.idUser AND au.idUser = {u.idUser}";

            DataTable dt = dbHelper.ExecuteQuery(query: Q);
            return dt;
        }
        public static void createOrder(DateTime date, int idProduct, int idAddress)
        {
            string fecha = date.ToString("yyyy/MM/dd");
            try
            {
                string nQ = $"INSERT INTO apporder(createDate, idProduct, idAddress) " +
                            $"VALUES('{fecha}', {idProduct}, {idAddress})";
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show($"Se ha agregado la orden correctamente");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }

        public static void removeUserOrder(int idOrder)
        {
            try
            {
                string nQ = String.Format($"DELETE FROM apporder WHERE idOrder= {idOrder}");
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show("Se ha eliminado La orden de la Base de Datos");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        
            
    }
}