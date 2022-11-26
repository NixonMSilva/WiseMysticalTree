namespace Core.ScriptableObjects.Gameplay
{
    [System.Serializable]
    public class XPData
    {
        public XPData(int level, int xpNeeded)
        {
            this.level = level;
            this.xpNeeded = xpNeeded;
        }
        
        public int level;
        public int xpNeeded;
    }
}