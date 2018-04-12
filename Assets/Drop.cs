using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

    public GameObject poop;
	// Use this for initialization
	void Start () {
        StartCoroutine(drop());
	}
	
	// Update is called once per frame
    void Update () {

    }

    IEnumerator drop(){
        while(true){
            /** From the Top
            Vector3 initialPosition = new Vector3(Random.Range(-10f, 10f), 25f, Random.Range(-10f, 10f));
            GameObject poopClone = Instantiate(poop, initialPosition, transform.rotation);
            poopClone.transform.Translate(Vector3.down * 4.5f * Time.deltaTime, Space.World);
            yield return new WaitForSeconds(.5f);
            **/

            /* From the Front */
            Vector3 initialPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(0f,2f), 50f);
            GameObject poopClone = Instantiate(poop, initialPosition, transform.rotation);
            poopClone.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            poopClone.GetComponent<Rigidbody>().AddForce(0f, 0f, -1050f);
            yield return new WaitForSeconds(.7f);
        }
    }
}
