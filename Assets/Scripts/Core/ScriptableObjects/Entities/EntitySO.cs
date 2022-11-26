using UnityEngine;

namespace Core.ScriptableObjects.Entities
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "Entity/Entity|NPC")]
    public class EntitySO : ScriptableObject
    {
        [Header("Name")]
        [Space]
        public string entityName;
        public bool displayNameAboveHead;

        [Header("Attributes")]
        [Space]
        public float level;
        public float maxHealth, maxEnergy;
        public float attack, defense, agility, mysticism;
    }    
}

