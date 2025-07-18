using FileReader.Library.Common;

namespace FileReader.Library.Security
{
    public class RoleBasedFileReader : IFileReader
    {
        private readonly IFileReader _inner;
        private readonly IRoleSecurityStrategy _security;
        private readonly string _role;

        public RoleBasedFileReader(IFileReader inner, IRoleSecurityStrategy security, string role)
        {
            _inner = inner;
            _security = security;
            _role = role;
        }

        public string Read(string path)
        {
            if (!_security.CanRead(path, _role))
                throw new UnauthorizedAccessException("Access denied for your role.");

            return _inner.Read(path);
        }
    }
}