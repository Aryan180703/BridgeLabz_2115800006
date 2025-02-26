using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;

class Program {
    public class Match {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public Dictionary<string, int> score { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }
    }

    static string MaskTeamName(string teamName) {
        string[] words = teamName.Split(' ');
        if(words.Length > 1) {
            words[1] = "***";
        }
        return string.Join(" ", words);
    }

    static List<Match> ApplyCensorship(List<Match> matches) {
        foreach (var match in matches) {
            match.team1 = MaskTeamName(match.team1);
            match.team2 = MaskTeamName(match.team2);
            match.winner = MaskTeamName(match.winner);
            match.player_of_match = "REDACTED";

            // Masking keys in the score dictionary
            Dictionary<string, int> newScores = new Dictionary<string, int>();
            foreach (var score in match.score) {
                newScores[MaskTeamName(score.Key)] = score.Value;
            }
            match.score = newScores;
        }
        return matches;
    }

    static List<Match> ReadJsonInput(string filePath) {
        string jsonData = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Match>>(jsonData);
    }

    static void WriteJsonOutput(List<Match> matches, string filePath) {
        string jsonOutput = JsonConvert.SerializeObject(matches, Formatting.Indented);
        File.WriteAllText(filePath, jsonOutput);
    }

    static List<Match> ReadCsvInput(string filePath) {
        var matches = new List<Match>();
        var lines = File.ReadAllLines(filePath).Skip(1);

        foreach (var line in lines) {
            var columns = line.Split(',');

            var match = new Match {
                match_id = int.Parse(columns[0]),
                team1 = columns[1],
                team2 = columns[2],
                score = new Dictionary<string, int> {
                    { columns[1], int.Parse(columns[3]) },
                    { columns[2], int.Parse(columns[4]) }
                },
                winner = columns[5],
                player_of_match = columns[6]
            };

            matches.Add(match);
        }

        return matches;
    }

    static void WriteCsvOutput(List<Match> matches, string filePath) {
        var csvLines = new List<string> {
            "match_id,team1,team2,score_team1,score_team2,winner,player_of_match"
        };
        foreach (var match in matches) {
            string line = $"{match.match_id},{match.team1},{match.team2},{match.score[match.team1]},{match.score[match.team2]},{match.winner},{match.player_of_match}";
            csvLines.Add(line);
        }
        File.WriteAllLines(filePath, csvLines);
    }

    static void Main(string[] args) {
        // File paths
        string jsonInputFile = "ipl_data.json";
        string csvInputFile = "ipl_data.csv";
        string jsonOutputFile = "censored_ipl_data.json";
        string csvOutputFile = "censored_ipl_data.csv";
        var jsonMatches = ReadJsonInput(jsonInputFile);
        var censoredJsonMatches = ApplyCensorship(jsonMatches);
        WriteJsonOutput(censoredJsonMatches, jsonOutputFile);
        Console.WriteLine("Censored JSON output saved!");

        var csvMatches = ReadCsvInput(csvInputFile);
        var censoredCsvMatches = ApplyCensorship(csvMatches);
        WriteCsvOutput(censoredCsvMatches, csvOutputFile);
        Console.WriteLine("Censored CSV output saved!");
    }
}
