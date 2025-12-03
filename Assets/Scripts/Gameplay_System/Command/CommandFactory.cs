using UnityEngine;

public class CommandFactory : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;
    [SerializeField] private CommandDispatcher dispatcher;

    private void OnEnable()
    {
        inputReader.RightClickEvent += CreateMoveCommand;
    }

    private void OnDisable()
    {
        inputReader.RightClickEvent -= CreateMoveCommand;
    }

    private void CreateMoveCommand(Vector2 point)
    {
        //ICommand cmd = new MoveCommand(point);
        //dispatcher.Dispatch(cmd);
    }
}

