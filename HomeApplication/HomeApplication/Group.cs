using HomeApplication.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace HomeApplication
{
    /// <summary>
    /// Группируемая универсальная коллекция
    /// </summary>
    public class Group<K, T> : ObservableCollection<T>
    {
        private object key;
        private IGrouping<object, HomeDevice> g;

        public K Name { get; private set; }
        public Group(K name, IEnumerable<T> items)
        {
            Name = name;
            foreach (T item in items)
                Items.Add(item);
        }

        public Group(object key, IGrouping<object, HomeDevice> g)
        {
            this.key = key;
            this.g = g;
        }
    }
}