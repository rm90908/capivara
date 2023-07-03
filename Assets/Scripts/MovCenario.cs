using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCenario : MonoBehaviour
{
    
    public float velocidade ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Movimentocenario();


    }

    private void Movimentocenario(){

        Vector2 deslocamento = new Vector2(Time.time * velocidade , 0);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;
    }


}
