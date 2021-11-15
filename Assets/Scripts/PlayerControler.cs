using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    //public float speed = 20.0f;//asi puedes elegir la velocidad en la que se mueve constatemente(velocidad)
    public float turnSpeed = 10.0f;
    public float horizontalInput; // tipo float que dara funcionara como union del horizontalaxis y el movimiento lateral
    public float turnSpeed1 = 10.0f;
    public float verticalInput; 
   
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        //movimiento hacia alante
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);//trnaslate lleva a cabo la función v/t en eje z
       
       //movimiento lateral
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);//trnaslate lleva a cabo la función v/t en eje x
        
        //movimieto arriba/abajo
        transform.Translate(Vector3.forward * turnSpeed1 * Time.deltaTime * verticalInput);//trnaslate lleva a cabo la función v/t en eje x

        //rotacion
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
