using Flunt.Notifications;
using System;
namespace Shared.Entidades
{
    public abstract class Entidade : Notifiable
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
