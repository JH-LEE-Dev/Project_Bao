using UnityEngine;
using UnityEngine.Diagnostics;

public class SelectionController : MonoBehaviour
{
    [SerializeField] private InputReader input;
    [SerializeField] private SelectionManager selectionManager;

    private Vector2 startPos;
    private bool selecting;

    private void OnEnable()
    {
        input.SelectStartEvent += StartSelection;
        input.SelectEndEvent += EndSelection;
    }

    private void OnDisable()
    {
        input.SelectStartEvent -= StartSelection;
        input.SelectEndEvent -= EndSelection;
    }

    private void StartSelection()
    {
        startPos = Input.mousePosition;
        selecting = true;
    }

    private void EndSelection()
    {
        selecting = false;
        SelectFromBox(startPos, Input.mousePosition);
    }

    private void SelectFromBox(Vector2 start, Vector2 end)
    {
        selectionManager.Clear();

        //SelectStartPos와 EndPos를 이용하여 선택 범위 구하기.
        Rect rect = new Rect();

        //foreach (var selectable in FindAnyObjectByType<MonoBehaviour>())
        //{
        //    if (selectable is ISelectable s)
        //    {
        //        Vector3 screenPos = Camera.main.WorldToScreenPoint(s.GetTransform().position);

        //        if (rect.Contains(screenPos))
        //            selectionManager.Add(s);
        //    }
        //}
    }
}