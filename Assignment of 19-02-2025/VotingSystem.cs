using System;
using System.Collections.Generic;
class VotingSystem{
    private Dictionary<string, int> votes;
    private SortedDictionary<string, int> sortedVotes;
    private LinkedList<string> voteOrder;
    public VotingSystem(){
        votes = new Dictionary<string, int>();
        sortedVotes = new SortedDictionary<string, int>();
        voteOrder = new LinkedList<string>();
    }
    public void CastVote(string candidate){
        if (!votes.ContainsKey(candidate)){
            votes[candidate] = 0;
            sortedVotes[candidate] = 0;
        }
        votes[candidate]++;
        sortedVotes[candidate]++;
        voteOrder.AddLast(candidate);
    }
    public void DisplayVoteCount(){
        Console.WriteLine("Vote Counts:");
        foreach (KeyValuePair<string, int> entry in votes){
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }
    public void DisplaySortedResults(){
        Console.WriteLine("Sorted Results:");
        foreach (KeyValuePair<string, int> entry in sortedVotes){
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }

    public void DisplayVotingOrder(){
        Console.WriteLine("Voting Order:");
        foreach (string candidate in voteOrder){
            Console.Write(candidate + " ");
        }
        Console.WriteLine();
    }
}

class Program{
    static void Main(){
        
        VotingSystem votingSystem = new VotingSystem();
        votingSystem.CastVote("Aryan");
        votingSystem.CastVote("Dhruv");

        votingSystem.CastVote("Prince");
        votingSystem.CastVote("Aryan");
        votingSystem.DisplayVoteCount();
        votingSystem.DisplaySortedResults();
        votingSystem.DisplayVotingOrder();
    }
}
