using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneObs : MonoBehaviour
{
    public float tiempoM = 1;
    private float tiempoI =0;
    public GameObject obstaculo;
    public float altura;
    // Start is called before the first frame update
    void Start()
    {
        GameObject nuevoObst = Instantiate(obstaculo);
        nuevoObst.transform.position = transform.position + new Vector3(2, 0, 0);
        Destroy(gameObject, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoI > tiempoM)
        {
            GameObject nuevoObst = Instantiate(obstaculo);
            nuevoObst.transform.position = transform.position + new Vector3(2, Random.Range(-altura,altura), 0);
            Destroy(gameObject, 100);
            tiempoI =0;
        } else
        {
            tiempoI += Time.deltaTime;
        }
    }
}
