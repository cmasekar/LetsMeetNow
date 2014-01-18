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
            new DummyUser("Tyler", 21, "Brace for impact.", "../Assets/Tyler.jpg"),
            new DummyUser("Jon", 21, "Hello.", "../Assets/Jon.jpg"),
            new DummyUser("Liz", 21, "I like men.", "../Assets/Lizzy.jpg"),
            new DummyUser("Chirag", 22, "I like food.", "../Assets/Chirag.jpg"),
            new DummyUser("Lisa", 19, "I like my computer.", "../Assets/Lisa.jpg")
        };
        
        public List<DummyUser> DummyUsers { get { return _dummyUsers; } }
    }
}
