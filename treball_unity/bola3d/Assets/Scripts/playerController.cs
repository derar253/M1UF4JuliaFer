using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour{
Rigidbody rb;
public float speed;
public Text countText;
public Text winText;
private int count;

  
    void Start(){
        rb=GetComponent<Rigidbody>();
        count=0;
        winText.text="";
        mostrarResultat();
    }


    void Update(){
        float x= Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");
        Vector3 move= new Vector3(x,0.0f,z);
    rb.AddForce(move*speed);    
 if (count==4) {
      winText.text="Partit guanyat";
 }
 if (Input.GetButtonDown("Jump")){
      rb.AddForce(new Vector3(0f,6f,0f), ForceMode.Impulse); 

 }

    }
    private void OnTriggerEnter(Collider other){

        Destroy(other.gameObject);
        count++;
           mostrarResultat();


    }
    void mostrarResultat(){
countText.text = "Madrid vs Girona 3-" + count.ToString();

    }


}
