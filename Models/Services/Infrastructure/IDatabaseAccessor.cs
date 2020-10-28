using System;
using System.Data;

namespace MyCourse1.Models.Services.Infrastructure
{
    public interface IDatabaseAccessor
    {
        DataSet Query(string query);

    }

}