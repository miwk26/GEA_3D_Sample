using UnityEngine;
using System.Collections.Generic;
public class BattleLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int totalDamage = 0;
        List<int> criticals = new List<int>();

        // 할 일 1 & 2: 총 데미지 계산 및 치명타 추출
        foreach (int damage in damages)
        {
            totalDamage += damage;

            if (damage >= criticalLine)
            {
                criticals.Add(damage);
            }
        }

        // 할 일 3: 결과 출력
        Debug.Log($"총 데미지 {totalDamage}");
        Debug.Log($"치명타 {criticals.Count} 회");

        foreach (int crit in criticals)
        {
            Debug.Log($"치명타 {crit}");
        }
    }
}

