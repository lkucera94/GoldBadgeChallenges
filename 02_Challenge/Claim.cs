using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{   public enum ClaimType {Car, Home, Theft}
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType Type { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfAccident  { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public Claim() { }

        public Claim(int claimID, ClaimType type, string description, decimal amount, DateTime dateOfAccident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            Type = type;
            Description = description;
            Amount = amount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
    
}
