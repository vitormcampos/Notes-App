using Notes_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.Services
{
    public class CardDataStore 
    {
        readonly List<Card> cards;

        public CardDataStore()
        {
            cards = new List<Card>()
            {
                new Card() { Id = 0, Text = "Sou o primeiro de muitos" }
            };
        }

        public void AddCard(Card card)
        {
            card.Id = cards.Count;
            cards.Add(card);
        }

        public void UpdateCard(Card card)
        {
            var _card = cards.FirstOrDefault(x => x.Id == card.Id);
            cards.Remove(_card);
            cards.Add(card);
        }

        public void DeleteCard(int id)
        {
            var _card = cards.FirstOrDefault(x => x.Id == id);
            cards.Remove(_card);
        }

        public Card GetCard(int id)
        {
            var _card = cards.FirstOrDefault(x => x.Id == id);
            return _card;
        }

        public IEnumerable<Card> GetCards(bool forceRefresh = false)
        {
            return cards;
        }
    }
}