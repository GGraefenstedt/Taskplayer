using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskplayer.LogicItems
{
    internal class User
    {
        private readonly String _id;
        private string name;
        private DateTime joinDate;
        public User(String id, String name, DateTime joinDate)
        {
            this._id = id;
            this.name = name;
            this.joinDate = joinDate;
        }
    }
}
