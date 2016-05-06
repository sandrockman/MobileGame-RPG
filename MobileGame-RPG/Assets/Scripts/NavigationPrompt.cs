using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class NavigationPrompt : MonoBehaviour {

    public GameObject travelContainer;

    // Use this for initialization
	void Start () {
        //travelContainer = GameObject.FindWithTag("TravelContainer");
        travelContainer.SetActive(false);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (NavigationManager.CanNavigate(gameObject.tag))
            {
                travelContainer.SetActive(true);
                travelContainer.GetComponentInChildren<Text>().text = "Do You Want To Travel To " +
                    NavigationManager.GetRouteInformation(gameObject.tag) + "?";
                DestinationScript.Instance.loadDestination = gameObject.tag;
            }
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            travelContainer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
