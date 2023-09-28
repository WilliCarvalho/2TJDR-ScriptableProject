using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerInventory : MonoBehaviour
    {
        [SerializeField] private Inventory inventory;
        [SerializeField] private PlayerItem playerinventoryItemPrefab;
        [SerializeField] private int PlayerCoinBalance;

        private void PopulatePlayerInventory()
        {
            foreach (Item item in inventory.items)
            {

            }
        }
    }
