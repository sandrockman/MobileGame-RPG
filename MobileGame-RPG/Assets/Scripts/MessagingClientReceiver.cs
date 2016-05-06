using UnityEngine;
public class MessagingClientReceiver : MonoBehaviour
{
    void Start()
    {
        //subscribe to the event we care about.
        MessagingManager.Instance.Subscribe(ThePlayerIsTryingToLeave);
    }

    void ThePlayerIsTryingToLeave()
    {
        Debug.Log("Oi Don't Leave Me!! - " + tag.ToString());

        ConversationComponent dialogue = GetComponent<ConversationComponent>();
        if(dialogue != null)
        {
            if(dialogue.Conversations != null && dialogue.Conversations.Length > 0)
            {
                var conversation = dialogue.Conversations[0];
                if(conversation != null)
                {
                    ConversationManager.Instance.StartConversation(conversation);
                }
            }
        }
    }
    
}
