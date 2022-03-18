using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour {
    public GameObject characterPrincipal;
    public float velocidad=20f;
    public GameObject bala;
    // Start is called before the first frame update
    void Start() {
        transform.position = new Vector3 (-3.452276F, 0.1900001F, -3.704882F);
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
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            transform.position += transform.forward *velocidad * Time.deltaTime;
        }
        if(Input.GetMouseButton(0)){
            Instantiate (bala, transform.position, transform.rotation);
        }
        if(Input.GetKey(KeyCode.Space)){
            Instantiate (bala, transform.position, transform.rotation);
        }
    }
}
