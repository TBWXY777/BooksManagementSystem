using MySql.Data.MySqlClient;
using System;
using System.Data;
using WindowsFormsWithSql;
using System.Collections.Generic;


/// <summary>
/// 这是我封装的与数据库交互的一个工具类
/// @author 吴勋宇 2019071061
/// </summary>
namespace ConnectSql
{
    class MysqlUtils
    {
        public static BookMainForm mainPage;

        public static readonly string connectStr = "server=119.29.40.89;port=3306;user=common_user;password=114514; database=book_manager;charset=utf8;";


        /// <summary>
        /// 返回默认的连接,记得关闭连接
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection GetMySqlConnection()
        {
            //string connectStr = "server=119.29.40.89;port=3306;user=common_user;password=114514; database=book_manager;charset=utf8;";
            MySqlConnection con = new MySqlConnection(connectStr);
            return con;
        }
        /// <summary>
        /// 返回指定的连接,记得关闭连接
        /// </summary>
        /// <param name="connectStr"></param>
        /// <returns></returns>
        public static MySqlConnection GetMySqlConnection(string connectStr)
        {
            MySqlConnection con = new MySqlConnection(connectStr);
            return con;
        }

        /// <summary>
        /// 返回查询结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataRowCollection Query(string sql)
        {
            var ap = GetDataAdapter(sql);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            return dt.Rows;
        }

        /// <summary>
        /// 返回查询结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable QueryToDataTable(string sql)
        {
            var ap = GetDataAdapter(sql);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 获取DataAdapter
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static MySqlDataAdapter GetDataAdapter(string sql)
        {
            MySqlConnection connect = null;
            try
            {
                connect = GetMySqlConnection();
                MySqlDataAdapter ap = new MySqlDataAdapter(sql, connect);
                return ap;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connect.Close();
            }
            return null;
        }

        /// <summary>
        /// 根据主键查询 返回一行
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataRow QueryOne(string sql)
        {
            var list = Query(sql);
            return list[0];
        }

        /// <summary>
        /// 用于执行insert,delete,update
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>返回影响的行数,异常返回-1</returns>
        public static int Update(string sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            int row = Update(cmd);
            return row;
        }

        /// <summary>
        /// 将处理好的cmd拿过来执行,不需要连接对象
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static int Update(MySqlCommand cmd)
        {
            MySqlConnection con = null;
            try
            {
                con = GetMySqlConnection();
                con.Open();
                cmd.Connection = con;
                int row = cmd.ExecuteNonQuery();
                mainPage.flushBookListView();
                return row;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return -1;
        }

        public static int Update(string sql,Dictionary<String,Object> paramsPair)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            //放置参数
            foreach(string key in paramsPair.Keys)
            {
                cmd.Parameters.AddWithValue(key, paramsPair[key]);
            }
            int row = Update(cmd);
            return row; 
        }
    }
}
