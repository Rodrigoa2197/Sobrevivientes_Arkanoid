﻿using System;
using ProyectoPoo.Properties;
using System.Collections.Generic;
using System.Data;
using System.Numerics;

namespace ProyectoPoo
{
    public static class PlayerDAO
    {
        public static bool verifyPlayer(string usuario)
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM USUARIO WHERE usuario = '{usuario}'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                Connection.ExecuteNonQuery("INSERT INTO USUARIO(usuario) VALUES" +
                                           $"('{usuario}')");
                return false;
            }
        }
        
        public static int GetIdPlayer(string usuario)
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM USUARIO WHERE usuario = '{usuario}'");
            if (dt.Rows.Count > 0)
            {
                var id = int.Parse(dt.Rows[0][0].ToString());
                return id;
            }
            else
            {
                Connection.ExecuteNonQuery("INSERT INTO USUARIO(usuario) VALUES" +
                                           $"('{usuario}')");
                var datat = Connection.ExecuteQuery($"SELECT * FROM USUARIO WHERE usuario = '{usuario}'");
                return Convert.ToInt32(datat.Rows[0][0].ToString());
            }
        }

        public static void CreateNewScore(int id_usuario, int puntaje)
        {
            Connection.ExecuteNonQuery("INSERT INTO PUNTAJE(id_usuario, puntaje) VALUES" +
                                       $"({id_usuario},{puntaje})");
        }

        public static List<Player> ObtainTopPlayers()
        {
            var topPlayers = new List<Player>();
            DataTable dt = Connection.ExecuteQuery("SELECT pl.usuario, sc.puntaje " +
                                                        "FROM USUARIO pl, PUNTAJE sc " +
                                                        "WHERE pl.id_usuario = sc.id_usuario " +
                                                        "ORDER BY sc.puntaje DESC " +
                                                        "LIMIT 10");
            foreach (DataRow dr in dt.Rows)
            {
                topPlayers.Add(new Player(dr[0].ToString(), Convert.ToInt32(dr[1])));
            }
            return topPlayers;
        }
    }
}