using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.ScriptableObjects.Entities;

namespace Entity
{
    public abstract class Entity : MonoBehaviour
    {
        [Header("Health Settings")]
        [SerializeField] protected float MaxHealth;
        [SerializeField] protected float Health;

        [Header("Stamina Settings")]
        [SerializeField] protected float MaxStamina;
        [SerializeField] protected float Stamina;
        [SerializeField] protected float StaminaRecoverPerTime;

        [Header("Attributes")]
        [SerializeField] protected float Strenght;
        [SerializeField] protected float Defense;
        [SerializeField] protected float Agility;
        [SerializeField] protected float Mysticism;

        [Header("Object Data")] 
        [SerializeField] protected EntitySO EntityData;
        
        
        // Start is called before the first frame update
        private void Start()
        {
            
        }

        // Update is called once per frame
        private void Update()
        {
            
        }

        #region StaminaMethods

        // checks if it has Stamina at all
        public abstract bool HasStamina();

        // checks if it has stamina to perform an action
        public abstract bool HasStaminaEnough(float actionStaminaCost);
        
        // spends stamina after it performs an action
        public abstract void SpendStamina(float actionStaminaCost);

        // chacks if it can recover Stamina
        public abstract bool CanRecoverStamina();

        // updates Stamina value increasing a value per time
        public abstract void StaminaRecovery();
        
        #endregion

        #region HealthMethods

        // Checks if it is alive
        public abstract bool IsAlive();

        // decreases health when it recieves damage
        public abstract void TakeDamage(float damage);

        // Recovers health when it recieves healing
        public abstract void RecoverHealth(float HealValue);

        // Check if it can recover Health
        public abstract bool CanRecoverHealth();

        // Kills it
        public abstract void KillEntity();

        #endregion
        
        #region Getter&Setters
        
        // Max Health
        public float GetMaxHealth(){
            return MaxHealth;
        }
        public void SetMaxHealth(float newMaxHealth){
            this.MaxHealth = newMaxHealth;
        }

        // Health
        public float GetHealth(){
            return Health;
        }
        public void SetHealth(float newHealth){
            this.Health = newHealth;
        }

        // Max Stamina
        public float GetMaxStamina(){
            return MaxStamina;
        }
        public void SetMaxStamina(float newMaxStamina){
            this.MaxStamina = newMaxStamina;
        }

        // Stamina
        public float GetStamina(){
            return Stamina;
        }
        public void SetStamina(float newStamina){
            this.Stamina = newStamina;
        }

        // Stamina Recover Per Time
        public float GetStaminaRecoverPerTime(){
            return StaminaRecoverPerTime;
        }
        public void SetStaminaRecoverPerTime(float newStaminaRecoverPerTime){
            this.StaminaRecoverPerTime = newStaminaRecoverPerTime;
        }

        // Strengh
        public float GetStrenght(){
            return Strenght;
        }
        public void SetStrenght(float newStrenght){
            this.Strenght = newStrenght;
        }

        // Defense
        public float GetDefense(){
            return Defense;
        }
        public void SetDefense(float newDefense){
            this.Defense = newDefense;
        }

        //Agility
        public float GetAgility(){
            return Agility;
        }
        public void SetAgility(float newAgility){
            this.Agility = newAgility;
        }

        //Mysticism
        public float GetMysticism(){
            return Mysticism;
        }
        public void SetMysticism(float newMysticism){
            this.Mysticism = newMysticism;
        }

        public EntitySO GetData()
        {
            return EntityData;
        }
        
        #endregion
    }
}

