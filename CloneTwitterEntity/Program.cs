using CloneTwitterEntity.Model.Context;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity
{
    class Program
    {

        static void Main(string[] args)
        {
            //COTContext data = new COTContext();
            //veri.Database.Create();

            COTContext Veri = new COTContext();
            Veri.USERS.Add(new USER
            {
                NAME = "Test",
                PHONE = "5552221545",
                EMAIL = "test@gmail.com",
                USERNAME = "tester",
                PASSWORD = "1234"
            });
            Veri.SaveChanges();



        }

    }
}
