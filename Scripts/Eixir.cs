using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eixir : MonoBehaviour{

//    public int presscounter=0;

    public void botoEixir(){

//        if (presscounter ==1){
            print("entra en el if de botoEixir");
            Application.Quit();
//        }
    }
}






/*
{

public Button btn { 
    get { 
        return GetComponent<Button> (); 
        } 
}

public void start(){
    print("Ha eixit. Pas 1");
    
    btn.onClick.AddListener (() => salir());
}


public void salir()
    {     
        print("Ha eixit. Pas 2");
        Application.Quit();
    }
}
*/