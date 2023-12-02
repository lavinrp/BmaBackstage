namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Training hall
    /// </summary>
    public interface IDojo : IEntity
    {
        /// <summary>
        /// Physical location of the dojo
        /// </summary>
        string Address { get; }

        /// <summary>
        /// Human readable name for the dojo
        /// </summary>
        string Name { get; }
    }
}
