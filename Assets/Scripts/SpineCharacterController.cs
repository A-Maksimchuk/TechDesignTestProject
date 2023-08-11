using Spine.Unity;
using Spine.Unity.Examples;
using UnityEngine;

public class SpineCharacterController:MovableObject
{
    [SerializeField] private SkeletonAnimation skeletonAnimation;
    [SerializeField] private AnimationReferenceAsset idleReferenceAsset;
    [SerializeField] private AnimationReferenceAsset runReferenceAsset;
    private bool lookForward = true;
    private const string IDLE_ANIM_NAME = "idle";
    private const string RUN_ANIM_NAME = "run";

    public void MoveToPoint(Vector3 point)
    {
        lookForward = point.x > transform.position.x;
        transform.localScale = new Vector3(lookForward ? 1 : -1, 1, 1);
        SetState(RUN_ANIM_NAME);
        MoveToPoint(point, () => 
            SetState(IDLE_ANIM_NAME));
    }

    private void SetAnimation(AnimationReferenceAsset animation, bool loop, float timeScale)
    {
        skeletonAnimation.state.SetAnimation(0, animation, loop).TimeScale = timeScale;
    }

    private void SetState(string state)
    {
        switch (state)
        {
            case IDLE_ANIM_NAME:
            {
                SetAnimation(idleReferenceAsset, true, 1f);
                break;
            }

            case RUN_ANIM_NAME:
            {
                SetAnimation(runReferenceAsset, true, 1f);
                break;
            }
        }
    }
}