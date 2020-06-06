using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MsBuildTask
{
    public class Multiply2Numbers : Microsoft.Build.Utilities.Task
    {

        [Required]
        public double Number1 { get; set; }
        [Required]
        public double Number2 { get; set; }
        [Output]
        public double Result { get; set; }

        public override bool Execute()
        {
            Result = Number1 * Number2;
            Log.LogMessage(MessageImportance.High, "Multiply two numbers", null);
            return true;
        }
    }
}
