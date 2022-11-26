using UnityEngine;
using Core.ScriptableObjects;
using Core.ScriptableObjects.Item;

namespace Core.Items
{
    public class Item : MonoBehaviour
    {
        [SerializeField] protected ConsumableItemsSO itemSo;

        public ConsumableItemsSO GetItemData() => itemSo;

        private void Equip ()
        {

        }

        private void Unequip ()
        {

        }

        private void Discard ()
        {

        }

        private void Sell ()
        {

        }
    }
}