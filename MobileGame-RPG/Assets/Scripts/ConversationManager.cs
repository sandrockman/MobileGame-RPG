using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is DIFFERENT from the Editor folder container.
public class ConversationManager : MonoBehaviour
{
    //static singelton property
    public static ConversationManager Instance { get; set; }

    bool isTalking = false;
    ConversationEntry currentConversationLine;

    int fontSpacing = 7;
    int conversationTextWidth;
    int dialogHeight = 70;

    void Awake()
    {
        //check if any other instances are conflicting
        if (Instance != null && Instance != this)
            Destroy(gameObject);

        //Save current instances
        Instance = this;
    }

    public void StartConversation(Conversation conversation)
    {
        if (!isTalking)
            StartCoroutine(DisplayConversation(conversation));
    }

    IEnumerator DisplayConversation(Conversation conversation)
    {
        isTalking = true;
        foreach (var conversationLine in conversation.ConversationLines)
        {
            currentConversationLine = conversationLine;
            conversationTextWidth = currentConversationLine.ConversationText.Length * fontSpacing;
            Debug.Log(currentConversationLine.SpeakingCharacterName + " " + currentConversationLine.ConversationText + " " + currentConversationLine.DisplayPicture);

            yield return new WaitForSeconds(3);
        }

        isTalking = false;
    }
}
