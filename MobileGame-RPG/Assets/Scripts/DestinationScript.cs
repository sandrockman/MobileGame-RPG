using UnityEngine;
using System.Collections;

public class DestinationScript : MonoBehaviour {

    public static DestinationScript Instance;
    public string loadDestination;

	// Use this for initialization
	void Start () {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
