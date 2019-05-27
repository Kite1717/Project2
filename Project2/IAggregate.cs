using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    #region Iterator
    /// <summary>
    /// Ref Link : 
    /// https://airbrake.io/blog/design-patterns/iterator-design-pattern
    /// </summary>

    interface IAggregate
    {
        IIterator CreateIterator();
    }

    interface IIterator
    {
        // Do you have the element in the next step?
        bool HasItem();
        //the next element brings
        Hotel NextItem();
        //the current element brings
        Hotel CurrentItem();
    }

    class HotelAggregate : IAggregate
    {
        List<Hotel> hotelList = new List<Hotel>();
        public void Add(Hotel Model) => hotelList.Add(Model);
        public Hotel GetItem(int index) => hotelList[index];
        public int Count { get => hotelList.Count; }
        public IIterator CreateIterator() => new HotelIterator(this);
    }

    class HotelIterator : IIterator
    {
        HotelAggregate aggregate;
        int currentindex;
        public HotelIterator(HotelAggregate aggregate) => this.aggregate = aggregate;
        public Hotel CurrentItem() => aggregate.GetItem(currentindex);
        public bool HasItem()
        {
            if (currentindex < aggregate.Count)
                return true;
            return false;
        }
        public Hotel NextItem()
        {
            if (HasItem())
                return aggregate.GetItem(currentindex++);

            return null;
        }
    }
}
#endregion