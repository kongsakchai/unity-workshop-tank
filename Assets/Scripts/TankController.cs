using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float speed; //ตัวแปรสำหรับกำหนดความเร็วในการวิ่ง
    public float rotateSpeed; //ตัวแปรสำหรับกำหนดความเร็วในการหมุน
    public GameObject bullet; // GameObject เพื่อนำไปสร้างกระสุน
    public Transform gun; // Tranform ของปืนเพื่อนำไประบุตำแหน่งของกระสุนที่จะสร้าง

    bool fire;
    void Start()
    {

    }

    void Update()
    {
        // horizontal = Input.GetAxis(""); // รับค่าจากแกนที่กำหนด 
        // vertical = Input.GetAxis(""); // รับค่าจากแกนที่กำหนด 

        fire = Input.GetKeyDown(KeyCode.Space);
        if (fire)
        {
        }
    }

    void MoveAndRotate()
    {
        transform.Translate(0, 0, 0);
        transform.Rotate(0, 0, 0);
    }

    void Shoot()
    {
        // Instantiate( GameObject ที่ต้องการสร้าง, ตำแหน่ง, การหมุน);
    }

    void ResetFire()
    {
    }

    void OnCollisionEnter(Collision other) {
        // การชน
    }
}
