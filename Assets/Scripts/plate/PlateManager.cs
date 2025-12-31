using TMPro;
using UnityEngine;

public class PlateManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static PlateManager Singleton { get; private set;}

    public float plateFullness;
    public float plateSatisfaction;

    public TextMeshProUGUI currentPlateFullnessStats;
    public TextMeshProUGUI currentPlateSatisfactionStats;
    
    void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
        }
    }

    void Start()
    {
        plateFullness = 0;
        plateSatisfaction = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendPlate()
    {
        //send the plate to the customer
        Customer.Singleton.addCustomerFullness(plateFullness);
        Customer.Singleton.addCustomerSatisfaction(plateSatisfaction);
        Customer.Singleton.reduceServingNumber(1);

        Customer.Singleton.updateCustomerText();
        ResetPlate();

    }

    public void ResetPlate()
    {
        //reset plate values;

        plateFullness = 0;
        plateSatisfaction = 0;
        updateTextDisplay();
    }

    public void updateTextDisplay()
    {
        currentPlateFullnessStats.text = "Fullness: " + plateFullness;
        currentPlateSatisfactionStats.text = "Satisfaction: " + plateSatisfaction;
    }
}
