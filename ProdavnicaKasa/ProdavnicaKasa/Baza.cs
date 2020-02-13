﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaKasa
{
    class Baza
    {
        OleDbConnection conn;
        public Baza()
        {
            this.conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\marko\Desktop\ProdavnicaKasa\Prodavnica.mdb'";
        }
        public void OtvoriKonekciju()
        {
            if (conn != null)
                conn.Open();
        }
        public void ZatvoriKonekciju()
        {
            if (conn != null)
                conn.Close();
        }
        public OleDbConnection Conn { get { return conn; } set { conn = value; } }

    }
}
