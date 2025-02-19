using System;
using System.Collections.Generic;
class Policy : IComparable<Policy>{
    public string PolicyNumber { get; }
    public string CoverageType { get; }
    public DateTime ExpiryDate { get; }
    public Policy(string policyNumber, string coverageType, DateTime expiryDate){
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }
    public override bool Equals(object obj){
        if (obj is Policy other){
            return PolicyNumber == other.PolicyNumber;
        }
        return false;
    }
    public override int GetHashCode(){
        return PolicyNumber.GetHashCode();
    }
    public int CompareTo(Policy other){
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }
}
class InsurancePolicyManager{
    private HashSet<Policy> policies = new HashSet<Policy>();
    private LinkedList<Policy> orderedPolicies = new LinkedList<Policy>();
    private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>();
    public void AddPolicy(Policy policy){
        if (policies.Add(policy)){
            orderedPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }
    }
    public List<Policy> GetAllPolicies(){
        List<Policy> result = new List<Policy>();
        foreach (Policy policy in policies){
            result.Add(policy);
        }
        return result;
    }
    public List<Policy> GetExpiringSoon(){
        DateTime threshold = DateTime.Now.AddDays(30);
        List<Policy> result = new List<Policy>();
        foreach (Policy policy in sortedPolicies){
            if (policy.ExpiryDate <= threshold){
                result.Add(policy);
            }
            else{
                break;
            }
        }
        return result;
    }
    public List<Policy> GetPoliciesByCoverage(string coverageType){
        List<Policy> result = new List<Policy>();
        foreach (Policy policy in policies){
            if (policy.CoverageType == coverageType){
                result.Add(policy);
            }
        }
        return result;
    }
    public List<Policy> GetDuplicatePolicies(){
        Dictionary<string, int> policyCount = new Dictionary<string, int>();
        List<Policy> duplicates = new List<Policy>();
        foreach (Policy policy in policies){
            if (!policyCount.ContainsKey(policy.PolicyNumber)){
                policyCount[policy.PolicyNumber] = 1;
            }
            else{
                policyCount[policy.PolicyNumber]++;
            }
        }
        foreach (Policy policy in policies){
            if (policyCount[policy.PolicyNumber] > 1){
                duplicates.Add(policy);
            }
        }
        return duplicates;
    }
}
