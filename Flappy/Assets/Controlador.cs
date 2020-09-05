using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    public GameObject canvasperdio;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perdiste ()
    {
        canvasperdio.SetActive(true);
        Time.timeScale = 0;
       //PersonajeCod.instancia.estadodos();
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(1);
    }
    
   
}
