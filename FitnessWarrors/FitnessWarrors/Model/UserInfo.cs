using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessWarrors.Model
{
    [Table(nameof(UserInfo))]
    public class UserInfo

    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Wake { get; set; }
        public string Sleep { get; set; }
        public string Train { get; set; }
        public string Job { get; set; }

        public override string ToString()
        {
            return this.Name + "(" + this.Age + ")";
        }
    }
}
