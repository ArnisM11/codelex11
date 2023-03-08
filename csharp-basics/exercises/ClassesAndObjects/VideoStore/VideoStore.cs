using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            var video = new Video(title);
            _inventory.Add(video);
        }
        
        public void Checkout(string title)
        {
            var video = _inventory.FirstOrDefault(v => v.Title == title);
            if(video != null)
            {
                video.BeingCheckedOut();
            }
        }

        public void ReturnVideo(string title)
        {
            var video = _inventory.FirstOrDefault(v => v.Title == title);
            if (video != null)
            {
                video.BeingReturned();
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            var video = _inventory.FirstOrDefault(v => v.Title == title);
            if (video != null)
            {
                video.ReceivingRating(rating);
            }
        }

        public void ListInventory()
        {
            _inventory.ForEach(v => Console.WriteLine(v));
        }
    }
}
