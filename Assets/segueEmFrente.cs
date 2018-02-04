using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segueEmFrente : MonoBehaviour
{
    public int Velocidade = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0, Velocidade * Time.deltaTime));
    }
}