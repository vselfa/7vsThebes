using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LogicaEdip : MonoBehaviour
{

    public float velocitatMoviment = 5.0f;
    public float velocitatRotacio = 200.0f;
    private Animator anim;
    public float x, y;
    private AudioSource audioSource;
    private int numCollisions = 0;
    public GameObject so_Explosio;
    public GameObject text_Canvas;
    //public GameObject Porta1, Porta2, Porta3, Porta4;
    private GameObject porta;
    
    //porta = GameObject.FindWithTag("Porta");

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "RedStone") {
        numCollisions++;    
        print("Xoc amb la bola roja!!!" + numCollisions);
        audioSource.Play();
        Destroy(collision.gameObject);
                if (numCollisions==3){
            Instantiate(so_Explosio);
            print("Les portes queden obertes");
            //Destroy(porta);
            //porta.transform.Rotate(0, 90, 0); 
            //Destroy(Porta1); Destroy(Porta2); 
            //Destroy(Porta3); Destroy(Porta4);
        }

        }
        if (collision.gameObject.tag == "BlueStone") {
        numCollisions++;  
        print("Xoc amb la bola blava!!!" + numCollisions);
        audioSource.Play();
        Destroy(collision.gameObject);
                if (numCollisions==3){
            Instantiate(so_Explosio);
            print("Les portes queden obertes");
            //Destroy(porta);
            //porta.transform.Rotate(0, 90, 0); 
            //Destroy(Porta1); Destroy(Porta2); 
            //Destroy(Porta3); Destroy(Porta4);
        }
        }

        if (collision.gameObject.tag == "YellowStone") {
        numCollisions++;  
        print("Xoc amb la bola groga!!!" + numCollisions);
        audioSource.Play();
        Destroy(collision.gameObject);
                if (numCollisions==3){
            Instantiate(so_Explosio);
            print("Les portes queden obertes");
            //Destroy(porta);
            //porta.transform.Rotate(0, 90, 0); 
            //Destroy(Porta1); Destroy(Porta2); 
            //Destroy(Porta3); Destroy(Porta4);
        }
        }

        if ((numCollisions==3)&(collision.gameObject.tag == "Porta")) {
        print("Colisió en la porta"); 
        SceneManager.LoadScene ("CNMTC2");       
        }



        }
    
    // Start is called before the first frame update
    void Start()
    {
        porta = GameObject.FindWithTag("Porta");
        anim=GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");

        transform.Rotate(0,x*Time.deltaTime*velocitatRotacio, 0);
        transform.Translate(0,0,y*Time.deltaTime*velocitatMoviment);

        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);
        
    }
}