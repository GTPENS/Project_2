using UnityEngine;
using System.Collections;

public class SpawnComet : MonoBehaviour {


    [SerializeField]
    private GameObject comet;

    [SerializeField]
    private Camera cam;

    [SerializeField]
    private float minSize, maxSize;

	void Update () {

        //Checks for Input

        if (Input.GetMouseButtonDown(0))
            Spawn();
	}

    void Spawn () {

        //Spawns a comet at the mouse pos

        GameObject x = Instantiate(comet, new Vector3(cam.ScreenToWorldPoint(Input.mousePosition).x, cam.ScreenToWorldPoint(Input.mousePosition).y, 0), Quaternion.identity) as GameObject;

        //Scales the comet to a random scale

        float i = Random.Range(minSize, maxSize);

        x.transform.localScale = new Vector3(i, i, 1);
    }
}
