using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000; // 몬스터 한 마리의 경험치
    public int killCount = 3;      // 잡은 마릿수

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;
        int totalExp = 0; // 얻은 경험치 전체 합계

        // [8.1 기본 과제] 몬스터를 killCount 마리 잡으며 경험치 누적 및 레벨업 계산
        for (int i = 1; i <= killCount; i++)
        {
            exp += expPerKill;
            totalExp += expPerKill;

            // 한 마리를 잡았을 때 연속 레벨업 처리
            while (exp >= level * 10000)
            {
                exp -= level * 10000;
                level++;
                Debug.Log($"레벨업! Lv {level} ({i} 마리째)");
            }
        }

        // [8.4 선택 과제 1] 10칸짜리 경험치 막대 생성
        int requiredExp = level * 10000;
        int barLength = 10;
        int filledCount = exp * barLength / requiredExp;
        string expBar = "";

        for (int i = 0; i < barLength; i++)
        {
            if (i < filledCount)
            {
                expBar += "■";
            }
            else
            {
                expBar += "□";
            }
        }

        // 최종 레벨 및 경험치 막대 출력
        Debug.Log($"최종 Lv {level} {expBar} {exp} / {requiredExp}");

        // [8.4 선택 과제 2] 다음 레벨업까지 남은 마릿수 출력 (expPerKill이 0이면 생략)
        if (expPerKill > 0)
        {
            int remainExp = requiredExp - exp;
            int remainKills = (remainExp + expPerKill - 1) / expPerKill;
            Debug.Log($"같은 몬스터를 {remainKills} 마리 더 잡으면 레벨업");
        }

        // [8.4 선택 과제 3] ToString 없이 천 단위 쉼표를 넣은 총 경험치 합계 출력
        string formattedTotalExp = FormatWithCommas(totalExp);
        Debug.Log($"얻은 경험치 합계 {formattedTotalExp}");
    }

    // 숫자를 세 자리마다 쉼표(,)로 구분된 문자열로 바꾸는 함수
    string FormatWithCommas(int number)
    {
        if (number == 0) return "0";

        string result = "";
        int digitCount = 0;

        while (number > 0)
        {
            if (digitCount > 0 && digitCount % 3 == 0)
            {
                result = "," + result;
            }

            int lastDigit = number % 10;
            result = lastDigit + result;
            number /= 10;
            digitCount++;
        }

        return result;
    }
}
