using System;
using System.Collections.Generic;
using UnityEngine;

public class MessagingManager : MonoBehaviour
{
    //static singelton property
    public static MessagingManager Instance { get; set; }

    //property for manager
    private List<Action> subscribers = new List<Action>();  //DELEGATE

    void Awake()
    {
        Debug.Log("Messaging Manager Started");
        //check if any other instances are conflicting
        if (Instance != null && Instance != this)
            Destroy(gameObject);

        //Save current instances
        Instance = this;

        //keep this around
        DontDestroyOnLoad(gameObject);
    }

    //Method to register recipients or subscribers to the messages
    public void Subscribe(Action subscriber)
    {
        Debug.Log("Subscriber registered");
        subscribers.Add(subscriber);
    }

    //Method to unsubscribe from the manager
    public void UnSubscribe(Action subscriber)
    {
        Debug.Log("Subscriber UnRegistered");
        subscribers.Remove(subscriber);
    }

    //Clear subscribers
    public void ClearAllSubscribers()
    {
        subscribers.Clear();
    }

    //Loop through all the subscribers and notify them using their delegates
    public void Broadcast()
    {
        Debug.Log("Broadcast requested, No of Subscribers = " + subscribers.Count);
        foreach (var subscriber in subscribers) //YES, use var
        {
            subscriber();
        }
    }
}
