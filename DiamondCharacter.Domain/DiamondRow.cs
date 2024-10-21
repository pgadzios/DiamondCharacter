namespace DiamonCharacter.Domain
{
    public class DiamondRow
    {
        public int RowNumber { get; private set; }

        private List<DiamondRowItem> _items { get; set; }

        public DiamondRow(int rowNumber)
        {
            _items = new List<DiamondRowItem>();
            RowNumber = rowNumber;
        }

        public List<DiamondRowItem> Items {
            get
            {
                return _items;
            }
        }

        public void AddItem(DiamondRowItem item)
        {
            _items.Add(item);
        }
    }
}
