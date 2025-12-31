using NUnit.Framework.Interfaces;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Customer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static Customer Singleton { get; private set;}


    private float customerFullness;
    private float customerSatisfaction;
    private int servingNumber;

    private bool full;
    private bool satisfied;

    public TextMeshProUGUI customerFullnessText;
    public TextMeshProUGUI customerSatisfactionText;
    public TextMeshProUGUI servingNumberText;



    void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
        }
    }
    void Start()
    {
        getNewCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCustomerFullness(float value)
    {
        customerFullness -= value;

    }

    public void addCustomerSatisfaction(float value)
    {
        customerSatisfaction -= value;
    }

    public void reduceServingNumber(int num)
    {
        servingNumber -= num;
    }

    private void checkCustomerLevels()
    {
        if(customerFullness <= 0)
        {
            full = true;
        }

        if(customerSatisfaction <= 0)
        {
            satisfied = true;
        }
    }

    public void getNewCustomer()
    {
        full = false;
        satisfied = false;
        customerFullness = UnityEngine.Random.Range(80, 121);
        customerSatisfaction = UnityEngine.Random.Range(80,121);
        servingNumber = UnityEngine.Random.Range(4,7);

        updateCustomerText();
    }

    public void updateCustomerText()
    {
        
        customerFullnessText.text = "Fullness: " + customerFullness;
        customerSatisfactionText.text = "Satisfaction: " + customerSatisfaction;
        servingNumberText.text = "Servings: " + servingNumber;

        
    }
}
