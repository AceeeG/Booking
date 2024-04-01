using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class User
    {
        public int id;
        public int Id
        {
            get
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            }
        }
        public string fio;
        public string Fio
        {
            get
            {
                return fio;
            }
            set
            {
                fio = value;
            }
        }
        public string birthday;
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int money;
        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public int days;
        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }
        public string come;
        public string Come
        {
            get
            {
                return come;
            }
            set
            {
                come = value;
            }
        }
        public int withAnimals;
        public int WithAnimals
        {
            get
            {
                return withAnimals;
            }
            set
            {
                withAnimals = value;
            }
        }
        public string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public User(string FIO, string birthday, int money, int days, int WithAnimals)
        {
            fio = FIO;
            this.birthday = birthday;
            this.money = money;
            this.days = days;
            withAnimals = WithAnimals;
            come = DateTime.Now.ToString();
 


        }
        public User(int id, string FIO, int money, int days, int WithAnimals)
        {
            fio = FIO;
            this.money = money;
            this.days = days;
            withAnimals = WithAnimals;
        }
        public User()
        {

        }
    }
}
