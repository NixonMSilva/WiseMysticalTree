using UnityEngine;

namespace Core.ScriptableObjects.Entities
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "Entity/Enemy")]
    public class EnemySO : EntitySO
    {
        [Header("Combat Information")]
        [Space]
        public float defeatXP;
        public float sightRange;

        /* Itens
         public Items[] drops;
         public Behavior behavior;
         */
    }
}