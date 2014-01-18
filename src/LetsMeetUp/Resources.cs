using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsMeetUp.ViewModel;

namespace LetsMeetUp
{
    public class StaticResources
    {
        private readonly List<DummyUser> _dummyUsers = new List<DummyUser>
        {
            new DummyUser("Tyler", 21, "Brace for impact."),
            new DummyUser("Jon", 21, "Hello."),
            new DummyUser("Liz", 21, "I like men."),
            new DummyUser("Chirag", 22, "I like food."),
            new DummyUser("Lisa", 19, "I like my computer.")
        };
        
        public List<DummyUser> DummyUsers { get { return _dummyUsers; } }
    }
}
