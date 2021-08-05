using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _gemAmount = 0;

    public void CollectGem(int amount)
    {
        _gemAmount += amount;
    }    
}
