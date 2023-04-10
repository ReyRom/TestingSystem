using TestingSystemData.Model;

namespace TestingSystemData
{
    public static class Core
    {
        static TestSystemContext context = null!;

        public static TestSystemContext Context { get => context ??= new TestSystemContext(); }
    }
}
