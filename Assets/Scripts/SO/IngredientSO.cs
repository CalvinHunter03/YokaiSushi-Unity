using System;
using UnityEngine;

[CreateAssetMenu(fileName = "IngredientSO", menuName = "Scriptable Objects/IngredientSO")]
public class IngredientSO : ScriptableObject
{
    public float fullness;
    public float satisfaction;
    public float shelfLife;
    
    public IngredientType type;

    public Sprite cardBase;
}

public enum IngredientType
{
    Base,
    Protein,
    Topping
}
