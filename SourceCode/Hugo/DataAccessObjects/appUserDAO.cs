﻿using System;
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
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }
    }
}