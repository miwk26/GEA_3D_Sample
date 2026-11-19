using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [ContextMenu("List 실습")]
    void ShowInventory()
    {
        List<string> inventory = new List<string>();
        inventory.Add("포션");
        inventory.Add("화살");
        inventory.Add("포션");
        inventory.Add("열쇠");
        inventory.Remove("포션");
        Debug.Log("아이템 " + inventory.Count + " 개");
        Debug.Log("열쇠 있음: " + inventory.Contains("열쇠"));
        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log(i + "번: " + inventory[i]);
        }
    }

}
