using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject
{
    [Serializable]
    public class LayerCollection : IEnumerable<Layer>
    {
        public Dictionary<LayerProperties, Layer> Internal { get; private set; }

        #region Public Constructors
        public LayerCollection()
        {
            Internal = new Dictionary<LayerProperties, Layer>();
            Internal.Add(new LayerProperties("Layer 0", true, false, 0), new Layer());
        }
        #endregion

        #region Public Methods
        public void Add(Layer layer)
        {
            if (!Internal.ContainsValue(layer))
            {
                var order = Internal.Max(x => x.Key.Order) + 1;
                Internal.Add(new LayerProperties($"Layer {order}", true, false, order), layer);
            }
            UpdateOrder();
        }

        public void Remove(Layer layer)
        {
            if (Internal.ContainsValue(layer) && Internal.Count>1)
                Internal.Remove(this[layer]);

            UpdateOrder();
        }

        public void MoveUp(Layer layer)
        {
            if (this[layer].Order == 0)
                return;

            var current = this[layer];
            var prev = this[this[current.Order - 1]];

            current.Order--;
            prev.Order++;

            UpdateOrder();
        }

        public void MoveDown(Layer layer)
        {
            if (this[layer].Order == Internal.Count-1)
                return;

            var current = this[layer];
            var next = this[this[current.Order + 1]];

            current.Order++;
            next.Order--;

            UpdateOrder();
        }

        public Layer this[int index]
        {
            get
            {
                return Internal.FirstOrDefault(x => x.Key.Order == index).Value;
            }
            set
            {
                Internal[Internal.FirstOrDefault(x => x.Key.Order == index).Key] = value;
            }
        }

        public LayerProperties this[Layer index]
        {
            get
            {
                return Internal.FirstOrDefault(x => x.Value == index).Key;
            }
        }

        #endregion

        private void UpdateOrder()
        {
            var layersQuery = Internal.OrderBy(x => x.Key.Order).ToList();
            for(int i=0; i<layersQuery.Count; i++)
            {
                layersQuery[i].Key.Order = i;
            }

        }

        public int IndexOf(Layer layer)
        {
            if (!Internal.Values.Contains(layer))
                return 0;

            return Internal.Keys.FirstOrDefault(x => x.Order == this[layer].Order).Order;
        }

        #region Interface Implementation
        public IEnumerator<Layer> GetEnumerator()
        {
            return Internal.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

    }
}
