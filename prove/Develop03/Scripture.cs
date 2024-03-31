using System;

public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();

        public Scripture(string reference, string text)
        {
            _reference = new Reference(reference);

            string[] parts = text.Split(" ");
            foreach (string part in parts)
            {
                Word newWord = new Word(part);
                _words.Add(newWord);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Scripture Reference: {_reference.GetReference()}");

            foreach (Word word in _words)
            {
                word.DisplayWord();
            }
        }

        public void HideRandomWord()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(_words.Count);
            _words[randomIndex].HideWord();
        }

        public bool AllWordsHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }
