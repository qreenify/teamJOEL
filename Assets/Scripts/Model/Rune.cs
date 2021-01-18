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
    
    public class Rune {
        private Rarity rarity;
        private Color color;
    }
    
    
}
