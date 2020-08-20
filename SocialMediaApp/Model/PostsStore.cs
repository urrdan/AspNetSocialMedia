using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Model
{
    public class PostsStore
    {
        public static PostsStore Current { get; } = new PostsStore();
        public List<Post> Posts { get; set; }

        public PostsStore()
        {
            Posts = new List<Post>()
            { new Post() {
                Id=1,
                Owner = "Nameless1995",
                Body="Happy Harvey Day.Rooting for Matt Harvey to get back to his dominant form as he makes his return to the big leagues with the Royals tonight.A bulldog that made Citi Field electric."
            },
            new Post() {
                Id=2,
                Owner = "Jackson_23",
                Body="Brett will be gone at the end of the season as he should be but Elton Brand needs to go too.$289M to Tobias Harris and Al Horford is absolutely inexcusable"
            },
            };
        }
    }
}
