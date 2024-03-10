using System;

namespace StardewModdingAPI.Framework.ModLoading.Framework
{
    /// <summary>An attribute which indicates that the member should only be rewritten if the reference is currently broken. For example, this can be used for an instance-to-static change where the method signature and behavior doesn't otherwise change.</summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, Inherited = false)]
    internal class OnlyIfNotResolvedAttribute : Attribute { }
}
