using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    [field: SerializeField] public int MinHarvest { get; private set; } = 1;
    [field: SerializeField] public int MaxHarvest { get; private set; } = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Harvestable harvestable = collision.GetComponent<Harvestable>();

        if (harvestable != null) 
        {
            int amountToHarvest = UnityEngine.Random.Range(MinHarvest, MaxHarvest);

            harvestable.Harvest(amountToHarvest);
        }
    }
}
