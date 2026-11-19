using UnityEngine;

public class ForeachPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int[] monsterHps = { 0, 35, 0, 80, 12 };

    [ContextMenu("foreach 실습")]
    void CountAlive()
    {
        int aliveCount = 0;
        int hpSum = 0;
        foreach (int hp in monsterHps)
        {
            if (hp > 0)
            {
                aliveCount++;
                hpSum += hp;
            }
        }
        Debug.Log("살아 있는 몬스터 " + aliveCount + " 마리");
        Debug.Log("남은 체력 합 " + hpSum);
    }

}
