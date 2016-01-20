﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PGP.Infrastructure.Framework.Repositories;

namespace PGP.Domain.Books
{
    public interface IBookService : IDomainService<Book>
    {
    }
}
