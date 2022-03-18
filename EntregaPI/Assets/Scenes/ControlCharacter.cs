using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour {
    public GameObject characterPrincipal;
    public float velocidad=20f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey(KeyCode.W)){
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position -= Vector3.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)){
            transform.eulerAngles += new Vector3(0,velocidad* Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.eulerAngles -= new Vector3(0,velocidad* Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position -= Vector3.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.eulerAngles += new Vector3(0,velocidad* Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.eulerAngles -= new Vector3(0,velocidad* Time.deltaTime);
        }
    }
}
