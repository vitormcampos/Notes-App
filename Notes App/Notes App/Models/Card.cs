using System;

namespace Notes_App.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
