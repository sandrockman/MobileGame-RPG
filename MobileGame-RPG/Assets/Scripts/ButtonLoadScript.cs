using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonLoadScript : MonoBehaviour {

    public void _LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void _LoadStoredScene()
    {
        //SceneManager.LoadScene(DestinationScript.Instance.loadDestination);
        NavigationManager.NavigateTo(DestinationScript.Instance.loadDestination);
    }


}
