using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private bool _available;
        private List<double> _ratings;

        public Video(string title)
        {
            Title = title;
            this._available = true;
            this._ratings= new List<double>();
        }

        public void BeingCheckedOut()
        {
            _available = false;
        }

        public void BeingReturned()
        {
            _available = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            return _ratings.Average();
        }

        public bool Available()
        {
            return _available;
        }

        public string Title { get; set; }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
