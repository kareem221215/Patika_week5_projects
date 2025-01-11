using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    public class movie
    {
        
            public string movie_name { get; set; }
            private float _IMDB;
            public float IMDB
            {
                get
                {
                    return _IMDB;
                }


                set
                {
                    if (_IMDB >= 1 || _IMDB <= 9)
                        _IMDB = value;
                    else
                        Console.WriteLine("Error: IMDb rating must be between 1 and 9.");
                }
            }
        }
    }

