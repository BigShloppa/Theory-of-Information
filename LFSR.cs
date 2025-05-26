using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class LFSR
    {
        public List<byte> maskIndexes;
        public List<byte> state;
        public LFSR(string mask) 
        {
            byte j = 0;
            maskIndexes = new List<byte>();
            for (byte i = 0; i < mask.Length; i++)
            {
                if (mask[i] == '0' || mask[i] == '1')
                    j++;
                if (mask[i] == '1')
                maskIndexes.Add(j);
            }
        }

        public LFSR(string mask, string sState) 
        {
            byte j = 0;
            maskIndexes = new List<byte>();
            for (byte i = 0; i < mask.Length; i++)
            {
                if (mask[i] == '0' || mask[i] == '1')
                    j++;
                if (mask[i] == '1')
                    maskIndexes.Add(j);
            }
            state = new List<byte>();
            for(int i = 0; i < sState.Length; i++)
                if (sState[i] == '0')
                    state.Add(0);
                else if (sState[i] == '1') 
                    state.Add(1);
        }

        public byte shift() {
            byte newState = state[maskIndexes[0] - 1];
            for(int i = 1; i < maskIndexes.Count; i++)
            newState ^= state[maskIndexes[i] - 1];
            byte oldState = state[0];
            state.RemoveAt(0);
            state.Add(newState);
            return oldState;
        }
    }
}
