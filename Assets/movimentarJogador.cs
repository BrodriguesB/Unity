using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentarJogador : MonoBehaviour
{
    public float velocidade;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            float valorVertical = Input.GetAxis("Vertical");

            this.transform.Translate(new Vector3(0,valorVertical * Time.deltaTime * velocidade));
        }

        if (Input.GetButton("Horizontal"))
        {
            float valorhorizontal = Input.GetAxis("Horizontal");

            this.transform.Rotate(new Vector3(0, 0, -valorhorizontal * Time.deltaTime * 200));            
        }
     }
}
