using System;
using UnityEngine;
using System.Collections.Generic;

namespace Core.ScriptableObjects.Gameplay
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "MENUNAME", order = 0)]
    public class LevelUpTable : ScriptableObject
    {
        public List<XPData> table = new List<XPData>();
        
        #if UNITY_EDITOR

        private void Awake()
        {
            for (int i = 0; i < 50; ++i)
            {
                table.Add(new XPData(i + 1, 0));
            }
        }

#endif
    }
}