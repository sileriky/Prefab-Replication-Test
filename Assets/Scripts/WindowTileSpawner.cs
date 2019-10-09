using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTileSpawner : MonoBehaviour {

    //Ref to window tile prefab file
    //Requires link in editor!!!
    public GameObject WindowTilePrefab;

    public int staircaseHeight;

    // Use this for initialization
    void Start () {

        //Get position of spawner
        float selfX = transform.position.x;
        float selfY = transform.position.y;

        //Setup initial tile
        Vector3 initPos = transform.position;
        GameObject newWindow = Instantiate(WindowTilePrefab, initPos, Quaternion.identity);

        //Get dimensions of prefab tile
        Vector3 prefabDims = newWindow.GetComponent<Renderer>().bounds.size;

        for (int curStep = 1; curStep <= staircaseHeight; curStep++) {
            for (int curStepTile = 0; curStepTile < curStep; curStepTile++) {
                Vector3 curPos = new Vector3(curStepTile * prefabDims.x + selfX, -curStep * prefabDims.y + selfY, 0);
                Instantiate(WindowTilePrefab, curPos, Quaternion.identity);
            }
            
        }

    }
	
}
