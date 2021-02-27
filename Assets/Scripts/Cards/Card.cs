using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Cards
{
    
    public class Card : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        private bool _isDragged;
        private bool _isInDropArea;

        private Vector3 _deltaPos;
        private Vector3 _mousePos;
        private Vector3 _startPos;

        private GameObject _dropArea;

        private void Update()
        {
            _mousePos = Input.mousePosition;

            if (!_isDragged) return;

            transform.position = _mousePos + _deltaPos;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // Save DropArea when entered.
            DropArea droppable = collision.GetComponent<DropArea>();
            if (droppable == null) return;
            _dropArea = collision.gameObject;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            // Clear DropArea when exited.
            DropArea droppable = collision.GetComponent<DropArea>();
            if (droppable == null) return;
            _dropArea = null;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            // If this Draggable has a saved dropArea, it should stay in it.
            if (_dropArea != null) return;

            _isDragged = true;
            _startPos = transform.position;
            // Adjust pos.
            _deltaPos = _startPos - _mousePos;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _isDragged = false;

            // If this Draggable has a saved dropArea, place it inside, otherwise return it.
            transform.position = _dropArea == null ? _startPos : _dropArea.transform.position;
        }
        
    }

}
