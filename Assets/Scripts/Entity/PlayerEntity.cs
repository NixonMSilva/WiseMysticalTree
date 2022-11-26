using System.Collections;
using System.Collections.Generic;
using Core.ScriptableObjects.Gameplay;
using UnityEngine;

namespace Entity
{
    public class PlayerEntity : Entity
    {
        [Header("leveling Settings")]
        [SerializeField] private float _experience;
        [SerializeField] private float _xpToTheNextLVL;
        [SerializeField] private int _level;

        [SerializeField] private LevelUpTable _xpTable;
        /* list to hold xp to the next lvl 
        |------------ example list--------------|
        | LVL |  XP   |
        |  0  | 270.0 |
        |  1  | 520.0 |
        .
        .
        .

        */



        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        // updates level, experience n takes new xp to the next level from the list
        public void LevelUP(){
            this._level++;
            this._experience = 0;
            this._xpToTheNextLVL = _xpTable.table[(_level - 1)].xpNeeded;
        }

        public bool CheckIfLevelUp(){
            if(_experience>=_xpToTheNextLVL){
                return true;
            }else{
                return false;
            }
        }

        public void ReceiveExperience(float receivedExperienece){
            this._experience += receivedExperienece;

            //ensures that experience don't goes over max value
            if(this._experience > this._xpToTheNextLVL)
                this._experience = this._xpToTheNextLVL;


            if(CheckIfLevelUp()){
                LevelUP();
            }
        }

//------------ Stamina methods ---------------------
        //if Stamina is less than 0 it isn't alive
        public override bool HasStamina()
        {
            if (this.Stamina<=0)
            {
                return false;
            }else{
                return true;
            }
        }

        public override bool HasStaminaEnough(float actionStaminaCost){
            if( this.Stamina > actionStaminaCost){
                return true;
            }else{
                return false;
            }
        }
        
        public override void SpendStamina(float actionStaminaCost){
            this.Stamina -= actionStaminaCost;
            
            //ensures that Stamina don't goes under 0
            if(this.Stamina<0)
                this.Stamina = 0;

            if (HasStamina())
            {
                //Maybe play a tired animation
            }
        }

        public override void StaminaRecovery(){
            if (CanRecoverStamina())
            {
                this.Stamina += StaminaRecoverPerTime;

                //ensures that Stamina don't goes over max value
                if(this.Stamina>this.MaxStamina)
                    this.Stamina = this.MaxStamina;
            }
           
        }

        public override bool CanRecoverStamina(){
            // can recover when Stamina is under max
            if (this.Stamina<this.MaxStamina)
            {
                return true;
            }else{
                return false;
            }

            //maybe for a recover stamina debuff
        }
//------------ Health n death Methods ---------------------

        public override bool IsAlive(){
            // if it's health is under 0 it isn't alive
            if (this.Health<=0)
            {
                return false;
            }else
            {
                return true;
            }
        }

        public override void TakeDamage(float damage){
            this.Health -= damage;

            //ensures that Health don't goes under 0
            if(this.Health<0)
                this.Health = 0;

            if(!IsAlive()){
                KillEntity();
            }
        }

        public override void RecoverHealth(float HealValue){
            if(CanRecoverHealth()){
                this.Health += HealValue;
                
                //ensures that Health don't goes over max value
                if(this.Health  > this.MaxHealth)
                    this.Health = this.MaxHealth;
                
            }
            
        }

        public override bool CanRecoverHealth(){
            return true;
            //maybe for a healing debuff
        }

        public override void KillEntity(){}

//---------------- Gets n Sets ---------------------------------------
        // Experience
        public float GetExperience(){
            return _experience;
        }
        public void SetExperience(float newExperience){
            this._experience = newExperience;
        }

        // Xp to the next level
        public float GetXpToTheNextLVL(){
            return _xpToTheNextLVL;
        }
        public void SetXpToTheNextLVL(float newXpToTheNextLVL){
            this._xpToTheNextLVL = newXpToTheNextLVL;
        }

        // Level
        public int GetLevel(){
            return _level;
        }
        public void SetLevel(int newLevel){
            this._level = newLevel;
        }

        public LevelUpTable GetXPTable() => _xpTable;

    }
}

