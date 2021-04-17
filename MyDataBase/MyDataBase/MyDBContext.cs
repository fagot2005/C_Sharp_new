using System;
using System.Data.Entity;

namespace MyDataBase
{
    public class MyDBContext : DbContext
    {
        protected MyDBContext() : base ("DbConnectionString")
        {

        }
    }
}
