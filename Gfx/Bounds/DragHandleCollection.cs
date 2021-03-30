using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseProject.Bounds
{
    [Serializable]
    public class DragHandleCollection : IEnumerable<DragHandle>
    {
        private readonly IDictionary<DragHandleAnchor, DragHandle> _items;

        public DragHandleCollection()
        {
            _items = new Dictionary<DragHandleAnchor, DragHandle>();
            _items.Add(DragHandleAnchor.TopLeft, new DragHandle(DragHandleAnchor.TopLeft));
            _items.Add(DragHandleAnchor.TopCenter, new DragHandle(DragHandleAnchor.TopCenter));
            _items.Add(DragHandleAnchor.TopRight, new DragHandle(DragHandleAnchor.TopRight));
            _items.Add(DragHandleAnchor.MiddleLeft, new DragHandle(DragHandleAnchor.MiddleLeft));
            _items.Add(DragHandleAnchor.MiddleRight, new DragHandle(DragHandleAnchor.MiddleRight));
            _items.Add(DragHandleAnchor.BottomLeft, new DragHandle(DragHandleAnchor.BottomLeft));
            _items.Add(DragHandleAnchor.BottomCenter, new DragHandle(DragHandleAnchor.BottomCenter));
            _items.Add(DragHandleAnchor.BottomRight, new DragHandle(DragHandleAnchor.BottomRight));
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public DragHandle this[DragHandleAnchor index]
        {
            get { return _items[index]; }
        }

        public IEnumerator<DragHandle> GetEnumerator()
        {
            return _items.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
