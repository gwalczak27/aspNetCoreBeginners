using CwkBooking.Api.Services.Abstractions;
using System;
using System.Reflection.Metadata.Ecma335;

namespace CwkBooking.Api.Services
{
    public class TransientOperation : ITransientOperation
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
