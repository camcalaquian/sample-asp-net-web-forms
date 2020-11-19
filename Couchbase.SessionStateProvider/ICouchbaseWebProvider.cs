using Couchbase;
using Couchbase.Core;

namespace Couchbase.SessionStateProvider.Caching
{
    internal interface ICouchbaseWebProvider
    {
        IBucket Bucket { get; set; }
        bool ThrowOnError { get; set; }
        string Prefix { get; set; }
        string BucketName { get; set; }
    }
}
