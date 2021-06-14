using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        public IFileReader FileReader { get; set; }

        public VideoService()
        {
            FileReader = new FileReader();
        }

        public string ReadVideoTitle()
        {
            //Using new here makes this code tightly coupled to FileReader to decouple we need to pass an instance of the FileReader class instead.
            //Three ways to do this
            // 1. Dependency Injection via Method Parameters
            // 2. Dependency Injection via Properties
            // 2. Dependency Injection via Constructor

            var str = FileReader.Read("video.txt");


             var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();
            
            using (var context = new VideoContext())
            {
                var videos = 
                    (from video in context.Videos
                    where !video.IsProcessed
                    select video).ToList();
                
                foreach (var v in videos)
                    videoIds.Add(v.Id);

                return String.Join(",", videoIds);
            }
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}