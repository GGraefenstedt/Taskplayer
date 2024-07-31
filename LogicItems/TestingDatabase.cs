using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskplayer.LogicItems
{
    class TestingDatabase
    {
        public List<Playtask> playtasks { get; set; }

        public void addPlaytask(Playtask task)
        {
            this.playtasks.Add(task);
        }
    }
}
