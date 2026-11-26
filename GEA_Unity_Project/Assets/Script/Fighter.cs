public class Fighter
{
    public string name;
    public int hp;
    public int attack;
    public int defense;

    public Fighter(string name, int hp, int attack, int defense)
    {
        // 1. 생성자: 받은 값 네 개를 필드에 넣음
        this.name = name;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
    }

    public int GetDamageTo(Fighter target)
    {
        // 2. 내 attack 에서 target 의 defense 를 뺀 값을 돌려줌. 1보다 작으면 1을 돌려줌
        int damage = attack - target.defense;
        if (damage < 1)
        {
            damage = 1;
        }
        return damage;
    }

    public void TakeDamage(int damage)
    {
        // 3. 내 hp 에서 damage 를 뺌. 0 보다 작아지면 0 으로 바꿈
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }
    }

    public bool IsDead()
    {
        // 4. hp 가 0 이하이면 true, 아니면 false 를 돌려줌
        if (hp <= 0)
        {
            return true;
        }
        return false;
    }
}
