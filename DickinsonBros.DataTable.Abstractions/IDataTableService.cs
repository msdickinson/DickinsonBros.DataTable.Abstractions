using System.Collections.Generic;

namespace DickinsonBros.DataTable.Abstractions
{
    public interface IDataTableService
    {
        System.Data.DataTable ToDataTable<T>(IEnumerable<T> enumerable, string tableName);
    }
}
