namespace System.Web.Optimization
{
    /// <summary>
    /// External bundle definition.
    /// Use it bundle for registration files which has been bundled externally via anothed bundler(webpack, gulp, grunt, rollup and etc.).
    /// </summary>
    /// <seealso cref="System.Web.Optimization.Bundle" />
    public sealed class ExternalBundle: Bundle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalBundle"/> class.
        /// </summary>
        /// <param name="virtualPath">The virtual path used to reference the <see cref="T:System.Web.Optimization.Bundle" /> from within a view or Web page.</param>
        /// <param name="cdnPath">An alternate url for the bundle when it is stored in a content delivery network.</param>
        public ExternalBundle(string virtualPath, string cdnPath = null): base(virtualPath, cdnPath) {}
    }
}