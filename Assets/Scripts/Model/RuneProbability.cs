using System.Collections.Generic;

namespace Model{
    public class RuneProbability{
        public Dictionary<int, int> MergeProbability{ get; }

        public RuneProbability(){
            MergeProbability = new Dictionary<int, int>();
            
            MergeProbability.Add(2, 20);
            MergeProbability.Add(3, 55);
            MergeProbability.Add(4, 95);
        }

    }
}