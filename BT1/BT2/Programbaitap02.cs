using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("So du khong du de thuc hien giao dich!");
        }
        public void tranferTo(Account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
            {
                Console.WriteLine("Giao dich thuc hien khong thanh cong");
            }
        }
        class ProgramBaiTap2
        {
            static void Main(string[] args)
            {
                Account my = new Account("2321160019", "Tu Luc", 1200);

                Console.Write("Inter id value:");
                string id = Console.ReadLine();

                Console.Write("Inter name value:");
                string name = Console.ReadLine();

                Console.Write("Inter balance value:");
                int balance = int.Parse(Console.ReadLine());

                Account myFriend = new Account(id, name, balance);

                Console.WriteLine("-----Thong tin hai tai khoan ban dau----");
                Console.WriteLine("My account: [id:{0}, name:{1}, balance:{2}] ",
                    my.getId(), my.getName(), my.getBalance());
                Console.WriteLine("My friend account: [id:{0}, name:{1}, balance:{2}]",
                    myFriend.getId(), myFriend.getName(), myFriend.getBalance());

                //rut tien
                my.debit(500);
                my.tranferTo(myFriend, 340);

                //ket qua sau khi thuc hien mot so hanh vi( nap, tur, chuyen tien)
                Console.WriteLine("-----Thong tin hai tai khoan sau khi thuc hien giao dich----");
                Console.WriteLine("My account:[id:{0}, name:{1}, balance:{2}]", my.getId(),
                    my.getName(), my.getBalance());
                Console.WriteLine("My friend account: [id:{0}, name:{1}, balance:{2}]",
                    myFriend.getId(), myFriend.getName(), myFriend.getBalance());
                Console.ReadLine();
            }
        }
    }
}
