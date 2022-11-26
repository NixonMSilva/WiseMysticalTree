using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Entity
{
    public class EnemyEntity : Entity
    {

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
    }
}

