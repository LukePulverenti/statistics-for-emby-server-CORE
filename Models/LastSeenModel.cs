using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Statistics.Models
{
    public class LastSeenModel
    {
        public string Name { get; set; }

        public DateTimeOffset Played { get; set; }

        public string UserName { get; set; }

        public override string ToString()
        {
            return string.IsNullOrEmpty(UserName) ?
                $"{Name} - {Played:d}" :
                $"{Name} - {Played:d} - Viewed by {UserName}";
        }
    }
}
