using TweenPlayables;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    public class TweenLineControllerTwoPointsMixerBehaviour : TweenAnimationMixerBehaviour<LineControllerTwoPoints, TweenLineControllerTwoPointsBehaviour>
    {
        private Vector2ValueMixer endAMixer = new Vector2ValueMixer();
        private Vector2ValueMixer endBMixer = new Vector2ValueMixer();

        public override void Blend(LineControllerTwoPoints binding, TweenLineControllerTwoPointsBehaviour behaviour, float weight, float progress)
        {
            endAMixer.TryBlend(behaviour.endA, binding, progress, weight);
            endBMixer.TryBlend(behaviour.endB, binding, progress, weight);
        }

        public override void Apply(LineControllerTwoPoints binding)
        {
            endAMixer.TryApplyAndClear(binding, (x, binding) => binding.EndA = x);
            endBMixer.TryApplyAndClear(binding, (x, binding) => binding.EndB = x);
        }
    }
}