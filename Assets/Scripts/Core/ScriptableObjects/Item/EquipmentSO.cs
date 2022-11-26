using UnityEngine;

namespace Core.ScriptableObjects.Item
{
    public enum EffectType {NONE, REGENERATION, CURSE, VENOM, FIRE};
    public enum ArmorType {NONE, HELMET, BREASTPLATE, GAUNTLETS, BOOTS, SHIELD};
    public enum WeaponType {NONE, SWORD, AXE, MACE, SPEAR, DAGGER, BOW, CROSSBOW};

    [CreateAssetMenu(fileName = "New Equipment", menuName = "Item/Equipment")]
    public class EquipmentSO : GeneralItensSO
    {
        [Header("Equipment information")]
        [Space]
        /// <summary>
        /// Dano causado no inimigo (0 para armadura)
        /// </summary>
        // public EquipmentType equipmentType;
        
        /// <summary>
        /// Dano causado no inimigo (0 para armadura)
        /// </summary>
        public float damage;

        /// <summary>
        /// Tempo de cooldown entre usos
        /// </summary>
        public float cooldown;

        /// <summary>
        /// Proteção fornecida pela armadura (0 para armas)
        /// </summary>
        public float protection;
        
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

        /// <summary>
        /// Tipo de armadura
        /// </summary>
        public ArmorType armorType;

        /// <summary>
        /// Tipo de arma
        /// </summary>
        public WeaponType weaponType;
    }
}
