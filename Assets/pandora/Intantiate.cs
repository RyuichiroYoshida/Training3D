using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intantiate : MonoBehaviour
{
    private GameObject gameObjectins;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectins = this.gameObject;
        StartCoroutine(Loop());

    }

    IEnumerator Loop()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(gameObjectins);
        StartCoroutine(Loop());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
