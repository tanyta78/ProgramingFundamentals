namespace P01_BasicSyntax
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var maxEnergyCapacity = long.Parse(Console.ReadLine());
            var robot = new Robot();
            var assembling = false;

            while (!assembling)
            {
                var input = Console.ReadLine().Split().ToList();
               
                switch (input[0])
                {
                    case "Head":
                        robot.AddHead(input);
                        break;
                    case "Torso":
                        robot.AddTorso(input);
                        break;
                    case "Arm":
                        robot.AddArm(input);
                        break;
                    case "Leg":
                        robot.AddLeg(input);
                        break;
                    case "Assemble!":
                        assembling = true;
                       
                        if (!robot.HasComponents())
                        {
                            Console.WriteLine("We need more parts!");
                        }
                       else if (!robot.HasPower(maxEnergyCapacity))
                        {
                            Console.WriteLine("We need more power!");
                        }
                        else
                        {
                            Console.Write(robot.ToString());
                        }

                        break;
                }
            }
        }

        public class Robot
        {
            public Head Head { get; set; }

            public Torso Torso { get; set; }

            public List<Arm> Arms { get; set; } = new List<Arm>();

            public List<Leg> Legs { get; set; } = new List<Leg>();

            public long EnergyConsumption()
            {
                return this.Head.EnergyConsumption + this.Torso.EnergyConsumption +
                       this.Arms.Select(a => a.EnergyConsumption).Sum() +
                       this.Legs.Select(l => l.EnergyConsumption).Sum();
            }

            public bool HasPower(long maxEnergyCapacity)
            {
                if (this.EnergyConsumption() > maxEnergyCapacity)
                {
                    return false;
                }

                return true;
            }

            public bool HasComponents()
            {
                return !(this.Torso == null || this.Head == null || this.Arms.Count != 2 || this.Legs.Count != 2);
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("Jarvis:");
                sb.AppendLine(this.Head.ToString());
                sb.AppendLine(this.Torso.ToString());
                foreach (var arm in this.Arms.OrderBy(a => a.EnergyConsumption))
                {
                    sb.AppendLine(arm.ToString());
                }
                foreach (var leg in this.Legs.OrderBy(l => l.EnergyConsumption))
                {
                    sb.AppendLine(leg.ToString());
                }


                return sb.ToString();
            }

            public void AddHead(List<string> input)
            {
                var energyCons = int.Parse(input[1]);

                if (this.Head != null && this.Head.EnergyConsumption < energyCons)
                {
                    return;
                }
                this.Head = new Head
                {
                    EnergyConsumption = energyCons,
                    IQ = int.Parse(input[2]),
                    SkinMaterial = input[3]
                };
            }

            public void AddTorso(List<string> input)
            {
                var energyCons = int.Parse(input[1]);

                if (this.Torso != null && this.Torso.EnergyConsumption < energyCons)
                {
                    return;
                }

                this.Torso = new Torso
                {
                    EnergyConsumption = energyCons,
                    ProcessorSizeInCm = double.Parse(input[2]),
                    HousingMaterial = input[3]
                };
            }

            public void AddArm(List<string> input)
            {
                var energy = int.Parse(input[1]);
                var distance = int.Parse(input[2]);
                var fingers = int.Parse(input[3]);
                var arm = new Arm()
                {
                    EnergyConsumption = energy,
                    ReachDistance = distance,
                    CountFingers = fingers
                };
                if (this.Arms.Count < 2)
                {
                    this.Arms.Add(arm);
                }
                else
                {
                    if (this.Arms.Any(a => a.EnergyConsumption > energy))
                    {
                        var old = this.Arms.Where(a => a.EnergyConsumption > energy).ToList();
                        if (old.Count == 2)
                        {
                            this.Arms.Add(arm);
                            this.Arms.RemoveAt(0);
                        }
                        else
                        {
                            this.Arms.Remove(old[0]);
                            this.Arms.Add(arm);
                        }
                    }
                }
            }

            public void AddLeg(List<string> input)
            {
                var energy = int.Parse(input[1]);
                var strength = int.Parse(input[2]);
                var speed = int.Parse(input[3]);
                var leg = new Leg
                {
                    EnergyConsumption = energy,
                    Strength = strength,
                    Speed = speed
                };
                if (this.Legs.Count < 2)
                {
                    this.Legs.Add(leg);
                }
                else
                {
                    if (this.Legs.Any(l => l.EnergyConsumption > energy))
                    {
                        var old = this.Legs.Where(l => l.EnergyConsumption > energy).ToList();
                        if (old.Count == 2)
                        {
                            this.Legs.Add(leg);
                            this.Legs.RemoveAt(0);
                        }
                        else
                        {
                            this.Legs.Remove(old[0]);
                            this.Legs.Add(leg);
                        }
                    }
                }
            }
        }

        public class Arm
        {
            public Arm()
            {
                
            }
            
            public Arm(int energyConsumption, int reachDistance, int countFingers)
            {
                this.EnergyConsumption = energyConsumption;
                this.ReachDistance = reachDistance;
                this.CountFingers = countFingers;
            }

            public int EnergyConsumption { get; set; }

            public int ReachDistance { get; set; }

            public int CountFingers { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("#Arm:");
                sb.AppendLine($"###Energy consumption: {this.EnergyConsumption}");
                sb.AppendLine($"###Reach: {this.ReachDistance}");
                sb.Append($"###Fingers: {this.CountFingers}");
                return sb.ToString();
            }
        }

        public class Leg
        {
            public Leg()
            {
                
            }
            
            public Leg(int energyConsumption, int strength, int speed)
            {
               this.EnergyConsumption = energyConsumption;
               this.Strength = strength;
               this.Speed = speed;
            }

            public int EnergyConsumption { get; set; }

            public int Strength { get; set; }

            public int Speed { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("#Leg:");
                sb.AppendLine($"###Energy consumption: {this.EnergyConsumption}");
                sb.AppendLine($"###Strength: {this.Strength}");
                sb.Append($"###Speed: {this.Speed}");
                return sb.ToString();
            }
        }

        public class Torso
        {
            public Torso()
            {
                
            }
            
            public Torso(int energyConsumption, double processorSizeInCm, string housingMaterial)
            {
                this.EnergyConsumption = energyConsumption;
                this.ProcessorSizeInCm = processorSizeInCm;
                this.HousingMaterial = housingMaterial;
            }

            public int EnergyConsumption { get; set; }

            public double ProcessorSizeInCm { get; set; }

            public string HousingMaterial { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("#Torso:");
                sb.AppendLine($"###Energy consumption: {this.EnergyConsumption}");
                sb.AppendLine($"###Processor size: {this.ProcessorSizeInCm:f1}");
                sb.Append($"###Corpus material: {this.HousingMaterial}");
                return sb.ToString();
            }
        }

        public class Head
        {
            public Head()
            {
                
            }
            
            public Head(int energyConsumption, double iQ, string skinMaterial)
            {
               this.EnergyConsumption = energyConsumption;
                this.IQ = iQ;
                this.SkinMaterial = skinMaterial;
            }

            public int EnergyConsumption { get; set; }

            public double IQ { get; set; }

            public string SkinMaterial { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("#Head:");
                sb.AppendLine($"###Energy consumption: {this.EnergyConsumption}");
                sb.AppendLine($"###IQ: {this.IQ}");
                sb.Append($"###Skin material: {this.SkinMaterial}");
                return sb.ToString();
            }
        }

    }
}
