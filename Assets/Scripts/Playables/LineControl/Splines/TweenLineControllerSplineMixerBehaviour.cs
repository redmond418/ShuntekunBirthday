using TweenPlayables;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    public class TweenLineControllerSplineMixerBehaviour : TweenAnimationMixerBehaviour<LineControllerSpline, TweenLineControllerSplineBehaviour>
    {
        private FloatValueMixer endAMixer = new FloatValueMixer();
        private FloatValueMixer endBMixer = new FloatValueMixer();

        public override void Blend(LineControllerSpline binding, TweenLineControllerSplineBehaviour behaviour, float weight, float progress)
        {
            endAMixer.TryBlend(behaviour.endA, binding, progress, weight);
            endBMixer.TryBlend(behaviour.endB, binding, progress, weight);
        }

        public override void Apply(LineControllerSpline binding)
        {
            endAMixer.TryApplyAndClear(binding, (x, binding) => binding.EndA = x);
            endBMixer.TryApplyAndClear(binding, (x, binding) => binding.EndB = x);
        }
    }
}