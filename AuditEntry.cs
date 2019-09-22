using Penguin.Cms.Attributes;
using Penguin.Entities;
using Penguin.Persistence.Abstractions.Attributes.Control;
using Penguin.Persistence.Abstractions.Attributes.Validation;
using System;

namespace Penguin.Cms.Auditing
{
    /// <summary>
    /// Represents the logged change in the values of an entity
    /// </summary>
    public class AuditEntry : Entity
    {
        /// <summary>
        /// The ID of the context that this change was created on
        /// </summary>
        [DontAllow(DisplayContexts.List)]
        public Guid ContextId { get; set; }

        /// <summary>
        /// The time this entry was created
        /// </summary>
        public DateTime Logged { get; set; } = DateTime.Now;

        /// <summary>
        /// The new value of the property
        /// </summary>
        [MaxLength]
        public string NewValue { get; set; }

        /// <summary>
        /// The change session of the context this entry was logged on
        /// </summary>
        [DontAllow(DisplayContexts.List)]
        public Guid ObjectSessionId { get; set; }

        /// <summary>
        /// The name of the changed property
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// A Guid representing the source of the change
        /// </summary>
        [CustomRoute(DisplayContexts.List | DisplayContexts.Edit, "Render", "UserRecord")]
        public Guid Source { get; set; }

        /// <summary>
        /// A Guid representing the object that changed
        /// </summary>
        public Guid Target { get; set; }

        /// <summary>
        /// The int ID of the changed object
        /// </summary>

        [DontAllow(DisplayContexts.List)]
        public int Target_Id { get; set; }

        /// <summary>
        /// The type name of the changed object
        /// </summary>

        public override string TypeName { get; set; }

        /// <summary>
        /// The full namespace of the changed object type
        /// </summary>

        [DontAllow(DisplayContexts.List)]
        public string TypeNamespace { get; set; }
    }
}
