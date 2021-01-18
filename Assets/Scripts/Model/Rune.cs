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

    public enum RuneColor {
        red,
        green,
        blue
    }
    
    public struct Rune {
        public Rarity rarity;
        public RuneColor color;
        public Vector2 position;
    }

    public class RuneType {
        public Rune rune;
        public int count;
        public bool isMergable;
    }
}
