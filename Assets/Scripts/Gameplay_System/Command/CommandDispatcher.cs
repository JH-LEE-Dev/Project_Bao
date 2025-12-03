using UnityEngine;

public class CommandDispatcher : MonoBehaviour
{
    [SerializeField] private SelectionManager selectionManager;

    public void Dispatch(ICommand command)
    {
        //foreach (var unit in selectionManager.Selected)
            
    }
}

