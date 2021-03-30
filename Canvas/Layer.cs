using CourseProject.Gfx;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject
{
    [Serializable]
    public class Layer : IEnumerable<IGraphic>
    {
        //public event EventHandler OrderChanged;
        //protected virtual void OnOrderChanged(EventArgs e)
        //{
        //  OrderChanged?.Invoke(this, e);
        //}
        private readonly List<IGraphic> _graphicObjects;

        //private int _order;
        /*public int Order
        {
            get
            {
                return _order;
            }
            set
            {
                if (_order != value)
                {
                    _order = value;
                    OnOrderChanged(EventArgs.Empty);
                }
            }
        }
        */
        //public bool Visible { get; set; } = true;
        //public bool Locked { get; set; }
        //public string Name { get; set; }

        public int Count
        {
            get { return _graphicObjects.Count; }
        }

        public Layer()
        {
            _graphicObjects = new List<IGraphic>();
        }

        public Layer(IEnumerable<IGraphic> visuals)
        {
            _graphicObjects = new List<IGraphic>();
            _graphicObjects.AddRange(visuals);
        }

        public IGraphic this[int index]
        {
            get
            {
                return _graphicObjects[index];
            }
            set
            {
                this[index] = value;
            }
        }

        public void Add(IGraphic graphic)
        {
            if (graphic == null)
                return;
            _graphicObjects.Add(graphic);
            graphic.Z = _graphicObjects.Max(x => x.Z) + 1;
        }
        public void Remove(IGraphic graphic)
        {
            _graphicObjects.Remove(graphic);
        }

        public IEnumerable<IGraphic> InternalCollection
        {
            get
            {
                return _graphicObjects;
            }
        }

        #region Interface Implementation
        public IEnumerator<IGraphic> GetEnumerator()
        {
            return _graphicObjects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }



        #endregion
    }
}
