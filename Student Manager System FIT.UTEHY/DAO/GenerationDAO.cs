﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class GenerationDAO:DBConnect
    {
        public DBConnect connect = new DBConnect();

        public DataTable GetData()
        {
            string sql = "select * from tbNhanVien";
            return connect.GetData(sql);
        }

        public void Add(Generation obj)
        {
            string sql = string.Format("INSERT INTO GENERATION VALUES ('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}',N'{6}')", obj.Id,obj.Name,obj.Desc);
            RunSQL(sql);
        }

        public void Edit(Generation obj)
        {
            string sql = string.Format("update GENERATION set NAME = N'{0}', DESC = N'{1}'", obj.Name, obj.Desc);
            RunSQL(sql);
        }

        public void Delete(string id)
        {
            string sql = "Delete from GENERATION WHERE ID = '" + id.Trim() + "'";
            RunSQL(sql);
        }
    }
}