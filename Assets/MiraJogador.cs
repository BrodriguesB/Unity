using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraJogador : MonoBehaviour
{
    GameObject Jogador;
    
    void Update()
    {
        Jogador = GameObject.FindWithTag("Jogador");
        Vector3 dir = Jogador.transform.position - this.transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, 120f * Time.deltaTime);
    }
}
