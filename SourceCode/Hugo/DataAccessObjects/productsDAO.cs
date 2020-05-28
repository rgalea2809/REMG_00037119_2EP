using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Hugo.CustomExceptions;
using Hugo.databaseObjects;

namespace Hugo.DataAccessObjects
{
    public class productsDAO
    {
        public static List<Producto> getProducts()
        {
            string query = "SELECT * FROM product";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            List<Producto> lista = new List<Producto>();
            foreach (DataRow fila in dt.Rows)
            {
                Producto p = new Producto();
                p.idProduct = Convert.ToInt16(fila[0].ToString());
                p.idBusiness = Convert.ToInt16(fila[1].ToString());
                p.name = fila[2].ToString();
                lista.Add(p);
            }
            return lista;
        }

        public static void addProduct(string name, int idBusiness)
        {
            try
            {
                if (name == " ")
                {
                    throw new EmptyInputFieldException("Debe completar todos los campos!");
                }

                string nQ = $"INSERT INTO product(\"idBusiness\", name) " +
                            $"VALUES({idBusiness}, '{name}')";
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show($"Se ha agregado el Producto '{name}' correctamente");

            }
            catch (EmptyInputFieldException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }

        public static void removeProduct(int idProduct)
        {
            try
            {
                string nQ = String.Format(
                    $"DELETE FROM apporder WHERE \"idProduct\"= {idProduct}; "+
                    $"DELETE FROM product WHERE \"idProduct\" = {idProduct}");
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show("Se ha eliminado el Producto de la base datos, " +
                                "al igual que las ordenes relacionadas al mismo.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
       
    }
}