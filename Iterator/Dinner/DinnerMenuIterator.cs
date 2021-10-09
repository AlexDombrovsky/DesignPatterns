namespace Iterator.Dinner
{
    public class DinnerMenuIterator : Abstract.Iterator
    {
        private readonly MenuItem[] _items;
        private int _position;

        public DinnerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position < _items.Length && _items[_position] != null;
        }

        public object Next()
        {
            var menuItem = _items[_position];
            _position += 1;
            return menuItem;
        }
    }
}