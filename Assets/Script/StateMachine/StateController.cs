using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(PlayerInput))]
public class StateController : MonoBehaviour
{

    private PlayerInput _playerInput;
    private IState currentState;
    private Animator _animator;


    public Animator animator
    { get { return _animator; }
      set { _animator = value; }
    }

    private bool _hasAnimator;
    private int _animIDDanceBboy;
    private int _animIDDanceHipHop;
    private int _animIDDanceRobot;
    private int _animIDDanceSilly;
    private int _animIDDanceTwerk;
    private int _animIDDanceTwist;


    private void AssignAnimationIDs()
    {
        _animIDDanceBboy = Animator.StringToHash("DanceBboy");
        _animIDDanceHipHop = Animator.StringToHash("DanceHipHop");
        _animIDDanceRobot = Animator.StringToHash("DanceRobot");
        _animIDDanceSilly = Animator.StringToHash("DanceSilly");
        _animIDDanceTwerk = Animator.StringToHash("DanceTwerk");
        _animIDDanceTwist = Animator.StringToHash("DanceTwist");

    }
    private bool IsCurrentDeviceMouse
    {
        get
        {
            return _playerInput.currentControlScheme == "KeyboardMouse";

        }
    }



    void Start()
    {

        _playerInput = GetComponent<PlayerInput>();

        _hasAnimator = TryGetComponent(out _animator);

        AssignAnimationIDs();


        // Initialize the state machine with an initial state.
        // For example, set it to the 'IdleState' initially.
        ChangeState(new IdleState());
    }

    void Update()
    {
        _hasAnimator = TryGetComponent(out _animator);


        // Update the current state.
        currentState.UpdateState(this);
    }


    public void OnDanceBboy(InputValue value)
    {

            ChangeState(new DanceBboy());

   

    }


    public void OnDanceHipHop(InputValue value)
    {

        ChangeState(new DanceHipHop());

    }


    public void OnDanceRobot(InputValue value)
    {
        ChangeState(new DanceRobot());



    }

    public void OnDanceSilly(InputValue value)
    {

        ChangeState(new DanceSilly());



    }

    public void OnDanceTwerk(InputValue value)
    {

        ChangeState(new DanceTwerk());


    }

    public void OnDanceTwist(InputValue value)
    {

        ChangeState(new DanceTwist());



    }

    public void ChangeState(IState newState)
    {
        if (currentState != null)
        {
            currentState.OnExit(this);
        }

        currentState = newState;
        currentState.OnEnter(this);
    }
}
