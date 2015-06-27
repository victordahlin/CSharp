using UnityEngine;
using System.Collections;

public class TrafficLights : MonoBehaviour {

    private GameObject redLeft, redRight, redCenter, 
                       yellowLeft, yellowRight, yellowCenter,
                       greenLeft, greenRight, greenCenter;

    IEnumerator Start()
    {
        redLeft = GameObject.FindGameObjectWithTag("RedLeft");
        redRight = GameObject.FindGameObjectWithTag("RedRight");
        redCenter = GameObject.FindGameObjectWithTag("RedCenter");

        yellowLeft = GameObject.FindGameObjectWithTag("YellowLeft");
        yellowRight = GameObject.FindGameObjectWithTag("YellowRight");
        yellowCenter = GameObject.FindGameObjectWithTag("YellowCenter");

        greenLeft = GameObject.FindGameObjectWithTag("GreenLeft");
        greenRight = GameObject.FindGameObjectWithTag("GreenRight");
        greenCenter = GameObject.FindGameObjectWithTag("GreenCenter");

        // Wait 1 sec before enable red lights
        yield return new WaitForSeconds(1);

        while (true)
        {            
            // Enable red light for 5 sec then switch
            redLeft.GetComponent<Light>().enabled = true;
            redRight.GetComponent<Light>().enabled = true;
            redCenter.GetComponent<Light>().enabled = true;  
            yield return new WaitForSeconds(5);
            redLeft.GetComponent<Light>().enabled = false;
            redRight.GetComponent<Light>().enabled = false;
            redCenter.GetComponent<Light>().enabled = false;  

            // Yellow should come and go fast
            yellowLeft.GetComponent<Light>().enabled = true;
            yellowRight.GetComponent<Light>().enabled = true;
            yellowCenter.GetComponent<Light>().enabled = true;
            yield return new WaitForSeconds(1);
            yellowLeft.GetComponent<Light>().enabled = false;
            yellowRight.GetComponent<Light>().enabled = false;
            yellowCenter.GetComponent<Light>().enabled = false;

            // Green light for 5 seconds
            greenLeft.GetComponent<Light>().enabled = true;
            greenRight.GetComponent<Light>().enabled = true;
            greenCenter.GetComponent<Light>().enabled = true;
            yield return new WaitForSeconds(5);            
            greenLeft.GetComponent<Light>().enabled = false;
            greenRight.GetComponent<Light>().enabled = false;
            greenCenter.GetComponent<Light>().enabled = false;

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
