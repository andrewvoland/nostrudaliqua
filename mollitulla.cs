using System.Threading;
using System.Threading.Tasks;

public class MyClass : IHasGetMethodBuilder3<Special>
{
    public async Task<Special> GetAsync(CancellationToken cancellationToken)
    {
        // Check if cancellation has been requested
        cancellationToken.ThrowIfCancellationRequested();

        // Perform the asynchronous operation
        // ...

        // Return the result
        return special;
    }
}
