using UnityEngine;
using System.Collections;

public class RandomBuildings : MonoBehaviour {

    public GameObject Road;
    public GameObject Building;

	// Use this for initialization
    
	void Start () {
        Vector3 previous;
        for (int i = 0; i < 5; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-76, 13), 8, Random.Range(-20,69));
            Instantiate(Building, pos, Building.transform.rotation);

        }

        /*
        Vector3 pos = new Vector3(0, 0, 0);
        float x = 0;
        for (int i = 0; i < 5; ++i)
        {
            float z = 0;

            for (int j = 0; j < 5; ++j)
            {
                Instantiate(Road, pos, Road.transform.rotation);
                z -= 150;
                pos = new Vector3(x, 0, z);
            }
            x -= 150;            
        } */           

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
