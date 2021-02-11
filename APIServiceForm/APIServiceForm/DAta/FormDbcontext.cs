
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServiceForm.DAta
{
    public class FormDbcontext : DbContext
    {
        private readonly DbContextOptions<FormDbcontext> _options;

        public FormDbcontext(DbContextOptions<FormDbcontext> options) : base(options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
        }
        public DbSet<Form> Form { get; set; }
        
    }
}
