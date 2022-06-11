﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBCustomLinq;
public class UserModel
{
    public UserModel()
    {
        EmailAddress = "";
    }
    public int Id { get; set; }

    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    public DateTime CreateDate { get; set; }

    public string EmailAddress { get; set; }
}
