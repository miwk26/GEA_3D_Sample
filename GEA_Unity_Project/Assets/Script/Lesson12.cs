using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [ContextMenu("복사")]
    void CopyPaste()
    {
        int a = 12 - 5;
        if (a < 1) a = 1;
        int b = 3 - 10;
        if (b < 1) b = 1;
        int c = 20 - 4;
        if (c < 1) c = 1;
        Debug.Log(a + " " + b + " " + c);
    }
    int GetDamage(int attack, int defense)
    {
        int damage = attack - defense;
        if (damage < 1) return 1;
        return damage;
    }


    [ContextMenu("함수")]
    void UseFunction()
    {
        int a = GetDamage(12, 5);
        int b = GetDamage(3, 10);
        int c = GetDamage(20, 4);
        Debug.Log(a + " " + b + " " + c);
    }
    void PrintHp(int hp)
    {
        Debug.Log("HP " + hp);
    }

    int GetHalf(int value)
    {
        return value / 2;
    }

    [ContextMenu("반환")]
    void ReturnTest()
    {
        PrintHp(GetHalf(50));
    }
    public int gold = 100;   // 필드

    int AddBonus(int amount)   // 매개변수 amount
    {
        int bonus = amount / 10;   // 지역 변수 bonus
        gold = gold + amount + bonus;
        return bonus;
    }

    [ContextMenu("변수의 종류")]
    void VariableKinds()
    {
        int a = AddBonus(200);
        int b = AddBonus(50);
        Debug.Log(gold + " " + a + " " + b);
    }
    int Square(int x) { return x * x; }
    void AddOne(int x) { x = x + 1; }
    void Fill(int[] arr) { arr[0] = 9; }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int a = 3;
        AddOne(a);
        Debug.Log(a);
        Debug.Log(Square(a) + Square(2));
        Debug.Log(Square(Square(2)));
        int[] nums = { 1, 2 };
        Fill(nums);
        Debug.Log(nums[0]);
    }
    float GetAverage(int[] values)
    {
        if (values.Length == 0) return 0;
        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }
        return (float)sum / values.Length;
    }
    [ContextMenu("평균")]
    void ShowAverage()
    {
        int[] scores = { 90, 75 };
        Debug.Log(GetAverage(scores));
        Debug.Log(GetAverage(new int[0]));
    }
    [ContextMenu("흩어진 값")]
    void SeparateVariables()
    {
        string[] names = { "슬라임", "고블린" };
        int[] hps = { 30, 50 };
        int[] attacks = { 5, 8 };

        hps[1] -= 20;
        Debug.Log(names[1] + " " + hps[1] + " " + attacks[1]);
    }
    [ContextMenu("메서드")]
    void UseMethods()
    {
     
    }
    [ContextMenu("생성자")]
    void UseConstructor()
    {
        Monster slime = new Monster("슬라임", 30, 5);
        Monster goblin = new Monster("고블린", 50, 8);
        Debug.Log(slime.name + " " + slime.hp);
        Debug.Log(goblin.name + " " + goblin.attack);
    }
    [ContextMenu("예측 2")]
    void Predict2()
    {
        Monster a = new Monster("슬라임", 30, 5);
        Monster b = a;
        b.hp = 10;
        Debug.Log(a.hp);
        Monster c = new Monster("슬라임", 30, 5);
        c.TakeDamage(100);
        Debug.Log(a.hp + " " + c.hp);
        Debug.Log(a == b);
        a = null;
        Debug.Log(b.name);
        Debug.Log(a.name);
    }
    [ContextMenu("지갑")]
    void UseWallet()
    {
        Wallet wallet = new Wallet();
        wallet.Add(500);
        wallet.Add(-9999);
        Debug.Log(wallet.GetGold());
    }
    [ContextMenu("객체 List")]
    void MonsterList()
    {
        List<Monster> monsters = new List<Monster>();
        monsters.Add(new Monster("슬라임", 30, 5));
        monsters.Add(new Monster("고블린", 50, 8));
        monsters.Add(new Monster("박쥐", 15, 3));

        foreach (Monster monster in monsters)
        {
            monster.TakeDamage(20);
            Debug.Log(monster.name + " " + monster.hp);
        }
    }
    void Attack(Monster attacker, Monster target)
    {
        target.TakeDamage(attacker.attack);
        Debug.Log(target.name + " 체력 " + target.hp);
    }

    [ContextMenu("공격")]
    void AttackTest()
    {
        Monster slime = new Monster("슬라임", 30, 5);
        Monster goblin = new Monster("고블린", 50, 8);
        Attack(slime, goblin);
        Attack(goblin, slime);
        Attack(goblin, slime);
        Debug.Log(slime.hp + " " + goblin.hp);
    }

}
