using System;
using System.Linq;
using Chinook.Core;
using Chinook.Core.Models;
using Chinook.Core.Repos;
using Microsoft.EntityFrameworkCore;

namespace Chinook.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

           var result = new TrackRepo().GetTracks();
            
        }
    }
}