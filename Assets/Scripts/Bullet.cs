using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10; // ความเร็วของกระสุน
    public GameObject smoke;
    void Start()
    {
        // Invoke("ชื่อ Method", เวลาในการดีเลย์(วินาที)); 
    }

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 10);
    }

    void StopMove()
    {
        // GameObject sm = Instantiate( GameObject ที่ต้องการสร้าง, ตำแหน่ง, การหมุน);
        // Destroy(สิ่งที่ต้องการทำลาย, delay); 
    }

    void OnCollisionEnter2D(Collision2D other)
    {
    }
}
