using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] golds = { 300, 1200, 50, 800 };

    [ContextMenu("배열 실습")]
    void ShowGolds()
    {
        int total = 0;
        for (int i = 0; i < golds.Length; i++)
        {
            Debug.Log(i + "번: " + golds[i]);
            total += golds[i];
        }
        Debug.Log("합계 " + total);
    }

}
