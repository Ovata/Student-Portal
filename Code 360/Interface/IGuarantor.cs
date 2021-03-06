﻿using System;
using System.Collections.Generic;

namespace Code_360.Models.Interface
{
    public interface IGuarantor
    {
        Guarantor.Guarantor AddGuarantor(Guarantor.Guarantor _guarantor);
        Guarantor.Guarantor UpdateGuarantor(Guarantor.Guarantor updateguarantor);
        IEnumerable<Guarantor.Guarantor> GetGuarantors();
        Guarantor.Guarantor GetGuarantor(Guid Id);
    }
}
