using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Hugo.databaseObjects;

namespace Hugo.DataAccessObjects
{
    public class businessDAO
    {
        public static List<Negocio> getBusiness()
        {
            string query = "SELECT * FROM business";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            List<Negocio> lista = new List<Negocio>();
            foreach (DataRow fila in dt.Rows)
            {
                Negocio u = new Negocio();
                u.idBusiness = Convert.ToInt16(fila[0].ToString());
                u.name = fila[1].ToString();
                u.description = fila[2].ToString();
                lista.Add(u);
            }
            return lista;
        }
        public static List<int> getBusinessProducts(string negocio, int idBusiness)
        {
            string query = $"SELECT idProduct FROM product WHERE idBusiness = {idBusiness}";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            List<int> lista = new List<int>();
            foreach (DataRow fila in dt.Rows)
            {
                lista.Add(Convert.ToInt16(fila[0].ToString()));
            }
            return lista;
        }
        public static void addBusiness(string name, string description)
        {
            if (name == " " ||
                description == " ")
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string nQ = $"INSERT INTO business(name, description) " +
                                $"VALUES('{name}', '{description}')";
                    dbHelper.ExecuteNonQuery(nQ);
                    MessageBox.Show($"Se ha agregado el negocio '{name}' correctamente");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);Console.WriteLine(e.Message);
                    MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
                }
            }
        }
        public static void removeBusiness(string name, int idbusiness)
        {
            try
            {
                List<int> productsIds = getBusinessProducts(name, idbusiness);
                foreach (var product in productsIds)
                {
                    string nQ1 = $"DELETE FROM apporder WHERE idProduct= {product}";
                    dbHelper.ExecuteNonQuery(nQ1);
                }
                string nQ = String.Format(
                    $"DELETE FROM product WHERE idBusiness= {idbusiness} ;" +
                    $"DELETE FROM business WHERE name = '{name}'");

                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show("Se ha eliminado el negocio de la base datos, " +
                                "al igual que los productos y ordenes relacionadas.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}