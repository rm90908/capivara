using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movcapivara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Movimento();
    }
    private void Movimento(){
        
        float veloc = 0;
        float entradaHorizontal = Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * entradaHorizontal * Time.deltaTime*veloc);
            if ( transform.position.x > 0){
                transform.position = new Vector3(transform.position.y,0,0); 
            } else if ( transform.position.x < -3.75f){
                transform.position = new Vector3(transform.position.y,-3.75f,0);
            }
            float entradaVertical = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.up * entradaVertical * Time.deltaTime*veloc);

            if ( transform.position.y > 9.68f){
                transform.position = new Vector3( -9.68f,transform.position.x,0);
            } else if ( transform.position.y < -9.68f ){
                transform.position = new Vector3( 9.68f,transform.position.x,0);
            }




    }

}
