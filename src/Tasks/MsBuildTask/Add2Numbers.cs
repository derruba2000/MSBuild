using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace MsBuildTask
{
    public class Add2Numbers : ITask
    {
        [Required]
        public double Number1 { get; set; }
        [Required]
        public double Number2 { get; set; }
        [Output]
        public double Result { get; set; }

        public IBuildEngine BuildEngine { get ; set; }
        public ITaskHost HostObject { get ; set ; }

        public bool Execute()
        {
            Result = Number1 + Number2;
            var args=new BuildMessageEventArgs("Added 2 Numbers", "Add", "Add2Numbers", MessageImportance.High);
            BuildEngine.LogMessageEvent(args);
            return true;
        }
    }
}
