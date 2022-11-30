using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaGabinete : MonoBehaviour
{
    public GameObject[] gabinete = new GameObject[5];
    public GameObject gabActual;
    public Transform posGabinete;
    public int numGabinete;
    public bool muestra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (muestra)
        {
            loadGabinete(gabinete[numGabinete]);
        }
    }

    public void setNumGabinete(int numGabinete)
    {
        this.numGabinete = numGabinete;
    }

    public void setMuestra(bool muestra)
    {
        this.muestra = muestra;
    } 

    public void loadGabinete(GameObject objGabinete)
    {
        Object.Destroy(gabActual);
        gabActual = Instantiate(objGabinete, posGabinete);
    }
}
