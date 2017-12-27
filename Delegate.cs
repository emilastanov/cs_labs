using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //объявление делегата
    delegate string SQLParseQuery(string tableName, string queryParam);
    class Program
    {
        //Методы, реализующие делегат
        static string InsertQuery(string tableName, string queryParam)
        {
            return "INSERT INTO " + tableName + " VALUES (" + queryParam + ") ;\n";
        }
       
        static string SelectQuery(string tableName, string queryParam)
        {
            return "SELECT * FROM " + tableName + " WHERE " + queryParam + " ;\n";
        }
        static string DeleteQuery(string tableName, string queryParam)
        {
            return "DELETE FROM " + tableName + " WHERE " + queryParam + " ;\n";
        }
        //Использование обобщенного делегата FUNC
        static void SQLFunc(string comment, string tblName, string param, Func<string,string,string> Query){
            string Result = Query(tblName, param);
            Console.WriteLine(comment + Result);
        }

        /// <summary>
        /// Использование делегата
        /// </summary>
        static void SQLQuery(string comment, string tableName, string queryParam, SQLParseQuery Query){
            string Result = Query(tableName, queryParam);
            Console.WriteLine(comment + Result);
        }

        static void Main(string[] args)
        {
            string tableName="users";
            string param="username=admin";
            //Вызов метода, передавай делегат в качестве параметра
            SQLQuery("Вставка: ", tableName, param, InsertQuery);
            SQLQuery("Выборка: ", tableName, param, SelectQuery);
            SQLQuery("Удаление: ", tableName, param, DeleteQuery);
            //На основе лямбда функции
            SQLQuery("Изменение: ", tableName, param, (string tblName, string queryParam) =>
            {
                return "UPDATE " + tableName + " SET " + queryParam + " ;\n"; 
            });
            Console.WriteLine("\nИспользование обобщенного делегата Func\n");
            tableName="news"; param="hidden=1"; 
            //На основе метода
            SQLFunc("Удаление новости: ", tableName, param, DeleteQuery);
            //На основе лямбда
            SQLFunc("Выборка новости: ", tableName, param, (string tblName, string queryParam) =>
            {
                return "SELECT * FROM " + tableName + " WHERE " + queryParam + " ORDER BY asc ;\n";
            });

            Console.ReadKey();
        }
    }
}
