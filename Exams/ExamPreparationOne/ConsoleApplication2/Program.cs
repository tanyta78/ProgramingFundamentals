using System;
using System.Text.RegularExpressions;


namespace WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            string[] allTickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Regex winningTicket = new Regex(@"([$]{6,}|[@]{6,}|[\^]{6,}|[#]{6,})");
            Regex jackpotTicket = new Regex(@"([$]{20}|[@]{20}|[\^]{20}|[#]{20})");

            string[] result = new string[allTickets.Length];
            for (int currTicket = 0; currTicket < allTickets.Length; currTicket++)
            {
                string ticket = allTickets[currTicket];

                if (ticket.Length != 20)
                {
                    result[currTicket] = "invalid ticket";

                    continue;
                }

                if (jackpotTicket.IsMatch(ticket))
                {
                    result[currTicket] = $"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!";

                    continue;
                }

                string leftHalf = ticket.Substring(0, 10);
                string rightHalf = ticket.Substring(10, 10);

                if (!winningTicket.IsMatch(leftHalf) || !winningTicket.IsMatch(rightHalf))
                {
                    result[currTicket] = $"ticket \"{ticket}\" - no match";

                    continue;
                }


                Match leftMatch = winningTicket.Match(leftHalf);
                Match rightMatch = winningTicket.Match(rightHalf);

                leftHalf = leftMatch.Groups[1].ToString();
                rightHalf = rightMatch.Groups[1].ToString();

                if (leftHalf[0] == rightHalf[0] && leftHalf.Length <= rightHalf.Length)
                {
                    result[currTicket] = $"ticket \"{ticket}\" - {leftHalf.Length}{leftHalf[0]}";
                }
                else if (leftHalf[0] == rightHalf[0] && leftHalf.Length > rightHalf.Length)
                {
                    result[currTicket] = $"ticket \"{ticket}\" - {rightHalf.Length}{leftHalf[0]}";
                }
            }

            for (int currTicket = 0; currTicket < result.Length; currTicket++)
            {
                Console.WriteLine(result[currTicket]);
            }
        }
    }
}