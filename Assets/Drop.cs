using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

    public GameObject poop;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
    void Update () {
        Vector3 initialPosition = new Vector3(Random.Range(-10f, 10f), 20f, Random.Range(-10f, 10f));
        GameObject poopClone = Instantiate(poop, initialPosition, transform.rotation);
        poopClone.transform.Translate(Vector3.down * 4.5f * Time.deltaTime, Space.World);
        
		
	}
}
