using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Hugo.CustomExceptions;
using Hugo.databaseObjects;

namespace Hugo.DataAccessObjects
{
    public class addressDAO
    {
        public static List<Direccion> getAdress()
        {
            string query = "SELECT * FROM address";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            List<Direccion> lista = new List<Direccion>();
            foreach (DataRow fila in dt.Rows)
            {
                Direccion d = new Direccion();
                d.idAddress = Convert.ToInt16(fila[0].ToString());
                d.idUser = Convert.ToInt16(fila[1].ToString());
                d.address = fila[2].ToString();
                lista.Add(d);
            }
            return lista;
        }
        
        public static DataTable getAddressdt()
        {
            string query = "SELECT * FROM address";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            return dt;
        }

        public static void addDireccion(int idUser, string address)
        {
            try
            {
                if (address == " ")
                {
                    throw new EmptyInputFieldException("No deje cmapos vacios!");
                }

                string nQ = $"INSERT INTO address(\"idUser\", address) VALUES(" +
                            $"{idUser}, " +
                            $"'{address}')";
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show($"Se ha agregado la direccion '{address}' correctamente");

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
        
        public static void removeAddress(int idAddress)
        {
            try
            {
                string nQ = String.Format(
                    $"DELETE FROM apporder WHERE \"idAddress\"= {idAddress}; "+
                    $"DELETE FROM address WHERE \"idAddress\" = {idAddress}");
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show("Se ha eliminado la direccion de la base datos, " +
                                "al igual que las ordenes relacionadas.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        public static void modAddress(string nAddress, int idAddress)
        {
            try
            {
                if (nAddress == " ")
                {
                    throw new EmptyInputFieldException("Por favor ingrese una nueva direccion!");
                }

                string nQ = $"UPDATE address SET address = '{nAddress}' WHERE \"idAddress\" = {idAddress} ";
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show($"Se ha actualizado la Direccion de '{nAddress}' exitosamente");
            }
            catch (EmptyInputFieldException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }
      
    }
}