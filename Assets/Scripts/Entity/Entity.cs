using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Entity
{
    public abstract class Entity : MonoBehaviour
    {
        [Header("Health Settings")]
        [SerializeField] protected float _maxHealth;
        [SerializeField] protected float _health;

        [Header("Stamina Settings")]
        [SerializeField] protected float _maxStamina;
        [SerializeField] protected float _stamina;
        [SerializeField] protected float _staminaRecoverPerTime;

        [Header("Attributes")]
        [SerializeField] protected float _strenght;
        [SerializeField] protected float _defense;
        [SerializeField] protected float _agility;
        [SerializeField] protected float _mysticism;
        
        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

//----------- Stamina Methods ----------------

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


//----------- Health n death Methods -----------------

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


//---------------- Gets n Sets ---------------------------------------
        // Max Health
        public float GetMaxHealth(){
            return _maxHealth;
        }
        public void SetMaxHealth(float newMaxHealth){
            this._maxHealth = newMaxHealth;
        }

        // Health
        public float GetHealth(){
            return _health;
        }
        public void SetHealth(float newHealth){
            this._health = newHealth;
        }

        // Max Stamina
        public float GetMaxStamina(){
            return _maxStamina;
        }
        public void SetMaxStamina(float newMaxStamina){
            this._maxStamina = newMaxStamina;
        }

        // Stamina
        public float GetStamina(){
            return _stamina;
        }
        public void SetStamina(float newStamina){
            this._stamina = newStamina;
        }

        // Stamina Recover Per Time
        public float GetStaminaRecoverPerTime(){
            return _staminaRecoverPerTime;
        }
        public void SetStaminaRecoverPerTime(float newStaminaRecoverPerTime){
            this._staminaRecoverPerTime = newStaminaRecoverPerTime;
        }

        // Strengh
        public float GetStrenght(){
            return _strenght;
        }
        public void SetStrenght(float newStrenght){
            this._strenght = newStrenght;
        }

        // Defense
        public float GetDefense(){
            return _defense;
        }
        public void SetDefense(float newDefense){
            this._defense = newDefense;
        }

        //Agility
        public float GetAgility(){
            return _agility;
        }
        public void SetAgility(float newAgility){
            this._agility = newAgility;
        }

        //Mysticism
        public float GetMysticism(){
            return _mysticism;
        }
        public void SetMysticism(float newMysticism){
            this._mysticism = newMysticism;
        }
// --------------------------------------------------------------------
    }
}

