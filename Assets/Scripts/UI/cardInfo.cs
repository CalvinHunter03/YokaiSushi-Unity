using UnityEngine;

public class cardInfo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float fullness;
    private float satisfaction;
    private float shelfLife;
    private IngredientType type;

    [SerializeField] private IngredientSO information;


    void Start()
    {
        fullness = information.fullness;
        satisfaction = information.satisfaction;
        shelfLife = information.shelfLife;
        type = information.type;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getFullness()
    {
        return fullness;
    }

    public float getSatisfaction()
    {
        return satisfaction;
    }

    public float getShelfLife()
    {
        return shelfLife;
    }

    public IngredientType getType()
    {
        return type;
    }
}
