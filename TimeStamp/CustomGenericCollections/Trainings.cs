using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CustomGenericCollections
{
    public class Trainings : Collection<Training>
    {
        public Training this[string name]
        {
            get { return this.Items.First(s => string.Equals(s.Name, name, StringComparison.OrdinalIgnoreCase)); }
        }

        public IEnumerable<string> All => this.Items.Select(s => s.Name);

        protected override void InsertItem(int index, Training item)
        {
            // validation before adding in common place.
            if (item.Cost > 0)
            {
                base.InsertItem(index, item);
            }
        }

        public void ForEach(Action<string> action)
        {
            foreach (var item in Items)
            {
                action($"Traning Name {item.Name} and cost {item.Cost}");
            }
        }
    }
}
