using AutoMapper;
using ConsoleCoreDapper.Model;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCoreDapper.AutoMapper;
namespace ConsoleCoreDapper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            AutoMapperConfiguration.Configure();
            MySqlConnection con = new MySqlConnection("server=;database=;uid=;pwd=;SslMode=None");
            //新增数据
            //con.Execute("insert into t_dept values(null,3, '设计', '最美的设计')");
            //新增数据返回自增id
            // var id = con.QueryFirst<int>("insert into t_dept values(null,4, '画画部', '最萌的二次元');select last_insert_id();");
           // var id = 4;
            //修改数据
           // con.Execute("update t_dept set dname = '美术部' where deptid = @Id", new { Id = id });
            //查询数据
            var list = con.Query<Dept>("SELECT * FROM t_dept");
            foreach (var item in list)
            {
                Console.WriteLine($"部门名：{item.dname} 备注：{item.dremark}");
            }
           // DestinDept dest = Mapper.Map<DestinDept>(list.First());
            List<DestinDept> destlist = Mapper.Map<List<DestinDept>>(list);
            Console.WriteLine("你是谁");
            Console.Read();
        }
    }
}
