
using UnityEngine;
using System;

public class work : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
    public void Settle()
    {
        TimeSpan time = TimeSpan.FromSeconds(playSeconds);
        string playTime = string.Format(
            "{0}:{1:D2}:{2:D2}",
            (int)time.TotalHours,
            time.Minutes,
            time.Seconds
        );

        int goldPerMember = gold / members;
        int leaderBonus = gold % members;

        int basicExp = kills * expPerKill;
        int finalExp = (int)(basicExp * expRate);

        int level = finalExp / 100 + 1;
        int nextExp = 100 - finalExp % 100;

        float averageDamage = (float)totalDamage / hits;

        Debug.Log($"플레이 시간 {playTime}");
        Debug.Log($"1인당 {goldPerMember}G, 리더 보너스 {leaderBonus}G");
        Debug.Log($"경험치 {finalExp} (기본 {basicExp})");
        Debug.Log($"Lv {level}, 다음 레벨까지 {nextExp}");
        Debug.Log($"평균 데미지 {averageDamage}");
    }
}
