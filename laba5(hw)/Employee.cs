using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Employee
    {
        public int ID;
        public string Name;
        public string Post;
        public int Impudence;
        public int Stupidity;
        public Employee( string Name, string Post, int Impudence, int Stupidity)
        {
            this.ID = GetNextID();
            this.Name = Name;
            this.Post = Post;
            this.Impudence = Impudence;
            this.Stupidity = Stupidity;
        }
        public int GetNextID()
        {
            return ID++;
        }
    }
}
