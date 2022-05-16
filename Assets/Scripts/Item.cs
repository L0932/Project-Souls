using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ALO
{
    public class Item : ScriptableObject
    {
        [Header("Item Information")]
        public Sprite itemIcon;
        public string itemName;

        //public string itemDescription;
    }
}
