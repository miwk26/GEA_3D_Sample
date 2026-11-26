using UnityEngine;

    public class Wallet
    {
        private int gold;

        public void Add(int amount)
        {
            if (amount > 0) gold += amount;
        }

        public int GetGold()
        {
            return gold;
        }
    }



