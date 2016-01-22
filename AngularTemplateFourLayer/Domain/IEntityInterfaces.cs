using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTemplateFourLayer.Domain
{
    public interface IDbEntity
    {
        int Id { get; set; }
    }

    public interface IActivatable
    {
        bool Active { get; set; }
    }
}