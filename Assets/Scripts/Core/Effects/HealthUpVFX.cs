using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    public class HealthUpVFX : ParticleVFX
    {
        private void OnEnable()
        {
            // OnPickUpItem += TriggerParticles
        }
        private void OnDisable()
        {
            // OnPickUpItem -= TriggerParticles
        }
        public override void TriggerParticles()
        {
            base.TriggerParticles();
            print("Health UP");
            Destroy(_particleClone, _effectDuration);
        }
    }

}
