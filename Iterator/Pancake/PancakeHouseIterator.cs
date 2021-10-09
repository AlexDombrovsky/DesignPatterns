using System.Collections;

namespace Iterator.Pancake
{
    public class PancakeHouseIterator : Abstract.Iterator
    {
        private readonly ArrayList _items;
        private int _position;

        public PancakeHouseIterator(ArrayList items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position < _items.Count-1 && _items[_position] != null;
        }

        public object Next()
        {
            var menuItem = _items[_position];
            _position += 1;
            return menuItem;
        }
    }
}