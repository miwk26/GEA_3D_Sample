using UnityEngine;


    
    public class Weapon
    {
        public string name;
        public int durability;

        public Weapon(string name, int durability)
        {
            this.name = name;
            this.durability = durability;
        }
        public bool Use()
        {
            if (durability <= 0) return false;
            durability--;
            return true;
        }
    }


