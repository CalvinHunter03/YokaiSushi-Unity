using System.Collections.Generic;
using UnityEngine;

public class CardHandManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> cardDeck; //has all the cards that can be placed into hand.

    [SerializeField] private List<GameObject> cardHand; //positions of where cards can be placed

    public static bool dragging;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCard()
    {
        int randomIndex = UnityEngine.Random.Range(0, cardDeck.Count);
        
        int cardHandIndex = findCardIndex();

        GameObject newCard = Instantiate(cardDeck[randomIndex], cardHand[cardHandIndex].transform);

    }

    private int findCardIndex()
    {
        for(int i = 0; i < cardHand.Count; i++)
        {
            if (cardHand[i].transform.childCount < 2)
            {
                return i;
            }
        }
        return -1;
    }
}
