using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x4amcd.Primordials;

namespace x4amcd.Player.Organs.Memory
{
    public class AMemory : ISerializable
    {
        public List<List<IThing>> visual { get; } = new();
        public Tuple<int, int> position = new(0, 0);

        public AMemory(List<List<IThing>> visual, Tuple<int, int> position)
        {
            this.visual = visual;
            this.position = position;
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}