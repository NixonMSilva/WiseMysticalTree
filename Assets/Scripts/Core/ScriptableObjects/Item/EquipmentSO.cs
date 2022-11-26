using Core.Enums;
using UnityEngine;

namespace Core.ScriptableObjects.Item
{
    [CreateAssetMenu(fileName = "New Equipment", menuName = "Item/Equipment")]
    public class EquipmentSO : GeneralItemsSO
    {
        [Header("Equipment information")]
        [Space]

        public EquipmentType equipmentType;

        /// <summary>
        /// Tempo de cooldown entre usos
        /// </summary>
        public float cooldown;

        /// <summary>
        /// Estado de manutencao do item (0 a 100)
        /// </summary>
        public float durability;

        /// <summary>
        /// Nivel necessário para equipar
        /// </summary>
        public int requiredLevel;

        /// <summary>
        /// Equipamento pode causar algum efeito no usuário ou inimigo
        /// </summary>
        public EffectType effect;
    }
}
