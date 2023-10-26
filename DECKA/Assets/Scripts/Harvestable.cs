using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Harvestable : MonoBehaviour
{
   [field: SerializeField] public int ResourceCount { get; private set; }
   [field: SerializeField] public GameObject ResourceNode { get; private set; }
   
   private ParticleSystem _ps;
   private int _amountHarvested = 0;

   private void Start()
   {
      _ps = GetComponent<ParticleSystem>();
   }

   public void Harvest(int amount)
   {
      // We can't harvest more resources than are left in the node
      int amountToSpawn = Mathf.Min(amount, ResourceCount - _amountHarvested);

      if (amountToSpawn > 0)
      {
         _ps.Emit(amountToSpawn);
         _amountHarvested += amountToSpawn;
      }
      
      if (_amountHarvested >= ResourceCount)
      {
         // The node is depleted
         Destroy(ResourceNode);
      }
        //Destroy(gameObject);
   }
}
