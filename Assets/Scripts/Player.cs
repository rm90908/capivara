using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float veloc  ;
    public float entradaHorizontal;
    public float entradaVertical;

    public GameObject pfLaser ;
    public float tempoDeDisparo = 0.3f;
    public float podeDisparar = 0.0f;

    public bool possoDarDisparoTriplo = false ;
    [SerializeField]
    private GameObject disparoTriploPrefab ;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Método Start de "+this.name);
        veloc = 6.0f;
        transform.position = new Vector3(0,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
         if ( Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            Disparo();
            }
    }
    private void Movimento(){
        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal );

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical );

        if ( transform.position.y > 0 ) {
            transform.position = new Vector3(transform.position.x,0,0);
        }

        if ( transform.position.y < -3.8f){
            transform.position = new Vector3(transform.position.x,-3.8f,0);
        }

        if ( transform.position.x > 9.65f){
            transform.position = new Vector3(-9.65f,transform.position.y,0);
        }

         if ( transform.position.x < -9.65f){
            transform.position = new Vector3(9.65f,transform.position.y,0);
        }
    }
        private void Disparo (){
            if (Time.time > podeDisparar)
            {

                if (possoDarDisparoTriplo == true)
                {
                    Instantiate(disparoTriploPrefab,transform.position,Quaternion.identity);
                }
                else 
                {
                Instantiate(pfLaser,transform.position + new Vector3 (0,0f,0),Quaternion.identity);          
                }
                podeDisparar = Time.time + tempoDeDisparo ;
            }        
        }


    }
