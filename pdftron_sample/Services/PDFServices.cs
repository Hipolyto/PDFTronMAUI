using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSample.Services
{
    public partial class PDFServices
    {
        static PDFServices _instance;
        public static PDFServices Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PDFServices();
                return _instance;
            }
        }
        public partial void OpenDocument(string uri);
    }
}
