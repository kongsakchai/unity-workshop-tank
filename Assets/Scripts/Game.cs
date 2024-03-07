using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI timeText;
    public bool stop = true;
    public TankController player;
    void Start()
    {
        // StartCoroutine( ฟังก์ชันแบบ IEnumerator)
        StartCoroutine(StartGame());
    }

    void LoadName(){
        //ตัวแปล = PlayerPrefs.GetString("", ค่าเริ่มต้น) ดึงค่าจากชื่อเซฟไว้
    }

    void Update()
    {
        
    }

    IEnumerator StartGame()
    {
        // yield return new WaitForSeconds(1) รอเวลา

        // เริ่มเกม

        yield return null;
    }
}
