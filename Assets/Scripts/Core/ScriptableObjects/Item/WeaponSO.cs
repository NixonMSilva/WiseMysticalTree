using Core.Enums;
using UnityEngine;

namespace Core.ScriptableObjects.Item
{
    [CreateAssetMenu(fileName = "New Weapon", menuName = "Item/Weapon")]
    public class WeaponSO : EquipmentSO
    {
        [Header("Equipment information")]
        [Space]

        /// <summary>
        /// Dano causado no inimigo (0 para armadura)
        /// </summary>
        public float damage;

        /// <summary>
        /// Tipo de arma
        /// </summary>
        public WeaponType weaponType;
    }
}
