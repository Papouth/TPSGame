using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    #region Variables

    [Header("Rareté")]

    [SerializeField] private int rarity = 0; // Rareté de l'arme

    /*
    0 => Munition
    1 => Arme commune
    2 => Arme peu commune
    3 => Arme rare
    4 => Arme épique
    5 => Arme Légendaire
    */

    [Header("Munitions")]

    [SerializeField] private int ammo = 0; // Nombre de munitions actuel (dans le chargeur)
    // Si munition, le nombre de munitions drop
    [SerializeField] private int maxAmmo = 64; // Nombre de munitions max (dans le chargeur)
    // Si munition, le nombre max de munitions qui peuvent être drop

    #endregion

    void Start()
    {


        
    }

    void Update()
    {
        


    }

}
