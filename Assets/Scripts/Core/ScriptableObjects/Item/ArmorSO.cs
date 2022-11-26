using Core.Enums;
using UnityEngine;

namespace Core.ScriptableObjects.Item
{
    [CreateAssetMenu(fileName = "New Armor", menuName = "Item/Armor")]
    public class ArmorSO : EquipmentSO
    {
        [Header("Equipment information")]
        [Space]
        /// <summary>
        /// Proteção fornecida pela armadura (0 para armas)
        /// </summary>
        public float protection;

        /// <summary>
        /// Tipo de armadura
        /// </summary>
        public ArmorType armorType;
    }
}
