using System.Collections.Generic;
using UnityEngine;

public class BattleList : MonoBehaviour
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

        int bestDamage = -1;
        int bestOrder = 0;
        int currentOrder = 0;

        int streak = 0;
        int bestStreak = 0;

        // 기존 foreach 틀을 유지하면서 순서 카운트 변수 활용
        foreach (int dmg in damages)
        {
            currentOrder++;
            totalDamage += dmg;

            // 2번 업그레이드: 최고 데미지 및 순서 찾기
            if (dmg > bestDamage)
            {
                bestDamage = dmg;
                bestOrder = currentOrder;
            }

            // 치명타 판별 및 3번 업그레이드: 연속 치명타 계산
            if (dmg >= criticalLine)
            {
                criticals.Add(dmg);
                streak++;
                bestStreak = Mathf.Max(bestStreak, streak);
            }
            else
            {
                streak = 0;
            }
        }

        // 기본 정보 출력
        Debug.Log("총 데미지 " + totalDamage);
        Debug.Log("치명타 " + criticals.Count + " 회");

        // 1번 업그레이드: 반복문으로 직접 쉼표 연결하기
        if (criticals.Count > 0)
        {
            string critText = "";
            for (int i = 0; i < criticals.Count; i++)
            {
                critText += criticals[i];
                if (i < criticals.Count - 1)
                {
                    critText += ", ";
                }
            }
            Debug.Log("치명타 목록: " + critText);
        }
        else
        {
            Debug.Log("치명타 목록: 없음");
        }

        // 2번 업그레이드: 최고 데미지 위치 출력
        if (damages.Length > 0)
        {
            Debug.Log("최고 데미지 " + bestDamage + " (" + bestOrder + " 번째 공격)");
        }
        else
        {
            Debug.Log("최고 데미지 0 (기록 없음)");
        }

        // 3번 업그레이드: 최대 연속 치명타 출력
        Debug.Log("최대 연속 치명타 " + bestStreak + " 회");
    }
}

