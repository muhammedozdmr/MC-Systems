using McSystems.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems
{
    public class RoomDto
    {
        public int Id { get; set; }
        public byte Number { get; set; }
        public byte Floor { get; set; }
        public string Name
        {
            get
            {
                if (this.Floor < 10 && this.Number < 10)
                {
                    return Floor.ToString().PadRight(2, '0') + Number.ToString();
                }
                else if (this.Floor < 10 && this.Number > 10)
                {
                    return Floor.ToString().PadRight(1, '0') + Number.ToString();
                }
                else if (this.Floor > 10 && this.Number < 10)
                {
                    return Floor.ToString().PadRight(1, '0') + Number.ToString();
                }
                else
                {
                    return string.Concat(Floor, Number);
                }
            }
        }
        public string Description { get; set; }
        public byte Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public bool InMaintenance { get; set; }
    }
}
