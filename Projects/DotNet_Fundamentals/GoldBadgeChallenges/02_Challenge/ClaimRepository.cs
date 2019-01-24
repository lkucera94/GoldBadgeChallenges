using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class ClaimRepository
    {
        private Queue<Claim> _claim = new Queue<Claim>();
        public void AddClaimToQueue(Claim claim)
        {
            _claim.Enqueue(claim);
        }
        public Queue<Claim> GetClaims()
        {
            return _claim;
        }
        public Claim ViewNextClaim()
        {
           Claim claim =  _claim.Peek();
            return claim;
        }
        public void RemoveClaim()
        {
            _claim.Dequeue();
        }

    }
}
