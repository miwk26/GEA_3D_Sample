using UnityEngine;

    public class Monster
    {
        public string name;
        public int hp;
        public int attack;


    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;
    }

    public bool IsDead()
    {
        return hp <= 0;
    }

    public Monster(string name, int hp, int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
    }



    }
 