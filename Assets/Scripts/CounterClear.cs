using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterClear : MonoBehaviour
{

   [SerializeField] private KitchenObjectSO kitchenObjectSO;
   [SerializeField] private Transform counterTopPoint;


    public void Interact()
    {
       Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;
    }

    
}
