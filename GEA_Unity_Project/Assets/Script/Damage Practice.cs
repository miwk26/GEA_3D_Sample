using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    // 인스펙터 창에서 값을 조절할 수 있도록 변수 선언
    public int attack = 10;
    public int defense = 5;
    public bool isCritical = false;
    public bool targetIsBoss = false;

    [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defense;
        damage = Mathf.Max(damage, 1);

        if (isCritical)
        {
            damage = damage * 2;
        }

        if (targetIsBoss)
        {
            damage = damage / 2;
        }

        Debug.Log(damage);
    }
}
