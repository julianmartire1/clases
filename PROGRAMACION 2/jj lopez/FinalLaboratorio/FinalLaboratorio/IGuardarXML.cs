using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public interface IGuardarXML<T>
    {
        bool SerializarXML(Galpon<T> galpon);
    }
}
