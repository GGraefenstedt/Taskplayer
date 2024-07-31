using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskplayer.LogicItems
{
    public class Playtask
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public int Points { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? DateDue { get; set; }

        public Playtask(string title, int points, string? description, DateTime created, DateTime? dateDue)
        {
            this.Title = title;
            this.Id = 0;
            this.Points = points;
            this.Description = description;
            this.Created = DateTime.Now;
            this.DateDue = dateDue;
        }
        public Playtask(string title)
        {
            this.Title = title;
            this.Id = 0;
            this.Points = 0;
            this.Description = "";
            this.Created = DateTime.Now;
            this.DateDue = null;
        }
        public Playtask getPlaytask()
        {
            return this;
        }
        public string toString()
        {
            return ($"Title: {this.Title}, ID: {this.Id}, Points: {this.Points}, Description: {this.Description}, CreateTime: {this.Created}, DueDate: {this.DateDue}");
        }
    }
}
