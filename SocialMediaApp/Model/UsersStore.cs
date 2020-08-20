using SocialMedia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Model
{
    public class UsersStore
    {
        public static UsersStore Current { get; } = new UsersStore();
        public List<User> Users { get; set; }

        public UsersStore()
        {
            Users = new List<User>()
            { new User() {
                UserName="Nameless1995"
            },
             new User() {
                UserName="Jackson_23"
            },
            
            };
        }
    }
}
