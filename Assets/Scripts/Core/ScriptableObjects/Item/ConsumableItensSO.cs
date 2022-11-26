using UnityEngine;

namespace Core.ScriptableObjects.Item
{

    [CreateAssetMenu(fileName = "Itens", menuName = "Item/New Consumable")]

    public class ConsumableItensSO : GeneralItensSO
    {
        [Header("Consumable information")]
        [Space]
        /// <summary>
        /// tempo que o item continuara ativo apos a utilizacao
        /// </summary>
        public float duration;

        /// <summary>
        /// Valor de status extra que o personagem recebera
        /// </summary>
        public int statusBoostValue;

        /// <summary>
        /// Tipos de consumiveis definidos em Consumables.cs
        /// </summary>
        //public ConsumableType type;

    }
}