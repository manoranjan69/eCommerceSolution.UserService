﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.Entities;
//<summary>
//Define the ApplicationUser Class  which acts as entity  model class to store  UserDetails in data store
//</summary>
    public class ApplicationUser
    {

    public Guid UserId { get; set; }
    public string ? Email { get; set; }
    public string ? Password { get; set; }
    public string ? PersonName { get; set; }
    public string ? Gender { get; set; }



}
