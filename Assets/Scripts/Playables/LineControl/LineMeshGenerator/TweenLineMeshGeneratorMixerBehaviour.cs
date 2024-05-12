using TweenPlayables;

namespace Redmond.QuectoLines.TweenPlayablesEx
{
    public class TweenLineMeshGeneratorMixerBehaviour : TweenAnimationMixerBehaviour<LineMeshGenerator, TweenLineMeshGeneratorBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();
        private FloatValueMixer thicknessMixer = new FloatValueMixer();
        private IntValueMixer endCapDivisionCountMixer = new IntValueMixer();
        private FloatValueMixer endCapStretchMixer = new FloatValueMixer();
        private IntValueMixer cornerDivisionCountMixer = new IntValueMixer();

        public override void Blend(LineMeshGenerator binding, TweenLineMeshGeneratorBehaviour behaviour, float weight, float progress)
        {
            colorMixer.TryBlend(behaviour.color, binding, progress, weight);
            thicknessMixer.TryBlend(behaviour.thickness, binding, progress, weight);
            endCapDivisionCountMixer.TryBlend(behaviour.endCapDivisionCount, binding, progress, weight);
            endCapStretchMixer.TryBlend(behaviour.endCapStretch, binding, progress, weight);
            cornerDivisionCountMixer.TryBlend(behaviour.cornerDivisionCount, binding, progress, weight);
        }

        public override void Apply(LineMeshGenerator binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.Color = x);
            thicknessMixer.TryApplyAndClear(binding, (x, binding) => binding.Thickness = x);
            endCapDivisionCountMixer.TryApplyAndClear(binding, (x, binding) => binding.EndCapDivisionCount = x);
            endCapStretchMixer.TryApplyAndClear(binding, (x, binding) => binding.EndCapStretch = x);
            cornerDivisionCountMixer.TryApplyAndClear(binding, (x, binding) => binding.CornerDivisionCount = x);
        }
    }
}