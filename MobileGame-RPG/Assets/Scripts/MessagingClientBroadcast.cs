using UnityEngine;
public class MessagingClientBroadcast : MonoBehaviour
{
    //Player enters our collision
    void OnCollisionEnter2D(Collision2D other)
    {
        MessagingManager.Instance.Broadcast();
    }
}
