using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bageri.api.ViewModels.Address;

public class AddressViewModel
{
    public string AddressLine { get; set; } 
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string AddressType { get; set; }
}
