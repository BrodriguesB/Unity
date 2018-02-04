using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontosVida : MonoBehaviour
{
    public int PontosDeVida = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PerderVida();
    }

    void PerderVida()
    {
        PontosDeVida--;
        if(PontosDeVida <=0)
        {
            Destroy(this.gameObject);
        }
    }
}
