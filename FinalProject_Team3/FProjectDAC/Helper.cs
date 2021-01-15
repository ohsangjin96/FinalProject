﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FProjectDAC
{
    public static class Helper
    {
        /// <summary>
        /// DataReader 객체로부터 List<VO> 객체로 변환
        /// </summary>
        /// <typeparam name="T">VO객체타입</typeparam>
        /// <param name="dr">DataReader</param>
        /// <returns></returns>
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            try
            {
                List<T> list = new List<T>();
                T obj = default(T);
                while (dr.Read())
                {
                    obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        //프로퍼티는 존재하는데, reader안에 조회된 컬럼이 없는 경우(오류)
                        //reader에 조회된 컬럼은 있지만, 프로퍼티가 정의되지 않은 경우(정상)
                        if(ContainsColumn(dr, prop.Name))
                        {
                            if (!object.Equals(dr[prop.Name], DBNull.Value))
                            {
                                prop.SetValue(obj, dr[prop.Name], null);
                            }
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch (Exception err)
            {
                string msg = err.Message;
                return null;
            }
        }

        private static bool ContainsColumn(IDataReader dataReader, string columnName)
        {
            try
            {
                return dataReader.GetOrdinal(columnName) >= 0;
            }
            catch (IndexOutOfRangeException err)
            {
                string msg = err.Message;
                return false;
            }
        }

        /// <summary>
        /// DataTable 객체로부터 List<VO> 객체로 변환
        /// </summary>
        /// <typeparam name="T">VO객체타입</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>DataTable Convert</returns>
        public static List<T> ConvertDataTableToList<T>(DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();
                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}