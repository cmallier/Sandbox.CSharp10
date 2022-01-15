namespace FileScopedNamespaceDeclaration;

internal class Person
{
    public string FirstName { get; set; } = "Joe";
}


/*

// Instead of

namespace FIleScopedNamespaceDeclaration
{
    internal class Person
    {
        public string FirstName { get; set; } = "Joe";
    }
}

*/