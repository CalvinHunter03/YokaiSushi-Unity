using System;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class gameplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public List<GameObject> cardPositions;
    public List<Sprite> deck;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCard()
    {
        int cardIndex = findEmptyPosition();
        if(cardIndex == -1)
        {
            Debug.Log("Hand is full");
        }
        else
        {
            placeCard(cardIndex);
        }
    }

    private int findEmptyPosition()
    {
        
        for(int i = 0; i < cardPositions.Count; i++){



            if(cardPositions[i].transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>().sprite == null)
            {
                return i;
            }
        }
        return -1;
    }

    private void placeCard(int index)
    {
        cardPositions[index].transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Image>().sprite = getRandomCard();
    }

    private Sprite getRandomCard()
    {
        int randomIndex = UnityEngine.Random.Range(0, deck.Count);
        return deck[randomIndex];
    }
}
