using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasShield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);
        Debug.Log(isDead && !hasShield);
        Debug.Log(isDead || hasShield);
        Debug.Log(!(hp > 0) == isDead);
    }

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }

    [ContextMenu("체력 상태")]
    void HpState()
    {
        int hp = 5;
        int maxHp = 10;
        float ratio = (float)hp / maxHp;
        if (ratio >= 0.7f)
        {
            Debug.Log("양호");
        }

        else if (ratio >= 0.3f)
        {
            Debug.Log("주의");
        }
        else
        {
            Debug.Log("위험");
        }
    }

    [ContextMenu("예측 2")]
    void Predict2()
    {
        int score = 95;
        if (score >= 60) Debug.Log("C");
        else if (score >= 80) Debug.Log("B");
        else if (score >= 90) Debug.Log("A");

        if (score >= 90) Debug.Log("A");
        if (score >= 80) Debug.Log("B");
        if (score >= 60) Debug.Log("C");
    }

    [ContextMenu("중괄호")]
    void Braces()
    {
        int hp = 10;
        if (hp <= 0)
            Debug.Log("사망");
        Debug.Log("게임 오버");

        if (hp <= 0)
        {
            Debug.Log("사망");
            Debug.Log("게임 오버");
        }
    }

    [ContextMenu("else 의 짝")]
    void ElsePair()
    {
        int hp = 50;
        bool hasPotion = false;
        if (hp < 30)
            if (hasPotion)
                Debug.Log("포션 사용");
            else
                Debug.Log("체력 충분");
        Debug.Log("끝");
    }

    [ContextMenu("무기")]
    void Weapon()
    {
        int weaponId = 2;
        switch (weaponId)
        {
            case 1:
                Debug.Log("검");
                break;

            case 2:
                Debug.Log("활");
                break;
            default:
                Debug.Log("맨손");
                break;
        }
    }

    [ContextMenu("무기 종류")]
    void WeaponType()
    {
        int weaponId = 2;
        switch (weaponId)
        {
            case 1:
            case 2:
                Debug.Log("근접 무기");
                break;
            case 3:
                Debug.Log("원거리 무기");
                break;
        }
    }

    [ContextMenu("삼항")]
    void Ternary()
    {
        int hp = 0;
        string state = hp > 0 ? "생존" : "사망";
        Debug.Log(state);

        int damage = -3;
        int finalDamage = damage < 1 ? 1 : damage;
        Debug.Log(finalDamage);
    }

    [ContextMenu("for")]
    void ForBasic()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        for (int i = 0; i < 3; i++) Debug.Log(i);
        for (int i = 1; i <= 10; i += 3) Debug.Log(i);
        for (int i = 5; i > 0; i -= 2) Debug.Log(i);
        int sum = 0;
        for (int i = 1; i <= 4; i++) sum += i;
        Debug.Log(sum);
    }

    [ContextMenu("격자")]
    void Grid()
    {
        string text = "";
        for (int row = 1; row <= 2; row++)
        {
            for (int col = 1; col <= 3; col++)
            {
                text += row + "-" + col + " ";
            }
            text += "\n";                            // backspace 아래 있는 원화 버튼
        }
        Debug.Log(text);
    }

    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 3;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

    [ContextMenu("레벨업")]
    void LevelUp()
    {
        int level = 1;
        int exp = 45000;
        while (exp >= level * 10000)
        {
            exp -= level * 10000;
            level++;
        }
        Debug.Log(level + " " + exp);
    }

    [ContextMenu("예측 4")]
    void Predict4()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 3 == 0) continue;
            if (i > 7) break;
            Debug.Log(i);
        }
        int n = 0;
        while (n <= 10) n += 4;
        Debug.Log(n);
    }

    [ContextMenu("상태")]
    void State()
    {
        int hp = 40;
        string state = "정상";
        if (hp <= 0) state = "사망";
        else if (hp < 50) state = "위험";
        Debug.Log(state);
        int weaponId = 3;
        switch (weaponId)
        {
            case 1: Debug.Log("검"); break;
            case 3: Debug.Log("활"); break;
            default: Debug.Log("맨손"); break;
        }
    }

    [ContextMenu("반복")]
    void Loop()
    {
        int sum = 0;
        for (int i = 2; i <= 10; i += 2)
        {
            sum += i;
        }
        Debug.Log(sum);
        for (int i = 1; i <= 9; i++)
        {
            Debug.Log("3 x " + i + " = " + 3 * i);
        }
    }

    [ContextMenu("예측 6")]
    void Predict6()
    {
        int i = 5;
        int a = i++;
        int b = ++i;
        Debug.Log(a + " " + b + " " + i);
        bool isDead = false;
        if (isDead = true) Debug.Log("사망");
        Debug.Log(true || false && false);
        int x = 15;
        // if (1 < x < 10) Debug.Log("범위 안");
    }



}
