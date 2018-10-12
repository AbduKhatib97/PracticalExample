using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalExample.ViewModels
{
    public class FilesViewModel
    {
        public IEnumerable<Models.Files> Files { set; get; }

        public FilesViewModel(IEnumerable<Models.Files> files) => Files = files;
    }
}
