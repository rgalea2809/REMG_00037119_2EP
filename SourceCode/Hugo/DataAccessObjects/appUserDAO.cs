using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Hugo.databaseObjects;

namespace Hugo.DataAccessObjects
{
    public class appUserDAO
    {
        public static List<Usuario> getUsers()
        {
            string query = "SELECT * FROM appuser";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.idUser = Convert.ToInt16(fila[0].ToString());
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = fila[3].ToString();
                u.userType = Convert.ToBoolean(fila[4].ToString());
                lista.Add(u);
            }
            return lista;
        }

        public static DataTable getUsersDt()
        {
            string query = "SELECT * FROM appuser";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            return dt;
        }

        public static List<int> getUserAdresses(Usuario user)
        {
            string query = $"SELECT \"idAddress\" FROM address WHERE \"idUser\" = '{user.idUser}'";
            DataTable dt = dbHelper.ExecuteQuery(query: query);
            List<int> lista = new List<int>();
            foreach (DataRow fila in dt.Rows)
            {
                lista.Add(Convert.ToInt16(fila[0].ToString()));
            }
            return lista;
        }

        public static void setPassword(string nPassword, Usuario u)
        {
            try
            {
                string nQ = $"UPDATE appuser SET password = '{nPassword}' WHERE \"idUser\" = {u.idUser} ";
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show($"Se ha actualizado la contraseña de '{u.fullname}' exitosamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }

        public static void addUser(Usuario u)
        {
            try
            {
                string nQ = $"INSERT INTO appuser(fullname, username, password, \"userType\") VALUES(" +
                            $"'{u.fullname}', " +
                            $"'{u.username}', " +
                            $"'{u.password}', " +
                            $"'{u.userType}')";
                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show($"Se ha agregado el usuario '{u.username}' correctamente");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }

        public static void removeUser(Usuario u)
        {
            try
            {
                List<int> addressesIds = getUserAdresses(u);
                foreach (var address in addressesIds)
                {
                    string nQ1 = $"DELETE FROM apporder WHERE \"idAddress\"= {address}";
                    dbHelper.ExecuteNonQuery(nQ1);
                }
                string nQ = String.Format(
                    $"DELETE FROM address WHERE \"idUser\"= {u.idUser} ;" +
                    $"DELETE FROM appuser WHERE username = '{u.username}'");

                dbHelper.ExecuteNonQuery(nQ);
                MessageBox.Show("Se ha eliminado el usuario, " +
                                "junto a las ordenes y direcciones relacionadas");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}