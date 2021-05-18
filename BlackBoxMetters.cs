using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BlackBoxMetters
    {
        public void Play(IGames games)
        {
            if (games != null)
            {
                games.Play();
            }

        }
    }

}
