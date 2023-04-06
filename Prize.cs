using System;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string text) {
            _text = text;
        }

        public void ShowPrize(Adventurer adventurer) {
            if (adventurer.Awesomeness > 0 ) {
                for (int i = 0; i < adventurer.Awesomeness; i++) {
                    Console.WriteLine(_text);
                }
            } else {
                Console.WriteLine("Wow, you have no awesomeness points and therefor receive no prize. I pitty you. I really do.");
            }
        }
    }
}