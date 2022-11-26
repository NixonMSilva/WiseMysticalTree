using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity
{
    public class PlayerEntity : Entity
    {
        [Header("leveling Settings")]
        [SerializeField] private float _experience;
        [SerializeField] private float _xpToTheNextLVL;
        [SerializeField] private int _level;
        [SerializeField] private List<float> _levelUpXpList;
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
            this._xpToTheNextLVL = _levelUpXpList[_level];
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
            if (this._stamina<=0)
            {
                return false;
            }else{
                return true;
            }
        }

        public override bool HasStaminaEnough(float actionStaminaCost){
            if( this._stamina > actionStaminaCost){
                return true;
            }else{
                return false;
            }
        }
        
        public override void SpendStamina(float actionStaminaCost){
            this._stamina -= actionStaminaCost;
            
            //ensures that Stamina don't goes under 0
            if(this._stamina<0)
                this._stamina = 0;

            if (HasStamina())
            {
                //Maybe play a tired animation
            }
        }

        public override void StaminaRecovery(){
            if (CanRecoverStamina())
            {
                this._stamina += _staminaRecoverPerTime;

                //ensures that Stamina don't goes over max value
                if(this._stamina>this._maxStamina)
                    this._stamina = this._maxStamina;
            }
           
        }

        public override bool CanRecoverStamina(){
            // can recover when Stamina is under max
            if (this._stamina<this._maxStamina)
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
            if (this._health<=0)
            {
                return false;
            }else
            {
                return true;
            }
        }

        public override void TakeDamage(float damage){
            this._health -= damage;

            //ensures that Health don't goes under 0
            if(this._health<0)
                this._health = 0;

            if(!IsAlive()){
                KillEntity();
            }
        }

        public override void RecoverHealth(float HealValue){
            if(CanRecoverHealth()){
                this._health += HealValue;
                
                //ensures that Health don't goes over max value
                if(this._health  > this._maxHealth)
                    this._health = this._maxHealth;
                
            }
            
        }

        public override bool CanRecoverHealth(){
            return true;
            //maybe for a healing debuff
        }

        public override void KillEntity(){}

    } 
}

