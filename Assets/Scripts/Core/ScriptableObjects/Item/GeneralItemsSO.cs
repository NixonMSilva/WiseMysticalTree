using UnityEngine;

namespace Core.ScriptableObjects.Item
{

    [CreateAssetMenu(fileName = "New Item", menuName = "Item/New General Item")]

    public class GeneralItemsSO : ScriptableObject
    {
        /// <summary>
        /// Identificador de item unico, caso seja nescess�rio identificar itens especificos para utiliza��o em puzzles, quests, etc
        /// </summary>
        public int id;

        /// <summary>
        /// Pre�o unitario do item
        /// </summary>
        public int price;

        /// <summary>
        /// Nome do Item 
        /// </summary>
        public string itemName;

        /// <summary>
        /// Descri��o do item
        /// </summary>
        public string description;

        /// <summary>
        /// Sprite 2d do item 
        /// </summary>
        public Sprite sprite;

        /// <summary>
        /// Peso do item
        /// </summary>
        public float weight;

        /// <summary>
        /// Cor do item
        /// </summary>
        public Color color = Color.white;
    }
}
