using UnityEngine;

namespace Model
{
    public enum Rarity {
        common,
        uncommon,
        rare,
        epic,
        legendary
    }

    public enum Color {
        red,
        green,
        blue
    }
    
    public struct Rune {
        public Rarity rarity;
        public Color color;
        public Vector2 position;
    }

    public class RuneType {
        private Rune rune;
        private int count;
        private bool isMergable;
    }
}
