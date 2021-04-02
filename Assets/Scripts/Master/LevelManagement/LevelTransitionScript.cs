using UnityEngine;

public class LevelTransitionScript : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private Animator transition;

    private GameObject _leftTransition;
    private GameObject _rightTransition;

    public void ChangeToLeftScene()
    {
        transition.Play("transition");
        _camera.transform.position += Vector3.left * 20;
        
        if (!(_leftTransition is null))
        {

        }
    }

    public void ChangeToRightScene()
    {
        transition.Play("transition");

        _camera.transform.position -= Vector3.left * 20;

        if (!(_rightTransition is null))
        {

        }
    }
}
