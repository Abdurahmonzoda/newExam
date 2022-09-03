using exam.DataBase;

var mysql = new MysqlConnection("SqlConnection" , TimeSpan.FromSeconds(10)); 


var dataBase = new DbCommand(mysql , "hello all Students"); 
