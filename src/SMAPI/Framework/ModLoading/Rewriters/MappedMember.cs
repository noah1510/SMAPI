using System.Reflection;

namespace StardewModdingAPI.Framework.ModLoading.Rewriters
{
    /// <summary>The member to map a facade method to as part of <see cref="ReplaceReferencesRewriter"/>.</summary>
    /// <param name="Member">The target member to use.</param>
    /// <param name="OnlyIfNotResolved">Whether to only rewrite the method if the reference is currently broken. For example, this can be used for an instance-to-static change where the method signature and behavior doesn't otherwise change.</param>
    internal record MappedMember(MemberInfo Member, bool OnlyIfNotResolved);
}
