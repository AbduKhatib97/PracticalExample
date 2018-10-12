using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalExample.ViewModels
{
    public class FilesViewModel
    {
        public IEnumerable<Models.File> Files { set; get; }

        public FilesViewModel(IEnumerable<Models.File> files) => Files = files;
    }
}
