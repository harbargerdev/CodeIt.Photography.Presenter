using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeIt.Photography.Presenter.WebAPI.Models
{
    public enum ErrorType { DatabaseException = 0, MissingArgument, InternalException }

    [Serializable]
    public class ErrorModel
    {

    }
}
