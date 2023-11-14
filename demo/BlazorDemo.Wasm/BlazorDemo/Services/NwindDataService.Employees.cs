using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class NwindDataService {
        public Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetEmployeesAsync(ct);
            /*EndHide*/
        }
    }
}
